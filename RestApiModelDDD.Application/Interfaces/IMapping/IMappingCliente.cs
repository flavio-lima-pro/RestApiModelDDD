using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interfaces.IMapping
{
    public interface IMappingCliente
    {
        Cliente MappingDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MappingListClienteDto(IEnumerable<Cliente> clientes);
        ClienteDto MappingEntityToDto(Cliente cliente);
    }
}
