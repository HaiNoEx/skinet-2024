using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class CreateProductDto
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
    public decimal Price { get; set; }
    [Required]
    public string PictureUrl { get; set; } = string.Empty;
    [Required]
    public string Type { get; set; } = string.Empty;

    [Required]
    public string Brand { get; set; } = string.Empty;
    [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0")]

    public int QuantityInStock { get; set; }

}
