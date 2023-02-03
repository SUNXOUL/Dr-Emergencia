using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class EmergenciaBLL
    {
    private Contexto _contexto;
    public EmergenciaBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(Emergencia Emergencia)
    {
        if (!Existe(Emergencia.OrdenID))
            return Insertar(Emergencia);
        else
            return Modificar(Emergencia);
    }

    public bool Existe(int OrdenID)
    {
        return _contexto.Emergencia.Any(o => o.OrdenID == OrdenID);
    }

    private bool Insertar(Emergencia Emergencia)
    {
        _contexto.Emergencia.Add(Emergencia);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    private bool Modificar(Emergencia Emergencia)
    {
        _contexto.Entry(Emergencia).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }
    
    public List<Emergencia> GetEmergencia()
    {
        return _contexto.Emergencia.ToList();
    }

        public bool Eliminar(Emergencia Emergencia)
        {
            Console.WriteLine("eliminado");
            _contexto.Entry(Emergencia).State=EntityState.Deleted;
            return _contexto.SaveChanges()>0;
        }   

        public Emergencia? Buscar(int OrdenID)
        {
            return _contexto.Emergencia
                    .Where(o => o.OrdenID==OrdenID).AsNoTracking().SingleOrDefault();
                    
        }
        public List<Emergencia> GetList()
        {
            return _contexto.Emergencia.AsNoTracking().ToList();
        }
    }
}