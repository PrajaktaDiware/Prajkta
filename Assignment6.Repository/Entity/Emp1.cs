using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6.Repository.Entity
{
    public class Emp1
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Your Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Phone Number")]
        public long Phone { get; set; }
        [Required(ErrorMessage = "Mention Your Marital Status")]
        public bool MaritalStatus { get; set; }
        [Required(ErrorMessage = "Please Enter state")]
        public int State { get; set; }
        [Required(ErrorMessage = "Please Enter city")]
        public int City { get; set; }
    }
}
