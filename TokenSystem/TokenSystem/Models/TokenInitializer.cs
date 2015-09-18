using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TokenSystem.Models
{
    public class TokenInitializer : DropCreateDatabaseIfModelChanges<TokenContext>
    {
        protected override void Seed(TokenContext context)
        {
            var student = new List<Student>{
                new Student{
                    StudentID="300718283",
                    Firstname="Sri",
                    Lastname="Chatala",
                    Phoneno="6477866026",
                    Course="Software Engineering Technology",
                    Email="schatala@my.centennialcollege.ca"
                },
                new Student{
                    StudentID="300718284",
                    Firstname="Alagu",
                    Lastname="Murugappan",
                    Phoneno="6477866325",
                    Course="Software Engineering Technology",
                    Email="malagu@my.centennialcollege.ca"
                },
                  new Student{
                    StudentID="300718285",
                    Firstname="Vangli",
                    Lastname="Rajan",
                    Phoneno="6477866363",
                    Course="Software Engineering Technology",
                    Email="rvangli@my.centennialcollege.ca"
                }
            };
            foreach (var item in student)
            {
                context.Students.Add(item);
            }
            context.SaveChanges();
            var campuses = new List<Campus>
            {
                new Campus{
                    Campusname="Progress",
                    Contactno="6477866026"
                },
                new Campus{
                    Campusname="MorningSide",
                    Contactno="6477866025"
                },
                new Campus{
                    Campusname="Downtown",
                    Contactno="6477866024"
                }
            };
            foreach (var item in campuses) {
                context.Campuses.Add(item);
            }
            context.SaveChanges();
        }
    }
}
