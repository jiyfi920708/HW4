using System;
using System.Collections.Generic;
using System.Linq;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeStudents();
            AdvisorInformation();
            TeamInformation();
            ClientInfoamtion();
            ProjectInformation();
            OrganizationInformation();
        }

        static void MakeStudents()
        {
           using(var db = new AppDbContext())
            {
                try
                {

                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Jeffry",
                                LastName = "Babb",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Joe",
                                LastName = "Smith",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Jane",
                                LastName = "Doe",
                                PhoneNumber = "123-555-1234", 
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },                        
                        };

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    }


                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    
        static void AdvisorInformation()
        {
            using(var db1 = new AppDbContext())
            try
            {
                db1.Database.EnsureCreated();

                Advisor a = new Advisor
                {   
                    AdvisorName = "Owen",
                    PhoneNumber = "415-245-2345",
                    Email = "asdd22@s22ad.com",
                };

                db1.Advisors.Add(a);

                db1.SaveChanges();
            }
            catch(Exception exp1)
            {
                Console.WriteLine(exp1.Message);
            }
        }
    
        static void TeamInformation()
        {
            using(var db2 = new AppDbContext())
            try
            {
                db2.Database.EnsureCreated();

                Team t = new Team
                {   
                    TeamMumbers = "lance",
                    TeamName = "990-990-8765",
                    ProjectID = "1234",
                };

                db2.Teams.Add(t);

                db2.SaveChanges();
            }
            catch(Exception exp2)
            {
                Console.WriteLine(exp2.Message);
            }
        }

        static void ClientInfoamtion()
        {
            using(var db3 = new AppDbContext())
            try
            {
                db3.Database.EnsureCreated();

                Client c = new Client
                {
                    FirstName = "Jeff",
                    LastName ="Babb",
                    Phone = "990-990-8765",
                    Email = "asd@sad.com",
                
                };

                db3.Clients.Add(c);

                db3.SaveChanges();
            }
            catch(Exception exp3)
            {
                Console.WriteLine(exp3.Message);
            }
        }  

        static void ProjectInformation()
        {
            using(var db4 = new AppDbContext())
            try
            {
                db4.Database.EnsureCreated();

                Project p = new Project
                {
                    ProjectName = "lucky",
                    LeaderName ="garen",
                    ClientName = "kat",
                    Deadline = "10/08/2018",
                    RequiredHours = "10",
                };

                db4.Projects.Add(p);

                db4.SaveChanges();
            }
            catch(Exception exp4)
            {
                Console.WriteLine(exp4.Message);
            }
        } 

        static void OrganizationInformation()
        {
            using(var db5 = new AppDbContext())
            try
            {
                db5.Database.EnsureCreated();

                Organization o = new Organization
                {
                   OrganizationName = "Desting",
                   OrganizationMember = "ten",
                };

                db5.Organizationes.Add(o);

                db5.SaveChanges();
            }
            catch(Exception exp5)
            {
                Console.WriteLine(exp5.Message);
            }
        } 
    
    }
}
