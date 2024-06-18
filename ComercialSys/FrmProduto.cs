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
                double.Parse(txtClasseDesc.Text),
                txtImagem.Text);

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
                txtImagem.Clear();
                txtID.ReadOnly = false;
                txtID.Focus();
                btnConsultar.Text = "Obter por ID";

            }
            else
            {
                if (txtID.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txtID.Text));
                    txtDescricao.Text = produto.Descricao;
                    txtCodBarras.Text = produto.CodBarras;
                    txtCategoria.Text = Convert.ToString(produto.ValorUnit);
                    txtEstoqueMin.Text = Convert.ToString(produto.EstoqueMin);
                    txtUniVendas.Text = produto.UnidadeVenda;
                    txtValorUnit.Text = Convert.ToString(produto.ValorUnit);
                    txtClasseDesc.Text = Convert.ToString(produto.ClasseDesc);
                    txtImagem.Text = produto.Imagem;
                    btnConsultar.Text = "&Consultar";
                    btnInserir.Enabled = true;
                }
            }
        }
    }
}
