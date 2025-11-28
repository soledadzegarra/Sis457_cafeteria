using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebCafeteria.Models;

public partial class Producto
{
    public int Id { get; set; }

    public int IdCategoria { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    // Nuevo: URL opcional de imagen
    [Url(ErrorMessage = "Ingrese una URL válida.")]
    [MaxLength(300)]
    public string? ImagenUrl { get; set; }

    public decimal Saldo { get; set; }

    public decimal PrecioVenta { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual Categoria? IdCategoriaNavigation { get; set; }
}