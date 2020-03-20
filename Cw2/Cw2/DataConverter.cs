using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cw2
{
    class DataConverter
    {
        string logPath;
        string dataPath;
        string destPath;
        public DataConverter(string dataPath, string destPath)
        {
            this.logPath = "log.txt";
            this.dataPath = dataPath;
            this.destPath = destPath;
        }
        public DataConverter() : this("dane.csv", "result.xml")
        {
        }

        public void addLog(string message)
        {
            using (StreamWriter sw = File.AppendText(logPath))
                sw.WriteLine(DateTime.Now + " " + message);

        }
        public List<Student> getDataFromFile()
        {
            List<Student> studentList = new List<Student>();
            var file = new FileInfo(dataPath);
            if (!file.Exists)
            {
                string exc = "Plik nie istnieje";
                addLog(exc);
                throw new FileNotFoundException(exc);
            }
            else
            {
                
                    var fi = new FileInfo(dataPath);
                    using (var stream = new StreamReader(fi.OpenRead()))
                    {
                        string line = null;
                        
                        while ((line = stream.ReadLine()) != null)
                        {

                            string[] studentData = line.Split(',');
    
                            if (studentData.Length == 9)
                            {
                                for (int i = 0; i < studentData.Length; i++)
                                {
                                    if (studentData[i] == null)
                                    {
                                        addLog(line);
                                        break;
                                    }
                                }
                                var student = new Student
                                {
                                    Name = studentData[0],
                                    Lastname = studentData[1],
                                    Study = studentData[2],
                                    StudyType = studentData[3],
                                    Index = int.Parse(studentData[4]),
                                    Birthday = studentData[5],
                                    MothersName = studentData[7],
                                    FathersName = studentData[8]
                                };
                            bool exist = false;
                           foreach(Student s in studentList)
                            {
                                if (s.Equals(student))
                                {
                                    exist = true;
                                }
                            }
                                if (!exist)
                                {
                                    studentList.Add(student);
                                }
                                
                            }
                            else
                            {
                                addLog(line);
                            }


                           
                        }
                    }
                
            }
            return studentList;

        }
        

    }
}
