using Studenci.Properties;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Studenci
{
   public class Students
    {
        
        public struct Student
        {
            public Dictionary<string, double> Dictionary;
            public int Id;
            public string Name;
            public int Semester;
            

            public Student(int id, string name, int semester,Dictionary<string,double> diction)
            {
                Id = id;
                Name = name;
                Semester = semester;
                Dictionary = diction;
            }
           
        }

        public Student Delete(int id,string name, List<Student> list)
        {
            var student = new Student();
            foreach (var s in list.Where(k => k.Id == id || k.Name == name))
            {
                student = new Student(s.Id, s.Name, s.Semester,s.Dictionary);
            }
            return student;
        }

        public Student Add(int id,string name,int semester,Dictionary<string,double>diction)
        {
            Student student = new Student(id, name, semester,diction);
            return student;
        }

        public List<Student> Search(int id,string name,int semester, List<Student> list)
        {
            List<Student> listn = new List<Student>();
            
            foreach (var s in list.Where(k => k.Id == id || k.Name == name || k.Semester == semester))
            {
                listn.Add(s);
            }
            return listn;
        }
        public Student Choose(int id, string name, List<Student> list)
        {
            var student = new Student();
            foreach (var s in list.Where(k => k.Id == id || k.Name == name))
            {
                student = new Student(s.Id, s.Name, s.Semester,s.Dictionary);
            }
            return student;
        }

        public void ToXML(List<Student> list)
        {
          
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\Students.xml");
            XmlSerializer xmlSer = new XmlSerializer(typeof(XElement) );
            foreach (var s in list)
            {
                XElement el = new XElement("Student");
                el.Add(new XElement("ID", s.Id));
                el.Add(new XElement("Name", s.Name));
                el.Add(new XElement("Semester", s.Semester));
                el.Add(new XElement("Degrees",s.Dictionary.Select(kv => new XElement(kv.Key, kv.Value))));
                xmlSer.Serialize(stream, el);
            }
            stream.Close();
        }

        public List<Student> Show()
        {
            List<Student> list = new List<Student>();
            Student uczen = new Student(1, "Dawid",1, (new Dictionary<string, double> { { "Matma", 5 } }));
            Student uczen1 = new Student(2, "Piotr", 2, (new Dictionary<string, double> { { "Matma", 3 } }));
            list.Add(uczen);
            list.Add(uczen1);
          
            XElement rootElement = XElement.Parse("<Degrees><key>value</key></Degrees>");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (var el in rootElement.Elements())
            {
                dict.Add(el.Name.LocalName, el.Value);
            }


              return list;
        }
        public static void Swap(double[] data, int a, int b)
        {
            double t = data[a];
            data[a] = data[b];
            data[b] = t;
        }

        public double Median(double[] data)
        {
            double median = (data[(data.Length / 2) - 1] + data[data.Length / 2])/2;
            return median;
        }

        public double SelectionSort(List<Student> list)
        {
            int l = 0;
            double[] data = new double[list.Count*2];
            foreach(var s in list)
            {
                List<double> degrees = new List<double>(s.Dictionary.Values);
                foreach (var d in degrees)
                {
                    data[l] = d;
                    l++;  
                }
            }
            int k;
            for (int i = 0; i < data.Length; i++)
            {
                k = i;
                for (int j = i + 1; j < data.Length; j++)
                {

                    if (data[j] < data[k])
                    {
                        k = j;
                    }

                }
                Swap(data, k, i);
            }
            return Median(data);
        }

        public double Standard(List<Student> list) {
            int i = 0;
            double average, sum = 0,up=0;
            
            foreach (var s in list)
            {
                List<double> degrees = new List<double>(s.Dictionary.Values);
                foreach (var d in degrees)
                {
                    sum = sum + d;
                    i++;
                }
            }
            average = sum / i;

            foreach (var s in list)
            {
                List<double> degrees = new List<double>(s.Dictionary.Values);
                foreach (var d in degrees) { 

                  up += Math.Pow(d-average,2);
            }
            }
            double st =Math.Round(Math.Sqrt((up / i)),4);
            return st;
             }

        
    }
}
