﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
    public class Verlanglijstje
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }

        public string Omschrijving { get; set; }
        public decimal? Prijs { get; set; }
        public string Winkel { get; set; }
        public string Link { get; set; }
    }
}
