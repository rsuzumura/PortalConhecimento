using AutoMapper;

namespace PortalConhecimento.UI.Web
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(i => i.AddProfile<AutoMapperProfile>());
        }
    }
}