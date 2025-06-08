using AutoMapper;
using SafeZone.Application.DTOs;
using SafeZone.Domain.Entities;

namespace SafeZone.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        CreateMap<Alerta, AlertaDTO>().ReverseMap();
        CreateMap<Localizacao, LocalizacaoDTO>().ReverseMap();
        CreateMap<AreaSegura, AreaSeguraDTO>().ReverseMap();

    }
}