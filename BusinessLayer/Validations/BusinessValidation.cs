using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class BusinessValidation:AbstractValidator<Business>
    {
        public BusinessValidation()
        {
            RuleFor(x => x.businessName).NotEmpty().WithMessage("Hizmet adı giriniz!");
            RuleFor(x => x.businessName).MaximumLength(50).WithMessage("0-50 karakter giriniz!");
            RuleFor(x => x.businessDescription).NotEmpty().WithMessage("Hizmet açıklaması giriniz!");
        }
    }
}
