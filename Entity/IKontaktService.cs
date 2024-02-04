using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface IKontaktService
    {
        void AddContactToStudent(int studentId, string email, string brojtelefona,string adresa );
    }
}
