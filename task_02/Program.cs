namespace Task_02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Server server = new Server();
      Workstation workstation = new Workstation();
      Router router = new Router();
            
      server.Connection();
      workstation.DataTransfer();
      router.Disconnection();

    }
  }
}