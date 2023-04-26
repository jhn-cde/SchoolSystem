using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApi.Models
{
    public class TopicReview
    {
        public long Id {get;set;}
        public int ReviewInterval {get;set;}
        public DateTime NextReview {get;set;}
    }
}