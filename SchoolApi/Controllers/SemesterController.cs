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
    public class SemesterController: BaseController<Answer>
    {
        private Context _context;
        public SemesterController(Context context): base(context)
        {
            _context = context;
        }

        // Update Answer
        [HttpPut("{id}")]
        public Semester? Put(Semester semester)
        {
            var semesterDbo = _context.Semesters.Find(semester.Id);

            if(semesterDbo == null) return null;

            semesterDbo.Name = semester.Name;
            semesterDbo.StartDate = semester.StartDate;
            semesterDbo.EndDate = semester.EndDate;
            _context.SaveChanges();

            return semesterDbo;
        }
    }
}