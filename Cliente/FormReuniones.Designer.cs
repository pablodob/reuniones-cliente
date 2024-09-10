namespace Cliente
{
    partial class FormReuniones
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
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            listarbutton = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(listarbutton);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 466);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(33, 400);
            button7.Name = "button7";
            button7.Size = new Size(105, 43);
            button7.TabIndex = 8;
            button7.Text = "Invitaciones rechazadas";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(33, 342);
            button6.Name = "button6";
            button6.Size = new Size(105, 43);
            button6.TabIndex = 7;
            button6.Text = "Invitaciones aceptadas";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(33, 280);
            button5.Name = "button5";
            button5.Size = new Size(105, 43);
            button5.TabIndex = 6;
            button5.Text = "Invitaciones pendientes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // listarbutton
            // 
            listarbutton.Location = new Point(33, 219);
            listarbutton.Name = "listarbutton";
            listarbutton.Size = new Size(105, 43);
            listarbutton.TabIndex = 5;
            listarbutton.Text = "Todas las reuniones";
            listarbutton.UseVisualStyleBackColor = true;
            listarbutton.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(33, 153);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 4;
            button4.Text = "Eliminar reunión";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(33, 114);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 3;
            button3.Text = "Editar reunión";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 75);
            button2.Name = "button2";
            button2.Size = new Size(105, 23);
            button2.TabIndex = 2;
            button2.Text = "Ver reunión";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 37);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 1;
            button1.Text = "Crear reunion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(168, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 466);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(491, 466);
            dataGridView1.TabIndex = 0;
            // 
            // FormReuniones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 466);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormReuniones";
            Text = "Reuniones";
            WindowState = FormWindowState.Maximized;
            Load += FormReuniones_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button listarbutton;
        private Button button7;
        private Button button6;
        private Button button5;
    }
}