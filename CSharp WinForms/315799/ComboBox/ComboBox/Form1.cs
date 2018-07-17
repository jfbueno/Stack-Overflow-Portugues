using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxFornecedor.DataSource = Fornecedor.GetAll();
            cbxFornecedor.DisplayMember = "Nome";
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            var fornecedor = (Fornecedor) cbxFornecedor.SelectedItem;
            txtId.Text = fornecedor.Id.ToString();
            txtNome.Text = fornecedor.Nome;
            txtObservacao.Text = fornecedor.Observacao;
        }
    }
}
