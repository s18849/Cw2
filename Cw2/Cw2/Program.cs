using System;
using System.IO;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataConverter dataConverter = new DataConverter();

            try
            {
                foreach(Student s in dataConverter.getDataFromFile())
                {
                    Console.WriteLine(s);
                }
                
                   
                
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
        
     

    }
}
