using FluentValidation;
public class CustomerValidator : BaseViewModelValidator<CustomerViewModel>
{
    public CustomerValidator()
    {
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.CustomerName).NotEmpty();
    }
}

