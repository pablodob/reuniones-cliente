namespace Cliente
{
    partial class DataUsuario
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
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(345, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 65);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(65, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(211, 136);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 101);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 7;
            label3.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 101);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // DataUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 171);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "DataUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carga de usuario nuevo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}