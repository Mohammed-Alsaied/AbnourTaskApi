using Common.ViewModels;
using FluentValidation;

namespace Common.Validators
{
    public abstract class BaseViewModelValidator<T> : AbstractValidator<T>
    where T : BaseViewModel
    {
        public BaseViewModelValidator()
        {
            //RuleFor(b => b.Id).NotEmpty();
            //RuleFor(b => b.CreationDate).NotEmpty();
        }
    }
}
