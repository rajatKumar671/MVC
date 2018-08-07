using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeController : Controller
    {
        public string EmployeProfile(int id)
        {
            string profile = string.Empty;
            if (id == 1)
            {
                profile = " employe 1";
            }
           else if (id == 2)
            {
                profile = " employe 2";
            }
            else 
            {
                profile = " employe profile not found";
            }
            return profile;
        }

        public string Address(int id, string department)
        {
            return " id =" + id + "dept =" + department;
        }
    }
}