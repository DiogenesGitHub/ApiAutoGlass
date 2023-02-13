using AutoGlass.Models.Entitys;
using AutoGlass.Repository.interfaces;
using AutoGlass.Repository.Scripts;
using AutoGlass.Util;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlass.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public async Task<IEnumerable<ProdutoEntitys>> Get()
        {
            try
            {
                using (var conn = new SqlConnection(EnvironmentVariable.GetConnectionDataBase()))
                {
                    var listProduto = await conn.QueryAsync<ProdutoEntitys>(ProdutoScripts.Select);

                    return listProduto;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<ProdutoEntitys> GetId(int id)
        {
            try
            {
                using (var conn = new SqlConnection(EnvironmentVariable.GetConnectionDataBase()))
                {
                    var parametros = new DynamicParameters();
                    parametros.Add("@COD_PRODUTO", id);

                    var produto = await conn.QueryFirstOrDefaultAsync<ProdutoEntitys>(ProdutoScripts.SelectById, parametros);

                    return produto;
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<bool> Insert(ProdutoEntitys protudo)
        {
            try
            {
                using (var conn = new SqlConnection(EnvironmentVariable.GetConnectionDataBase()))
                {
                    var parametros = new DynamicParameters();

                    parametros.Add("@cod_produto", protudo.CodigoProduto);
                    parametros.Add("@desc_produto", protudo.DescricaoProduto);
                    parametros.Add("@situacao_produto", protudo.SituacaoProduto);
                    parametros.Add("@dh_fabricacao", protudo.DataFabricacao);
                    parametros.Add("@dh_validade", protudo.DataValidade);
                    parametros.Add("@cod_fornecedor", protudo.CodigoFornecedor);
                    parametros.Add("@desc_fornecedor", protudo.DescricaoFornecedor);
                    parametros.Add("@cnpj", protudo.Cnpj);

                    var result = await conn.ExecuteAsync(ProdutoScripts.Insert, parametros);
                    
                    return result != null;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<bool> Update(ProdutoEntitys protudo)
        {
            try
            {
                using (var conn = new SqlConnection(EnvironmentVariable.GetConnectionDataBase()))
                {
                    var parametros = new DynamicParameters();

                    parametros.Add("@cod_produto", protudo.CodigoProduto);
                    parametros.Add("@desc_produto", protudo.DescricaoProduto);
                    parametros.Add("@situacao_produto", protudo.SituacaoProduto);
                    parametros.Add("@dh_fabricacao", protudo.DataFabricacao);
                    parametros.Add("@dh_validade", protudo.DataValidade);
                    parametros.Add("@cod_fornecedor", protudo.CodigoFornecedor);
                    parametros.Add("@desc_fornecedor", protudo.DescricaoFornecedor);
                    parametros.Add("@cnpj", protudo.Cnpj);

                    var result =  await conn.ExecuteAsync(ProdutoScripts.UpdateById, parametros);

                    return result != null;

                }
            }
            catch (System.Exception e)
            {

                throw;
            }
        }

        public async Task<bool> Remove(int cod_produto)
        {
            try
            {
                using (var conn = new SqlConnection(EnvironmentVariable.GetConnectionDataBase()))
                {
                    var parametros = new DynamicParameters();
                    parametros.Add("@cod_produto", cod_produto);

                    var result = await conn.ExecuteAsync(ProdutoScripts.DeleteById, parametros);

                    return result != null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
