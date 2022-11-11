using System;

namespace EJERCICIO_2
{
    class AlturaPersonas
    {
        private float[] alturas;
        private float promedio;

        public void Cargar()
        {
            alturas=new float[5];
            for (int f=0; f < 5; f++)
            {
                Console.Write("Ingrese la altura de la persona:");
                string linea = Console.ReadLine();
                alturas[f] = float.Parse(linea);
            }
        }
        public void CalcularPromedio()
        {
            float suma = 0;
            for(int f=0; f < 5; f++)
            {
                suma=suma+alturas[f];
            }
             promedio=suma/5;
            Console.WriteLine("Promedio de alturas:"+promedio);
        }
        public void MayoresMenores()
        {
            int may = 0;
            int men = 0;
            for(int f=0; f < 5; f++)
            {
                if(alturas[f]>promedio)
                {
                    may++;
                }
                else
                {
                    if (alturas[f]<promedio)
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas mayores al promedio:"+may);
            Console.WriteLine("Cantidad de personas menores al promedio:"+men);
        }
        static void Main(string[] args)
        {
            AlturaPersonas ap = new AlturaPersonas();
            ap.Cargar();
            ap.CalcularPromedio();
            ap.MayoresMenores();
            Console.ReadKey();
        }
    }
}

                
