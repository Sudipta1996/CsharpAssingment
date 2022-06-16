using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }
        public class StudentTable
    {
        public void StuList()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name ="Rahul",Age =22, Marks = 70},
                 new Student(){ Id = 2, Name ="RahulG",Age =22, Marks = 70},
                  new Student(){ Id = 3, Name ="RahulP",Age =22, Marks = 70},
            };
            foreach (Student student in students)
            {
                Console.WriteLine("name"+student.Name+"Roll"+student.Id+"Id"+student.Marks+"Marks");
            }
            
        }
    }
}
