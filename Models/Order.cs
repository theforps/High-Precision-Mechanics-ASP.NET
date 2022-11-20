using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace High_precisionMechanics.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime date { get; set; }
        [Required(ErrorMessage = "Необходимо загрузить файл")]
        [DisplayName("Заявка на изготовление")]
        public string file1 { get; set; }
        [DisplayName("Конструкторская документация")]
        [Required(ErrorMessage = "Необходимо загрузить файл")]
        public string file2 { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
        public bool CustomerServiceManager { get; set; }
        public bool HeadOfQualityDepartment { get; set; }
        public bool HeadOfLogistics { get; set; }
        public bool HeadOfTheEconomicDepartment { get; set; }
        public bool HeaOfProduction { get; set; }
    }
}
