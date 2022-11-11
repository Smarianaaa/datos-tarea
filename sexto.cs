using System;

namespace EJERCICIO_6
{
    class Matriz
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[3, 4];
            for(int f=0; f<3; f++)
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
            for(int f=0; f<3; f++)
            {
                for(int c=0; c<4; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        } 

        public void Primerfila()
        {
            Console.WriteLine("Primer fila de la matriz:");
            for(int c=0; c<4; c++)
            {
                Console.WriteLine(mat[0, c]);
            }
        }

        public void Ultimafila()
        {
            Console.WriteLine("Ultima fila de la matriz:");
            for(int c=0; c<4; c++)
            {
                Console.WriteLine(mat[2, c]);
            }
        }

        public void PrimerColumna()
        {
            Console.WriteLine("Primer Columna:");
            for(int f=0; f<3; f++)
            {
                Console.WriteLine(mat[f, 0]);
            }
        }
        static void Main(string[] args)
        {
            Matriz m = new Matriz();
            m.Cargar();
            m.Imprimir();
            m.Primerfila();
            m.Ultimafila();
            m.PrimerColumna();
            Console.ReadKey();

        }
    }
}