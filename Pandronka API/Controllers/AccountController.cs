using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Pandronka.Models;
using Pandronka_API.Models.DTO;
using Pandronka_API.Models.DTOS;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Pandronka.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationUser> roleManager;
        private readonly IConfiguration configuration;
        private readonly SignInManger<ApplicationUser> _singInManager;

        public AccountController(UserManager<ApplicationUser> userManager,SignInManger<ApplicationUser> singInManager, RoleManager<ApplicationUser> roleManager, IConfiguration configuration)
        {
            _singInManager = singInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDTO request)
        {
            var user = await userManager.FindByNameAsync(request.Login);
            if (user != null && await userManager.CheckPasswordAsync(user, request.Haslo))
            {
                var userRoles = await userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role,userRole));
                }

                var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
                var token = new JwtSecurityToken(
                    issuer:configuration["JWT:ValidIssuer"],
                    audience:configuration["JWT:ValidAudience"],
                    expires:DateTime.Now.AddHours(5),
                    claims: authClaims,
                    signingCredentials:new SigningCredentials(authSigninKey,SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                });
            }

            return Unauthorized();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok(new Response() { Status = "Success", Message = "User has been logged out"});
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterDTO request)
        {
            var userExist = await userManager.FindByNameAsync(request.Imie);

            if (userExist != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "User already exist"

                    }
                );
            }

            if (!ModelState.IsValid)
            {
                string errCallBack = "";

                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        errCallBack += error.ErrorMessage + ";";
                    }
                }

                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = String.Format("Incorrect model data: {0}",errCallBack)
                    }
                );
            }


            ApplicationUser user = new ApplicationUser(request);

            var result = await userManager.CreateAsync(user, request.Haslo);

            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "User creation failed"
                    }
                );
            }

            return Ok(new Response(){Status = "Success",Message = "User created successfully"});
        }

        private string GeneratePassword(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO request)
        {
            string generatedPassword = GeneratePassword(8);
            var user =await  this.userManager.FindByEmailAsync(request.Email);
            var result = await this.userManager.RemovePasswordAsync(user);
            if(result.Succeeded)
            {
                result = await userManager.AddPasswordAsync(user, generatedPassword);
                if (result.Succeeded)
                {
                    SendMail(user.Email,generatedPassword);
                    return  Ok(new Response() { Status = "Success", Message = "Email with password sended successfully" });
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Problem was occurred..."

                    }
                    );
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                {
                    Status = "Error",
                    Message = "Problem was occured..."
                });
            }
        }

        private void SendMail(string emailAddress,string password)
        {
            var smtpClient = new SmtpClient("smtp.poczta.onet.pl")
            {
                Port = 587,
                Credentials = new NetworkCredential("pandronka@op.pl", "P@ndronka#1"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("email"),
                Subject = "Nowe hasło",
                Body = "Hasło do Twojego konta zostało zresetowane.<br />Nowe hasło to: <b>"+password+"</b> <br /> Hasło należy zmienić przy pierwszym logowaniu.",
                IsBodyHtml = true,
            };

            mailMessage.To.Add(emailAddress);

            smtpClient.Send(mailMessage);
        }

    }
}