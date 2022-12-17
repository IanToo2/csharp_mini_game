namespace csharp_mini_game
{
    partial class Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_car = new System.Windows.Forms.PictureBox();
            this.pictureBox_police = new System.Windows.Forms.PictureBox();
            this.pictureBox_police2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_money1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_money2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_money3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_police)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_police2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(178, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(178, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 80);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(178, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 92);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(178, 272);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 98);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(178, 376);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 99);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 464);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(375, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 464);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_car
            // 
            this.pictureBox_car.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_car.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_car.Image")));
            this.pictureBox_car.Location = new System.Drawing.Point(145, 376);
            this.pictureBox_car.Name = "pictureBox_car";
            this.pictureBox_car.Size = new System.Drawing.Size(76, 78);
            this.pictureBox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_car.TabIndex = 7;
            this.pictureBox_car.TabStop = false;
            // 
            // pictureBox_police
            // 
            this.pictureBox_police.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_police.Image")));
            this.pictureBox_police.Location = new System.Drawing.Point(45, 86);
            this.pictureBox_police.Name = "pictureBox_police";
            this.pictureBox_police.Size = new System.Drawing.Size(76, 68);
            this.pictureBox_police.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_police.TabIndex = 8;
            this.pictureBox_police.TabStop = false;
            // 
            // pictureBox_police2
            // 
            this.pictureBox_police2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_police2.Image")));
            this.pictureBox_police2.Location = new System.Drawing.Point(246, 86);
            this.pictureBox_police2.Name = "pictureBox_police2";
            this.pictureBox_police2.Size = new System.Drawing.Size(76, 68);
            this.pictureBox_police2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_police2.TabIndex = 9;
            this.pictureBox_police2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(36, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Game Over";
            this.label1.Visible = false;
            // 
            // pictureBox_money1
            // 
            this.pictureBox_money1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_money1.Image")));
            this.pictureBox_money1.Location = new System.Drawing.Point(67, 24);
            this.pictureBox_money1.Name = "pictureBox_money1";
            this.pictureBox_money1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox_money1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_money1.TabIndex = 11;
            this.pictureBox_money1.TabStop = false;
            // 
            // pictureBox_money2
            // 
            this.pictureBox_money2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_money2.Image")));
            this.pictureBox_money2.Location = new System.Drawing.Point(145, 98);
            this.pictureBox_money2.Name = "pictureBox_money2";
            this.pictureBox_money2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox_money2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_money2.TabIndex = 12;
            this.pictureBox_money2.TabStop = false;
            // 
            // pictureBox_money3
            // 
            this.pictureBox_money3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_money3.Image")));
            this.pictureBox_money3.Location = new System.Drawing.Point(281, 52);
            this.pictureBox_money3.Name = "pictureBox_money3";
            this.pictureBox_money3.Size = new System.Drawing.Size(27, 28);
            this.pictureBox_money3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_money3.TabIndex = 13;
            this.pictureBox_money3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "점수 = 0";
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_money3);
            this.Controls.Add(this.pictureBox_money2);
            this.Controls.Add(this.pictureBox_money1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_police2);
            this.Controls.Add(this.pictureBox_police);
            this.Controls.Add(this.pictureBox_car);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Car_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_police)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_police2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_car;
        private System.Windows.Forms.PictureBox pictureBox_police;
        private System.Windows.Forms.PictureBox pictureBox_police2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_money1;
        private System.Windows.Forms.PictureBox pictureBox_money2;
        private System.Windows.Forms.PictureBox pictureBox_money3;
        private System.Windows.Forms.Label label2;
    }
}