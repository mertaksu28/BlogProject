using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(b => b.BlogTitle).NotEmpty().WithMessage("Blog Başlığı boş geçilemez");
            RuleFor(b => b.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçilemez");
            RuleFor(b => b.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçilemez");
            RuleFor(b => b.BlogTitle).MaximumLength(150).WithMessage("150 Karakterden daha az veri girişi yapın...");
            RuleFor(b => b.BlogTitle).MinimumLength(5).WithMessage("5 Karakterden daha fazla veri girişi yapın...");
        }
    }
}
