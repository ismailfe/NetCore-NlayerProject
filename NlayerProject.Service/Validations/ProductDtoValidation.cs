﻿using FluentValidation;
using NlayerProject.Core.DTOs.ModuleProduct;

namespace NlayerProject.Service.Validations
{
    public class ProductDtoValidation : AbstractValidator<ProductDto>
    {
        public ProductDtoValidation()
        {
            RuleFor(x => x.Name).NotNull()
                .WithMessage("{PropertyName} is required")
                .NotEmpty()
                .WithMessage("{PropertyName} is required");

            RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue)
                .WithMessage("{PropertyName} must be greater 0");
            RuleFor(x => x.Stock).InclusiveBetween(1, int.MaxValue)
                .WithMessage("{PropertyName} must be greater 0");
        }
    }
}
