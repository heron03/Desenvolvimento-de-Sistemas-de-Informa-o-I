using System;
using System.ComponentModel.DataAnnotations;
public class FormularioValidacao
{
    [Required(ErrorMessage = "O Título é obrigatório")]
    public string titulo { get; set; }
    [Required(ErrorMessage = "O Primeiro Nome é obrigatório")]
    public string Primeironome { get; set; }

    [Required(ErrorMessage = "O Sobrenome é obrigatório")]
    public string Sobrenome { get; set; }

    [Required(ErrorMessage = "A data de Aniversário é obrigatório")]
    public Nullable<DateTime> dataAniversario { get; set; }


    [Required(ErrorMessage = "Informe o email")]
    [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
    public string Email { get; set; }

    [StringLength(255, ErrorMessage = "Mínimo de 6 caracteres ", MinimumLength = 6)]
    [Required(ErrorMessage = "A Senha é obrigatório")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [StringLength(255, ErrorMessage = "Mínimo de 6 caracteres ", MinimumLength = 6)]
    [Required(ErrorMessage = "Confirmar Senha é obrigatório")]
    [DataType(DataType.Password)]
    [Compare("Senha", ErrorMessage = "As senhas Informadas são diferentes")]
    public string ConfirmarSenha { get; set; }

    [Range(typeof(bool), "true", "true",
        ErrorMessage = "Os termos e condições são obrigatorios")]
    public bool Termos { get; set; }
}