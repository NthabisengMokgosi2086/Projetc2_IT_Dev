using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projetc2_IT_Dev.Models; ///reference to model
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Web;
using Projetc2_IT_Dev.Controllers;


namespace Projetc2_IT_Dev.Controllers
{
    public class AccountController : Controller
    {
        
        //Get: Account  
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        void connectionString()
        {

        }
        public IActionResult Verify(Account acc)
        {
            return View();
        }
    }
}
