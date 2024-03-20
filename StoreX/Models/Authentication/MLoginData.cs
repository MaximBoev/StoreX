using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreX.Models.Authentication
{
    public class MLoginData
    {
        [Required(ErrorMessage = "Введите никнейм")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}