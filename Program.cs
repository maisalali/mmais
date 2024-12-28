using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
            public class Trainee
            {
                public int ID { get; set; }
                public string Name { get; set; }
                public string Country { get; set; }
                public string EducationLevel { get; set; }
                public int Age { get; set; }

                public Trainee(int id, string name, string country, string educationLevel, int age)
                {
                    ID = id;
                    Name = name;
                    Country = country;
                    EducationLevel = educationLevel;
                    Age = age;
                }
            }

            static void Main(string[] args)
            {
                List<Trainee> trainees = new List<Trainee>();

                while (true)
                {
                    Console.WriteLine("أدخل بيانات المنتسب (أو اكتب 'exit' للخروج):");

                    Console.Write("رقم: ");
                    string idInput = Console.ReadLine();
                    if (idInput.ToLower() == "exit") break;
                    int id = int.Parse(idInput);

                    Console.Write("اسم: ");
                    string name = Console.ReadLine();

                    Console.Write("بلد: ");
                    string country = Console.ReadLine();

                    Console.Write("درجة التحصيل العلمي (ابتدائي/اعدادي/ثانوي/جامعي): ");
                    string educationLevel = Console.ReadLine();

                    Console.Write("العمر: ");
                    int age = int.Parse(Console.ReadLine());

                    trainees.Add(new Trainee(id, name, country, educationLevel, age));
 
                    trainees.Sort((x, y) => x.Age.CompareTo(y.Age));
                }

                Console.WriteLine("\nقائمة المنتسبين بعد الفرز:");
                foreach (var trainee in trainees)
                {
                    Console.WriteLine($"رقم: {trainee.ID}, اسم: {trainee.Name}, بلد: {trainee.Country}, درجة التحصيل: {trainee.EducationLevel}, عمر: {trainee.Age}");
                }
            }
        }

    }


