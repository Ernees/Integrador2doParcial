namespace Integrador_Repaso
{
    partial class FrmPrincipal
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
            empladosToolStripMenuItem = new ToolStripMenuItem();
            desarrolladoresToolStripMenuItem = new ToolStripMenuItem();
            cargarToolStripMenuItem = new ToolStripMenuItem();
            gerentesToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            mostrarTodosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { empladosToolStripMenuItem, mostrarTodosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // empladosToolStripMenuItem
            // 
            empladosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desarrolladoresToolStripMenuItem, gerentesToolStripMenuItem });
            empladosToolStripMenuItem.Name = "empladosToolStripMenuItem";
            empladosToolStripMenuItem.Size = new Size(71, 20);
            empladosToolStripMenuItem.Text = "Emplados";
            // 
            // desarrolladoresToolStripMenuItem
            // 
            desarrolladoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargarToolStripMenuItem });
            desarrolladoresToolStripMenuItem.Name = "desarrolladoresToolStripMenuItem";
            desarrolladoresToolStripMenuItem.Size = new Size(155, 22);
            desarrolladoresToolStripMenuItem.Text = "Desarrolladores";
            // 
            // cargarToolStripMenuItem
            // 
            cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            cargarToolStripMenuItem.Size = new Size(180, 22);
            cargarToolStripMenuItem.Text = "Cargar";
            cargarToolStripMenuItem.Click += cargarToolStripMenuItem_Click;
            // 
            // gerentesToolStripMenuItem
            // 
            gerentesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem });
            gerentesToolStripMenuItem.Name = "gerentesToolStripMenuItem";
            gerentesToolStripMenuItem.Size = new Size(155, 22);
            gerentesToolStripMenuItem.Text = "Gerentes";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(180, 22);
            crearToolStripMenuItem.Text = "Crear";
            // 
            // mostrarTodosToolStripMenuItem
            // 
            mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            mostrarTodosToolStripMenuItem.Size = new Size(94, 20);
            mostrarTodosToolStripMenuItem.Text = "Mostrar Todos";
            mostrarTodosToolStripMenuItem.Click += mostrarTodosToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem empladosToolStripMenuItem;
        private ToolStripMenuItem desarrolladoresToolStripMenuItem;
        private ToolStripMenuItem cargarToolStripMenuItem;
        private ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private ToolStripMenuItem gerentesToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private MenuStrip menuStrip2;
    }
}