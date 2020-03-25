using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// Это класс о Applicant
    /// </summary>
    [Serializable]
    public class Applicant : Persona
    {
        public Applicant()
        : base()
        {
            Faculty = "asd";
        }
        /// <summary>
        /// Это конструктор класса
        /// </summary>
        /// <param name="repeat">Имя, дата рождения, факультет</param>
        /// <returns>Сам новый класс</returns>
        public Applicant(string name, string dateOfBorth, string faculty)
            : base(name, dateOfBorth)
        {
            Faculty = faculty;
        }

        public string Faculty;
        /// <summary>
        /// Это метод выводи всю инф-цию
        /// </summary>
        public override void outInfo()
        {
            Console.WriteLine("Возраст: "+Age()+", Фамилия: " + Name + ", Дата рождения: " + DateOfBirth.ToShortDateString() + ", факультет: " + Faculty);
        }
    }
}
