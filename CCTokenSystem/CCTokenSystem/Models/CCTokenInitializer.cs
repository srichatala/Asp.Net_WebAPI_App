using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTokenSystem.Models
{
    public class CCTokenInitializer : DropCreateDatabaseIfModelChanges<CCTokenSystemContext>
    {

        //seed mehtod is used to insert data into table while it created
        protected override void Seed(CCTokenSystemContext context)
        {
            var student = new List<Student>{
                new Student{
                    StudentID=300718283,
                    Firstname="Sri",
                    Lastname="Chatala",
                    Phoneno="6477866026",
                    Course="Software Engineering Technology",
                    Email="schatala@my.centennialcollege.ca"
                },
                new Student{
                    StudentID=300718284,
                    Firstname="Alagu",
                    Lastname="Murugappan",
                    Phoneno="6477866325",
                    Course="Software Engineering Technology",
                    Email="malagu@my.centennialcollege.ca"
                },
                  new Student{
                    StudentID=300718285,
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

            var campus = new List<Campus>
            {
                new Campus {
                    CampusName="Progress",
                    ContactNo = "4158565000",
                    Address = "941 Progress",
                    City="Scarbrough",
                    Provience="Ontario",
                    PostalCode="L9T7T2"
                },
                new Campus {
                    CampusName="Morningside",
                    ContactNo = "4158566000",
                    Address = "149 MorningSide",
                    City="Scarbrough",
                    Provience="Ontario",
                    PostalCode="L9T7T2"
                },
                new Campus {
                    CampusName="Downtown",
                    ContactNo = "4158567000",
                    Address = "941 Young",
                    City="Toronto",
                    Provience="Ontario",
                    PostalCode="L9T7T2"
                }
            };
            foreach (var item in campus)
            {
                context.Campuses.Add(item);
            }
            context.SaveChanges();

            var Departments = new List<Department> {
                new Department
                {
                    DeptName="Co-op",
                    Advisor_Fname="Alalgu",
                    Advisor_Lname="Murugappan",
                    Email="co-op@my.centennialcollege.ca",
                    ContactNo="6477866026",
                    Extension=5555,
                    CampusId=1
                },
                 new Department
                {
                    DeptName="International",
                    Advisor_Fname="Vangli",
                    Advisor_Lname="Khan",
                    Email="internation@my.centennialcollege.ca",
                    ContactNo="6477866026",
                    Extension=5556,
                    CampusId=1
                },
                  new Department
                {
                    DeptName="Time-Table",
                    Advisor_Fname="Sri",
                    Advisor_Lname="Chatala",
                    Email="timetable@my.centennialcollege.ca",
                    ContactNo="6477866026",
                    Extension=5557,
                    CampusId=1
                }
            };
            foreach(var item in Departments)
            {
                context.Departments.Add(item);
            }
            context.SaveChanges();
        }
    }
}
