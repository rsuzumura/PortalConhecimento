using Resources;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PortalConhecimento.UI.Web.Attributes
{
    public class CustomRequiredAttribute : RequiredAttributeAdapter
    {
        public CustomRequiredAttribute(
            ModelMetadata metadata,
            ControllerContext context,
            RequiredAttribute attribute
        ) : base(metadata, context, attribute)
        {
            if (string.IsNullOrEmpty(attribute.ErrorMessage))
            {
                attribute.ErrorMessageResourceType = typeof(DefaultResource);
                attribute.ErrorMessageResourceName = "PropertyValueRequired";
            }
        }
    }
}