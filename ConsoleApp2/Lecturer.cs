using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// Это класс о лекторе
    /// </summary>
    [Serializable]
    public class Lecturer : Persona
    {
        public Lecturer()
            :base()
        {
            Position = "afs";
            Faculty = "asfa";
        }
        /// <summary>
        /// Это конструктор класса
        /// </summary>
        /// <param name="repeat">Имя, дата рождения, факультет, должность, стаж</param>
        /// <returns>Сам новый класс</returns>
        public Lecturer(string name, string dateOfBorth, string faculty, string position, string experience)
          : base(name, dateOfBorth)
        {
            Faculty = faculty;
            Position = position;
            Experience = experience;
        }
        public string Position;
        public string Faculty;
        public string Experience;
        /// <summary>
        /// Это метод выводи всю инф-цию
        /// </summary>
        public override void outInfo()
        {
            Console.WriteLine("Возраст: " + Age() + ", Фамилия: " + Name + ", Дата рождения: " + DateOfBirth.ToShortDateString() + ", факультет: " + Faculty+ ", Должность: "+ Position+", Стаж: "+Experience);
        }
    }
}
