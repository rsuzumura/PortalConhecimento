using AutoMapper;
using PortalConhecimento.Domain.Entities;
using PortalConhecimento.UI.Web.ViewModels;

namespace PortalConhecimento.UI.Web
{
    public class AutoMapperProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ContatoViewModel, Contato>();
        }
    }
}