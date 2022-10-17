using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class ProjectValidation:AbstractValidator<Project>
    {
        public ProjectValidation()
        {
            RuleFor(x => x.projectName).NotEmpty().WithMessage("Proje adı giriniz!");
            RuleFor(x => x.projectName).MaximumLength(50).WithMessage("0-50 karakter giriniz!");
            RuleFor(x => x.projectDescription).NotEmpty().WithMessage("Proje açıklaması giriniz!");
        }
    }
}
