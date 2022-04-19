using DataAccess.Dtos.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class VacationRequestDtoValidatior: AbstractValidator<VacationRequestDto>
    {
        public VacationRequestDtoValidatior()
        {
            RuleFor(x => x.VacationerFullName).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz").MinimumLength(5).WithMessage("Ən azı 5 simvol girməlisiniz");
            RuleFor(x => x.ReplacementPerson).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz").MinimumLength(5).WithMessage("Ən azı 5 simvol girməlisiniz");
            RuleFor(x => x.VacationerPosition).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz").MinimumLength(2).WithMessage("Ən azı 2 simvol girməlisiniz");
            RuleFor(x => x.VacationTypeId).GreaterThan(0).WithMessage("Məzuniyyət tipini seçin")
                .NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz");
            RuleFor(x => x.VacationerFullName).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz").MinimumLength(5).WithMessage("Ən azı 5 simvol girməlisiniz");
            RuleFor(x => x.StartVacation).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz").Must(x => x.Date > DateTime.Now.Date).WithMessage("Məzuniyyət tələbinin başlama vaxtı ən azı sabahdan olmalıdır");
            RuleFor(x => x.EndVacation).NotEmpty().WithMessage("Boş ola bilməz").NotNull().WithMessage("Boş ola bilməz").GreaterThan(x => x.StartVacation).WithMessage("Məzuniyyət tələbinin bitmə vaxtı başlanğıcından böyük olmalıdır");
        }
    }
}
