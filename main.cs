using System;
using System.Collections.Generic;
using System.Linq;

namespace aa{

class MainClass {

  static string nombre;
  static float salario;
  static List<string> nombres = new List<string>(); 
  static List<float> salarios = new List<float>();


  public static void Main (string[] args) {
      
    Cargar();

    SalarioMayor();

  }

  public static void Cargar(){

    Console.WriteLine("Introduzca el nombre y salario de 5 empleados:");

    for(int i=1;i<6;i++){
      Console.Write("Nombre del {0}° Empleado:",i);
      nombres.Add(Console.ReadLine());

      Console.Write("Salario del {0}° Empleado:",i);
      salarios.Add(float.Parse(Console.ReadLine()));
      
    }

  }

  public static void SalarioMayor(){

    float mayor = salarios.Max();
    int pos = salarios.IndexOf(mayor);    

    Console.WriteLine("El empleado con el salario mayor es {0}", nombres[pos]);
    Console.WriteLine("Tiene un salario de {0}",mayor);   

  }

}
}