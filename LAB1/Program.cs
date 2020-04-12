using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Демонстрация использования всех конструкторов
            Console.WriteLine("Демонстрация использования всех конструкторов:");
            Console.WriteLine("1. Создание объекта класса Auto с помощью пустого коснтруктора:");
            Auto auto1 = new Auto();
            Console.WriteLine(auto1);
            Console.WriteLine("");

            Console.WriteLine("2. Создание объекта класса Auto, конструктором с полным набором аргументов:");
            Auto auto2 = new Auto("Mercedes", "ML370", 70, 30, 40, 8.2, 2.2, 2.2, 2.3, 0.9);
            Console.WriteLine(auto2);
            Console.WriteLine("");

            Console.WriteLine("3. Создание объекта класса Auto, конструктором с частичным набором аргументов:");
            Auto auto3 = new Auto("Mercedes", "ML270");
            Console.WriteLine(auto3);
            Console.WriteLine("");

            //Демонстрация работы методов
            Console.WriteLine("Демонстрация работы методов:");
            Console.WriteLine("1. Определение дистанции которое еще может проехать автомобиль: {0}", auto2.Distance());
            Console.WriteLine("2. Определение разницы скорости между 2-мя автомобилями второй автомобиль быстрее первого? {0}", auto2.Faster(auto1));
            Console.WriteLine("3. Определение более быстрого автомобиля из 3-х:\n{0}", Auto.Faster_of_3(auto1, auto2, auto3));
           ;
            Console.WriteLine("4. Проверка колес на прокол, и в случае прокола остановка автомобиля.\nКолесо пробыто? {0}.\nСкорость авто после проверки = {1}", auto2.Pen_Wheel(),  auto2.Speed);
            Console.WriteLine("");

            //Демонстрация работы свойств
            Console.WriteLine("Демонстрация работы свойств:");
            //Получение значений
            Console.WriteLine("Получение значений для auto2");
            Console.WriteLine("Марка автомобиля: " + auto2.brand);
            Console.WriteLine("Расход в л на 100 км: " + auto2.Fuel_cons);
            Console.WriteLine("Модель автомобиля: " + auto2.model);
            Console.WriteLine("Количество оставшегося топлива: " + auto2.Qty_gasoline);
            Console.WriteLine("Скорость автомобиля: " + auto2.Speed);
            Console.WriteLine("Объем бака: " + auto2.Tank_volume);
            Console.WriteLine("Давление в 4-х колесах: " + auto2.Wheel_preassure[0] + ", " + auto2.Wheel_preassure[1] + ", " + auto2.Wheel_preassure[2] + ", " + auto2.Wheel_preassure[3]);
            Console.WriteLine("");

            //Присваивание значений
            Console.WriteLine("Присваивание значений");
            auto1.brand = "BMW";
            auto1.Fuel_cons = 9.2;
            auto1.model = "X5";
            auto1.Qty_gasoline = 10;
            auto1.Speed = 20;
            auto1.Tank_volume = 60;
            auto1.Wheel_preassure = new double[] { 2.1, 2.1, 2.2, 2.2 };
            Console.WriteLine(auto1);

            Console.ReadKey();
        }
    }
}
