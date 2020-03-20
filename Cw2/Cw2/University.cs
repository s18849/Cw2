using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Cw2
{
    public class University
    {
        public List<Student> Students { get; set; }
        [XmlAttribute("CreatedAt")]
        public string CreatedAt { get; set; }
        [XmlAttribute("Author")]
        public string Author { get; set; }
        
    }
}
