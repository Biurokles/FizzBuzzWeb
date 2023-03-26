using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        [Required(ErrorMessage = "Pole jestobowiązkowe"), Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]
        [Display(Name = "Twój szczęśliwy numerek")]
        public int? Number { get; set; }

    }
}
