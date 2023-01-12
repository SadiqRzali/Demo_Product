using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Validation
{
    public class CustomerValidatior : AbstractValidator<Customer>
    {
        public CustomerValidatior()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad hissesini bos kece bilmezsiniz");
            RuleFor(x => x.City).NotEmpty().WithMessage("City hissesini bos kece bilmezsiniz");
            
        }
    }
}
