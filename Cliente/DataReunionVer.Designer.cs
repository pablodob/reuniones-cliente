namespace Cliente
{
    partial class DataReunionVer
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            colorDialog1 = new ColorDialog();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label11 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button6 = new Button();
            button5 = new Button();
            label12 = new Label();
            panel3 = new Panel();
            label13 = new Label();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(61, 738);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(421, 738);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 51);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 51);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 5;
            label3.Text = "id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 85);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha a realizarse:";
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(142, 50);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Realizada";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(362, 50);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Cancelada";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(33, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 84);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 32);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 8);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 10;
            label5.Text = "Estado actual de la reunión:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(519, 79);
            dataGridView1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(11, 535);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 123);
            panel2.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 10);
            label11.Name = "label11";
            label11.Size = new Size(104, 15);
            label11.TabIndex = 13;
            label11.Text = "Personas invitadas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 236);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 11;
            label7.Text = "Minuta de reunión:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 260);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Escriba aquí la minuta de la reunion realizada";
            textBox2.Size = new Size(546, 135);
            textBox2.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 208);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 13;
            label8.Text = "Temas a tratar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(115, 209);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 14;
            label9.Text = "Temas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(131, 85);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 15;
            label10.Text = "Fecha";
            // 
            // button6
            // 
            button6.Location = new Point(24, 664);
            button6.Name = "button6";
            button6.Size = new Size(122, 36);
            button6.TabIndex = 16;
            button6.Text = "Aceptar invitación";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(421, 664);
            button5.Name = "button5";
            button5.Size = new Size(122, 36);
            button5.TabIndex = 17;
            button5.Text = "Rechazar invitación";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(248, 711);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 18;
            label12.Text = "Estado invitacion";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(11, 401);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 128);
            panel3.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 5);
            label13.Name = "label13";
            label13.Size = new Size(40, 15);
            label13.TabIndex = 0;
            label13.Text = "Textos";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(526, 92);
            dataGridView2.TabIndex = 1;
            // 
            // DataReunionVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 778);
            Controls.Add(panel3);
            Controls.Add(label12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Name = "DataReunionVer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Información de la reunión";
            Load += DataReunionVer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private ColorDialog colorDialog1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button6;
        private Button button5;
        private Label label11;
        private Label label12;
        private Panel panel3;
        private DataGridView dataGridView2;
        private Label label13;
    }
}