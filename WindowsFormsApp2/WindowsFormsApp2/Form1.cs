using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void SAIDA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TextoAleatorio.Text ="Bem Vindo ao Menu Principal";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "Calc.Exe";
            process1.Start();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "Excel.Exe";
            process1.Start();
        }

        private void Word_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "WinWord.Exe";
            process1.Start();
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
