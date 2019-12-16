using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JSLogin.Pages
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {


        public async Task<IActionResult> OnPostAsync(string username, string password)
        {
            Console.WriteLine("Posting here..");
            
            // TODO get claims here by username from database.
 
            var claims = new List<Claim>{
                new Claim(ClaimTypes.Name, username),
                new Claim("Role", "ninja"),
                
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return LocalRedirect(Url.Content("~/"));
        }
    }
}