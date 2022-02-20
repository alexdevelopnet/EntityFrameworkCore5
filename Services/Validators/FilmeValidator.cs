using Domain.Entities;
using FluentValidation;

namespace Services.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(f => f.Titulo)
                .NotEmpty().WithMessage("Titulo é obrigatário")
                .NotNull().WithMessage("Titulo é obrigatário");
            RuleFor(f => f.Genero)
                .NotEmpty().WithMessage("Titulo é obrigatário")
                .NotNull().WithMessage("Titulo é obrigatário");
            RuleFor(f => f.Diretor)
                .NotEmpty().WithMessage("Titulo é obrigatário")
                .NotNull().WithMessage("Titulo é obrigatário");
            RuleFor(f => f.Duracao)
                .NotEmpty().WithMessage("Titulo é obrigatário")
                .NotNull().WithMessage("Titulo é obrigatário");

        }
    }
}
