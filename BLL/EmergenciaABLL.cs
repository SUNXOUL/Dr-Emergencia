using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class EmergenciaABLL
    {
    private Contexto _contexto;
    public EmergenciaABLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(EmergenciaA EmergenciaA)
    {
        if (!Existe(EmergenciaA.OrdenID))
            return Insertar(EmergenciaA);
        else
            return Modificar(EmergenciaA);
    }

    public bool Existe(int OrdenID)
    {
        return _contexto.EmergenciaA.Any(o => o.OrdenID == OrdenID);
    }

    private bool Insertar(EmergenciaA EmergenciaA)
    {
        _contexto.EmergenciaA.Add(EmergenciaA);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    private bool Modificar(EmergenciaA EmergenciaA)
    {
        _contexto.Entry(EmergenciaA).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }
    
    public List<EmergenciaA> GetEmergenciaA()
    {
        return _contexto.EmergenciaA.ToList();
    }

        public bool Eliminar(EmergenciaA EmergenciaA)
        {
            Console.WriteLine("eliminado");
            _contexto.Entry(EmergenciaA).State=EntityState.Deleted;
            return _contexto.SaveChanges()>0;
        }   

        public EmergenciaA? Buscar(int OrdenID)
        {
            return _contexto.EmergenciaA
                    .Where(o => o.OrdenID==OrdenID).AsNoTracking().SingleOrDefault();
                    
        }
        public List<EmergenciaA> GetList()
        {
            return _contexto.EmergenciaA.AsNoTracking().ToList();
        }
    }
}