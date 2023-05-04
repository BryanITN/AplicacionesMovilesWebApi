using AplicacionesMoviles.WebApi.Dtos.Tecnico;
using AplicacionesMoviles.WebApi.Entidades;
using AutoMapper;

namespace AplicacionesMoviles.WebApi.Mappers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Tecnico, DtoCreateUpdateTecnico>();
            CreateMap<Tecnico, DtoLoginTecnico>();
            CreateMap<Tecnico, DtoTecnico>();
        }
    }
}
