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
        [Required] //Поле обязательно к заполнению;
        [Display(Name = "Your Login")]
        public string Login { get; set; }

        [Required] //Поле обязательно к заполнению;
        [DataType(DataType.Password)]
        [Display(Name = "Your Password")]
        public string Password { get; set; }
    }
}