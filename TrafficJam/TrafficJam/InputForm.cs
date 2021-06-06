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

        private void btnStart_Click(object sender, EventArgs e)
        {
            double percentageCars = (double) percentageCarsNumeric.Value;
            int maxSpeed = (int) maxSpeedNumeric.Value;
            uint countCars = (uint) countCarsNumeric.Value;

            var form = new MainForm(percentageCars, maxSpeed, countCars);

            Hide();

            form.ShowDialog();

            Close();
        }
    }
}
