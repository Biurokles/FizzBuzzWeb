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
        public string Year { get; set; }
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
            char imie = FizzBuzz.FirstName.Last();
            if(FizzBuzz.Number%4==0)
            {
              
                Year = "Ten rok jest przestępny";
            }
            else
            {
                Year = "Ten rok nie jest przestępny";
            }
            if (imie == 'a')
            {
                Name = $"{FizzBuzz.FirstName} urodziła się w {FizzBuzz.Number}.";
            }
            else
            {
                Name = $"{FizzBuzz.FirstName} urodził się w {FizzBuzz.Number}.";
            }
            Result = Name + " " +  Year;
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Data",
                JsonConvert.SerializeObject(FizzBuzz));
                
            }

            return Page();  
        }
    }
}