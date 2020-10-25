using JsonDemo.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

//
using System.Data;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto fotoObj = new Foto();
            //Console.WriteLine(fotoObj.zona);

            Console.WriteLine("Teste");

            var json = File.ReadAllText(@"C:\Users\alefm\source\repos\JsonDemo\pessoa.json");
            //var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\pessoa.json");
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            //Console.WriteLine(AppDomain.CurrentDomain);
            var js = new DataContractJsonSerializer(typeof(List<Pessoa>));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var pessoa = (List<Pessoa>)js.ReadObject(ms);
            // new Pessoa = pessoa p
            // Console.WriteLine(Pessoa.Nome);
            var show = pessoa[0].Nome;
            Console.WriteLine(show);
            show = pessoa[1].Nome;
            Console.WriteLine(show);

            int[] lista;
            lista = new int[100];
            for (int i = 0; i < 100; i++)
            {
                lista[i] = 100 - i;
            }
            //mostraVetor(lista);
            //Console.WriteLine(Convert.ToString(lista));
            bubbleSort(lista);
            //Quick_Sort(lista, 0, lista.Length - 1);
            //cocktailSort(lista);
            //Console.WriteLine("\n"+lista.Length);
            //mostraVetor(lista);

            json = File.ReadAllText(@"C:\Users\alefm\source\repos\JsonDemo\fotos.json");
            js = new DataContractJsonSerializer(typeof(List<Foto>));
            ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var foto = (List<Foto>)js.ReadObject(ms);
            show = foto[0].LocalDaFoto;
            Console.WriteLine("foto SetType " + foto.GetType());
            Console.WriteLine(show); // Manaus
            Console.WriteLine("foto[0].LocalDaFoto GetType " + show.GetType());
            Console.WriteLine("Count " + foto.Count); // 5
            Console.WriteLine("Second");
            var show2 = foto[0];
            Console.WriteLine("show2 GetType " + show2.GetType());
            var arr1 = transformArrayTitulo(foto, foto.Count);
            Console.WriteLine("preFor");
            for (var i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            String strToBytes = "abcwxyzaçãéóõô"; //231 227
            byte[] asciiBytes = Encoding.Default.GetBytes(strToBytes);
            Console.WriteLine("{0} {1} {2} ", asciiBytes[0], asciiBytes[1], asciiBytes[2]); // 97 98 99
            foreach (int c in asciiBytes) { 
                Console.Write(" "+c); }
            strToBytes = "ABCWXYZaÇÃÉÓÕÔ "; // 199 195
            asciiBytes = Encoding.Default.GetBytes(strToBytes); //ASCII
            Console.WriteLine("\n{0} {1} {2} ", asciiBytes[0], asciiBytes[1], asciiBytes[2]); // 65 66 67
            foreach (int c in asciiBytes)
                {
                    Console.Write(" " + c);
                }
            Console.WriteLine("\n chars "+ (char)65);
            byte by;
            //char c;
            string str2;
            for (int b = 65; b <123; b++)
                {
                    Console.Write("" + (char)b);
                    if (b == 90) b = 96;
                //Console.Write(System.Text.Encoding.ASCII.GetString(new byte[] { 65 }));
            }
            Console.Write("" +(char)231+(char)227+(char)199+(char)195+(char)32+(char)233+(char)201+(char)245); //çãÇÃ éÉó


            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime dateTime = DateTime.UtcNow.Date;
            Console.WriteLine("\n"+now);
            Console.WriteLine(today); // 00:00:00
            Console.WriteLine(dateTime.ToString("d"));
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];
            Console.WriteLine(date);
            Console.WriteLine(time);

            Console.ReadKey();
        }
        /*
        public class Foto
        {
            //public string zona = "BrasilNorte";
            public int IdFoto { get; set; }
            public String Titulo { get; set; }
            public String LocalDaFoto { get; set; }
            public String DataDaFoto { get; set; } //DataHora
            public int ResoluçãoX { get; set; } // px
            public int ResoluçãoY { get; set; } // px
            public String Tamanho { get; set; } // KB or double
            public String Formato { get; set; }
        }*/
        static void mostraVetor(int[] vetor)
        {
            Console.Write(vetor[0]);
            for (int i = 1; i < 100; i++)
            {
                Console.Write(", " + vetor[i]);
            }
            Console.WriteLine("\n");
        }
        static void bubbleSort(int[] vetor)
        {
            Boolean troca = true;
            int aux;
            int p = 10;
            while (troca)
            {
                troca = false;
                for (int i = 0; i < vetor.Length - 1; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        troca = true;
                        if (vetor[i] > vetor.Length / 100 * p)
                        {
                            Console.WriteLine("Progresso em " + p + "% ...");
                            p += 10;
                        }
                    }
                }
            }
        }
        static void bubbleSortString(String[] vetor)
        {
            Boolean troca = true;
            String aux;
            while (troca)
            {
                troca = false;
                for (int i = 0; i < vetor.Length - 1; i++)
                {
                    if (vetor[i].CompareTo(vetor[i + 1]) > 0)
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        troca = true;
                    }
                }
            }
        }
        /*static void transformArray(string prop, object obj) // Transforma propriedade da lista de objetos em array
        {/*
            var array;
            var len = obj.Count;
            var str = obj as string[];
            foreach (var s in obj) {
                array = obj;

            }* /
        }*/
        static String[] transformArrayTitulo(List<Foto> fotoObj, int tam) //obj.Count
        {
            String[] arr = new string[tam];
            for(int i=0; i<tam; i++)
            {
                arr[i] = fotoObj[i].Titulo;
                Console.WriteLine(arr[i]);
            }
            return arr;
        }
        /*
         * Algoritmo nomeação randomica: random[2:9];if(r<4)str+=(" "+random[2><6]);trash="çéãó";if("trash">1)random;if(bool[0])random[0:1]bool=[th|ch|lh|çã|ão];
        if(!"aeiou")random[0:1]bool[a|e|i|o|u]
         * Método de conversão de datas para numério 
         * Método de geração randomica de datas
         * Método de gravação da serialização em json
         * Método de ordenação quickSort
         * Método de ordenação mergeSort
         * Método de ordenação cockTailSort
         * Método de ordenação insertionSort
        */
        // --QuickSort--//
            private static void Quick_Sort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(arr, left, right);

                    if (pivot > 1)
                    {
                        Quick_Sort(arr, left, pivot - 1);
                    }
                    if (pivot + 1 < right)
                    {
                        Quick_Sort(arr, pivot + 1, right);
                    }
                }

            }

            private static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[left];
                while (true)
                {

                    while (arr[left] < pivot)
                    {
                        left++;
                    }

                    while (arr[right] > pivot)
                    {
                        right--;
                    }

                    if (left < right)
                    {
                        if (arr[left] == arr[right]) return right;

                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;


                    }
                    else
                    {
                        return right;
                    }
                }
            }
        // --QuickSort--\\
        // --CockTailSort--//
            static void cocktailSort(int[] a)
            {
                bool swapped = true;
                int start = 0;
                int end = a.Length;

                while (swapped == true)
                {

                    // reset the swapped flag on entering the 
                    // loop, because it might be true from a 
                    // previous iteration. 
                    swapped = false;

                    // loop from bottom to top same as 
                    // the bubble sort 
                    for (int i = start; i < end - 1; ++i)
                    {
                        if (a[i] > a[i + 1])
                        {
                            int temp = a[i];
                            a[i] = a[i + 1];
                            a[i + 1] = temp;
                            swapped = true;
                        }
                    }

                    // if nothing moved, then array is sorted. 
                    if (swapped == false)
                        break;

                    // otherwise, reset the swapped flag so that it 
                    // can be used in the next stage 
                    swapped = false;

                    // move the end point back by one, because 
                    // item at the end is in its rightful spot 
                    end = end - 1;

                    // from top to bottom, doing the 
                    // same comparison as in the previous stage 
                    for (int i = end - 1; i >= start; i--)
                    {
                        if (a[i] > a[i + 1])
                        {
                            int temp = a[i];
                            a[i] = a[i + 1];
                            a[i + 1] = temp;
                            swapped = true;
                        }
                    }

                    // increase the starting point, because 
                    // the last stage would have moved the next 
                    // smallest number to its rightful spot. 
                    start = start + 1;
                }
            }
        // --CockTailSort--\\

    }

}