using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            string destPath;
            DataConverter dataConverter;
            if (args.Length == 3)
            {
                type = args[2];
                dataConverter = new DataConverter(args[0]);
                destPath = args[1];
            }
            else
            {
                type = "xml";
                destPath = "data.xml";
                dataConverter = new DataConverter();
            }
            
            
            
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
                    FileStream writer = new FileStream(destPath, FileMode.Create);

                    XmlSerializer serializer = new XmlSerializer(typeof(University),
                                               new XmlRootAttribute("uczelnia"));
                    serializer.Serialize(writer, university);
                }
                if(type.Equals("json"))
                {
                    var university = new University
                    {
                        CreatedAt = DateTime.Now + "",
                        Author = "Piotr Miluszkiewicz",
                        Students = dataConverter.getDataFromFile()

                    };
                    var jsonString = JsonSerializer.Serialize(university);
                    File.WriteAllText(destPath, jsonString);
                }



            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
        
     

    }
}
