using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces.IMapping;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModelDDD.Application.Mapping
{
    public class MappingProduto : IMappingProduto
    {
        public Produto MappingDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id
               ,
                Name = produtoDto.Name
               ,
                Value = produtoDto.Value
            };
            return produto;
        }

        public ProdutoDto MappingEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id
               ,
                Name = produto.Name
               ,
                Value = produto.Value
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MappingListProdutoDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(p => new ProdutoDto
            {
                Id = p.Id
                                                           ,
                Name = p.Name
                                                           ,
                Value = p.Value
            });
            return dto;
        }
    }
}
