using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
     
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzzForm FizzBuzz { get; set; }
        
        public string Name { get; set; }
        public string Result { get; set; }
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
        public IActionResult OnPost()
        {
            if(FizzBuzz.Number%15==0)
            {
                Name = "Fiucie";
                Result = "FizzBuzz";
            }
            else if (FizzBuzz.Number % 3 == 0)
            {
                Result = "Fizz";
            }
            else if (FizzBuzz.Number % 5 == 0)
            {
                Result = "Buzz";
            }
            else
            {
                Result = "";
            }
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Data",
                JsonConvert.SerializeObject(FizzBuzz));
                
            }

            return Page();  
        }
    }
}