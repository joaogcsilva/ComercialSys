using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(

                txtCodBarras.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUniVendas.Text,
                int.Parse(txtCategoria.Text),
                int.Parse(txtEstoqueMin.Text),
                double.Parse(txtClasseDesc.Text));

            produto.Inserir();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtDescricao.Clear();
                txtCodBarras.Clear();
                txtCategoria.Clear();
                txtEstoqueMin.Clear();
                txtUniVendas.Clear();
                txtValorUnit.Clear();
                txtDescricao.Clear();
                txtClasseDesc.Clear();
                txtID.ReadOnly = false;
                txtID.Focus();
                btnConsultar.Text = "Obter por ID";
                txtID.Enabled = true;

            }
            else
            {
                if (txtID.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txtID.Text));
                    txtDescricao.Text = produto.Descricao;
                    txtCodBarras.Text = produto.CodBarras;
                    txtCategoria.Text = Convert.ToString(produto.CategoriaId);
                    txtEstoqueMin.Text = Convert.ToString(produto.EstoqueMin);
                    txtUniVendas.Text = produto.UnidadeVenda;
                    txtValorUnit.Text = Convert.ToString(produto.ValorUnit);
                    txtClasseDesc.Text = Convert.ToString(produto.ClasseDesc);
                    btnConsultar.Text = "&Consultar";
                    btnEditar.Enabled = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                                            int.Parse(txtID.Text),
                                            txtCodBarras.Text,
                                            txtDescricao.Text,
                                            double.Parse(txtValorUnit.Text),
                                            txtUniVendas.Text,
                                            int.Parse(txtCategoria.Text),
                                            int.Parse(txtEstoqueMin.Text),
                                            double.Parse(txtClasseDesc.Text));

            if (produto.Editar(produto.Id)) 
            {
                FrmProduto_Load(sender, e);
                MessageBox.Show($"o Produto {produto.Descricao} foi alterado com sucesso");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar Produto \"{produto.Id}\" !");
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[2].Value = produto.CodBarras;
                dgvProdutos.Rows[count].Cells[3].Value = produto.CategoriaId;
                dgvProdutos.Rows[count].Cells[4].Value = produto.EstoqueMin;
                dgvProdutos.Rows[count].Cells[5].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[count].Cells[6].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesc;



                count++;




            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                var lista = Produto.ObterLista(txtBusca.Text);
                dgvProdutos.Rows.Clear();
                int count = 0;
                foreach (var produto in lista) 
                {
                    dgvProdutos.Rows.Add();
                    dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                    dgvProdutos.Rows[count].Cells[1].Value = produto.Descricao;
                    dgvProdutos.Rows[count].Cells[2].Value = produto.CodBarras;
                    dgvProdutos.Rows[count].Cells[3].Value = produto.CategoriaId;
                    dgvProdutos.Rows[count].Cells[4].Value = produto.EstoqueMin;
                    dgvProdutos.Rows[count].Cells[5].Value = produto.UnidadeVenda;
                    dgvProdutos.Rows[count].Cells[6].Value = produto.ValorUnit;
                    dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesc;


                    count++;
                }
            }
        }
    }
}
