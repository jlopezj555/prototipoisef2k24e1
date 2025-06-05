namespace Capa_Vista_RRHH
{
    partial class MDI_RRHH
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantemientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desarrolloDeCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capacitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capacitacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.instructoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDisciplinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltasDisciplinariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEvidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicarSanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_inferior = new System.Windows.Forms.Panel();
            this.Pnl_Fecha = new System.Windows.Forms.Panel();
            this.Lbl_FechaActual = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Pnl_Usuario = new System.Windows.Forms.Panel();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Pnl_inferior.SuspendLayout();
            this.Pnl_Fecha.SuspendLayout();
            this.Pnl_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.nóminaToolStripMenuItem,
            this.desarrolloDeCarreraToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.capacitacionesToolStripMenuItem,
            this.gestiónDisciplinariaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.inicioToolStripMenuItem.Text = "Abrir";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // nóminaToolStripMenuItem
            // 
            this.nóminaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantemientosToolStripMenuItem});
            this.nóminaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nóminaToolStripMenuItem.Name = "nóminaToolStripMenuItem";
            this.nóminaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.nóminaToolStripMenuItem.Text = "Catálogos";
            this.nóminaToolStripMenuItem.Click += new System.EventHandler(this.nóminaToolStripMenuItem_Click);
            // 
            // mantemientosToolStripMenuItem
            // 
            this.mantemientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacacionesToolStripMenuItem});
            this.mantemientosToolStripMenuItem.Name = "mantemientosToolStripMenuItem";
            this.mantemientosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mantemientosToolStripMenuItem.Text = "Mantemientos";
            // 
            // vacacionesToolStripMenuItem
            // 
            this.vacacionesToolStripMenuItem.Name = "vacacionesToolStripMenuItem";
            this.vacacionesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.vacacionesToolStripMenuItem.Text = "Vacaciones";
            this.vacacionesToolStripMenuItem.Click += new System.EventHandler(this.vacacionesToolStripMenuItem_Click);
            // 
            // desarrolloDeCarreraToolStripMenuItem
            // 
            this.desarrolloDeCarreraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.desarrolloDeCarreraToolStripMenuItem.Name = "desarrolloDeCarreraToolStripMenuItem";
            this.desarrolloDeCarreraToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.desarrolloDeCarreraToolStripMenuItem.Text = "Procesos";
            // 
            // capacitacionesToolStripMenuItem
            // 
            this.capacitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capacitacionesToolStripMenuItem1,
            this.instructoresToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.cierresToolStripMenuItem});
            this.capacitacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.capacitacionesToolStripMenuItem.Name = "capacitacionesToolStripMenuItem";
            this.capacitacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.capacitacionesToolStripMenuItem.Text = "Herramienta";
            // 
            // capacitacionesToolStripMenuItem1
            // 
            this.capacitacionesToolStripMenuItem1.Name = "capacitacionesToolStripMenuItem1";
            this.capacitacionesToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.capacitacionesToolStripMenuItem1.Text = "Capacitaciones";
            this.capacitacionesToolStripMenuItem1.Click += new System.EventHandler(this.capacitacionesToolStripMenuItem1_Click);
            // 
            // instructoresToolStripMenuItem
            // 
            this.instructoresToolStripMenuItem.Name = "instructoresToolStripMenuItem";
            this.instructoresToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.instructoresToolStripMenuItem.Text = "Instructores";
            this.instructoresToolStripMenuItem.Click += new System.EventHandler(this.instructoresToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // cierresToolStripMenuItem
            // 
            this.cierresToolStripMenuItem.Name = "cierresToolStripMenuItem";
            this.cierresToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cierresToolStripMenuItem.Text = "Cierres ";
            this.cierresToolStripMenuItem.Click += new System.EventHandler(this.cierresToolStripMenuItem_Click);
            // 
            // gestiónDisciplinariaToolStripMenuItem
            // 
            this.gestiónDisciplinariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faltasDisciplinariasToolStripMenuItem});
            this.gestiónDisciplinariaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestiónDisciplinariaToolStripMenuItem.Name = "gestiónDisciplinariaToolStripMenuItem";
            this.gestiónDisciplinariaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.gestiónDisciplinariaToolStripMenuItem.Text = "Seguridad";
            // 
            // faltasDisciplinariasToolStripMenuItem
            // 
            this.faltasDisciplinariasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEvidenciasToolStripMenuItem,
            this.aplicarSanciónToolStripMenuItem});
            this.faltasDisciplinariasToolStripMenuItem.Name = "faltasDisciplinariasToolStripMenuItem";
            this.faltasDisciplinariasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.faltasDisciplinariasToolStripMenuItem.Text = "Faltas Disciplinarias";
            this.faltasDisciplinariasToolStripMenuItem.Click += new System.EventHandler(this.faltasDisciplinariasToolStripMenuItem_Click);
            // 
            // registrarEvidenciasToolStripMenuItem
            // 
            this.registrarEvidenciasToolStripMenuItem.Name = "registrarEvidenciasToolStripMenuItem";
            this.registrarEvidenciasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registrarEvidenciasToolStripMenuItem.Text = "Registrar evidencias";
            this.registrarEvidenciasToolStripMenuItem.Click += new System.EventHandler(this.registrarEvidenciasToolStripMenuItem_Click);
            // 
            // aplicarSanciónToolStripMenuItem
            // 
            this.aplicarSanciónToolStripMenuItem.Name = "aplicarSanciónToolStripMenuItem";
            this.aplicarSanciónToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aplicarSanciónToolStripMenuItem.Text = "Aplicar sanción";
            this.aplicarSanciónToolStripMenuItem.Click += new System.EventHandler(this.aplicarSanciónToolStripMenuItem_Click);
            // 
            // Pnl_inferior
            // 
            this.Pnl_inferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_inferior.Controls.Add(this.Pnl_Fecha);
            this.Pnl_inferior.Controls.Add(this.Pnl_Usuario);
            this.Pnl_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_inferior.Location = new System.Drawing.Point(0, 549);
            this.Pnl_inferior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_inferior.Name = "Pnl_inferior";
            this.Pnl_inferior.Size = new System.Drawing.Size(877, 60);
            this.Pnl_inferior.TabIndex = 1;
            // 
            // Pnl_Fecha
            // 
            this.Pnl_Fecha.Controls.Add(this.Lbl_FechaActual);
            this.Pnl_Fecha.Controls.Add(this.Lbl_Fecha);
            this.Pnl_Fecha.Location = new System.Drawing.Point(229, 8);
            this.Pnl_Fecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_Fecha.Name = "Pnl_Fecha";
            this.Pnl_Fecha.Size = new System.Drawing.Size(231, 41);
            this.Pnl_Fecha.TabIndex = 3;
            // 
            // Lbl_FechaActual
            // 
            this.Lbl_FechaActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_FechaActual.AutoSize = true;
            this.Lbl_FechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaActual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_FechaActual.Location = new System.Drawing.Point(62, 10);
            this.Lbl_FechaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_FechaActual.Name = "Lbl_FechaActual";
            this.Lbl_FechaActual.Size = new System.Drawing.Size(19, 20);
            this.Lbl_FechaActual.TabIndex = 2;
            this.Lbl_FechaActual.Text = "--";
            this.Lbl_FechaActual.Click += new System.EventHandler(this.Lbl_FechaActual_Click);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Fecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Fecha.Location = new System.Drawing.Point(2, 10);
            this.Lbl_Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(58, 20);
            this.Lbl_Fecha.TabIndex = 0;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Pnl_Usuario
            // 
            this.Pnl_Usuario.Controls.Add(this.lbl_nombreUsuario);
            this.Pnl_Usuario.Controls.Add(this.Lbl_Usuario);
            this.Pnl_Usuario.Location = new System.Drawing.Point(8, 8);
            this.Pnl_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_Usuario.Name = "Pnl_Usuario";
            this.Pnl_Usuario.Size = new System.Drawing.Size(189, 41);
            this.Pnl_Usuario.TabIndex = 0;
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(70, 10);
            this.lbl_nombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(19, 20);
            this.lbl_nombreUsuario.TabIndex = 2;
            this.lbl_nombreUsuario.Text = "--";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Usuario.Location = new System.Drawing.Point(2, 10);
            this.Lbl_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(68, 20);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "Usuario:";
            this.Lbl_Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // MDI_RRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(877, 609);
            this.Controls.Add(this.Pnl_inferior);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MDI_RRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0901-21-4188 JOEL LÓPEZ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_RRHH_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pnl_inferior.ResumeLayout(false);
            this.Pnl_Fecha.ResumeLayout(false);
            this.Pnl_Fecha.PerformLayout();
            this.Pnl_Usuario.ResumeLayout(false);
            this.Pnl_Usuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantemientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desarrolloDeCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capacitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDisciplinariaToolStripMenuItem;
        private System.Windows.Forms.Panel Pnl_inferior;
        private System.Windows.Forms.Panel Pnl_Usuario;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Panel Pnl_Fecha;
        public System.Windows.Forms.Label Lbl_FechaActual;
        private System.Windows.Forms.Label Lbl_Fecha;
        public System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem capacitacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem instructoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faltasDisciplinariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEvidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicarSanciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
    }
}