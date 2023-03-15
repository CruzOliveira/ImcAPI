using System.ComponentModel.DataAnnotations;

namespace ImcAPI.Models;

public class Usuario
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required (ErrorMessage = "O Nome e obrigatorio!")]   
    public string Nome { get; set; }
    [Required(ErrorMessage = "O CPF e obrigatorio!")]
    public string Cpf { get; set; }
    [Required(ErrorMessage = "O idade e obrigatorio!")]
    public string Idade { get; set; }
    [Required(ErrorMessage = "O Peso e obrigatorio!")]
    public double Peso { get; set; }
    [Required(ErrorMessage = "A data de nacimento e obrigatorio!")]
    public string DtNacimento { get; set; }
    [Required(ErrorMessage = "O Altura e obrigatorio!")]
    public double Altura { get; set; }
    
}
