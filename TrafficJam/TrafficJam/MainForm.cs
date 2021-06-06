using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficJam
{
    public partial class MainForm : Form
    {
        double percentageCars;

        int maxSpeed;

        uint countCars;

        const int StartPositionX = 10;

        const int StartPositionY = 10;

        const int WidthCar = 100;

        const int HeightCar = 100;

        const int RenderInterval = 100;

        System.Windows.Forms.Timer timer;

        Road road;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(double percentageCars, int maxSpeed, uint countCars)
        {
            InitializeComponent();

            DoubleBuffered = true;

            this.percentageCars = percentageCars;

            this.maxSpeed = maxSpeed;

            this.countCars = countCars;

            road = new Road(countCars, percentageCars, maxSpeed, StartPositionX);

            timer = new System.Windows.Forms.Timer();

            timer.Interval = RenderInterval;

            timer.Tick += new EventHandler(Rendering);

            timer.Start();
        }

        void Rendering(object myObject, EventArgs myEventArgs)
        {
            road.MoveCars();

            Invalidate();
        }

        void btnStart_Click(object sender, EventArgs e)
        {

        }

        void btnStop_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            foreach (var car in road.Cars)
            {
                graphics.DrawEllipse(new Pen(Brushes.Red, 3), car.PositionX, StartPositionY, WidthCar, HeightCar);
            }
        }
    }
}
