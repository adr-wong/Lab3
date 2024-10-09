namespace Lab3otravez
{
    partial class Problema1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 52);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 85);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 114);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Monto Inicial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 171);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "Transacciones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 235);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 4;
            label5.Text = "Cuenta de Ahorros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 284);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Retiros";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(245, 284);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 6;
            label7.Text = "Depositos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(586, 266);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Saldo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(548, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 23);
            textBox3.TabIndex = 10;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(201, 169);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Depositos";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(323, 171);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Retiros";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(95, 325);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 13;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(236, 325);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(536, 80);
            button1.Name = "button1";
            button1.Size = new Size(136, 73);
            button1.TabIndex = 15;
            button1.Text = "Abrir Cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(536, 313);
            button2.Name = "button2";
            button2.Size = new Size(136, 75);
            button2.TabIndex = 16;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Problema1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Problema1";
            Text = "Problema1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
    }
}