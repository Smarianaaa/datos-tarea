using System;

namespace EJERCICIO_4
{
    class PruebaMatriz
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[3,5];
            for(int f=0; f<3; f++)
            {
                for(int c=0; c<5; c++)
                {
                    Console.Write("Ingrese componente:");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            for(int f=0; f<3; f++)
            {
                for(int c=0; c<5; c++)
                {
                    Console.Write(mat[f,c] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            PruebaMatriz pm = new PruebaMatriz();
            pm.Cargar();
            pm.Imprimir();
            Console.ReadKey();
        }
    }
}
