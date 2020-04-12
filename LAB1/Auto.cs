using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Auto
    {
        public string brand;
        public string model;
        private int tank_volume;
        private int qty_gasoline;
        private int speed;
        private double fuel_cons;
        private double[] wheel_preassure = new double[4];

        public int Tank_volume
        {
            get
            {
                return tank_volume;
            }

            set
            {
                if (value > 0 & value < 2000)
                    tank_volume = value;
            }
        }

        public int Qty_gasoline
        {
            get
            {
                return qty_gasoline;
            }

            set
            {
                if (value >= 0 & value < 2000)
                    qty_gasoline = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value >= 0 & value < 300)
                    speed = value;
            }
        }

        public double Fuel_cons
        {
            get
            {
                return fuel_cons;
            }

            set
            {
                if (value >= 0 & value < 30)
                    fuel_cons = value;
            }
        }

        public double[] Wheel_preassure
        {
            get
            {
                return wheel_preassure;
            }

            set
            {
                wheel_preassure.Initialize(); //Чистка массива
                int i = 0;
                foreach (double m in value)
                {
                    wheel_preassure[i] = m;
                    i++;
                    if (i >= 4) break;
                }
            }
        }

        public Auto() : this("Nobrand", "Nomodel", 1, 0, 0, 0.0, 0.0, 0.0, 0.0, 0.0)
        {
        }

        public Auto(string brand, string model, int tank_volume, int qty_gasoline, int speed, double fuel_cons, params double[] wheel_preassure)
        {
            this.brand = brand;
            this.model = model;
            Tank_volume = tank_volume;
            Qty_gasoline = qty_gasoline;
            Speed = speed;
            Fuel_cons = fuel_cons;
            Wheel_preassure = wheel_preassure;
        }

        public Auto(string brand, string model):this(brand, model, 1, 0, 0, 0.0, 0.0, 0.0, 0.0, 0.0)
        {
        }

        public override string ToString()
        {
            return String.Format("Марка: {0},\nмодель: {1},\nобъем бака: {2} л.,\nкол-во топлива в баке: {3} л.,\nскорость: {4} км/ч,\nрасход: {5} л/100км,\nдавление в:\n-1-ом колесе: {6} Атм.,\n-2-ом колесе: {7} Атм.,\n-3-ом колесе: {8} Атм.,\n-4-ом колесе: {9} Атм.", brand, model, tank_volume, qty_gasoline, speed, fuel_cons, wheel_preassure[0], wheel_preassure[1], wheel_preassure[2], wheel_preassure[3]);
        }

        public int Distance()
        {
            return (int)(this.qty_gasoline * 100 / this.fuel_cons);
        }

        public bool Pen_Wheel()
        {
            for (int i = 0; i < 4; i++)
            {
                if (wheel_preassure[i] < 1.0)
                {
                    speed = 0;
                   return  true;
                }
            }
            return false;
        }

        public bool Faster(Auto auto2)
        {
            return this.speed - auto2.speed > 0;
        }

        public static Auto Faster_of_3(Auto auto1, Auto auto2, Auto auto3)
        {
            if (auto1.speed > auto2.speed & auto1.speed > auto3.speed)
            {
                return auto1;
            }
            else if (auto2.speed > auto3.speed)
            {
                return auto2;
            }
            else
            {
                return auto3;
            }
        }
    }
}
