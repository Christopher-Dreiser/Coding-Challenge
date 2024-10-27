using ClarkCodingChallenge.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.Models
{
    public class ContactsFormModel : PageModel
    {
        [BindProperty]
        public Contact FormContact { get; set; }

        public void OnPost()
        {
            // Breakpoint not being hit
            Console.WriteLine("test");
        }
    }
}
