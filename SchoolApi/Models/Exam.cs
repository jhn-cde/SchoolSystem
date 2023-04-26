using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApi.Models
{
    public class Exam
    {
        public long Id {get;set;}
        public string Name {get;set;}
        public DateTime Date {get;set;}
    }
}