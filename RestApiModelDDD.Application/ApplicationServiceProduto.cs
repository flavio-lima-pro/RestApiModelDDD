using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces;
using RestApiModelDDD.Application.Interfaces.IMapping;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModelDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMappingProduto mappingProduto;

        public void Add(ProdutoDto produtoDto)
        {
            var produto = mappingProduto.MappingDtoToEntity(produtoDto);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            return mappingProduto.MappingListProdutoDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            return mappingProduto.MappingEntityToDto(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mappingProduto.MappingDtoToEntity(produtoDto);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mappingProduto.MappingDtoToEntity(produtoDto);
            serviceProduto.Update(produto);
        }
    }
}
