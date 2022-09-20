using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class MediaValidation:AbstractValidator<Media>
    {
        public MediaValidation()
        {
            RuleFor(x => x.mediaName).NotEmpty().WithMessage("Medya Adı Giriniz!");
            RuleFor(x => x.mediaUrl).NotEmpty().WithMessage("Medya Url Giriniz!");
        }
    }
}
