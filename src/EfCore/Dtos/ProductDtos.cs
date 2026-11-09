using System.ComponentModel.DataAnnotations;
using EfCore.Models;

namespace EfCore.Dtos;

public record ProductRequest(
    [Required, StringLength(30)]
    string Code,

    [Required]
    [StringLength(120)]
    string Name,

    [Required]
    [Range(typeof(decimal), "0", "99999999999.99", ParseLimitsInInvariantCulture = true, ConvertValueInInvariantCulture = true)]
    decimal Price,

    [Required]
    [Range(0, int.MaxValue)]
    int Stock,

    [Required, StringLength(120)]
    string Category
);

public record UpdateProductRequest(
    [Required]
    [StringLength(120)]
    string Name,

    [Required]
    [Range(typeof(decimal), "0", "99999999999.99", ParseLimitsInInvariantCulture = true, ConvertValueInInvariantCulture = true)]
    decimal Price,

    [Required]
    [Range(0, int.MaxValue)]
    int Stock,

    [Required, StringLength(120)]
    string Category
);

public sealed record ProductResponse(string ProductCode, string Name, decimal Price, int Stock, string Category)
{
    public static ProductResponse FromModel(Product product) => new(product.Code, product.Name, product.Price, product.Stock, product.Category);
}