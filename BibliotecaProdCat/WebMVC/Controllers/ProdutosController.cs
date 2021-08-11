using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProdCad.Model;
using ProdCad.Repository;

namespace WebMVC.Controllers
{
    public class ProdutosController : BaseController<Produtos, ProdutoRepository>
    {
        public ProdutosController()
        {

        }
    }
}