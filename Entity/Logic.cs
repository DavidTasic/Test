using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Logic
    {

        public class ProgramLogic
        {
            private readonly StudentService _studentService;
            private readonly KontaktService _kontaktService;

            public ProgramLogic(StudentService studentService, KontaktService kontaktService)
            {
                _studentService = studentService;
                _kontaktService = kontaktService;
            }

            public void Run()
            {
                // Dodavanje studenata
                _studentService.Add(new Student { Name = "Rados", LastName = "Ljiga", DateOfBirth = new DateTime(1998, 12, 12), index = "kurac" });
                _studentService.Add(new Student { Name = "David", LastName = "Tasic", DateOfBirth = new DateTime(1998, 12, 11), index = "jedan" });

                Console.WriteLine("Lista studenata: ");
                foreach (var student in _studentService.GetAllStudentsQuery())
                {
                    Console.WriteLine($"{student.Name} {student.LastName}, Datum rođenja: {student.DateOfBirth}, Indeks: {student.index}");
                }

                // Dodavanje kontakata studentima
                _kontaktService.AddContactToStudent(studentId: 1, "Rados@gmail.com", "Balkanska 6 ", "05482452");
                _kontaktService.AddContactToStudent(studentId: 2, "David@gmail.com", "Focanska 20", "0600229108");

                // Prikazivanje studenata sa kontaktima
                foreach (var student in _studentService.GetAllStudentsQueryWithContact())
                {
                    Console.WriteLine($"{student.Name} {student.LastName}, Datum rođenja: {student.DateOfBirth}, Indeks: {student.index}");

                    if (student.Kontakt != null)
                    {
                        Console.WriteLine($"Kontakt: Email: {student.Kontakt.Email}, Telefon: {student.Kontakt.Brojtelefona}");
                    }
                }
            }
        }

    }
}
