using Resources;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PortalConhecimento.UI.Web.Attributes
{
    public class CustomStringLengthAttribute: StringLengthAttributeAdapter
    {
        public CustomStringLengthAttribute(
            System.Web.Mvc.ModelMetadata metadata,
            ControllerContext context,
            StringLengthAttribute attribute)
            : base(metadata, context, attribute)
        {
            if (string.IsNullOrEmpty(attribute.ErrorMessage))
            {
                attribute.ErrorMessageResourceType = typeof(DefaultResource);
                attribute.ErrorMessageResourceName = "StringLength";
            }
        }
    }
}