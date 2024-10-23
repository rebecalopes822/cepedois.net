using System.ComponentModel.DataAnnotations;

public class Produto
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty; 

    [Required]
    public decimal Preco { get; set; }

    [MaxLength(200)]
    public string Descricao { get; set; } = string.Empty;  
}
