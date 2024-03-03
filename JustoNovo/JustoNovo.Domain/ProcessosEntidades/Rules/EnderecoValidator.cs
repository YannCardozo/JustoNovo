using FluentValidation;


namespace JustoNovo.Domain.ProcessosEntidades.Rules
{
    public class EnderecoValidator : AbstractValidator<Endereco>
    {
        public EnderecoValidator()
        {
            RuleFor(x => x.Rua)
              .NotEmpty().WithMessage("A rua não pode estar vazia");

            RuleFor(x => x.Numero)
                .NotEmpty().WithMessage("O número não pode estar vazio");

            RuleFor(x => x.Bairro)
                .NotEmpty().WithMessage("O bairro não pode estar vazio");

            RuleFor(x => x.Municipio)
                .NotEmpty().WithMessage("O município não pode estar vazio");

            RuleFor(x => x.UF)
                .NotEmpty().WithMessage("A UF não pode estar vazia");

            RuleFor(x => x.Cep)
                .NotEmpty().WithMessage("O CEP não pode estar vazio");

            RuleFor(x => x.Referencia)
                .NotEmpty().WithMessage("A referência não pode estar vazia");
        }
    }    

}
