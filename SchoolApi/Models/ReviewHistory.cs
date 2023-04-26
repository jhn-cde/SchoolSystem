using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApi.Models
{
    public class ReviewHistory
    {
        public long Id {get;set;}
        public Boolean Success {get;set;}
        public DateTime ReviewDate {get;set;}
    }
}