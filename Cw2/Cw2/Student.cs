using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
    class Student
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Study { get; set; }
        public string StudyType { get; set; }
        public int Index { get; set; }
        public string Birthday { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public override string ToString()
        {
            return base.ToString() + ": " + Name + " " + Lastname + " " + Index;
        }

        public bool Equals(Student otherStudent)
        {
            if (this.Index == otherStudent.Index && this.Name.Equals(otherStudent.Name)&&this.Lastname.Equals(otherStudent.Lastname))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
