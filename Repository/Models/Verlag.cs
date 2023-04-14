﻿using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Verlag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Ort { get; set; }
    }
}