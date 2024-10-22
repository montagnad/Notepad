using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class BlocoDeNotas : Form
    {
        public BlocoDeNotas()
        {
            InitializeComponent();
            labelLine.Text = "0";
            labelColumn.Text = "0";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeStatus.Visible = !barraDeStatus.Visible; // alterna se a barra de status no rodapé é visível ou não
        }

        private void formatarQuebraDeLinha_Click(object sender, EventArgs e)
        {
            caixaDeTexto.WordWrap = !caixaDeTexto.WordWrap; // alterna se o texto deve seguir o word wrap ou não
        }

        private void caixaDeTexto_TextChanged(object sender, EventArgs e)
        {
            labelLine.Text = caixaDeTexto.SelectionStart.ToString();
        }

        private void caixaDeTexto_CursorPositionChanged(object sender, EventArgs e)
        {
            
        }

        private void caixaDeTexto_CursorChanged(object sender, EventArgs e)
        {
            //labelLine.Text = caixaDeTexto.SelectionStart.ToString();
        }

        private void caixaDeTexto_LocationChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Trocou de posição");
        }

        private void caixaDeTexto_MouseDown(object sender, MouseEventArgs e)
        {
            labelLine.Text = caixaDeTexto.SelectionStart.ToString();
        }

        private void caixaDeTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void caixaDeTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) {
                labelLine.Text = caixaDeTexto.SelectionStart.ToString();
                labelLine.Text = caixaDeTexto.SelectionStart.ToString();
            }
            if (e.KeyData == Keys.Right)
            {

                labelLine.Text = caixaDeTexto.SelectionStart.ToString();
                labelLine.Text = caixaDeTexto.SelectionStart.ToString();
            }
            if (e.KeyData == Keys.Down)
            {
                labelLine.Text = caixaDeTexto.SelectionStart.ToString();
                labelLine.Text = caixaDeTexto.SelectionStart.ToString();
            }
            if (e.KeyData == Keys.Left)
            {
                labelLine.Text = caixaDeTexto.SelectionStart.ToString();
                labelLine.Text = caixaDeTexto.SelectionStart.ToString();
            }
        }

        private void arquivoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajudaSobre_Click(object sender, EventArgs e)
        {
            Sobre s1 = new Sobre();
            s1.ShowDialog();
        }
    }
}
