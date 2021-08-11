using ProdCad.Model;
using ProdCad.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormsProdCad
{
    public partial class CadastroPro : Form
    {
        ProdutoRepository repository = new ProdutoRepository();
        public CadastroPro()
        {
            InitializeComponent();
            dgProd.AutoGenerateColumns = false;
            dgProd.AllowUserToAddRows = false;
            Listar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            produto.Nome = this.txtNome.Text;
            produto.Valor = Convert.ToDecimal(this.txtValor.Text);

            repository.Create(produto);
            Listar();
        }


        private void Listar()
        {
            List<Produtos> lista = repository.Read();
            dgProd.Rows.Clear();
            foreach (var item in lista)
            {
                dgProd.Rows.Add(item.Nome, item.Valor, "Deletar");
            }
            dgProd.Refresh();
        }


        private void dgCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Produtos> lista = repository.Read();
           if (e.ColumnIndex == 2)
            {
                repository.Delete(lista[e.RowIndex].Id);
            }
            Listar();
        }
    }
    }
