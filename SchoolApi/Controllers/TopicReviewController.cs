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
    public class TopicReviewController: BaseController<Answer>
    {
        private Context _context;
        public TopicReviewController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut("{id}")]
        public TopicReview? Put(TopicReview topicReview)
        {
            var topicReviewDbo = _context.TopicReviews.Find(topicReview.Id);

            if(topicReviewDbo == null) return null;

            topicReviewDbo.NextReview = topicReview.NextReview;
            topicReviewDbo.ReviewInterval = topicReview.ReviewInterval;
            _context.SaveChanges();

            return topicReviewDbo;
        }
    }
}