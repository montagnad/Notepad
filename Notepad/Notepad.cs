using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Notepad;

namespace Notepad
{
    public partial class BlocoDeNotas : Form
    {
        public BlocoDeNotas()
        {
            InitializeComponent();
           
            labelLine.Text = "1";
            labelColumn.Text = "1";

            MemoryStream entradaDoUsuario = new MemoryStream();
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
            Application.Exit(); // fecha a aplicação
        }

        private void ajudaSobre_Click(object sender, EventArgs e)
        {
            Sobre s1 = new Sobre(); // exibe a tela do Sobre
            s1.ShowDialog();
        }

        private void editarCopiar_Click(object sender, EventArgs e)
        {
            caixaDeTexto.Copy(); // copia o texto selecionado
        }

        private void editarColar_Click(object sender, EventArgs e)
        {
            caixaDeTexto.Paste(); // cola o texto que está na área de transferência
        }

        private void editarSelecionarTudo_Click(object sender, EventArgs e)
        {
            caixaDeTexto.SelectAll(); // seleciona todo o texto dentro da richtextbox
        }

        private void editarRecortar_Click(object sender, EventArgs e)
        {
            caixaDeTexto.Cut(); // recorta o texto selecionado
        }

        private void contextoRecortar_Click(object sender, EventArgs e)
        {
            caixaDeTexto.Cut(); // recorta o texto selecionado
        }

        private void contextoCopiar_Click(object sender, EventArgs e)
        {
            caixaDeTexto.Copy(); // copia o texto selecionado
        }

        private void contextoColar_Click(object sender, EventArgs e)
        {
            caixaDeTexto.Paste(); // cola o texto que está na área de transferência
        }

        private void contextoSelecionarTudo_Click(object sender, EventArgs e)
        {
            caixaDeTexto.SelectAll(); // seleciona todo o texto dentro da richtextbox
        }

        private void formatarFonte_Click(object sender, EventArgs e)
        {
            seletorDeFonte.ShowColor = true;

            seletorDeFonte.Font = caixaDeTexto.SelectionFont; // aplica ao seletor a fonte atual para inicializar
            seletorDeFonte.Color = caixaDeTexto.SelectionColor; // aplica ao seletor a cor atual para inicializar

            if (seletorDeFonte.ShowDialog() == DialogResult.OK) // caso seja clicado em OK
            {
                caixaDeTexto.SelectionFont = seletorDeFonte.Font; // aplica ao texto selecionado a fonte
                caixaDeTexto.SelectionColor = seletorDeFonte.Color; // aplica ao texto selecionado a cor
            }
        }

        private void seletorDeFonte_Apply(object sender, EventArgs e)
        {
            caixaDeTexto.SelectionFont = seletorDeFonte.Font; // aplica ao texto selecionado a fonte
            caixaDeTexto.SelectionColor = seletorDeFonte.Color; // aplica ao texto selecionado a cor
        }

        private void arquivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog(); // exibe a tela para selecionar um arquivo para abrir
            abrirArquivo.Filter = "Arquivos de texto (*.txt)|*.txt"; // filtra a tela de seleção, permitindo apenas arquivos .txt

            if (abrirArquivo.ShowDialog() == DialogResult.OK) { // se clicar em ok
                StreamReader dadosDoArquivo = new StreamReader(abrirArquivo.FileName, Encoding.UTF8); // passa o arquivo TXT pelo encoder UTF-8
                caixaDeTexto.Text = dadosDoArquivo.ReadToEnd(); // carrega o TXT na richtextbox
            }
        }

        private void arquivoSalvar_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.CreatePrompt = true;
            //saveFileDialog1.OverwritePrompt = true;

            //saveFileDialog1.FileName = "Documento de texto";
            //saveFileDialog1.DefaultExt = "txt";

            //saveFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            //saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //DialogResult resultado = saveFileDialog1.ShowDialog();
            //Stream filestream;

            //if (resultado == DialogResult.OK)
            //{
            //    filestream = saveFileDialog1.OpenFile();
            //}
        }
    }
}
