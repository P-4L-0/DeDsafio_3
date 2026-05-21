namespace DeDsafio3
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
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            listBox1 = new ListBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 315);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Resultados:";
            // 
            // button3
            // 
            button3.Location = new Point(14, 271);
            button3.Name = "button3";
            button3.Size = new Size(216, 35);
            button3.TabIndex = 12;
            button3.Text = "Limpiar Mapa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(14, 230);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 11;
            button2.Text = "Cargar Datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 189);
            button1.Name = "button1";
            button1.Size = new Size(218, 35);
            button1.TabIndex = 10;
            button1.Text = "Calcular Ruta";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(14, 117);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 9;
            label4.Text = "Destino:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 8;
            label3.Text = "Origen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 7;
            label2.Text = "Controles";
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 14;
            // 
            // listBox1
            // 
            listBox1.Enabled = false;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(19, 333);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(211, 109);
            listBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 135);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(215, 23);
            comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 23);
            comboBox1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 450);
            panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(960, 830);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Sistema de Rutas UDB (Desafío 3)";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}
