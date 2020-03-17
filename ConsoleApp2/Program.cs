using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp2
{
    /// <summary>
    ///программа, которая собирает базу из людей и выводит в диапозоне возвраста
    /// </summary>
    class Program
    {
        /// <summary>
        /// начало запуска программы
        /// </summary>
        /// <param name="repeat">Параметры</param>
        /// <returns>результат выполнения</returns>
        static void Main(string[] args)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt");
            FileInfo fileInf = new FileInfo(path);
            int n = 0;
            string input = "";
            List<Persona> personas = new List<Persona>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    n = Int32.Parse(sr.ReadLine());
                    for(int i=0;i<n;i++)
                    {
                        input = sr.ReadLine();
                        string[] inpArr = input.Split('|');
                        switch (inpArr[0])
                        {
                            case "a":
                                personas.Add(new Applicant(inpArr[1], inpArr[2], inpArr[3]));
                                break;
                            case "l":
                                personas.Add(new Lecturer(inpArr[1], inpArr[2], inpArr[3], inpArr[4], inpArr[5]));
                                break;
                            case "s":
                                personas.Add(new Student(inpArr[1], inpArr[2], inpArr[3], Int32.Parse(inpArr[4])));
                                break;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }


             
            for (int i=0; i<n; i++)
            {
                personas[i].outInfo();
            }
            Console.WriteLine("Введите возраст ОТ чего считать");
            int min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите возраст ДО чего считать");
            int max = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (personas[i].Age()<max && personas[i].Age()>min)
                personas[i].outInfo();
            }
            Console.ReadLine();
        }
    }
}
