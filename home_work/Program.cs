using System;
/*Домашнее задание №1. Лозовский Филипп Сергеевич. С остальными пунктами пока разбираюсь.*/
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
            Console.ReadKey();
            #endregion
            #region Task3 
            // Вычисление расстояния между точками.
            Console.WriteLine("Введите координату x1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            int y2 = int.Parse(Console.ReadLine());
            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точек = {0:f2}",r);
            Console.ReadKey();
            #endregion


        }
    }
}
