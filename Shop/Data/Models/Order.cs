using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        
        [BindNever]
        public int id { get; set; } // данное поле никогда не будет показано на странице

        [Display(Name = "Введите имя")]
        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "Длина имени должна быть не менее 3 символов")]
        public string name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "Длина фамилии должна быть не менее 3 символов")]
        public string surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(40, MinimumLength = 5)]
        [Required(ErrorMessage = "Длина адреса должна быть не менее 5 символов")]
        public string address { get; set; }

        [Display(Name = "Введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11, MinimumLength = 7)]
        [Required(ErrorMessage = "Длина номера телефона должна быть не менее 7 символов")]
        public string phone { get; set; }

        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30, MinimumLength = 6)]
        [Required(ErrorMessage = "Длина email должна быть не менее 6 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]     // данное поле не будет отображаться в исходном коде
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

    }
}
