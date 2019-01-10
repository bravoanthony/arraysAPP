using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3, 3];
            int[,] y = new int[3, 2];
            int[,] z = new int[3, 1];
            leer(x);
            imprimir(x);

            leer(y);
            imprimir(y);
            multiplicar(x, y, z);
            imprimir(z);
            int[][,] matriz = new int[3][,];
            inicializar(matriz);
            int[][][] m1 = new int[3][][];

            Console.ReadKey();




        }
        public static void leer(int[,] matriz)
        {
            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    string aux;
                    Console.Write("[{0}, {1}]", i, j);
                    aux = Console.ReadLine();
                    matriz[i, j] = Int32.Parse(aux);

                }
                Console.WriteLine();
            }
        }
        public static void imprimir(int[,] matriz)
        {
            Console.WriteLine("\nImpreseion de la matriz");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write(" {0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void multiplicar(int[,] A, int[,] B, int[,] C)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < A.GetLength(0); k++)
                    {
                        C[i, j] = C[i, j] * B[i, k] * B[k, j];

                    }
                }

            }
        }
        public static void inicializar(int[][,] matriz)
        {
            matriz[0] = new int[3, 3];
            matriz[1] = new int[3, 2];
            matriz[2] = new int[3, 2];
            Console.WriteLine("\nMultiplicacion de matrices utilizando dimenciones ");
            leer(matriz[0]);
            leer(matriz[1]);
            multiplicar(matriz[0], matriz[1], matriz[2]);
            imprimir(matriz[2]);
        }
    }
    
}
