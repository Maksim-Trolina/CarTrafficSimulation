
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
            // 
            // countCarsNumeric
            // 
            this.countCarsNumeric.Location = new System.Drawing.Point(417, 54);
            this.countCarsNumeric.Name = "countCarsNumeric";
            this.countCarsNumeric.Size = new System.Drawing.Size(98, 23);
            this.countCarsNumeric.TabIndex = 2;
            // 
            // maxSpeedNumeric
            // 
            this.maxSpeedNumeric.DecimalPlaces = 3;
            this.maxSpeedNumeric.Location = new System.Drawing.Point(395, 114);
            this.maxSpeedNumeric.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.maxSpeedNumeric.Name = "maxSpeedNumeric";
            this.maxSpeedNumeric.Size = new System.Drawing.Size(120, 23);
            this.maxSpeedNumeric.TabIndex = 3;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown percentageCarsNumeric;
        private System.Windows.Forms.NumericUpDown countCarsNumeric;
        private System.Windows.Forms.NumericUpDown maxSpeedNumeric;
    }
}