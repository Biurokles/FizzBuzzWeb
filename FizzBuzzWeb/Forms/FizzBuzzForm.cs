using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        [Required(ErrorMessage = "Pole jest obowiązkowe"), Range(1984, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]
        [Display(Name = "Twój rok urodzenia")]
        public int? Number { get; set; }


        [Required(ErrorMessage = "Pole jest obowiązkowe"), StringLength(1000)]
        [Display(Name = "Twoje imie")]
        public string? FirstName { get; set; }
    }
}
