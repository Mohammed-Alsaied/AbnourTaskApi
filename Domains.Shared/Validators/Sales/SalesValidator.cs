using FluentValidation;
public class SalesValidator : BaseViewModelValidator<SalesViewModel>
{
    public SalesValidator()
    {
        RuleFor(s => s.SalesName).NotEmpty();
        RuleFor(s => s.Email).NotEmpty();
    }
}

