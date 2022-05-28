using TeacherMangementCoreDBfirstApp.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace TeacherMangementCoreDBfirstApp.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly TeacherContext _context;

        public TeacherRepository()
        {
            _context = new TeacherContext();
        }
        public TeacherRepository(TeacherContext context)
        {
            _context = context;
        }
        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }
        public Teacher GetById(int Id)
        {
            return _context.Teachers.Find(Id);
        }
        public void Insert(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
        }
        public void Update(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
        }
        public void Delete(int Id)
        {
            Teacher teacher = _context.Teachers.Find(Id);
            _context.Teachers.Remove(teacher);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }

}
