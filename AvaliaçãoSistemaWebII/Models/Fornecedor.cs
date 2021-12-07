using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliaçãoSistemaWebII.Models
{
    public class Fornecedor
    {
        public long FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string cidade { get; set; }
        public long ProdutoId { get; set; }
        public Produto produto { get; set; }
    }
}