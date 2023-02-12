using AutoGlass.Models.Entitys;
using AutoGlass.Repository.interfaces;
using AutoGlass.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoGlass.Services
{
    public class ProtudoServices : IProtudoServices
    {
        private readonly IProdutoRepository _produtoRepository;


        public async Task<IEnumerable<ProdutoEntitys>> Get()
        {
            try
            {


                var listProdutos = await _produtoRepository.Get();

                return listProdutos;
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
                var produto = await _produtoRepository.GetId(id);

                return produto;
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
                var result = await _produtoRepository.Insert(protudo);

                return result;
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
                var result = await _produtoRepository.Update(protudo);

                return result;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<bool> Remove(int cod_produto)
        {
            try
            {
                var result = await _produtoRepository.Remove(cod_produto);

                return result;

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
