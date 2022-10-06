using System;

// Singleton pattern -- Ejemplo estructural
// dotnet run

namespace Patrones.Singleton
{

  class MainApp
  {

    static void Main()
    {

      Singleton s1 = Singleton.Instance();

      Singleton s2 = Singleton.Instance();


      if (s1 == s2)
      {
        Console.WriteLine("Son iguales");
      }

      Console.ReadKey();

    }

  }


  class Singleton
  {
    private static Singleton _instance;

 
    protected Singleton()
    {
    }

 
    public static Singleton Instance()
    {
      if (_instance == null)
      {
        _instance = new Singleton();
      }

      return _instance;

    }

  }

}
 

