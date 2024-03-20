using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreX.Models.Authentication
{
    public class MRegistrationData
    {
        [Required(ErrorMessage = "Введите никнейм")]
        public string username { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароль и подтверждение пароля не совпадают")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }

        [Required(ErrorMessage = "Введите Email адрес")]
        [EmailAddress(ErrorMessage = "Введите корректный Email адрес")]
        public string email { get; set; }
    }
}