
namespace csharp_mini_game
{
    partial class Baseball
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
            this.lb_Result = new System.Windows.Forms.ListBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Result
            // 
            this.lb_Result.Font = new System.Drawing.Font("굴림", 12F);
            this.lb_Result.FormattingEnabled = true;
            this.lb_Result.ItemHeight = 20;
            this.lb_Result.Location = new System.Drawing.Point(12, 12);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(536, 324);
            this.lb_Result.TabIndex = 4;
            this.lb_Result.SelectedIndexChanged += new System.EventHandler(this.lb_Result_SelectedIndexChanged);
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(12, 384);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(548, 25);
            this.tb_number.TabIndex = 1;
            this.tb_number.TextChanged += new System.EventHandler(this.tb_number_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "시작하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "정답보기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "초기화";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(633, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "결과확인";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(633, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 49);
            this.button5.TabIndex = 6;
            this.button5.Text = "게임종료";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Baseball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.lb_Result);
            this.Name = "Baseball";
            this.Text = "Baseball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Result;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}