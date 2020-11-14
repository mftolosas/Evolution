using AutoMapper;
using EvolutionAPI.Models;

namespace EvolutionAPI.DTOs
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Usuario, UsuarioDTO>()
                   .ForMember(x => x.UsuId, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Producto, ProductoDTO>()
                   .ForMember(x => x.ProId, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Pedido, PedidoDTO>()
                    .ForMember(x => x.PedId, o => o.Ignore())
                   .ReverseMap();
            });
        }
    }
}
