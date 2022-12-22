using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228FirstAPI.DTOs.CategoryDTOs
{
    public class CategoryForCreateDto
    {
        /// <summary>
        /// Categoriyan Adi
        /// </summary>
        public string Name { get; set; }
    }

    public class CategoryForCreateDtoValidator : AbstractValidator<CategoryForCreateDto>
    {
        public CategoryForCreateDtoValidator()
        {
            RuleFor(r => r.Name)
                .MaximumLength(255).WithMessage("maximum 255 simvol Ola Biler")
                .MinimumLength(10).WithMessage("Minimum 10 simvol Ola Biler")
                .NotEmpty().WithMessage("Bos Ola Bilmez");

        }
    }
}
