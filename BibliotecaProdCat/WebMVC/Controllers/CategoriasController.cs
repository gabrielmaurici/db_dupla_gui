using ProdCad.Model;
using ProdCad.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class CategoriasController : BaseController<Categorias, CategoriaRepository>
    {
        public CategoriasController()
        {

        }
    }
}