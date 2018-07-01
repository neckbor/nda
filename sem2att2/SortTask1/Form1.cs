using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void chartRun_Btn_Click(object sender, EventArgs e)
        {
            try { 
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            chart.Series[2].Points.Clear();

            int leng = 100;

                for (int i = 1; i < leng; i++)
                {
                    int[] mas = new int[i];
                    mas = RandomData(i);

                    int[] a1 = new int[i];
                    int[] a2 = new int[i];
                    int[] a3 = new int[i];

                    for (int j = 0; j < i; j++)
                    {
                        a1[j] = mas[j];
                        a2[j] = mas[j];
                        a3[j] = mas[j];
                    }

                    if (radioButtonChange.Checked)
                    {
                        //натуральное слияние
                        Sort.NatureMergeSort(a1);
                        chart.Series[0].Points.AddXY(i, Sort.GetChangeCount());

                        //простое слияние
                        Sort.SimpleMergeSort(a2);
                        chart.Series[1].Points.AddXY(i, Sort.GetChangeCount());

                        //шейкер
                        Sort.ShakerSort(a3);
                        chart.Series[2].Points.AddXY(i, Sort.GetChangeCount());
                    }
                    else
                        if (radioButtonCompare.Checked)
                        {
                            //натуральное слияние
                            Sort.NatureMergeSort(a1);
                            chart.Series[0].Points.AddXY(i, Sort.GetCompareCount());

                            //простое слияние
                            Sort.SimpleMergeSort(a2);
                            chart.Series[1].Points.AddXY(i, Sort.GetCompareCount());

                            //шейкер
                            Sort.ShakerSort(a3);
                            chart.Series[2].Points.AddXY(i, Sort.GetCompareCount());
                        }
                    else
                        throw new Exception("Choose chart data type on radioButtons!");
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error");
            }
        }

        private int[] RandomData(int leng)
        {
            int[] rMas = new int[leng];

            Random rnd = new Random();

            for (int i = 0; i < leng; i++)
            {
                int x = rnd.Next(1, 50);
                rMas[i] = x;
            }

            return rMas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw_Form form = new Draw_Form();

            form.Show();
        }
    }
}
