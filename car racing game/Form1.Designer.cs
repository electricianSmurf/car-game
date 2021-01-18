namespace car_racing_game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.roadLine1 = new System.Windows.Forms.PictureBox();
            this.roadLine2 = new System.Windows.Forms.PictureBox();
            this.roadLine3 = new System.Windows.Forms.PictureBox();
            this.roadLine4 = new System.Windows.Forms.PictureBox();
            this.roadLine5 = new System.Windows.Forms.PictureBox();
            this.roadLine6 = new System.Windows.Forms.PictureBox();
            this.gameMover = new System.Windows.Forms.Timer(this.components);
            this.roadLine7 = new System.Windows.Forms.PictureBox();
            this.roadLine8 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.PBoxCar1 = new System.Windows.Forms.PictureBox();
            this.PBoxCar2 = new System.Windows.Forms.PictureBox();
            this.PBoxCar3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnReStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCarSpeed = new System.Windows.Forms.Label();
            this.carFuelGauge = new System.Windows.Forms.ProgressBar();
            this.fuelOil = new System.Windows.Forms.PictureBox();
            this.lblFuelOver = new System.Windows.Forms.Label();
            this.cup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelOil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cup)).BeginInit();
            this.SuspendLayout();
            // 
            // roadLine1
            // 
            this.roadLine1.BackColor = System.Drawing.Color.White;
            this.roadLine1.Location = new System.Drawing.Point(73, -11);
            this.roadLine1.Name = "roadLine1";
            this.roadLine1.Size = new System.Drawing.Size(10, 96);
            this.roadLine1.TabIndex = 0;
            this.roadLine1.TabStop = false;
            // 
            // roadLine2
            // 
            this.roadLine2.BackColor = System.Drawing.Color.White;
            this.roadLine2.Location = new System.Drawing.Point(152, -11);
            this.roadLine2.Name = "roadLine2";
            this.roadLine2.Size = new System.Drawing.Size(10, 96);
            this.roadLine2.TabIndex = 1;
            this.roadLine2.TabStop = false;
            // 
            // roadLine3
            // 
            this.roadLine3.BackColor = System.Drawing.Color.White;
            this.roadLine3.Location = new System.Drawing.Point(152, 103);
            this.roadLine3.Name = "roadLine3";
            this.roadLine3.Size = new System.Drawing.Size(10, 96);
            this.roadLine3.TabIndex = 3;
            this.roadLine3.TabStop = false;
            // 
            // roadLine4
            // 
            this.roadLine4.BackColor = System.Drawing.Color.White;
            this.roadLine4.Location = new System.Drawing.Point(73, 103);
            this.roadLine4.Name = "roadLine4";
            this.roadLine4.Size = new System.Drawing.Size(10, 96);
            this.roadLine4.TabIndex = 2;
            this.roadLine4.TabStop = false;
            // 
            // roadLine5
            // 
            this.roadLine5.BackColor = System.Drawing.Color.White;
            this.roadLine5.Location = new System.Drawing.Point(152, 221);
            this.roadLine5.Name = "roadLine5";
            this.roadLine5.Size = new System.Drawing.Size(10, 96);
            this.roadLine5.TabIndex = 5;
            this.roadLine5.TabStop = false;
            // 
            // roadLine6
            // 
            this.roadLine6.BackColor = System.Drawing.Color.White;
            this.roadLine6.Location = new System.Drawing.Point(73, 221);
            this.roadLine6.Name = "roadLine6";
            this.roadLine6.Size = new System.Drawing.Size(10, 96);
            this.roadLine6.TabIndex = 4;
            this.roadLine6.TabStop = false;
            // 
            // gameMover
            // 
            this.gameMover.Enabled = true;
            this.gameMover.Interval = 10;
            this.gameMover.Tick += new System.EventHandler(this.gameMover_Tick);
            // 
            // roadLine7
            // 
            this.roadLine7.BackColor = System.Drawing.Color.White;
            this.roadLine7.Location = new System.Drawing.Point(152, 354);
            this.roadLine7.Name = "roadLine7";
            this.roadLine7.Size = new System.Drawing.Size(10, 96);
            this.roadLine7.TabIndex = 7;
            this.roadLine7.TabStop = false;
            // 
            // roadLine8
            // 
            this.roadLine8.BackColor = System.Drawing.Color.White;
            this.roadLine8.Location = new System.Drawing.Point(73, 354);
            this.roadLine8.Name = "roadLine8";
            this.roadLine8.Size = new System.Drawing.Size(10, 96);
            this.roadLine8.TabIndex = 6;
            this.roadLine8.TabStop = false;
            // 
            // car
            // 
            this.car.Image = global::car_racing_game.Properties.Resources.car;
            this.car.Location = new System.Drawing.Point(118, 345);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(28, 55);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 8;
            this.car.TabStop = false;
            // 
            // PBoxCar1
            // 
            this.PBoxCar1.Image = global::car_racing_game.Properties.Resources.car1;
            this.PBoxCar1.Location = new System.Drawing.Point(0, 33);
            this.PBoxCar1.Name = "PBoxCar1";
            this.PBoxCar1.Size = new System.Drawing.Size(27, 52);
            this.PBoxCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxCar1.TabIndex = 9;
            this.PBoxCar1.TabStop = false;
            // 
            // PBoxCar2
            // 
            this.PBoxCar2.Image = global::car_racing_game.Properties.Resources.car2;
            this.PBoxCar2.Location = new System.Drawing.Point(80, 12);
            this.PBoxCar2.Name = "PBoxCar2";
            this.PBoxCar2.Size = new System.Drawing.Size(26, 50);
            this.PBoxCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxCar2.TabIndex = 10;
            this.PBoxCar2.TabStop = false;
            // 
            // PBoxCar3
            // 
            this.PBoxCar3.Image = global::car_racing_game.Properties.Resources.car3;
            this.PBoxCar3.Location = new System.Drawing.Point(168, 21);
            this.PBoxCar3.Name = "PBoxCar3";
            this.PBoxCar3.Size = new System.Drawing.Size(25, 52);
            this.PBoxCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxCar3.TabIndex = 11;
            this.PBoxCar3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(266, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 414);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Snow;
            this.lblGameOver.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGameOver.Location = new System.Drawing.Point(20, 88);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(196, 28);
            this.lblGameOver.TabIndex = 13;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // btnReStart
            // 
            this.btnReStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReStart.ForeColor = System.Drawing.Color.Red;
            this.btnReStart.Location = new System.Drawing.Point(80, 138);
            this.btnReStart.Name = "btnReStart";
            this.btnReStart.Size = new System.Drawing.Size(75, 37);
            this.btnReStart.TabIndex = 14;
            this.btnReStart.Text = "restart";
            this.btnReStart.UseVisualStyleBackColor = true;
            this.btnReStart.Visible = false;
            this.btnReStart.Click += new System.EventHandler(this.btnReStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(22, 5);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(44, 13);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "Score 0";
            // 
            // lblCarSpeed
            // 
            this.lblCarSpeed.AutoSize = true;
            this.lblCarSpeed.Location = new System.Drawing.Point(166, 5);
            this.lblCarSpeed.Name = "lblCarSpeed";
            this.lblCarSpeed.Size = new System.Drawing.Size(47, 13);
            this.lblCarSpeed.TabIndex = 16;
            this.lblCarSpeed.Text = "Speed 0";
            // 
            // carFuelGauge
            // 
            this.carFuelGauge.BackColor = System.Drawing.Color.Red;
            this.carFuelGauge.Location = new System.Drawing.Point(79, 5);
            this.carFuelGauge.Maximum = 10;
            this.carFuelGauge.Name = "carFuelGauge";
            this.carFuelGauge.Size = new System.Drawing.Size(81, 10);
            this.carFuelGauge.TabIndex = 17;
            this.carFuelGauge.Value = 10;
            // 
            // fuelOil
            // 
            this.fuelOil.Image = global::car_racing_game.Properties.Resources.fuel;
            this.fuelOil.Location = new System.Drawing.Point(82, 55);
            this.fuelOil.Name = "fuelOil";
            this.fuelOil.Size = new System.Drawing.Size(34, 30);
            this.fuelOil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fuelOil.TabIndex = 19;
            this.fuelOil.TabStop = false;
            this.fuelOil.Visible = false;
            // 
            // lblFuelOver
            // 
            this.lblFuelOver.AutoSize = true;
            this.lblFuelOver.BackColor = System.Drawing.Color.Snow;
            this.lblFuelOver.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelOver.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFuelOver.Location = new System.Drawing.Point(13, 179);
            this.lblFuelOver.Name = "lblFuelOver";
            this.lblFuelOver.Size = new System.Drawing.Size(209, 25);
            this.lblFuelOver.TabIndex = 20;
            this.lblFuelOver.Text = "OUT OF FUEL";
            this.lblFuelOver.Visible = false;
            // 
            // cup
            // 
            this.cup.Image = global::car_racing_game.Properties.Resources.cup;
            this.cup.Location = new System.Drawing.Point(70, 176);
            this.cup.Name = "cup";
            this.cup.Size = new System.Drawing.Size(100, 100);
            this.cup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cup.TabIndex = 21;
            this.cup.TabStop = false;
            this.cup.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(234, 416);
            this.Controls.Add(this.cup);
            this.Controls.Add(this.lblFuelOver);
            this.Controls.Add(this.fuelOil);
            this.Controls.Add(this.carFuelGauge);
            this.Controls.Add(this.lblCarSpeed);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnReStart);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBoxCar3);
            this.Controls.Add(this.PBoxCar2);
            this.Controls.Add(this.PBoxCar1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.roadLine7);
            this.Controls.Add(this.roadLine8);
            this.Controls.Add(this.roadLine5);
            this.Controls.Add(this.roadLine6);
            this.Controls.Add(this.roadLine3);
            this.Controls.Add(this.roadLine4);
            this.Controls.Add(this.roadLine2);
            this.Controls.Add(this.roadLine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(250, 450);
            this.Name = "Form1";
            this.Text = "Wrong Way Home";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.roadLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelOil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox roadLine1;
        private System.Windows.Forms.PictureBox roadLine2;
        private System.Windows.Forms.PictureBox roadLine3;
        private System.Windows.Forms.PictureBox roadLine4;
        private System.Windows.Forms.PictureBox roadLine5;
        private System.Windows.Forms.PictureBox roadLine6;
        private System.Windows.Forms.Timer gameMover;
        private System.Windows.Forms.PictureBox roadLine7;
        private System.Windows.Forms.PictureBox roadLine8;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox PBoxCar1;
        private System.Windows.Forms.PictureBox PBoxCar2;
        private System.Windows.Forms.PictureBox PBoxCar3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button btnReStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCarSpeed;
        private System.Windows.Forms.ProgressBar carFuelGauge;
        private System.Windows.Forms.PictureBox fuelOil;
        private System.Windows.Forms.Label lblFuelOver;
        private System.Windows.Forms.PictureBox cup;
    }
}

