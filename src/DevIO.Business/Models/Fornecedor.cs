
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIO.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }

        public string Documento { get; set; }

        public TipoFornecedorEnum TipoFornecedor { get; set; }

        public Endereco Endereco { get; set; }

        public bool Ativo { get; set; }

        /*EF Relations*/
        public IEnumerable<Produto> Produtos { get; set; }

    }
}
