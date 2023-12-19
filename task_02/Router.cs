using System;
using System.Net;

namespace Task_02
{
    public class Router
    {
        public int RouterType { get; set; }

        public Router(string ipAdress, int power, string operatingSystem, int routerType)
            : base()
        {
            RouterType = routerType;
        }
        public void DataTransfer()
        {
            Console.WriteLine("Дані передано");
        }
        public void Connection()
        {
            Console.WriteLine("Підключено до комп'ютеру");
        }
        public void Disconnection()
        {
            Console.WriteLine("Відключено від комп'ютеру");
        }
    }
}