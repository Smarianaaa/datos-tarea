using System;

namespace EJERCICIO_3
{
    class Empresa
    {
        private float[] turnoMan;
        private float[] turnoTar;

        public void Cargar()
        {
            turnoMan = new float[4];
            turnoTar = new float[4];
            Console.WriteLine("Carga de sueldos de empleados del turno de la mañana:");
            for(int f=0; f<4;f++)
            {
                Console.Write("Ingrese sueldo:");
                string linea = Console.ReadLine();
                turnoMan[f]=float.Parse(linea);
            }
            Console.WriteLine("Carga de sueldos de empleados del turno de la tarde:");
            for(int f=0; f<4;f++)
            {
                Console.Write("Ingrese sueldo:");
                string linea = Console.ReadLine();
                turnoTar[f]=float.Parse(linea);
            }
        }

        public void CalcularGastos()
        {
            float man = 0;
            float tar = 0;
            for(int f=0; f<4; f++)
            {
                man = man + turnoMan[f];
                tar = tar + turnoTar[f];
            }
            Console.WriteLine("Total de gastos en sueldos del turno de la mañana:"+ man);
            Console.WriteLine("Total de gastos en sueldos del turno de la tarde:"+ tar);
        }
        static void Main(string[] args)
        {
            Empresa empresa1 = new Empresa();
            empresa1.Cargar();
            empresa1.CalcularGastos();
            Console.ReadKey();
        }
    }
}