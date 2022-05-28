using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebStudentApi1.Models;

namespace WebStudentApi1.Controllers
{
    public class StudentController : ApiController
    {
        List<Student> Students = new List<Student>()
        {
            new Student()
            {
                StudentId = 1,
                StudentName = "Rajesh Kumar",
                Address = "New Delhi",
                Course = "IT"
            },
            new Student()
            {
                StudentId = 2,
                StudentName = "Sandeep Khan",
                Address = "BLR",
                Course = "ECE"
            },
            new Student()
            {
                StudentId = 3,
                StudentName = "Prakash Rout",
                Address = "MUM",
                Course = "EE"
            },
            new Student()
            {
                StudentId = 4,
                StudentName = "Rohit Dhane",
                Address = "HYD",
                Course = "CIVIL"
            },


        };
        public List<Student> GetAllStudents()
        {
            return Students;
        }
        public Student GetStudentDetails(int id)
        {
            var student = Students.FirstOrDefault(e=>e.StudentId == id);
            return student;
        }
    }
}
