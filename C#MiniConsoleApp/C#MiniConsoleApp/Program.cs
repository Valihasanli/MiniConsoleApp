using Core.Models;

namespace C_MiniConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Student student0 = new Student()
                {
                    Name = "Veli",
                    Surname = "Hesenli"
                };
                Student student1 = new Student()
                {
                    Name = "Ekber",
                    Surname = "Novruzlu"
                };
                Student student2 = new Student()
                {
                    Name = "Eli",
                    Surname = "Eliyev"
                };
                Student student3 = new Student()
                {
                    Name = "Nadir",
                    Surname = "Memmedov"
                };
                Classroom classroom0 = new Classroom()
                {
                    Name = "BB207",
                    Type = "Backend"
                };
                Classroom classroom1 = new Classroom()
                {
                    Name = "BF213",
                    Type = "Backend"
                };
                Classroom classroom2 = new Classroom()
                {
                    Name = "AF206",
                    Type = "Backend"
                };
                Classroom classroom3 = new Classroom()
                {
                    Name = "AB123",
                    Type = "Backend"
                };
                School school = new School();
                school.AddClassroom(classroom0);
                school.AddClassroom(classroom1);
                school.AddClassroom(classroom2);
                school.AddClassroom(classroom3);
                school.AddStudentToClassroom(student0, 0);
                school.AddStudentToClassroom(student1, 1);
                school.AddStudentToClassroom(student2, 2);
                school.AddStudentToClassroom(student3, 3);
                bool check = true;
                while (check)
                {
                    Console.WriteLine("1.Classroom yarat\n" +
                              "2.Student yarat\n" +
                              "3.Butun Telebeleri ekrana cixart\n" +
                              "4.Secilmis sinifdeki telebeleri ekrana cixart\n" +
                              "5.Telebe sil\n" +
                              "0.Proqrami dayandir");
                    string answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "1":
                            string Name;
                            string Type;
                            do
                            {
                                Console.WriteLine("Sinife ad daxil et");
                                Name = Console.ReadLine();
                            }
                            while (!(char.IsLetter(Name[0]) && char.IsLetter(Name[1]) && char.IsDigit(Name[2]) && char.IsDigit(Name[3]) && char.IsDigit(Name[4]) && Name.Length == 5));
                            Console.WriteLine("Sinifin tipini daxil et");
                            Type = Console.ReadLine();
                            Classroom classroom = new Classroom()
                            {
                                Name = Name,
                                Type = Type
                            };
                            school.AddClassroom(classroom);

                            break;
                        case "2":
                            string StudentName;
                            string StudentSurname;
                            int ClassroomId;
                            string ClassroomIdstr;


                            Console.WriteLine("Telebe adini daxil et");
                            StudentName = Console.ReadLine();
                            Console.WriteLine("Telebe Soyadini daxil et");
                            StudentSurname = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Elave edeceyiniz sinifin ID-ni daxil edin");
                                ClassroomIdstr = Console.ReadLine();
                            } while (!(int.TryParse(ClassroomIdstr, out ClassroomId)));
                            Student student = new Student()
                            {
                                Name = StudentName,
                                Surname = StudentSurname

                            };
                            school.AddStudentToClassroom(student, ClassroomId);

                            break;
                        case "3":
                            school.ShowAllStudents();
                            break;
                        case "4":
                            do
                            {
                                Console.WriteLine("Elave edeceyiniz sinifin ID-ni daxil edin");
                                ClassroomIdstr = Console.ReadLine();
                            } while (!(int.TryParse(ClassroomIdstr, out ClassroomId)));
                            school.ShowStudentsInClassroom(ClassroomId);
                            break;
                        case "5":
                            string StudentIdstr;
                            int StudentId;
                            do
                            {
                                Console.WriteLine("Sileceyiniz telebenin ID-ni daxil edin");
                                StudentIdstr = Console.ReadLine();
                            } while (!(int.TryParse(StudentIdstr, out StudentId)));
                            school.DeleteStudent(StudentId);
                            break;
                        case "0":
                            check = false;
                            break;
                        default:
                            Console.WriteLine("Duzgun secim edin");
                            break;
                    }
                }
            }
            catch (Exception A)
            {
                Console.WriteLine(A.Message);
            }
        }
    }
}
