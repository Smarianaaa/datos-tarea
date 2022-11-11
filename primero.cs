using System;

namespace Ejercicio1
{
    class PruebaVector1
    {
    private int[] sueldos;
    public void Cargar()
    {
        string linea;
        sueldos = new int[5];
        for (int f = 0; f < 5; f++)
        {
            Console.Write("Ingrese el sueldo :");
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }

    public void Imprimir()
    {
        
       Console.WriteLine("Listado de todos los sueldos");
        for(int f=0; f<5;f++)
        {
            Console.WriteLine(sueldos[f]);
        }
    }
    
    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
        Console.ReadKey();
    }
    }
}