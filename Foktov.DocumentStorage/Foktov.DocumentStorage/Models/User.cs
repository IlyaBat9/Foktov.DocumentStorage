using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Foktov.DocumentStorage.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
    }

    public class UserLogin
    {
        [Required]
        [Display(Name = "Ваш логин")]
        public string Login { get; set; }
        [Required]
        [Display(Name = "Ваш пароль")]
        public string Password { get; set; }
    }
}