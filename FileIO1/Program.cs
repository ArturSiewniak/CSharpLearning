using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO1
{
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\b.txt", FileMode.OpenOrCreate);
            /*for (int i = 1; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }*/

            int ii = 0;
            while ((ii = f.ReadByte()) != -1)
            {
                Console.Write((char)ii);
            }
            f.Close();

            FileStream f1 = new FileStream("C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\output.txt", FileMode.Create);
            StreamWriter s1 = new StreamWriter(f1);

            s1.WriteLine("Hello C#!");
            s1.Close();
            f1.Close();
            Console.WriteLine();
            Console.WriteLine("File created successfully");

            FileStream f2 = new FileStream("C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\output.txt", FileMode.OpenOrCreate);
            StreamReader s2 = new StreamReader(f2);

            string line = s2.ReadLine();
            Console.WriteLine(line);
            s2.Close();
            f2.Close();

            FileStream f3 = new FileStream("C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\a.txt", FileMode.OpenOrCreate);
            StreamReader s3 = new StreamReader(f3);

            string line3 = "";
            while((line3 = s3.ReadLine()) != null)
            {
                Console.WriteLine(line3);
            }
            s3.Close();
            f3.Close();

            using (TextWriter writer = File.CreateText("C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\e.txt"))
            {
                writer.WriteLine("Hola C#");
                writer.WriteLine("C# file handling");
            }
            Console.WriteLine("Data written successfully");

            using (TextReader tr = File.OpenText("C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\e.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());  //ReadLine() for one line
            }

            string fileName = "C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\binaryfile.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("This is a string");
                writer.Write(true);
            }
            Console.WriteLine("Data written successfully");

            using(BinaryReader reader = new BinaryReader(File.Open("C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\binaryfile.dat", FileMode.Open)))
            {
                Console.WriteLine("Double: " + reader.ReadDouble());
                Console.WriteLine("String: " + reader.ReadString());
                Console.WriteLine("Boolean: " + reader.ReadBoolean());
            }

            string text1 = "Hello, \n" + "World! \n" + "Sup?";
            StringBuilder sb = new StringBuilder();
            StringWriter writer1 = new StringWriter(sb);
            writer1.WriteLine(text1);
            writer1.Flush();
            writer1.Close();

            StringReader reader1 = new StringReader(sb.ToString());
            while(reader1.Peek() > -1)
            {
                Console.WriteLine(reader1.ReadLine());
            }

            try
            {
                string loc = "C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\f.txt";
                FileInfo file = new FileInfo(loc);
                //file.Create();
                //Console.WriteLine("File created successfully");

                StreamWriter sw4 = file.CreateText();
                sw4.WriteLine("This text is written by StreamWriter");
                sw4.Close();

                StreamReader sr4 = file.OpenText();
                string data = "";
                while ((data = sr4.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }

            FileStream stream6 = new FileStream("C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student stu = new Student(1, "Studentorro");
            formatter.Serialize(stream6, stu);
            stream6.Close();

            FileStream stream7 = new FileStream("C:\\Users\\Reaper\\Desktop\\QAP\\c#\\FileIO1\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter1 = new BinaryFormatter();

            Student stu1 = (Student)formatter1.Deserialize(stream7);
            Console.WriteLine("Rollno: " + stu1.rollno);
            Console.WriteLine("Name: " + stu1.name);

            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Reaper\Desktop\QAP\c#\FileIO1\excersieDir");
            try
            {
                if (directory.Exists)
                {
                    Console.WriteLine("That directory already exists");
                    return;
                }
                directory.Create();
                Console.WriteLine("Directory created successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }

            /*try
            {
                directory.Delete();
                Console.WriteLine("Directory deleted successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong: {0}", e.ToString());
            }*/
        }
    }
}
