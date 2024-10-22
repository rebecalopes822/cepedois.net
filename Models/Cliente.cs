using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    // Tornar o campo Pedidos opcional
    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();  // Inicializado com uma lista vazia
}
