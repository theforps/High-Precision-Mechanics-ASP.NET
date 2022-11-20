using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace High_precisionMechanics.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [DisplayName("Имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [DisplayName("Отчество")]
        public string MiddleName { get; set; }
        [DisplayName("Номер телефона")]
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [Phone(ErrorMessage = "Некорректный номер")]
        [MinLength(10, ErrorMessage = ("Некорректный номер")), MaxLength(11, ErrorMessage = ("Некорректный номер"))]
        public string NumberPhone { get; set; }
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [EmailAddress(ErrorMessage = "Некорректный Email")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Обязательное поле для заполнения")]
        [DisplayName("Дата рождения")]
        [DataType(DataType.Date,ErrorMessage =("Обязательное поле для заполнения"))]
        public DateTime DateOfBth { get; set; }
    }
}
