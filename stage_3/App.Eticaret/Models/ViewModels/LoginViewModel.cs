﻿using System.ComponentModel.DataAnnotations;

namespace App.Eticaret.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required, MaxLength(256), EmailAddress]
        public string Email { get; set; } = null!;

        [Required, MinLength(4), DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}