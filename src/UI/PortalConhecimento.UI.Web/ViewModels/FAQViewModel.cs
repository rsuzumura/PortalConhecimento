using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalConhecimento.UI.Web.ViewModels
{
    public class FAQViewModel
    {
        public int Id { get; set; }
        public string Cabecalho { get; set; }
        public string Conteudo { get; set; }
        public bool Ativo { get; set; }

        public static IEnumerable<FAQViewModel> ListarAtivos()
        {
            var result = new List<FAQViewModel>
            {
                new FAQViewModel { Id = 1, Cabecalho = "Teste 1", Conteudo = "<p>Ut fusce varius nisl ac ipsum gravida vel pretium tellus tincidunt integer eu augue augue nunc elit dolor, luctus placerat.</p>" },
                new FAQViewModel { Id = 2, Cabecalho = "Teste 2", Conteudo = "<p>Sapien elit in malesuada semper mi, id sollicitudin urna fermentum.</p>" },
                new FAQViewModel { Id = 3, Cabecalho = "Teste 3", Conteudo = "<p>Sollicitudin urna fermentum ut fusce varius nisl ac ipsum gravida vel pretium tellus tincidunt integer eu augue.</p>" },
                new FAQViewModel { Id = 4, Cabecalho = "Teste 4", Conteudo = "<p>In malesuada semper mi, id sollicitudin urna fermentum ut fusce varius nisl.</p>" },
                new FAQViewModel { Id = 5, Cabecalho = "Teste 5", Conteudo = "<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>" },
                new FAQViewModel { Id = 6, Cabecalho = "Teste 6", Conteudo = "<p>Laoreet ac, aliquam sit amet justo nunc tempor, metus vel placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante fusce non varius purus aenean nec magna felis fusce vestibulum.</p>" }
            };

            return result;
        }
    }
}