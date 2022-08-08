using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces;
using RestApiModelDDD.Application.Interfaces.IMapping;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModelDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMappingCliente mappingCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente,
                                          IMappingCliente mappingCliente)
        {
            this.serviceCliente = serviceCliente;
            this.mappingCliente = mappingCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = mappingCliente.MappingDtoToEntity(clienteDto);
            serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            return mappingCliente.MappingListClienteDto(clientes);
        }

        public ClienteDto GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            return mappingCliente.MappingEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mappingCliente.MappingDtoToEntity(clienteDto);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mappingCliente.MappingDtoToEntity(clienteDto);
            serviceCliente.Update(cliente);
        }
    }
}
