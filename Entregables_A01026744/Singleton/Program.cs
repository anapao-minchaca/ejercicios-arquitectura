using System;

// Ejemplo para demostrar que la instancia singleton se crea solo una vez
// a pesar de que la instancia fue llamada 3 veces.

namespace Patrones.Singleton
{
  class MainApp
  {
    static void Main()
    {
      Singleton s1 = Singleton.Instance();
      s1.PrintDetails("Singleton s1");
      Singleton s2 = Singleton.Instance();
      s2.PrintDetails("Singleton s2");
      Singleton s3 = Singleton.Instance();
      s3.PrintDetails("Singleton s3");
    }
  }

  class Singleton
  {
    private static Singleton? _instance;
    protected Singleton()
    {
        Console.WriteLine("Objeto Sigleton creado por primera vez!!!");
    }

    public static Singleton Instance()
    {
      if (_instance == null)
      {
        _instance = new Singleton();
      }

      return _instance;
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
  }
}
