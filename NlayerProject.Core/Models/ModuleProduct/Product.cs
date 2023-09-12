﻿using NlayerProject.Core.Models.Bases;
using NlayerProject.Core.Models.ModuleCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerProject.Core.Models.ModuleProduct
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
    }
}
