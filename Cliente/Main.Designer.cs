namespace Cliente
{
    partial class Main
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
            menu = new Panel();
            menuStrip1 = new MenuStrip();
            botonReuniones = new ToolStripMenuItem();
            botonUsuarios = new ToolStripMenuItem();
            menu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Controls.Add(menuStrip1);
            menu.Dock = DockStyle.Top;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 25);
            menu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { botonReuniones, botonUsuarios });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // botonReuniones
            // 
            botonReuniones.Name = "botonReuniones";
            botonReuniones.Size = new Size(74, 20);
            botonReuniones.Text = "Reuniones";
            botonReuniones.Click += botonReuniones_Click;
            // 
            // botonUsuarios
            // 
            botonUsuarios.Name = "botonUsuarios";
            botonUsuarios.Size = new Size(64, 20);
            botonUsuarios.Text = "Usuarios";
            botonUsuarios.Click += botonUsuarios_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menu);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Main";
            Text = "Main";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem botonReuniones;
        private ToolStripMenuItem botonUsuarios;
    }
}