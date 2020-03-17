using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// Это абстрактный класс, есть имя и дата рождение
    /// </summary>
    /// <param name="repeat">Имя и дата рождения</param>
    /// <returns>Сам класс</returns>
    abstract class Persona
    {
        /// <summary>
        /// Это конструктор абстрактного класса, есть имя и дата рождение
        /// </summary>
        /// <param name="repeat">Имя и дата рождения</param>
        /// <returns>Сам новый класс</returns>
        public Persona (string name,string dateOfBirht)
        {
            Name = name;
            string[] dateArr = dateOfBirht.Split('.');
            DateOfBirth = new DateTime(Int32.Parse(dateArr[2]), Int32.Parse(dateArr[1]), Int32.Parse(dateArr[0]),0,0,0);
        }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public abstract void outInfo();

        /// <summary>
        /// Это метод считает возраст
        /// </summary>
        /// <returns>возраст в годах</returns>
        public int Age()
        {
            return (int)(DateTime.Now.Subtract(DateOfBirth).TotalDays/365);
        }
    }
}
