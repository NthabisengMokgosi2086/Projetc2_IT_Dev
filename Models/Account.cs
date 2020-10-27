using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetc2_IT_Dev.Models
{
    public class Account
    {

        public string EmployeeNumber{ get; set; }

        public string Department { get; set; }

        public string Role { get; set; }

        public string MaritalStatus { get; set; }

        public string Gender { get; set; }
        public string[] Genders = new[] { "Male", "Female" };

        public string BusinessTravel { get; set; }

        public string EducationField { get; set; }


        ///register
        


    }
}
