using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Cw2
{
    public class Student
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Study { get; set; }
        public string StudyType { get; set; }
        [XmlAttribute]
        public string Index { get; set; }
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
