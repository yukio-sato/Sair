namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Word = new System.Windows.Forms.ToolStripButton();
            this.Excel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SAIDA = new System.Windows.Forms.ToolStripButton();
            this.Calculadora = new System.Windows.Forms.ToolStripButton();
            this.aplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextoAleatorio = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Word,
            this.Excel,
            this.Calculadora,
            this.toolStripSeparator1,
            this.SAIDA});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicativoToolStripMenuItem,
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextoAleatorio,
            this.toolStripStatusLabel2,
            this.Data,
            this.toolStripStatusLabel4,
            this.Hora,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 23);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Word
            // 
            this.Word.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Word.Image = global::WindowsFormsApp2.Properties.Resources.word;
            this.Word.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(23, 35);
            this.Word.Text = "Word";
            this.Word.Click += new System.EventHandler(this.Word_Click);
            // 
            // Excel
            // 
            this.Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Excel.Image = global::WindowsFormsApp2.Properties.Resources.excel;
            this.Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(23, 35);
            this.Excel.Text = "Excel";
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(18, 25);
            // 
            // SAIDA
            // 
            this.SAIDA.AutoSize = false;
            this.SAIDA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SAIDA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SAIDA.Image = global::WindowsFormsApp2.Properties.Resources.exit;
            this.SAIDA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SAIDA.Name = "SAIDA";
            this.SAIDA.Size = new System.Drawing.Size(30, 23);
            this.SAIDA.Text = "Exit";
            this.SAIDA.Click += new System.EventHandler(this.SAIDA_Click);
            // 
            // Calculadora
            // 
            this.Calculadora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Calculadora.Image = global::WindowsFormsApp2.Properties.Resources.calculadora;
            this.Calculadora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(23, 35);
            this.Calculadora.Text = "Calculadora";
            this.Calculadora.Click += new System.EventHandler(this.Calculadora_Click);
            // 
            // aplicativoToolStripMenuItem
            // 
            this.aplicativoToolStripMenuItem.Name = "aplicativoToolStripMenuItem";
            this.aplicativoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.aplicativoToolStripMenuItem.Text = "Aplicativo";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            this.programasToolStripMenuItem.Click += new System.EventHandler(this.programasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // TextoAleatorio
            // 
            this.TextoAleatorio.AutoSize = false;
            this.TextoAleatorio.Name = "TextoAleatorio";
            this.TextoAleatorio.Size = new System.Drawing.Size(569, 18);
            this.TextoAleatorio.Text = "Bem Vindo ao Menu Principal";
            this.TextoAleatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 18);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // Data
            // 
            this.Data.AutoSize = false;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(99, 18);
            this.Data.Text = "15/04/2023";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(11, 18);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // Hora
            // 
            this.Hora.AutoSize = false;
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(86, 18);
            this.Hora.Text = "24:10";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(11, 18);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Word;
        private System.Windows.Forms.ToolStripButton Excel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SAIDA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton Calculadora;
        private System.Windows.Forms.ToolStripMenuItem aplicativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TextoAleatorio;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel Hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.Process process1;
    }
}

