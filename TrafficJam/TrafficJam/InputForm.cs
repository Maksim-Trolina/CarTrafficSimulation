using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficJam
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }
        //Срабатывает когда нажимается кнопка Старт
        private void btnStart_Click(object sender, EventArgs e)
        {
            double percentageCars = (double) percentageCarsNumeric.Value;
            int maxSpeed = (int) maxSpeedNumeric.Value;
            uint countCars = (uint) countCarsNumeric.Value;

            var form = new MainForm(percentageCars, maxSpeed, countCars);

            //Прячет форму текущую
            Hide();

            //Открывает другую форму
            form.ShowDialog();

            //После того как форма, которая до этого была открыта, закроет, то тоже закроет эту форму
            Close();
        }
    }
}
