using Application.Commands.Request.Despesa;
using AutoMapper;
using Domain.Models;

namespace Application.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Despesa, RegistrarDespesaRequest>()
                .ReverseMap();
        }
    }
}