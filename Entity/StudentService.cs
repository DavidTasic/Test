using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StudentService : IStudentService   
    {
        private readonly FakultetDbContext _fakultetDbContext;

        public StudentService(FakultetDbContext fakultetDbContext)
        {
            _fakultetDbContext = fakultetDbContext;
        }

        public void Add(Student student)
        {
            _fakultetDbContext.Studenti.Add(student);   
            _fakultetDbContext.SaveChanges();
        }

        public void Update(Student student)
        {
            _fakultetDbContext.Studenti.Update(student);
            _fakultetDbContext.SaveChanges();
        }

        public void Delete(Student student)
        {
            _fakultetDbContext.Studenti.Remove(student);
            _fakultetDbContext.SaveChanges();

        }
        public IEnumerable<Student> GetAllStudentsQuery()
        {
            return _fakultetDbContext.Studenti.ToList();
        }
        public IEnumerable<Student> GetAllStudentsQueryWithContact()
        {
            return _fakultetDbContext.Studenti.Include(s => s.Kontakt).ToList();
        }

    }
}
