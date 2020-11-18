using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
// using System.IO;
using Newtonsoft.Json;
using AnaliseAlgoritmoOrdenacao.Serialization;
using System.IO;

namespace AnaliseAlgoritmoOrdenacao
{
    public partial class Form1 : Form
    {
        List<Foto> fotos = new List<Foto>();

        static Random randNum = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Análise executada");
            if(radioButton1.Checked == false) // Dados de origem interna
            {   // gerar dados internamente
                
                preencheObj(100000);
            }
            else
            {   // carregar dados externamente
                string pathc = File.ReadAllText(openFileDialog1.FileName);
                void convertJson(string path)
                {
                    var fotos = JsonConvert.DeserializeObject<List<Foto>>(path);
                    //this.textBox1.Text = " "+fotos[0].Titulo;//testa se o objeto está sendo serializado
                }
                convertJson(pathc);
            } // arr[] = dataSeparate(attr)
            var arrOrdena = transformArray(fotos, comboBox1.SelectedIndex);
            string[] arrOrdenaStringCopia = new string[100000];
            int[] arrOrdenaIntCopia = new int[100000];
            if (checkBox1.Checked == true) {
                DateTime startTime = DateTime.Now;
                int msStart = startTime.Millisecond;
                AnaliseAlgoritmoOrdenacao.Program.setLog(msStart.ToString() + "\r\n" + AnaliseAlgoritmoOrdenacao.Program.getLog());
                this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
                //TimeSpan interval;
                AnaliseAlgoritmoOrdenacao.Program.setLog(comboBox1.SelectedIndex + ": indece\r\n" + AnaliseAlgoritmoOrdenacao.Program.getLog());
                this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
                if (comboBox1.SelectedIndex == 4) {
                    Quick_Sort(arrOrdena, 0, arrOrdena.Length - 1);
                }
                else {
                    arrOrdena.CopyTo(arrOrdenaStringCopia, 0);
                    Quick_Sort(arrOrdenaStringCopia, 0, arrOrdenaStringCopia.Length - 1);
                }
                DateTime finalTime = DateTime.Now;
                int msFinal = finalTime.Millisecond;
                int ms = msFinal - msStart;
                addLog(ms.ToString());
                AnaliseAlgoritmoOrdenacao.Program.setLog(ms.ToString() + "\r\n" + AnaliseAlgoritmoOrdenacao.Program.getLog());
                this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
            }
            if (checkBox2.Checked == true)
            {
                arrOrdena.CopyTo(arrOrdenaStringCopia, 0);
                DateTime startTime = DateTime.Now;
                TimeSpan interval;
                CocktailSort(arrOrdenaIntCopia);
                interval = DateTime.Now - startTime;
                addLog(interval.Milliseconds.ToString());
                AnaliseAlgoritmoOrdenacao.Program.setLog(interval.Milliseconds.ToString() + "\r\n" + AnaliseAlgoritmoOrdenacao.Program.getLog());
                this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
            }
            if (checkBox3.Checked == true)
            {
                arrOrdena.CopyTo(arrOrdenaStringCopia, 0);
                DateTime startTime = DateTime.Now;
                TimeSpan interval;
                MergeSort(arrOrdenaIntCopia, 0, arrOrdenaIntCopia.Length - 1);
                interval = DateTime.Now - startTime;
                addLog(interval.Milliseconds.ToString());
                AnaliseAlgoritmoOrdenacao.Program.setLog(interval.Milliseconds.ToString() + "\r\n" + AnaliseAlgoritmoOrdenacao.Program.getLog());
                this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
            }
        }
        //separate in array
        static String[] transformArray(List<Foto> fotoObj, int selec) 
        {
            int tam = 100000;
            String[] arr = new string[tam];
            for (int i = 0; i < tam; i++)
            {
                if (selec == 0)
                {arr[i] = fotoObj[i].Titulo; //Titulo
                }
                if (selec == 1)
                {arr[i] = fotoObj[i].LocalDaFoto; //Titulo
                }
                if (selec == 2)
                {arr[i] = fotoObj[i].DataDaFoto; //Titul
                }
                if (selec == 3)
                {arr[i] = fotoObj[i].Tamanho; //Titul
                }
                if (selec == 4)
                {arr[i] = fotoObj[i].Formato; //Titul
                }
            }
            return arr;
        }
        public void addLog(string param)
        {
            AnaliseAlgoritmoOrdenacao.Program.setLog(param + "\r\n" + AnaliseAlgoritmoOrdenacao.Program.getLog());
            this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
        }

        public void preencheObj(int qtd)
        {
            
            string[] strArr = new string[5];
            int int1;
            for (int i = 0; i < qtd; i++)
            {
                int1 = randomic(0, qtd);
                strArr[0] = geraNomeacao();
                strArr[1] = geraNomeacao();
                strArr[2] = geraNomeacao();
                strArr[3] = geraNomeacao();
                strArr[4] = geraNomeacao();
                fotos.Add(new Foto{IdFoto=int1, Titulo=strArr[0], LocalDaFoto=strArr[1], DataDaFoto=strArr[2], Tamanho=strArr[3], Formato=strArr[4] });
            }
        }
        public string geraNomeacao()
        {

            string str = "";
            //quantas letra vai ter o nome
            int tam = randNum.Next(2, 9);
            //str = new String[tam];
            for (int i = 0; i < tam; i++)
            {
                str = str.Insert(i, Char.ToString((char)randNum.Next(97, 123)));
            }

            return str;
        }

        int randomic(int intervalInit, int intervalEnd) // Random int
        {
            //static Random randNum;
            //Random randNum = new Random();
            return randNum.Next(intervalInit, intervalEnd);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //add pilha styled
            // Primeiro elemento sempre por cima
            
        }

        /*private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var iten = comboBox1.SelectedItem;
            string logStr = AnaliseAlgoritmoOrdenacao.Program.getLog();
            iten = comboBox1.SelectedIndex;
            /*this.listBox1.Items.AddRange(new object[] {
            iten});
            this.listBox1.Items.AddRange(new object[]
            {
                AppDomain.CurrentDomain

            });*/
            logStr = iten + "\r\n" + logStr;
            AnaliseAlgoritmoOrdenacao.Program.setLog(logStr);
            if (comboBox1.SelectedItem == "Data da Foto")
            {
                this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
                //this.textBox1.Text = "\r\n " + typeof(this.textBox1);
            }
            else
            {
                this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
            }


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.button2.Visible = true;
            this.button3.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.button2.Visible = false;
            this.button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.ShowDialog();

            //openFileDialog1.OpenFile();
            var fileStream = openFileDialog1.FileName;
            AnaliseAlgoritmoOrdenacao.Program.setLog(fileStream + "\r\n" + AnaliseAlgoritmoOrdenacao.Program.getLog());
            this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            preencheObj(100000);
            string jsonData = JsonConvert.SerializeObject(fotos);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"fotos.json", jsonData); //sobrescreve o arquivo inteiro
            AnaliseAlgoritmoOrdenacao.Program.setLog("Arquivo foto.json gerado em " + AppDomain.CurrentDomain.BaseDirectory + "\r\n" + AnaliseAlgoritmoOrdenacao.Program.getLog());
            this.textBox1.Text = AnaliseAlgoritmoOrdenacao.Program.getLog();
        }   

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
        //string
        static void Quick_Sort(string[] a, int start, int end)
        {
            // index for the "left-to-right scan"
            int i = start;
            // index for the "right-to-left scan"
            int j = end;

            // only examine arrays of 2 or more elements.
            if (j - i >= 1)
            {
                // The pivot point of the sort method is arbitrarily set to the first element int the array.
                String pivot = a[i];
                // only scan between the two indexes, until they meet.
                while (j > i)
                {
                    // from the left, if the current element is lexicographically less than the (original)
                    // first element in the String array, move on. Stop advancing the counter when we reach
                    // the right or an element that is lexicographically greater than the pivot String.
                    while (a[i].CompareTo(pivot) < 0 && i <= end && j > i)
                    {
                        i++;
                    }
                    // from the right, if the current element is lexicographically greater than the (original)
                    // first element in the String array, move on. Stop advancing the counter when we reach
                    // the left or an element that is lexicographically less than the pivot String.
                    while (a[j].CompareTo(pivot) > 0 && j >= start && j >= i)
                    {
                        j--;
                    }
                    // check the two elements in the center, the last comparison before the scans cross.
                    if (j > i)
                        swap(a, i, j);
                }
                // At this point, the two scans have crossed each other in the center of the array and stop.
                // The left partition and right partition contain the right groups of numbers but are not
                // sorted themselves. The following recursive code sorts the left and right partitions.

                // Swap the pivot point with the last element of the left partition.
                swap(a, start, j);
                // sort left partition
                Quick_Sort(a, start, j - 1);
                // sort right partition
                Quick_Sort(a, j + 1, end);
            }
        }
        /**
         * This method facilitates the quickSort method's need to swap two elements, Towers of Hanoi style.
         */
        private static void swap(String[] a, int i, int j)
        {
            String temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    
    // --QuickSort--\\
    // --CockTailSort--//
    static void CocktailSort(int[] a)
    {
        bool swapped = true;
        int start = 0;
        int end = a.Length;

        while (swapped == true)
        {

            swapped = false;

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

            if (swapped == false)
                break;

            swapped = false;
            end = end - 1;
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
            start = start + 1;
        }
    }
    // --CockTailSort--\\
    // --MergeSort-- //
    void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }
        // --MergeSort-- \\
    }
}
