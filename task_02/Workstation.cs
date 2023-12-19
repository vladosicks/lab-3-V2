using System;

namespace Task_02
{
    public class Workstation
    {
        public int WorkStationType { get; set; }

        public WorkStation(string ipAdress, int power, string operatingSystem, int workStationType)
            : base(ipAdress, power, operatingSystem)
        {
            WorkStationType = workStationType;
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