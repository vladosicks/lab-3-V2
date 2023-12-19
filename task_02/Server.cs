using System;

namespace Task_02
{
    public class Server
    {
        public int ServerType { get; set; }

        public Server(string ipAdress, int power, string operatingSystem, int serverType)
            : base(ipAdress, power, operatingSystem)
        {
            ServerType = serverType;
        }
        public void DataTransfer()
        {
            Console.WriteLine("Дані передані на сервер");
        }
        public void Connection()
        {
            Console.WriteLine("Сервер підключено");
        }
        public void Disconnection()
        {
            Console.WriteLine("Сервер відключено");
        }
    }
}