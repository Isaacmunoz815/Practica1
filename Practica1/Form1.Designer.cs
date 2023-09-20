namespace Practica1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(589, 39);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 182);
            label1.Name = "label1";
            label1.Size = new Size(288, 32);
            label1.TabIndex = 1;
            label1.Text = "POBLACION DE CONEJOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 261);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 4;
            label2.Text = "DIMENSIONES ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(533, 335);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 39);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 339);
            label3.Name = "label3";
            label3.Size = new Size(319, 32);
            label3.TabIndex = 6;
            label3.Text = "CONEJOS POR GENERACION";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(848, 336);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 39);
            textBox4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 417);
            label4.Name = "label4";
            label4.Size = new Size(328, 32);
            label4.TabIndex = 8;
            label4.Text = "GENERACIONES DE CONEJOS";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(394, 413);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(589, 39);
            textBox5.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(328, 486);
            button1.Name = "button1";
            button1.Size = new Size(394, 69);
            button1.TabIndex = 9;
            button1.Text = "GENERAR LISTA DE CONEJOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(43, 585);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(952, 360);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(394, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(589, 39);
            textBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 339);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 12;
            label5.Text = "MINIMO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(712, 335);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 13;
            label6.Text = "MAXIMO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7600_4_2_04;
            pictureBox1.Location = new Point(-2, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 159);
            panel1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(268, 45);
            label7.Name = "label7";
            label7.Size = new Size(667, 71);
            label7.TabIndex = 0;
            label7.Text = "POBLACION DE CONEJOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 980);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "POBLACION DE CONEJOS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label7;
    }
}