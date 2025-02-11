using blazor_vehiculos_app.Models;

namespace blazor_vehiculos_app.Services;

/// <summary>
/// Servicio que gestiona las operaciones CRUD para los vehículos.
/// Mantiene los datos en memoria durante la ejecución de la aplicación.
/// </summary>
public class VehicleService
{
    /// <summary>
    /// Lista estática que almacena los vehículos en memoria
    /// </summary>
    private static readonly List<Vehicle> _vehicles = new();

    /// <summary>
    /// Contador para generar IDs únicos para cada vehículo
    /// </summary>
    private static int _nextId = 1;

    /// <summary>
    /// Obtiene todos los vehículos almacenados
    /// </summary>
    /// <returns>Lista de vehículos</returns>
    public Task<List<Vehicle>> GetAll()
    {
        return Task.FromResult(_vehicles.ToList());
    }

    /// <summary>
    /// Agrega un nuevo vehículo a la colección
    /// </summary>
    /// <param name="vehicle">Vehículo a agregar</param>
    /// <returns>Tarea completada</returns>
    public Task Add(Vehicle vehicle)
    {
        vehicle.Id = _nextId++;
        _vehicles.Add(vehicle);
        return Task.CompletedTask;
    }

    /// <summary>
    /// Actualiza la información de un vehículo existente
    /// </summary>
    /// <param name="vehicle">Vehículo con la información actualizada</param>
    /// <returns>Tarea completada</returns>
    public Task Update(Vehicle vehicle)
    {
        var index = _vehicles.FindIndex(v => v.Id == vehicle.Id);
        if (index != -1)
        {
            _vehicles[index] = vehicle;
        }
        return Task.CompletedTask;
    }

    /// <summary>
    /// Elimina un vehículo por su ID
    /// </summary>
    /// <param name="id">ID del vehículo a eliminar</param>
    /// <returns>Tarea completada</returns>
    public Task Delete(int id)
    {
        var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
        if (vehicle != null)
        {
            _vehicles.Remove(vehicle);
        }
        return Task.CompletedTask;
    }
} 