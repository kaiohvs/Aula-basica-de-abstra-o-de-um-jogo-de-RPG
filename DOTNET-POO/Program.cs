using System;
using DOTNET_POO.src.Entities;

namespace DOTNET_POO
{
    class Program
    {
        static void Main(string [] args)
        {
            Knight Arus = new Knight("Arus", 12, "Knight");
            Wizard Jenica = new Wizard("Jessica", 20, "white Wizard");
            Wizard Topapa = new Wizard("Topapa", 12, "Black Wizard");
            Ninja Wedge = new Ninja("Wedge", 12, "Ninja");
          

            Console.WriteLine(Arus.ToString() + "\n");
            Console.WriteLine(Jenica.ToString()+ "\n");
            Console.WriteLine(Topapa.ToString()+ "\n");
            Console.WriteLine(Wedge.ToString());
            
            
          
        }
    }
}