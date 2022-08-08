using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces.IMapping;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModelDDD.Application.Mapping
{
    public class MappingCliente : IMappingCliente
    {
        public Cliente MappingDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id
               ,
                Name = clienteDto.Name
               ,
                LastName = clienteDto.LastName
               ,
                Email = clienteDto.Email
            };
            return cliente;
        }

        public ClienteDto MappingEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto
            {
                Id = cliente.Id
               ,
                Name = cliente.Name
               ,
                LastName = cliente.LastName
               ,
                Email = cliente.Email
            };
            return clienteDto;
        }

        public IEnumerable<ClienteDto> MappingListClienteDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDto
            {
                Id = c.Id
                                                           ,
                Name = c.Name
                                                           ,
                LastName = c.LastName
                                                           ,
                Email = c.Email
            });
            return dto;
        }
    }
}
