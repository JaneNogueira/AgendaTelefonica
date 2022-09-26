using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e, DataGridView dataGridView) => dataGridView.Rows.Add(bxNome.Text, bxEndereco.Text, bxEmail.Text, bxTelefone.Text);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;

            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtbxTelefone_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void bxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            dataContatos.Rows.Add(bxNome.Text, bxEndereco.Text, bxTelefone.Text, bxEmail.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataContatos.CurrentRow != null)
            {
                dataContatos.CurrentRow.Cells["nome"].Value = bxNome.Text;
                dataContatos.CurrentRow.Cells["endereco"].Value = bxEndereco.Text;
                dataContatos.CurrentRow.Cells["telefone"].Value = bxTelefone.Text;
                dataContatos.CurrentRow.Cells["email"].Value = bxEmail.Text;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataContatos.CurrentRow != null)
            {
                dataContatos.Rows.RemoveAt(dataContatos.CurrentRow.Index);
            }
        }

        private void dataContatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataContatos.CurrentRow != null)
            {
                bxNome.Text = dataContatos.CurrentRow.Cells["nome"].Value.ToString();
                bxEndereco.Text = dataContatos.CurrentRow.Cells["endereco"].Value.ToString();
                bxTelefone.Text = dataContatos.CurrentRow.Cells["telefone"].Value.ToString();
                bxEmail.Text = dataContatos.CurrentRow.Cells["email"].Value.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (dataContatos.CurrentRow != null)
            {
                bxNome.Clear();
                bxEndereco.Clear();
                bxTelefone.Clear();
                bxEmail.Clear();
            }
        }
    }
}