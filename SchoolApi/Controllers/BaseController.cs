using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<T> : ControllerBase where T : class
    {
        private readonly Context _context;

        public BaseController(Context context)
        {
            _context = context;
        }

        // Get list
        [HttpGet]
        public ActionResult<IEnumerable<T>> Get()
        {
            return _context.Set<T>().ToList();
        }

        // Get item
        [HttpGet("{id}")]
        public ActionResult<T?> Get(int id)
        {
            var model = _context.Set<T>().Find(id);
            return model;
        }

        // Insert
        [HttpPost]
        public ActionResult<T> Post(T model)
        {
            _context.Set<T>().Add(model);
            _context.SaveChanges();
            return model;
        }

        // Update
        [HttpPut]
        public ActionResult<T>? Put(T model)
        {
            return null;
        }

        // Delete
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var model = _context.Set<T>().Find(id);
            if (model == null) return false;

            _context.Set<T>().Remove(model);
            _context.SaveChanges();
            return true;
        }
    }
}