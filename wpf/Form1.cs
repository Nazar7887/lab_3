using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(txtArraySize.Text);
                double[] array = new double[size];
                FillRandomArray(array, -28.35, 12.91);
                txtArrayOutput.Text = string.Join(", ", array.Select(x => x.ToString("F2")));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double[] array = ParseArrayFromText(txtArrayOutput.Text);
                int product = FindNegativeIndexesProduct(array);
                txtResult.Text = "Product of indexes: " + product;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double[] array = ParseArrayFromText(txtArrayOutput.Text);
                int k = int.Parse(txtKValue.Text);
                SortFirstKElementsDescending(array, k);
                txtArrayOutput.Text = string.Join(", ", array.Select(x => x.ToString("F2")));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void FillRandomArray(double[] array, double min, double max)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(random.NextDouble() * (max - min) + min, 2);
            }
        }

        private int FindNegativeIndexesProduct(double[] array)
        {
            int product = 1;
            bool hasNegative = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    product *= i;
                    hasNegative = true;
                }
            }
            return hasNegative ? product : 0;
        }

        private void SortFirstKElementsDescending(double[] array, int k)
        {
            double[] sortedPart = array.Take(k).OrderByDescending(x => x).ToArray();
            for (int i = 0; i < k; i++)
            {
                array[i] = sortedPart[i];
            }
        }

        private double[] ParseArrayFromText(string text)
        {
            return text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(double.Parse)
                       .ToArray();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
