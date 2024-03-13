namespace HePhuongTrinhBac1_2an
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            a1 = new Label();
            b1 = new Label();
            c1 = new Label();
            a2 = new Label();
            b2 = new Label();
            c2 = new Label();
            calc = new Button();
            x = new Label();
            y = new Label();
            txt_a1 = new TextBox();
            txt_b1 = new TextBox();
            txt_c1 = new TextBox();
            txt_a2 = new TextBox();
            txt_b2 = new TextBox();
            txt_c2 = new TextBox();
            txt_x = new TextBox();
            txt_y = new TextBox();
            clear = new Button();
            exit = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 37);
            label1.Name = "label1";
            label1.Size = new Size(398, 40);
            label1.TabIndex = 0;
            label1.Text = "Hệ Phương Trình Bậc 1 2 ẩn";
            label1.Click += label1_Click;
            // 
            // a1
            // 
            a1.AutoSize = true;
            a1.Location = new Point(121, 146);
            a1.Name = "a1";
            a1.Size = new Size(21, 15);
            a1.TabIndex = 1;
            a1.Text = "A1";
            // 
            // b1
            // 
            b1.AutoSize = true;
            b1.Location = new Point(121, 179);
            b1.Name = "b1";
            b1.Size = new Size(20, 15);
            b1.TabIndex = 2;
            b1.Text = "B1";
            // 
            // c1
            // 
            c1.AutoSize = true;
            c1.Location = new Point(121, 213);
            c1.Name = "c1";
            c1.Size = new Size(21, 15);
            c1.TabIndex = 3;
            c1.Text = "C1";
            // 
            // a2
            // 
            a2.AutoSize = true;
            a2.Location = new Point(121, 363);
            a2.Name = "a2";
            a2.Size = new Size(21, 15);
            a2.TabIndex = 4;
            a2.Text = "A2";
            a2.Click += A2_Click;
            // 
            // b2
            // 
            b2.AutoSize = true;
            b2.Location = new Point(121, 395);
            b2.Name = "b2";
            b2.Size = new Size(20, 15);
            b2.TabIndex = 5;
            b2.Text = "B2";
            // 
            // c2
            // 
            c2.AutoSize = true;
            c2.Location = new Point(121, 429);
            c2.Name = "c2";
            c2.Size = new Size(21, 15);
            c2.TabIndex = 6;
            c2.Text = "C2";
            // 
            // calc
            // 
            calc.Location = new Point(353, 265);
            calc.Name = "calc";
            calc.Size = new Size(154, 58);
            calc.TabIndex = 7;
            calc.Text = "Giải";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // x
            // 
            x.AutoSize = true;
            x.Location = new Point(604, 208);
            x.Name = "x";
            x.Size = new Size(22, 15);
            x.TabIndex = 8;
            x.Text = "X=";
            x.Click += x_Click;
            // 
            // y
            // 
            y.AutoSize = true;
            y.Location = new Point(604, 363);
            y.Name = "y";
            y.Size = new Size(22, 15);
            y.TabIndex = 9;
            y.Text = "Y=";
            // 
            // txt_a1
            // 
            txt_a1.Location = new Point(148, 146);
            txt_a1.Name = "txt_a1";
            txt_a1.Size = new Size(100, 23);
            txt_a1.TabIndex = 10;
            // 
            // txt_b1
            // 
            txt_b1.Location = new Point(148, 179);
            txt_b1.Name = "txt_b1";
            txt_b1.Size = new Size(100, 23);
            txt_b1.TabIndex = 11;
            // 
            // txt_c1
            // 
            txt_c1.Location = new Point(148, 213);
            txt_c1.Name = "txt_c1";
            txt_c1.Size = new Size(100, 23);
            txt_c1.TabIndex = 12;
            // 
            // txt_a2
            // 
            txt_a2.Location = new Point(148, 360);
            txt_a2.Name = "txt_a2";
            txt_a2.Size = new Size(100, 23);
            txt_a2.TabIndex = 13;
            // 
            // txt_b2
            // 
            txt_b2.Location = new Point(148, 392);
            txt_b2.Name = "txt_b2";
            txt_b2.Size = new Size(100, 23);
            txt_b2.TabIndex = 14;
            // 
            // txt_c2
            // 
            txt_c2.Location = new Point(148, 426);
            txt_c2.Name = "txt_c2";
            txt_c2.Size = new Size(100, 23);
            txt_c2.TabIndex = 15;
            // 
            // txt_x
            // 
            txt_x.Enabled = false;
            txt_x.Location = new Point(632, 205);
            txt_x.Name = "txt_x";
            txt_x.Size = new Size(252, 23);
            txt_x.TabIndex = 16;
            // 
            // txt_y
            // 
            txt_y.Enabled = false;
            txt_y.Location = new Point(632, 360);
            txt_y.Name = "txt_y";
            txt_y.Size = new Size(252, 23);
            txt_y.TabIndex = 17;
            // 
            // clear
            // 
            clear.Location = new Point(384, 213);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 18;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // exit
            // 
            exit.Location = new Point(384, 360);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 19;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 200.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(-23, 87);
            label2.Name = "label2";
            label2.Size = new Size(230, 355);
            label2.TabIndex = 20;
            label2.Text = "{";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 129.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(513, 154);
            label3.Name = "label3";
            label3.Size = new Size(149, 229);
            label3.TabIndex = 21;
            label3.Text = "{";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 679);
            Controls.Add(exit);
            Controls.Add(clear);
            Controls.Add(txt_y);
            Controls.Add(txt_x);
            Controls.Add(txt_c2);
            Controls.Add(txt_b2);
            Controls.Add(txt_a2);
            Controls.Add(txt_c1);
            Controls.Add(txt_b1);
            Controls.Add(txt_a1);
            Controls.Add(y);
            Controls.Add(x);
            Controls.Add(calc);
            Controls.Add(c2);
            Controls.Add(b2);
            Controls.Add(a2);
            Controls.Add(c1);
            Controls.Add(b1);
            Controls.Add(a1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label a1;
        private Label b1;
        private Label c1;
        private Label a2;
        private Label b2;
        private Label c2;
        private Button calc;
        private Label x;
        private Label y;
        private TextBox txt_a1;
        private TextBox txt_b1;
        private TextBox txt_c1;
        private TextBox txt_a2;
        private TextBox txt_b2;
        private TextBox txt_c2;
        private TextBox txt_x;
        private TextBox txt_y;
        private Button clear;
        private Button exit;
        private Label label2;
        private Label label3;
    }
}
