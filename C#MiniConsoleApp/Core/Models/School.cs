using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class School
    {
        static Classroom[] classrooms = { };
        public Classroom[] AddClassroom(Classroom classroom)
        {
            Array.Resize(ref classrooms, classrooms.Length + 1);
            classrooms[classrooms.Length - 1] = classroom;
            return classrooms;
        }
        public void AddStudentToClassroom(Student student, int classroomid)
        {
            bool check = false;
            for (int i = 0; i < classrooms.Length; i++)
            {
                if (classrooms[i].Id == classroomid)
                {
                    Array.Resize(ref classrooms[i].students, classrooms[i].students.Length + 1);
                    classrooms[i].students[classrooms[i].students.Length - 1] = student;
                    check = true;

                }
            }
            if (check == false)
            {
                throw new AddStudentException("Classroom Not Found");
            }


        }
        public Student FindId(int id)
        {
            for (int i = 0; i < classrooms.Length; i++)
            {
                Classroom classroom = classrooms[i];
                for (int j = 0; j < classroom.students.Length; j++)
                {
                    if (id == classroom.students[j].Id)
                    {
                        return classroom.students[j];
                    }
                }
            }
            return null;
        }

        public Student[] DeleteStudent(int id)
        {

            for (int i = 0; i < classrooms.Length; i++)
            {
                Student[] NewStudents = { };
                Classroom classroom = classrooms[i];
                for (int j = 0; j < classroom.students.Length; j++)
                {
                    if (id == classroom.students[j].Id)
                    {
                        if (id != classroom.students[j].Id)
                        {
                            Array.Resize(ref NewStudents, NewStudents.Length + 1);
                            NewStudents[NewStudents.Length - 1] = classroom.students[j];
                            classroom.students = NewStudents;

                        }

                    }
                    else
                    {
                        throw new DeleteStudentException("Student Not Found");
                    }
                }
            }
            return null;

        }
        public void ShowAllStudents()
        {
            for (int i = 0; i < classrooms.Length; i++)
            {
                for (int j = 0; j < classrooms[i].students.Length; j++)
                {
                    Console.WriteLine(classrooms[i].students[j]);
                }
            }
        }
        public void ShowStudentsInClassroom(int id)
        {
            for (int i = 0; i < classrooms.Length; i++)
            {
                if (id == classrooms[i].Id)
                {
                    for (int j = 0; j < classrooms[i].students.Length; j++)
                    {
                        Console.WriteLine(classrooms[i].students[j]);
                    }
                }
            }
        }
    }
}
