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
    public partial class Form1 : Form
    {
        // Создаем экземпляр босса
        Boss boss = new Boss();

        public Form1()
        {
            InitializeComponent();

            // Подписываем объекты на события босса
            boss.Upgraded += LogMessage;
            boss.TurnedOn += LogMessage;
        }

        // Метод для вывода сообщений в ListBox
        private void LogMessage(string message)
        {
            listBox1.Items.Add(message);
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем несколько объектов техники
            Computer computer1 = new Computer("Компьютер 1", 200);
            Computer computer2 = new Computer("Компьютер 2", 220);
            Printer printer1 = new Printer("Принтер 1", 180);

            // Вызываем методы босса для генерации событий
            boss.UpgradeEquipment(computer1);
            boss.TurnOnEquipment(computer1);

            boss.UpgradeEquipment(computer2);
            boss.TurnOnEquipment(computer2);

            boss.UpgradeEquipment(printer1);
            boss.TurnOnEquipment(printer1);
        }
    }
}
