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
        public IActionResult Login()
        {
            return View();
        }
        //Get: Account  
        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }


        void connectionString()
        {

        }
        public IActionResult Verify(Account acc)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        
    }
}
