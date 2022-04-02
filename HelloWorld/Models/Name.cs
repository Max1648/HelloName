using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class Name
    {
        [Required(ErrorMessage = "Enter your name")]
        [RegularExpression("^[a-zA-Zа-яА-Я]+$", ErrorMessage = "You entered the wrong value")]
        public string NamePerson { get; set; }
    }
}
