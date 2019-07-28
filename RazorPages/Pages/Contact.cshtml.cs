using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class ContactModel : PageModel
    {
        public int? id { get; set; }
        public string username { get; set; }
        public void OnGet(int? id,string username)
        {
            this.id = id;
            this.username = username;
            //return RedirectToPage("/Store/Index");
            //return RedirectToPage("/Publisher/Index", new { area = "Admin" });
        }
    }
}