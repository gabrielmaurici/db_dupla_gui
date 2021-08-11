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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            CadastroPro produtos = new CadastroPro();
            produtos.Show();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            CadastroCat categorias = new CadastroCat();
            categorias.Show();
        }
    }
}
