using AutoGlass.Models.Entitys;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoGlass.Services.Interfaces
{
    public interface IProtudoServices
    {
        Task<IEnumerable<ProdutoEntitys>> Get();

        Task<ProdutoEntitys> GetId(int id);

        Task<bool> Insert(ProdutoEntitys protudo);

        Task<bool> Update(ProdutoEntitys protudo);

        Task<bool> Remove(int cod_produto);

    }
}
