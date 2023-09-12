using NlayerProject.Core.Models.Bases;
using NlayerProject.Core.Models.ModuleProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerProject.Core.Models.ModuleCategory
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
