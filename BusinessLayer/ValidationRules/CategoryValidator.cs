﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemessiniz.");
            RuleFor(x => x.CategoryName).MaximumLength(25).WithMessage("Kategori adını en fazla 25 karakter olmalıdır.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adını en az 3 karakter olmalıdır.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemessiniz.");
        }
    }
}
