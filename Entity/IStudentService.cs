using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface IStudentService
    {

        void Add(Student student);  
        void Delete(Student student);   
        void Update(Student student);
       IEnumerable<Student> GetAllStudentsQuery();
    }
}
