﻿namespace Cliente
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
            components = new System.ComponentModel.Container();
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
            dataGridView2 = new DataGridView();
            label13 = new Label();
            button7 = new Button();
            label14 = new Label();
            label15 = new Label();
            panel4 = new Panel();
            dataGridView3 = new DataGridView();
            reunionUsuarioBindingSource = new BindingSource(components);
            label16 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reunionUsuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(61, 714);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(421, 714);
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
            label4.Location = new Point(285, 51);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha a realizarse:";
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(163, 27);
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
            button4.Location = new Point(278, 27);
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
            panel1.Location = new Point(26, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 59);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 8);
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
            dataGridView1.Location = new Point(6, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(538, 79);
            dataGridView1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(11, 419);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 108);
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
            label7.Location = new Point(16, 174);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 11;
            label7.Text = "Minuta de reunión:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 200);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Escriba aquí la minuta de la reunion realizada";
            textBox2.Size = new Size(538, 93);
            textBox2.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 151);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 13;
            label8.Text = "Temas a tratar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(115, 152);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 14;
            label9.Text = "Temas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(392, 51);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 15;
            label10.Text = "Fecha";
            // 
            // button6
            // 
            button6.Location = new Point(24, 637);
            button6.Name = "button6";
            button6.Size = new Size(122, 36);
            button6.TabIndex = 16;
            button6.Text = "Aceptar invitación";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(421, 637);
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
            label12.Location = new Point(243, 648);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 18;
            label12.Text = "Estado invitacion";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(11, 291);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 128);
            panel3.TabIndex = 19;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(538, 92);
            dataGridView2.TabIndex = 1;
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
            // button7
            // 
            button7.Location = new Point(224, 689);
            button7.Name = "button7";
            button7.Size = new Size(126, 28);
            button7.TabIndex = 20;
            button7.Text = "Descargar PDF";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(285, 152);
            label14.Name = "label14";
            label14.Size = new Size(77, 15);
            label14.TabIndex = 21;
            label14.Text = "Coordinador:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(368, 152);
            label15.Name = "label15";
            label15.Size = new Size(74, 15);
            label15.TabIndex = 22;
            label15.Text = "Coordinador";
            // 
            // panel4
            // 
            panel4.Controls.Add(label16);
            panel4.Controls.Add(dataGridView3);
            panel4.Location = new Point(11, 529);
            panel4.Name = "panel4";
            panel4.Size = new Size(551, 102);
            panel4.TabIndex = 23;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 25);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(538, 77);
            dataGridView3.TabIndex = 24;
            // 
            // reunionUsuarioBindingSource
            // 
            reunionUsuarioBindingSource.DataSource = typeof(Entidades.ReunionUsuario);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 7);
            label16.Name = "label16";
            label16.Size = new Size(123, 15);
            label16.TabIndex = 26;
            label16.Text = "Personas confirmadas";
            // 
            // DataReunionVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(589, 630);
            Controls.Add(panel4);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(button7);
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)reunionUsuarioBindingSource).EndInit();
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
        private Button button7;
        private Label label14;
        private Label label15;
        private Panel panel4;
        private Label label16;
        private DataGridView dataGridView3;
        private BindingSource reunionUsuarioBindingSource;
    }
}