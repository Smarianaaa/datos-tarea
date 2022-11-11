using System;

namespace EJERCICIO_5
{
    class PruebaMatriz
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[4, 4];
            for(int f=0; f<4; f++)
            {
                for(int c=0; c<4; c++)
                {
                    Console.Write("Ingrese componente:");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            for(int f=0; f<4; f++)
            {
                for(int c=0; c<4; c++)
                {

                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ImprimirDiagonalPrincipal()
        {
            Console.WriteLine(mat[0, 0]);
            Console.WriteLine(mat[1, 1]);
            Console.WriteLine(mat[2, 2]);
            Console.WriteLine(mat[3, 3]);
        }
        static void Main(string[] args)
        {
            PruebaMatriz pm = new PruebaMatriz();
            pm.Cargar();
            pm.Imprimir();
            Console.WriteLine("_________________");
            pm.ImprimirDiagonalPrincipal();
            Console.ReadKey();
        }
    }
}
