using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Метод для удаления знаков препинания
        public static string RemovePunctuation(string input)
        {
            var sb = new StringBuilder();
            foreach (char c in input)
            {
                if (!char.IsPunctuation(c) && !char.IsSymbol(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        // Метод для добавления символов
        public static string AddSymbols(string input)
        {
            return input + "###";
        }

        // Метод для замены на заглавные буквы
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        // Метод для удаления лишних пробелов
        public static string RemoveExtraSpaces(string input)
        {
            var sb = new StringBuilder();
            bool lastCharWasSpace = false;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    sb.Append(c);
                    lastCharWasSpace = false;
                }
                else
                {
                    if (!lastCharWasSpace)
                    {
                        sb.Append(c);
                    }
                    lastCharWasSpace = true;
                }
            }
            return sb.ToString();
        }

        // Метод для обрезки строки до определенной длины
        public static string Truncate(string input, int length)
        {
            if (input.Length > length)
                return input.Substring(0, length);
            else
                return input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Вызываем первый метод обработки и выводим результат в ListBox
            listBox1.Items.Add(RemovePunctuation(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Вызываем второй метод обработки и выводим результат в ListBox
            listBox1.Items.Add(AddSymbols(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Вызываем третий метод обработки и выводим результат в ListBox
            listBox1.Items.Add(ToUpperCase(textBox1.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Вызываем четвертый метод обработки и выводим результат в ListBox
            listBox1.Items.Add(RemoveExtraSpaces(textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Вызываем пятый метод обработки и выводим результат в ListBox
            listBox1.Items.Add(Truncate(textBox1.Text, 10));
        }
    }
}
