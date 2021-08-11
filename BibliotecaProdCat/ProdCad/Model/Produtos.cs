using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdCad.Model
{
    public class Produtos : BaseModel
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
