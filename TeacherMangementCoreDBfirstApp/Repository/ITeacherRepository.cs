using TeacherMangementCoreDBfirstApp.Models;
using System.Collections.Generic;
namespace TeacherMangementCoreDBfirstApp.Repository
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();
        Teacher GetById(int id);
        void Insert(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int id);
        void Save();
    }
}
