using System.ComponentModel.DataAnnotations;

namespace blazor_vehiculos_app.Models;

public class Vehicle
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor ingrese la marca del vehículo")]
    [StringLength(50, ErrorMessage = "La marca debe tener máximo 50 caracteres")]
    public string Brand { get; set; } = string.Empty;

    [Required(ErrorMessage = "Por favor ingrese el modelo del vehículo")]
    [StringLength(50, ErrorMessage = "El modelo debe tener máximo 50 caracteres")]
    public string Model { get; set; } = string.Empty;

    [Required(ErrorMessage = "Por favor ingrese el año del vehículo")]
    [Range(1950, 2025, ErrorMessage = "El año debe ser entre 1950 y 2025")]
    public int Year { get; set; }
} 