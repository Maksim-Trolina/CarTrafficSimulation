
namespace TrafficJam
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.percentageCarsNumeric = new System.Windows.Forms.NumericUpDown();
            this.countCarsNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxSpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCarsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCarsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(32, 54);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // percentageCarsNumeric
            // 
            this.percentageCarsNumeric.DecimalPlaces = 3;
            this.percentageCarsNumeric.Location = new System.Drawing.Point(218, 54);
            this.percentageCarsNumeric.Name = "percentageCarsNumeric";
            this.percentageCarsNumeric.Size = new System.Drawing.Size(99, 23);
            this.percentageCarsNumeric.TabIndex = 1;
            this.percentageCarsNumeric.Tag = "";
            // 
            // countCarsNumeric
            // 
            this.countCarsNumeric.Location = new System.Drawing.Point(417, 54);
            this.countCarsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countCarsNumeric.Name = "countCarsNumeric";
            this.countCarsNumeric.Size = new System.Drawing.Size(98, 23);
            this.countCarsNumeric.TabIndex = 2;
            this.countCarsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxSpeedNumeric
            // 
            this.maxSpeedNumeric.Location = new System.Drawing.Point(395, 114);
            this.maxSpeedNumeric.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.maxSpeedNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxSpeedNumeric.Name = "maxSpeedNumeric";
            this.maxSpeedNumeric.Size = new System.Drawing.Size(120, 23);
            this.maxSpeedNumeric.TabIndex = 3;
            this.maxSpeedNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Процент соблюдающих дистанцию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество машин на дороге";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Максимальная скорость";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxSpeedNumeric);
            this.Controls.Add(this.countCarsNumeric);
            this.Controls.Add(this.percentageCarsNumeric);
            this.Controls.Add(this.btnStart);
            this.Name = "InputForm";
            this.Text = "InputForm";
            ((System.ComponentModel.ISupportInitialize)(this.percentageCarsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCarsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown percentageCarsNumeric;
        private System.Windows.Forms.NumericUpDown countCarsNumeric;
        private System.Windows.Forms.NumericUpDown maxSpeedNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}