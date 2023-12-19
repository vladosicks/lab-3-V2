using System;

namespace Task_02
{
    public class Computer
    {
        public string IPAdress { get; set; }
        public int Power { get; set; }
        public string OperatingSystem { get; set; }

        public Computer(string ipAdress, int power, string operatingSystem)
        {
            IPAdress = ipAdress;
            Power = power;
            OperatingSystem = operatingSystem;
        }
        public virtual void DataTransfer()
        {
            Console.WriteLine("Дані передані");
        }

        public virtual void Connection()
        {
            Console.WriteLine("Комп'ютер під'єднано");
        }

        public virtual void Disconnection()
        {
            Console.WriteLine("Комп'ютер відключено");
        }
    }
}