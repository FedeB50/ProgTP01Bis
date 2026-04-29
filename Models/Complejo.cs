namespace Tp01Bis.Models;
class Complejo
{
    public Dictionary<int, Cabaña> Cabañas;
    public Complejo()
    {
        Cabañas = new Dictionary<int, Cabaña>();
    }
    public void AgregarCabaña(Cabaña cabaña)
    {
        Cabañas[cabaña.id] = cabaña;
    }
    public void cargarCabañas()
    {
        AgregarCabaña(new Cabaña(1, "Cabaña 1", "Cabaña en el pueblo", 4, new List<string> { "CA1.png", "CA2.png" }, new List<string> { "Cocina", "Baño", "Dormitorio", "Living" }));
        AgregarCabaña(new Cabaña(2, "Cabaña 2", "Cabaña con vista a la montaña", 6, new List<string> { "CB1.png", "CB2.png" }, new List<string> { "Cocina", "Baño", "Dormitorio", "Living" }));
        AgregarCabaña(new Cabaña(3, "Cabaña 3", "Cabaña espaciosa y grande", 8, new List<string> { "CC1.png", "CC2.png" }, new List<string> { "Cocina", "Baño", "Dormitorio", "Living" }));
    }
    public Cabaña ObtenerCabaña(int id)
    {
        return Cabañas[id];
    }
    public List<Cabaña> ObtenerTodasLasCabañas()
    {
        return Cabañas;
    }
}