namespace Tp01Bis.Models;

public class Cabaña
{
    public int id;
    public string nombre;
    public string descripcion;
    public int capacidad;
    public List<string> fotos;
    public List<string> ambientes;
    public Cabaña(int id, string nombre, string descripcion, int capacidad, List<string> fotos, List<string> ambientes)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.capacidad = capacidad;
        this.fotos = fotos;
        this.ambientes = ambientes;
    }
}