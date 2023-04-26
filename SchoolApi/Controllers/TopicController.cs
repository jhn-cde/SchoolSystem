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
    public class TopicController: BaseController<Answer>
    {
        private Context _context;
        public TopicController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut("{id}")]
        public Topic? Put(Topic topic)
        {
            var topicDbo = _context.Topics.Find(topic.Id);

            if(topicDbo == null) return null;

            topicDbo.Name = topic.Name;
            _context.SaveChanges();

            return topicDbo;
        }
    }
}