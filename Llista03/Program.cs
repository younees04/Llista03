using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] mat = { 1, 1, 1, 2, 2, 2, 3, 3, 3};

            //EXERCICI14();

            int[] taula1 = { 1, 2, 3, 4, 5, 7, 11, 15 };
            int[] taula2 = { 3, 4, 5, 6, 7, 8};

            //    List<int> elementsComuns = EXERCICI15(taula1, taula2);

            //    Console.WriteLine("Elements comuns: ");
            //    foreach (int element in elementsComuns)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}

            //List<int> elementsComuns = EXERCICI16(taula1, taula2);

            //    Console.WriteLine("Elements no comuns: ");
            //    foreach (int element in elementsComuns)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}

            /* int[] taulaFusionada = EXERCICI17(taula1, taula2);

             Console.WriteLine("Taula fusionada: ");
             foreach (int element in taulaFusionada)
             {
                 Console.Write("" + element + " ");
             }
            */

            EXERCICI18();
        }

        public static void MostrarVector(int[] r)
        {

            for (int i = 0; i < r.Length; i++)
            {
                Console.Write(r[i]);
                Console.WriteLine();
            }
        }

        public static void MostrarMatriu(int[,] v)
        {
            for (int i = 0; i < v.GetLength(0); i++)
            {
                for (int j = 0; j < v.GetLength(1); j++)
                {
                    Console.Write(v[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static void EXERCICI02()
        {
            int files = 3;
            int colm = 3;

            int[,] mat2 = new int[files, colm];

            int valor = 1;

            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < colm; j++)
                {
                    mat2[i, j] = valor;
                }
                valor++;
            }
            MostrarMatriu(mat2);

        }

        public static void EXERCICI03()
        {

            int files = 3;
            int colm = 3;

            int[,] mat3 = new int[files, colm];

            int valor2 = 1;

            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < colm; j++)
                {
                    mat3[i, j] = valor2;
                    valor2++;
                }
                valor2 = 1;
            }
            MostrarMatriu(mat3);
        }

        public static void EXERCICI04()
        {
            int files = 3;
            int colm = 4;


            int[,] mat4 = new int[files, colm];

            int valor4 = 1;

            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < colm; j++)
                {
                    mat4[i, j] = valor4;
                    valor4++;
                }
            }
            MostrarMatriu(mat4);
        }

        public static void EXERCICI05()
        {
            int files = 3;
            int colm = 4;

            int[,] mat2 = new int[files, colm];

            int valor = 12;

            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < colm; j++)
                {
                    mat2[i, j] = valor;
                    valor--;
                }
            }
            MostrarMatriu(mat2);
        }

        public static void EXERCICI06()
        {
            int files = 3;
            int colm = 3;

            int[,] mat2 = new int[files, colm];


            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < colm; j++)
                {
                    if (i == j) mat2[i, j] = 1;

                    else mat2[i, j] = 0;
                }
            }
            MostrarMatriu(mat2);
        }

        public static void EXERCICI07()
        {
            int num;

            Console.WriteLine("Quantes files tindra el teu vector:");
            int files = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[files];

            Console.WriteLine("ENTRA ELS NUMEROS: ");

            for (int i = 0; i < files; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                vector[i] = num;
            }
            Console.WriteLine();
            MostrarVector(vector);
        }

        public static void EXERCICI08()
        {
            int num = 1;

            Console.WriteLine("Quantes files tindra el teu vector:");
            int files = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[files];

            for (int i = 0; i < files; i++)
            {

                vector[i] = num;
                num++;

            }
            Console.WriteLine();
            MostrarVector(vector);
        }

        public static void EXERCICI09()
        {
            int[] vector;
            int suma = 0;

            Console.WriteLine("Escriu la longitud de l'array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = i;
                suma += vector[i];
            }
            MostrarVector(vector);
            Console.WriteLine("La suma és: " + suma);
        }

        public static void EXERCICI10()
        {
            Console.WriteLine("Introduce una frase acabada en punto:");
            string frase = Console.ReadLine();

            if (!frase.EndsWith("."))
            {
                throw new Exception("La frase ha d'acabar en punt!");
            }

            frase = frase.ToLower();

            Dictionary<char, int> frecuenciaLetras = new Dictionary<char, int>();

            foreach (char letra in frase)
            {
                if (char.IsLetter(letra))
                {
                    if (frecuenciaLetras.ContainsKey(letra))
                    {
                        frecuenciaLetras[letra]++;
                    }
                    else
                    {
                        frecuenciaLetras[letra] = 1;
                    }
                }
            }

            Console.WriteLine("Frecuencia de letras:");

            foreach (var kvp in frecuenciaLetras.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public static void EXERCICI11()
        {
            Console.WriteLine("Escriu de quan sera el teu vector: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int posicio = 0;

            int petit = int.MaxValue;

            Random r = new Random();

            int[] vector = new int[num];

            for (int i = 0; i < num; i++)
            {
                vector[i] = r.Next(1, 100);

                if (vector[i] < petit)
                {
                    petit = vector[i];
                    posicio = i + 1;
                }
            }
            MostrarVector(vector);
            Console.WriteLine("El mes petit es: " + petit + " en la posicio: " + posicio);
        }
        public static void EXERCICI12()
        {
            int petit = int.MaxValue;
            int contFILA = 0, contColum = 0;

            Console.WriteLine("Escriu el numero de files de la matriu: ");
            int files = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriu el numero de columnes de la matriu: ");
            int colum = Convert.ToInt32(Console.ReadLine());

            int[,] Matriu = new int[files, colum];
            Random r = new Random();

            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    Matriu[i, j] = r.Next(1, 10);

                    if (Matriu[i, j] < petit)
                    {
                        petit = Matriu[i, j];
                        contFILA = i + 1;
                        contColum = j + 1;
                    }
                }
            }
            MostrarMatriu(Matriu);
            Console.WriteLine($"El numero més petit es el: {petit}, que esta en la fila: {contFILA}, en la columna: {contColum}");
        }

        public static void EXERCICI13()
        {
            int num, petit = int.MaxValue, gran = int.MinValue, suma = 0;
            double mitjana;

            Console.WriteLine("Escriu de quan sera el teu vector: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[longitud];

            Console.WriteLine("Emplena el vector: ");

            for (int i = 0; i < longitud; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                arr[i] = num;

                if (arr[i] < petit)
                {
                    petit = arr[i];
                }

                if (arr[i] > gran)
                {
                    gran = arr[i];
                }

                suma += arr[i];
            }
            mitjana = suma / longitud;
            Console.WriteLine($"El MAXIM és: {gran}, el MINIM es: {petit}, i el promig es: {mitjana}");
        }

        public static void EXERCICI14()
        {
            Console.WriteLine("Escriu el numero de files de la matriu: ");
            int files = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriu el numero de columnes de la matriu: ");
            int colum = Convert.ToInt32(Console.ReadLine());

            int[,] Matriu = new int[files, colum];

            Console.WriteLine("Emplena la matriu: ");

            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    Matriu[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("La Matriu original es: ");
            MostrarMatriu(Matriu);
            Console.WriteLine();

            Console.WriteLine("La Matriu transposada es: ");
            TransposarMatriu(Matriu);
        }

        public static void TransposarMatriu(int[,] matriuoriginal)
        {
            int[,] matriutrans = new int[matriuoriginal.GetLength(0), matriuoriginal.GetLength(1)];

            for (int i = 0; i < matriuoriginal.GetLength(0); i++)
            {
                for (int j = 0; j < matriuoriginal.GetLength(1); j++)
                {
                    matriutrans[j, i] = matriuoriginal[i, j];
                }
            }
            MostrarMatriu(matriutrans);
        }

        public static List<int> EXERCICI15(int[] taula1, int[] taula2)
        {
            List<int> elementsComuns = new List<int>();

            int index1 = 0;
            int index2 = 0;

            while (index1 < taula1.Length && index2 < taula2.Length)
            {
                if (taula1[index1] == taula2[index2])
                {
                    elementsComuns.Add(taula1[index1]);
                    index1++;
                    index2++;
                }
                else if (taula1[index1] < taula2[index2])
                {
                    index1++;
                }
                else
                {
                    index2++;
                }
            }
            return elementsComuns;
        }
        public static List<int> EXERCICI16(int[] taula1, int[] taula2)
        {
            List<int> elementsNoComuns = new List<int>();

            int index1 = 0;
            int index2 = 0;

            while (index1 < taula1.Length && index2 < taula2.Length)
            {
                if (taula1[index1] == taula2[index2])
                {
                    index1++;
                    index2++;
                }
                else if (taula1[index1] < taula2[index2])
                {
                    elementsNoComuns.Add(taula1[index1]);
                    index1++;
                }
                else
                {
                    elementsNoComuns.Add(taula2[index2]);
                    index2++;
                }
            }

            while (index1 < taula1.Length)
            {
                elementsNoComuns.Add(taula1[index1]);
                index1++;
            }

            while (index2 < taula2.Length)
            {
                elementsNoComuns.Add(taula2[index2]);
                index2++;
            }

            return elementsNoComuns;
        }

        public static int[] EXERCICI17(int[] taula1, int[] taula2)
        {
            List<int> taulaFusionada = new List<int>();

            int index1 = 0;
            int index2 = 0;

            while (index1 < taula1.Length && index2 < taula2.Length)
            {
                if (taula1[index1] < taula2[index2])
                {
                    taulaFusionada.Add(taula1[index1]);
                    index1++;
                }
                else if (taula1[index1] > taula2[index2])
                {
                    taulaFusionada.Add(taula2[index2]);
                    index2++;
                }
                else
                {
                    // Si els elements són iguals, només afegim un d'ells i incrementem ambdós índexs.
                    taulaFusionada.Add(taula1[index1]);
                    index1++;
                    index2++;
                }
            }

            // Afegim els elements restants de taula1 (si n'hi ha)
            while (index1 < taula1.Length)
            {
                taulaFusionada.Add(taula1[index1]);
                index1++;
            }

            // Afegim els elements restants de taula2 (si n'hi ha)
            while (index2 < taula2.Length)
            {
                taulaFusionada.Add(taula2[index2]);
                index2++;
            }

            return taulaFusionada.ToArray();
        }

        public static void EXERCICI18()
        {
            int num;

            Console.WriteLine("Escriu de quan sera el teu vector: ");
            num = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();

            int[] vector = new int[num];
            int[] vectorGirat = new int[num];

            for (int i = 0; i < num; i++)
            {
                vector[i] = r.Next(1, 100);
            }

            for (int j = 0; j < num; j++)
            {
                vectorGirat[j] = vector[num - j - 1];
            }

            Console.WriteLine("Vector original: ");
            MostrarVector(vector);

            Console.WriteLine("Vector girat: ");
            MostrarVector(vectorGirat);
        }
    }
}