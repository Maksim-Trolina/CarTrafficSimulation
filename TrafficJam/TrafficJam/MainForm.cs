using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficJam
{
    public partial class MainForm : Form
    {
        const int StartPositionX = 10;

        const int StartPositionY = 10;

        const int WidthCar = 50;

        const int HeightCar = 50;

        const int RenderInterval = 100;

        const string StopStateText = "Стоп";

        const string StartStateText = "Старт";

        System.Windows.Forms.Timer timerRender;

        Stopwatch timerWork;

        Road road;

        SaveFileDialog saveFileDialog;
        public MainForm()
        {
            InitializeComponent();
        }

        //Инициализация всего необходимого(этот метод это конструктор формы)
        public MainForm(double percentageCars, int maxSpeed, uint countCars)
        {
            InitializeComponent();

            DoubleBuffered = true;

            MaximizeBox = false;

            MinimizeBox = false;

            road = new Road(percentageCars, maxSpeed, StartPositionX, WidthCar / 2, Width, countCars);

            timerRender = new System.Windows.Forms.Timer
            {
                Interval = RenderInterval
            };

            timerRender.Tick += new EventHandler(Rendering);

            timerRender.Start();

            timerWork = new Stopwatch();

            timerWork.Start();

            saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        //Происходит каждые RenderInterval мс
        void Rendering(object myObject, EventArgs myEventArgs)
        {
            road.MoveCars();

            //Вызывает метод OnPaint, который все перерисовывает
            Invalidate();
        }

        //Когда нажимаем на кнопку Старт/Стоп
        void btnChangeState_Click(object sender, EventArgs e)
        {
            if (timerRender.Enabled)
            {
                btnChangeState.Text = StopStateText;

                timerWork.Stop();
            }
            else
            {
                btnChangeState.Text = StartStateText;

                timerWork.Start();
            }

            timerRender.Enabled = !timerRender.Enabled;
        }

        //Рендеринг(переписовка) машин
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            foreach (var car in road.Cars)
            {
                graphics.DrawEllipse(new Pen(Brushes.Red, 3), car.PositionX - 9, StartPositionY, WidthCar, HeightCar);
            }
        }

        //Срабатывает когда нажимаем по кнопке сохранить
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string fileName = saveFileDialog.FileName;

            File.WriteAllText(fileName, $"За {timerWork.Elapsed.Seconds} секунд проехало дорогу, протяженностью {Width}, {road.CarsFinished} машин ");
        }
    }
}
