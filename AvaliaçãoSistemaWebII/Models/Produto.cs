using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliaçãoSistemaWebII.Models
{
    public class Produto
    {
        public long ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Fornecedor> fornecedor { get; set; }
    }
}