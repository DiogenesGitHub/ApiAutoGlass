using System;

namespace AutoGlass.Models.Entitys
{
    public class ProdutoEntitys : Base
    {
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public bool SituacaoProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int CodigoFornecedor { get; set; }
        public string DescricaoFornecedor { get; set; }
        public string Cnpj { get; set; }
    }
}
