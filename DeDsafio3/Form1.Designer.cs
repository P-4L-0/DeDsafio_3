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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 233);
            button3.Name = "button3";
            button3.Size = new Size(216, 35);
            button3.TabIndex = 12;
            button3.Text = "Limpiar Mapa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 192);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 11;
            button2.Text = "Cargar Datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 151);
            button1.Name = "button1";
            button1.Size = new Size(218, 35);
            button1.TabIndex = 10;
            button1.Text = "Calcular Ruta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 79);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 9;
            label4.Text = "Destino:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(10, 19);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 8;
            label3.Text = "Origen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(-42, -104);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 7;
            label2.Text = "Controles";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(3, 330);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 400);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(238, 378);
            listBox1.TabIndex = 16;
            listBox1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 322);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controles";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Edificio 2", "Edificio 3", "Edificio 4", "Edificio 5", "Observatorio Micro Macro", "Edificio OWCC", "Porton NorOeste", "Porton Sur", "Edificio 6", "Edificio 7", "Hangar UDB", "Cafeterias CIT", "Baños CIT", "Parqueo Techado 1", "Aula Magna C", "Edificio 8", "Casa de Padres", "Biblioteca", "Pinacoteca", "Porton NorEste", "Capilla", "Edificio R", "Edificio A", "Edificio B", "Magna A", "Magna B", "Baños", "Edificio C", "Edificio CDIU", "Cafeterias", "Edificio de Profesores", "CDIM" });
            comboBox2.Location = new Point(13, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(215, 23);
            comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Edificio 2", "Edificio 3", "Edificio 4", "Edificio 5", "Observatorio Micro Macro", "Edificio OWCC", "Porton NorOeste", "Porton Sur", "Edificio 6", "Edificio 7", "Hangar UDB", "Cafeterias CIT", "Baños CIT", "Parqueo Techado 1", "Aula Magna C", "Edificio 8", "Casa de Padres", "Biblioteca", "Pinacoteca", "Porton NorEste", "Capilla", "Edificio R", "Edificio A", "Edificio B", "Magna A", "Magna B", "Baños", "Edificio C", "Edificio CDIU", "Cafeterias", "Edificio de Profesores", "CDIM" });
            comboBox1.Location = new Point(13, 44);
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
            // 
            // button4
            // 
            button4.Location = new Point(12, 274);
            button4.Name = "button4";
            button4.Size = new Size(216, 35);
            button4.TabIndex = 16;
            button4.Text = "Ejecutar DFS";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button button4;
    }
}
