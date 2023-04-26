using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolApi.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options):base(options){

        }
        public DbSet<Answer> Answers {get; set;}
        public DbSet<Course> Courses {get; set;}
        public DbSet<Exam> Exams {get; set;}
        public DbSet<Question> Questions {get; set;}
        public DbSet<ReviewHistory> ReviewHistories {get; set;}
        public DbSet<Semester> Semesters {get; set;}
        public DbSet<Student> Students {get; set;}
        public DbSet<StudentAnswer> StudentAnswers {get; set;}
        public DbSet<StudentCourse> StudentCourses {get; set;}
        public DbSet<Teacher> Teachers {get; set;}
        public DbSet<Topic> Topics {get; set;}
        public DbSet<TopicReview> TopicReviews {get; set;}
    }
}