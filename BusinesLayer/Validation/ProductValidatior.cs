using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Validation
{
    public class ProductValidatior:AbstractValidator<Product>
    {
        public ProductValidatior()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Mehsul Adini Bos kece bilmezsiniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("minimum 3 karakter daxil edin");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Qiymet Bos kece bilmezsiniz");
            RuleFor(x => x.Sock).NotEmpty().WithMessage("Stoc siyahisini bos kece bilmezsiniz");
        }
    }
}
