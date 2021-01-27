﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pandronka.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public double   OrderTotalOriginal { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name ="Suma zamowienia")]
        public double OrderTotal { get; set; }

        [Required]
        [Display(Name = "Czas dostawy")]
        public DateTime PickUpTime { get; set; }

        [Required]
        [NotMapped]
        public DateTime PickUpDate { get; set; }

        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public string Comments { get; set; }


        [Display(Name = "Dostawca")]
        public string PickupName { get; set; }

        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }

        public string TransactionId { get; set; }
    }
}
