using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataConverter dataConverter = new DataConverter();
            string type = "xml";
            
            try
            {

                if (type.Equals("xml"))
                {
                    var university = new University
                    {
                        CreatedAt = DateTime.Now + "",
                        Author = "Piotr Miluszkiewicz",
                        Students = dataConverter.getDataFromFile()

                    };

                    FileStream writer = new FileStream(@"data.xml", FileMode.Create);

                    XmlSerializer serializer = new XmlSerializer(typeof(University),
                                               new XmlRootAttribute("uczelnia"));
                
                                               


                    serializer.Serialize(writer, university);
                }
                
 




            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
        
     

    }
}
