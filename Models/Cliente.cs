using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty; 

    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;  

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
