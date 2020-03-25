using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// Это класс о студенте
    /// </summary>
    [Serializable]
    public class Student : Persona
    {
        public Student()
             : base("Иванов" ,"01.01.2000")
        {
            Faculty = "def";
            Cours = 1;
        }
        /// <summary>
        /// Это конструктор абстрактного класса
        /// </summary>
        /// <param name="repeat">Имя, дата рождения, факультет, курс</param>
        /// <returns>Сам новый класс</returns>
        public Student(string name, string dateOfBorth, string faculty,int cours)
          : base(name, dateOfBorth)
        {
            Faculty = faculty;
            Cours = cours;
        }

        public string Faculty;
        public int Cours;
        /// <summary>
        /// Это метод выводи всю инф-цию
        /// </summary>
        public override void outInfo()
        {
            Console.WriteLine("Возраст: " + Age() + ", Фамилия: " + Name + ", Дата рождения: " + DateOfBirth.ToShortDateString() + ", факультет: " + Faculty+", курс: "+Cours);
        }
    }
}
