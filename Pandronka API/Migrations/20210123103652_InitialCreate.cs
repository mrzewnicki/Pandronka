using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Pandronka.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Imie = table.Column<string>(type: "text", nullable: true),
                    Nazwisko = table.Column<string>(type: "text", nullable: true),
                    Miejscowosc = table.Column<string>(type: "text", nullable: true),
                    Ulica = table.Column<string>(type: "text", nullable: true),
                    NumerDomu = table.Column<string>(type: "text", nullable: true),
                    KodPocztowy = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NumerTelefonu = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JednostkaMiary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nazwa = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JednostkaMiary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nazwa = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Miasta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ViewName = table.Column<string>(type: "text", nullable: true),
                    SubName = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miasta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platnosci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nazwa = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platnosci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nazwa = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statusy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nazwa = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statusy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Koszyk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UzytkownikId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koszyk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Koszyk_AspNetUsers_UzytkownikId",
                        column: x => x.UzytkownikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produkt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nazwa = table.Column<string>(type: "text", nullable: true),
                    Ilosc = table.Column<int>(type: "integer", nullable: false),
                    JednostkaMiaryId = table.Column<int>(type: "integer", nullable: false),
                    Dostepnosc = table.Column<bool>(type: "boolean", nullable: false),
                    KategoriaId = table.Column<int>(type: "integer", nullable: false),
                    ProducentId = table.Column<int>(type: "integer", nullable: false),
                    Cena = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produkt_JednostkaMiary_JednostkaMiaryId",
                        column: x => x.JednostkaMiaryId,
                        principalTable: "JednostkaMiary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produkt_Kategoria_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produkt_Producent_ProducentId",
                        column: x => x.ProducentId,
                        principalTable: "Producent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kwota = table.Column<float>(type: "real", nullable: false),
                    WykonujacyId = table.Column<string>(type: "text", nullable: true),
                    KoszykId = table.Column<int>(type: "integer", nullable: false),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    PlatnoscId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zamowienia_AspNetUsers_WykonujacyId",
                        column: x => x.WykonujacyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zamowienia_Koszyk_KoszykId",
                        column: x => x.KoszykId,
                        principalTable: "Koszyk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zamowienia_Platnosci_PlatnoscId",
                        column: x => x.PlatnoscId,
                        principalTable: "Platnosci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zamowienia_Statusy_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statusy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kosz_Prod",
                columns: table => new
                {
                    ProduktId = table.Column<int>(type: "integer", nullable: true),
                    KoszykId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Kosz_Prod_Koszyk_KoszykId",
                        column: x => x.KoszykId,
                        principalTable: "Koszyk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kosz_Prod_Produkt_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "JednostkaMiary",
                columns: new[] { "Id", "Nazwa" },
                values: new object[,]
                {
                    { 1, "ml" },
                    { 2, "gr" },
                    { 3, "szt" }
                });

            migrationBuilder.InsertData(
                table: "Kategoria",
                columns: new[] { "Id", "Nazwa" },
                values: new object[,]
                {
                    { 1, "Nabiał" },
                    { 2, "Mięso" },
                    { 3, "Pieczywo" },
                    { 4, "Napoje" },
                    { 5, "Alkohol" }
                });

            migrationBuilder.InsertData(
                table: "Miasta",
                columns: new[] { "Id", "PostalCode", "SubName", "ViewName" },
                values: new object[,]
                {
                    { 52, "04-825", "Wawer", "Warszawa" },
                    { 51, "04-682", "Wawer", "Warszawa" },
                    { 50, "02-468", "Włochy", "Warszawa" },
                    { 49, "02-484", "Włochy", "Warszawa" },
                    { 48, "05-075", "Wesoła", "Warszawa" },
                    { 47, "05-075", "Wesoła", "Warszawa" },
                    { 46, "00-430", "Śródmieście", "Warszawa" },
                    { 42, "03-528", "Targówek", "Warszawa" },
                    { 44, "00-249", "Śródmieście", "Warszawa" },
                    { 43, "04-277", "Rembertów", "Warszawa" },
                    { 53, "04-622", "Wawer", "Warszawa" },
                    { 41, "03-338", "Targówek", "Warszawa" },
                    { 40, "00-656", "Śródmieście", "Warszawa" },
                    { 39, "00-497", "Śródmieście", "Warszawa" },
                    { 45, "00-513", "Śródmieście", "Warszawa" },
                    { 54, "02-243", "Włochy", "Warszawa" },
                    { 58, "02-708", "Mokotów", "Warszawa" },
                    { 56, "01-386", "Bemowo", "Warszawa" },
                    { 70, "04-428", "Rembertównew", "Warszawa" },
                    { 69, "03-610", "Targówek", "Warszawa" },
                    { 68, "03-678", "Targówek", "Warszawa" },
                    { 67, "00-686", "Śródmieście", "Warszawa" },
                    { 66, "00-405", "Śródmieście", "Warszawa" },
                    { 65, "00-453", "Śródmieście", "Warszawa" },
                    { 55, "01-497", "Bemowo", "Warszawa" },
                    { 64, "04-498", "Rembertów", "Warszawa" },
                    { 62, "03-054", "Białołęka", "Warszawa" },
                    { 61, "03-089", "Białołęka", "Warszawa" },
                    { 60, "01-492", "Bemowo", "Warszawa" },
                    { 59, "01-497", "Bemowo", "Warszawa" },
                    { 37, "04-474", "Rembertów", "Warszawa" },
                    { 57, "01-940", "Bielany", "Warszawa" },
                    { 63, "01-995", "Bielany", "Warszawa" },
                    { 36, "01-727", "Bielany", "Warszawa" },
                    { 38, "00-454", "Śródmieście", "Warszawa" },
                    { 34, "03-063", "Białołęka", "Warszawa" },
                    { 15, "03-622", "Targówek", "Warszawa" },
                    { 14, "03-784", "Targówek", "Warszawa" },
                    { 13, "00-654", "Śródmieście", "Warszawa" },
                    { 35, "03-128", "Białołęka", "Warszawa" },
                    { 11, "00-117", "Śródmieście", "Warszawa" },
                    { 10, "04-413", "Rembertów", "Warszawa" },
                    { 9, "01-870", "Bielany", "Warszawa" },
                    { 8, "03-144", "Białołęka", "Warszawa" },
                    { 7, "03-085", "Białołęka", "Warszawa" },
                    { 6, "01-358", "Bemowo", "Warszawa" },
                    { 5, "01-493", "Bemowo", "Warszawa" },
                    { 4, "00-791", "Mokotów", "Warszawa" },
                    { 3, "01-934", "Bielany", "Warszawa" },
                    { 2, "01-475", "Bemowo", "Warszawa" },
                    { 1, "01-376", "Bemowo", "Warszawa" },
                    { 16, "04-424", "Rembertów", "Warszawa" },
                    { 17, "00-275", "Śródmieście", "Warszawa" },
                    { 12, "00-575", "Śródmieście", "Warszawa" },
                    { 19, "00-127", "Śródmieście", "Warszawa" },
                    { 33, "01-318", "Bemowo", "Warszawa" },
                    { 18, "00-229", "Śródmieście", "Warszawa" },
                    { 32, "01-493", "Bemowo", "Warszawa" },
                    { 30, "01-696", "Bielany", "Warszawa" },
                    { 29, "01-317", "Bemowo", "Warszawa" },
                    { 28, "01-480", "Bemowo", "Warszawa" },
                    { 27, "02-441", "Włochy", "Warszawa" },
                    { 31, "02-716", "Mokotów", "Warszawa" },
                    { 25, "04-880", "Wawer", "Warszawa" },
                    { 24, "04-854", "Wawer", "Warszawa" },
                    { 23, "02-168", "Włochy", "Warszawa" },
                    { 22, "02-490", "Włochy", "Warszawa" },
                    { 21, "05-075", "Wesoła", "Warszawa" },
                    { 20, "05-075", "Wesoła", "Warszawa" },
                    { 26, "04-682", "Wawer", "Warszawa" }
                });

            migrationBuilder.InsertData(
                table: "Platnosci",
                columns: new[] { "Id", "Nazwa" },
                values: new object[,]
                {
                    { 3, "Przelewem tradycyjnym" },
                    { 2, "Za pobraniem" },
                    { 1, "Online" }
                });

            migrationBuilder.InsertData(
                table: "Producent",
                columns: new[] { "Id", "Nazwa" },
                values: new object[,]
                {
                    { 7, "Sokołów" },
                    { 1, "Piątnica" },
                    { 2, "Hortex" },
                    { 3, "Grella" },
                    { 4, "CocaCola" },
                    { 5, "Polmos" }
                });

            migrationBuilder.InsertData(
                table: "Statusy",
                columns: new[] { "Id", "Nazwa" },
                values: new object[,]
                {
                    { 2, "W kompletowaniu" },
                    { 3, "W drodze do klienta" },
                    { 1, "Nowe" },
                    { 4, "Zakończone" }
                });

            migrationBuilder.InsertData(
                table: "Produkt",
                columns: new[] { "Id", "Cena", "Dostepnosc", "Ilosc", "JednostkaMiaryId", "KategoriaId", "Nazwa", "ProducentId" },
                values: new object[,]
                {
                    { 1, 3.5, true, 11, 1, 1, "Jogurt naturalny", 1 },
                    { 2, 4.9900000000000002, true, 9, 1, 1, "Jogurt owocowy", 1 },
                    { 3, 5.9900000000000002, true, 500, 1, 1, "Mleko", 1 },
                    { 4, 10.9, true, 9, 2, 2, "Pierś z kurczaka", 2 },
                    { 8, 4.9000000000000004, true, 50, 1, 4, "Sok pomarańczowy", 2 },
                    { 9, 4.9000000000000004, true, 50, 1, 4, "Sok pożeczkowy", 2 },
                    { 6, 1.2, true, 200, 3, 3, "Kajzerka", 3 },
                    { 7, 2.0, true, 100, 3, 3, "Chleb", 3 },
                    { 10, 19.899999999999999, true, 500, 1, 5, "Pan Tadeusz", 5 },
                    { 5, 7.9000000000000004, true, 122, 2, 2, "Podwawelska", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kosz_Prod_KoszykId",
                table: "Kosz_Prod",
                column: "KoszykId");

            migrationBuilder.CreateIndex(
                name: "IX_Kosz_Prod_ProduktId",
                table: "Kosz_Prod",
                column: "ProduktId");

            migrationBuilder.CreateIndex(
                name: "IX_Koszyk_UzytkownikId",
                table: "Koszyk",
                column: "UzytkownikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produkt_JednostkaMiaryId",
                table: "Produkt",
                column: "JednostkaMiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Produkt_KategoriaId",
                table: "Produkt",
                column: "KategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produkt_ProducentId",
                table: "Produkt",
                column: "ProducentId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_KoszykId",
                table: "Zamowienia",
                column: "KoszykId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_PlatnoscId",
                table: "Zamowienia",
                column: "PlatnoscId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_StatusId",
                table: "Zamowienia",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_WykonujacyId",
                table: "Zamowienia",
                column: "WykonujacyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Kosz_Prod");

            migrationBuilder.DropTable(
                name: "Miasta");

            migrationBuilder.DropTable(
                name: "Zamowienia");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Produkt");

            migrationBuilder.DropTable(
                name: "Koszyk");

            migrationBuilder.DropTable(
                name: "Platnosci");

            migrationBuilder.DropTable(
                name: "Statusy");

            migrationBuilder.DropTable(
                name: "JednostkaMiary");

            migrationBuilder.DropTable(
                name: "Kategoria");

            migrationBuilder.DropTable(
                name: "Producent");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
