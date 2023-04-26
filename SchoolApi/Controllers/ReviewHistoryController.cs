using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

namespace SchoolApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewHistoryController: BaseController<Answer>
    {
        private Context _context;
        public ReviewHistoryController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut("{id}")]
        public ReviewHistory? Put(ReviewHistory reviewHistory)
        {
            var reviewHistoryDbo = _context.ReviewHistories.Find(reviewHistory.Id);

            if(reviewHistoryDbo == null) return null;

            reviewHistoryDbo.ReviewDate = reviewHistory.ReviewDate;
            reviewHistoryDbo.Success = reviewHistory.Success;
            _context.SaveChanges();

            return reviewHistoryDbo;
        }
    }
}