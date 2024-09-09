namespace Cliente
{
    partial class DataReunion
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
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            colorDialog1 = new ColorDialog();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button5 = new Button();
            label8 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(65, 753);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(180, 753);
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
            // textBox1
            // 
            textBox1.Location = new Point(118, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 59);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dddd, dd 'de' MMMM 'de' yyyy '-' HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(19, 91);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(302, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2024, 7, 29, 18, 14, 56, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 62);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha a realizarse:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 23);
            comboBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(273, 232);
            dataGridView1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(20, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 301);
            panel2.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(198, 13);
            button5.Name = "button5";
            button5.Size = new Size(88, 23);
            button5.TabIndex = 0;
            button5.Text = "Invitar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 125);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 13;
            label8.Text = "Temas a tratar:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(43, 145);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 36);
            textBox3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 712);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 15;
            label2.Text = "Coordinador:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(111, 709);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(195, 23);
            comboBox3.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(dataGridView2);
            panel1.Location = new Point(20, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 178);
            panel1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 104);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(273, 60);
            dataGridView2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(71, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(71, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 23);
            textBox4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 20);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 3;
            label5.Text = "Texto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 50);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 4;
            label6.Text = "Link";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 79);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Obligatorio";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(107, 76);
            button3.Name = "button3";
            button3.Size = new Size(171, 22);
            button3.TabIndex = 6;
            button3.Text = "Agregar texto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DataReunion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 793);
            Controls.Add(panel1);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Name = "DataReunion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cargar una reunion nueva";
            Load += DataReunion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ColorDialog colorDialog1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button button5;
        private Label label8;
        private TextBox textBox3;
        private Label label2;
        private ComboBox comboBox3;
        private Panel panel1;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private Button button3;
        private CheckBox checkBox1;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
    }
}