using C_MiniConsoleApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        public Student()
        {
            _id += 1;
            Id = _id;
        }
        static int _id = -1;
        public int Id { get; set; }
        string _surname;
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                string newsurname = value.Trim();
                if (newsurname.Length >= 3 && newsurname[0] >= 'A' && newsurname[0] <= 'Z')
                {
                    for (int i = 0; i < newsurname.Length; i++)
                    {
                        if (newsurname[i] == ' ')
                        {
                            Console.WriteLine("Soyad 1 sozden ibaret olmalidir");
                            break;
                        }
                        _surname = newsurname;
                    }
                }
                else
                {
                    throw new StudentSurnameException("Duzgun soyad daxil etmediniz");
                }
            }
        }
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                string newname = value.Trim();
                if (newname.Length >= 3 && newname[0] >= 'A' && newname[0] <= 'Z')
                {
                    for (int i = 0; i < newname.Length; i++)
                    {
                        if (newname[i] == ' ')
                        {
                            Console.WriteLine("Ad 1 sozden ibaret olmalidir");
                            break;
                        }
                        _name = newname;
                    }
                }
                else
                {
                    throw new StudentNameException("Duzgun ad daxil etmediniz");
                }
            }
        }
        public override string ToString()
        {
            return $" Id:{Id} Name:{Name} Surname:{Surname}";
        }


    }
}
