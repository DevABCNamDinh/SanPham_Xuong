﻿using System.ComponentModel.DataAnnotations;

namespace Xuong_C_.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
