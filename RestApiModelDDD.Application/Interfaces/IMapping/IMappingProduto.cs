using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interfaces.IMapping
{
    public interface IMappingProduto
    {
        Produto MappingDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MappingListProdutoDto(IEnumerable<Produto> produtos);
        ProdutoDto MappingEntityToDto(Produto produto);
    }
}
