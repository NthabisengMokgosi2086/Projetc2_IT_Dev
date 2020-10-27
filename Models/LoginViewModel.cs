using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetc2_IT_Dev.Models
{
    public class LoginViewModel
    {
         public string EmployeeNumber { get; set; }

        public string Role { get; set; }

        
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }

       

    
    }
}
