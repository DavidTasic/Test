using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KontaktService : IKontaktService
    {

        private readonly FakultetDbContext _fakultetDbContext;
        public KontaktService(FakultetDbContext fakultetDbContext)
        {
           _fakultetDbContext = fakultetDbContext;
        }
        public void AddContactToStudent(int studentId, string email, string brojtelefona, string adresa)
        {
            var student = _fakultetDbContext.Studenti.Find(studentId);

            if (student != null)
            {
                var existingContact = _fakultetDbContext.kontakti.FirstOrDefault(k => k.StudentId == studentId);

                if (existingContact == null)
                {
                    
                    student.Kontakt = new Kontakt
                    {
                        Email = email,
                        Brojtelefona = brojtelefona,
                        Adresa = adresa
                    };
                }
                else
                {
                   
                    existingContact.Email = email;
                    existingContact.Brojtelefona = brojtelefona;
                    existingContact.Adresa = adresa;
                }

                _fakultetDbContext.SaveChanges();
            }
            else
            {
              
            }
        }
    }
}
