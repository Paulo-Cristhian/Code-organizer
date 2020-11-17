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
            MessageBox.Show("Não quero Funfar!");
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
                TimeSpan interval;
                if (comboBox1.SelectedIndex == 4) {
                    arrOrdena.CopyTo(arrOrdenaIntCopia, 0);
                    Quick_Sort(arrOrdenaIntCopia, 0, arrOrdenaIntCopia.Length - 1);
                }
                else {
                    arrOrdena.CopyTo(arrOrdenaStringCopia, 0);
                    Quick_Sort(arrOrdenaStringCopia, 0, arrOrdenaStringCopia.Length - 1);
                }
                interval = DateTime.Now - startTime;
                addLog(interval.Milliseconds.ToString());
            }
            if (checkBox2.Checked == true)
            {
                DateTime startTime = DateTime.Now;
                TimeSpan interval;
                //ordenação cocktailSort(lista);
                interval = DateTime.Now - startTime;
                addLog(interval.Milliseconds.ToString());
            }
            if (checkBox3.Checked == true)
            {
                DateTime startTime = DateTime.Now;
                TimeSpan interval;
                //MergeSort(arr, 0, arr.Length - 1);
                interval = DateTime.Now - startTime;
                addLog(interval.Milliseconds.ToString());
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
                {arr[i] = fotoObj[i].LocalDaFoto; //Titul
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
        static char[] Quick_Sort(char[] items, int left, int right)
        {
            int i, j;
            char x, y;

            i = left; j = right;
            x = items[(left + right) / 2];

            do
            {
                while ((items[i] < x) && (i < right)) i++;
                while ((x < items[j]) && (j > left)) j--;

                if (i <= j)
                {
                    y = items[i];
                    items[i] = items[j];
                    items[j] = y;
                    i++; j--;
                }
            } while (i <= j);

            if (left < j)
            {
                return Quick_Sort(items, left, j);
            }
            if (i < right)
            {
                return Quick_Sort(items, i, right);
            } return items;//whatever is most appropriate in the case that you arrive here
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
        private void Merge(int[] input, int left, int middle, int right)
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

        private void MergeSort(int[] input, int left, int right)
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
