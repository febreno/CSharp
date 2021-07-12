using System;

namespace Learn //name project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console App(.NET Framework)
            //windows forms(.NET Framework)
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5] {{ 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 }};

            Random random = new Random();
            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(50);//next possui (sobrecarga)
            }
            Console.WriteLine("Elementos do vetor1");
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("------------------------------------------------");

            //public static int BinarySearch(array, valor);
            Console.WriteLine("BinarySearch");
            int procurando = 44;
            int pos = Array.BinarySearch(vetor1, procurando);//posicao
            Console.WriteLine("valor {0} esta na posicao {1} ", procurando, pos);
            Console.WriteLine("------------------------------------------------");

            //public static void Copy(Ar_Origem, Ar_destino,qtde_elemento);
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("------------------------------------------------");

            //public static void CopyTo;
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0); //copiar do 1 para o 3
            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("------------------------------------------------");

            //public long GetLongLength(dimensao)
            Console.WriteLine();
            long qtdeElementosVetor = vetor1.GetLongLength(0);
            Console.WriteLine("Quantidade De elementos {0}", qtdeElementosVetor);
            Console.WriteLine("------------------------------------------------");

            //public int GetLowerBound(dimensao) menor indice
            Console.WriteLine("GetLowerBound");
            int MenorIndiceVetor = vetor1.GetLowerBound(0);
            int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
            Console.WriteLine("menor indices {0}", MenorIndiceMatriz_D1);
            Console.WriteLine("------------------------------------------------");

            //public int GetUpperBound(dimensao) maior indice
            //Console.WriteLine("GetUpperBound");
            //int MenorIndiceVetor = vetor1.GetUpperBound(0);
            //int MenorIndiceMatriz_D1 = matriz.GetUpperBound(1);
            //Console.WriteLine("maior indice {0}", MenorIndiceMatriz_D1);
            //Console.WriteLine("------------------------------------------------");

            //public obj GetValue(long indice)
            Console.WriteLine("GetValue");
            int valor0 = Convert.ToInt32(vetor1.GetValue(3));
            int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
            Console.WriteLine("Indice do primeiro valor 3:", valor0);
            Console.WriteLine("------------------------------------------------");

            //public static int IndexOf(array, valor)
            Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(vetor1,3);
            Console.WriteLine("Valor do primeiro valor 3: ", indice1);
            Console.WriteLine("------------------------------------------------");

            //public static int LastIndexOf(array, valor)
            Console.WriteLine("IndexOf");
            int indice2 = Array.LastIndexOf(vetor1, 3);
            Console.WriteLine("Valor do ultimo valor 3: ", indice2);
            Console.WriteLine("------------------------------------------------");

            //public static void Reverse(array);
            Array.Reverse(vetor1);
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("------------------------------------------------");

            //public void SetValue(obj valor, long pos);
            vetor2.SetValue(99, 0);
            for (int i = 0; i < vetor2.Length; i++)
            {
                vetor2.SetValue(0, i);
            }
            Console.WriteLine("Vetor2");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("------------------------------------------------");

            //public static void Sort(array);
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Console.WriteLine("Vetor1");
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVetor2");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVetor3");
            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("------------------------------------------------");


            //const int numeroQtd = 2;
            //int[] numeros = new int[numeroQtd];
            //int menor = 0, maior = 0, posicao_menor = 0, posicao_maior = 0;

            //Console.WriteLine("Informe 2 números inteiros:");

            //for (int i = 0; i < numeroQtd; i++)
            //{

            //    Console.WriteLine((i + 1) + "º número:");
            //    numeros[i] = Convert.ToInt32(Console.ReadLine());

            //    if (i == 0)
            //    {
            //        menor = numeros[0];
            //        maior = numeros[0];
            //    }

            //    if (numeros[i] < menor)
            //    {

            //        menor = numeros[i];
            //        posicao_menor = i;

            //    }
            //    else if (numeros[i] > maior)
            //    {
            //        maior = numeros[i];
            //        posicao_maior = i;
            //    }

            //}

            //Console.WriteLine("O menor número é:" + menor);
            //Console.WriteLine("A posição do menor número é:" + posicao_menor);
            //Console.WriteLine("O maior número é:" + maior);
            //Console.WriteLine("A posição do maior número é:" + posicao_maior);

            Console.Read();
            //int[] original = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] copia = new int[original.Length];

            //for (int index = 0; index > original.Length; index++) copia[index] = original[index];

            //Console.WriteLine("Original 1");
            //original.ToList().ForEach(p => Console.WriteLine(p.ToString()));

            //Console.WriteLine("Copia 1");
            //copia.ToList().ForEach(p => Console.WriteLine(p.ToString()));

            //Console.WriteLine("Original 2");
            //original.ToList().ForEach(Console.WriteLine);

            //Console.WriteLine("Copia 2");
            //copia.ToList().ForEach(Console.WriteLine);

            //Console.WriteLine("Original 3");
            //Console.WriteLine("[{0}]", string.Join(", ", original));

            //Console.WriteLine("Copia 3");
            //Console.WriteLine("[{0}]", string.Join(", ", copia));

            //Console.WriteLine("Original 4");
            //foreach (var item in original) Console.WriteLine(item.ToString());

            //Console.WriteLine("Copia 4");
            //foreach (var item in copia) Console.WriteLine(item.ToString());
        }
    }
}
