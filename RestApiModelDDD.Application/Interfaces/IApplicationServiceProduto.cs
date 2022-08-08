using RestApiModelDDD.Application.DTOs;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);
        void Update(ProdutoDto produtoDto);
        void Remove(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto GetById(int id);
    }
}
