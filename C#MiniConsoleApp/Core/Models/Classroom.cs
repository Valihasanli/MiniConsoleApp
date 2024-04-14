using Core.Enums;
using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Classroom
    {
        public Classroom()
        {
            _id++;
            Id = _id;
        }
        static int _id = -1;
        public int Id { get; set; }
        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (char.IsLetter(value[0]) && char.IsLetter(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]) && char.IsDigit(value[4]) && value.Length == 5)
                {
                    _name = value;
                }
                else
                {
                    throw new ClassNameException("class adi duzgun deyil");
                }
            }
        }
        public string Type { get; set; }
        public Student[] students = { };
    }
}
