using System;

namespace home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /* Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
            а) используя склеивание;
            б) используя форматированный вывод;
            в) *используя вывод со знаком $.*/

            // Блок запроса данных
            Console.WriteLine("Ваше Имя?");
              string name1 = Console.ReadLine();
             Console.WriteLine("Фамилия?");
               string name2 = Console.ReadLine();
             Console.WriteLine("Сколько Вам лет?");
              int age = int.Parse(Console.ReadLine());
              Console.WriteLine("Каков Ваш рост?");
              int higth = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько Вы весите?");
              int weigth = int.Parse(Console.ReadLine());

            // Склеевание
            Console.WriteLine("Здравствуйте, " + name1 + " " + name2 + "! Возраст "+ age + " лет" + ", рост " + higth + "см, вес " + weigth + "кг");

            // Форматированный вывод
            Console.WriteLine(string.Format("Здравствуйте, {0} {1}! Возраст {2} лет, рост {3}см, вес {4}кг", name1, name2, age, higth, weigth));

            // Вывод со знаком $
            Console.WriteLine(string.Format($"Здравствуйте, {name1} {name2}! Возраст {age} лет, рост {higth}см, вес {weigth}кг"));

            Console.ReadKey();
            #endregion
            #region Task2
            /* Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
              где m — масса тела в килограммах, h — рост в метрах*/
            var ind = weigth / Math.Pow(higth,2);
            Console.WriteLine("index of mass = " + ind.ToString("0.000"));
            #endregion
        }
    }
}
