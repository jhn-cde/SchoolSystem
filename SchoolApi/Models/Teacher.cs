using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApi.Models
{
    public class Teacher
    {
        public long Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
    }
}