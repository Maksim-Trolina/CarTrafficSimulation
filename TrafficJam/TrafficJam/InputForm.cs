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
            decimal percentageCars = percentageCarsNumeric.Value;
            decimal maxSpeed = maxSpeedNumeric.Value;
            uint countCars = (uint) countCarsNumeric.Value;

            var form = new MainForm(percentageCars, maxSpeed, countCars);

            Hide();

            form.ShowDialog();

            Close();
        }
    }
}
