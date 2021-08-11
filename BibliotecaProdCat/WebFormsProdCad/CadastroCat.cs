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
    public partial class CadastroCat : Form
    {
        CategoriaRepository repository = new CategoriaRepository();
        public CadastroCat()
        {
            InitializeComponent();
            dgCat.AutoGenerateColumns = false;
            dgCat.AllowUserToAddRows = false;
            Listar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           Categorias categoria = new Categorias();
            categoria.Nome = this.txtNome.Text;
            categoria.Descricao = this.txtValor.Text;

            repository.Create(categoria);
            Listar();
        }

        private void Listar()
        {
            List<Categorias> lista = repository.Read();
            dgCat.Rows.Clear();
            foreach (var item in lista)
            {
                dgCat.Rows.Add(item.Nome, item.Descricao,"Deletar");
            }
            dgCat.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Categorias> lista = repository.Read();
          if (e.ColumnIndex == 2)
            {
                repository.Delete(lista[e.RowIndex].Id);
            }
            Listar();
        }
    }
}
