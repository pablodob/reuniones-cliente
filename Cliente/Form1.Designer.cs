namespace Cliente
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(412, 314);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(21, 36);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 1;
            button1.Text = "Listar usuarios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 74);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 2;
            button2.Text = "Agregar usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(21, 113);
            button3.Name = "button3";
            button3.Size = new Size(125, 23);
            button3.TabIndex = 3;
            button3.Text = "Modificar usuario";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(21, 152);
            button4.Name = "button4";
            button4.Size = new Size(125, 23);
            button4.TabIndex = 4;
            button4.Text = "Eliminar usuario";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 314);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(167, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 314);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 314);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Usuarios";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
    }
}
