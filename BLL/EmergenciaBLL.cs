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

    public bool Existe(int EmergenciaId)
    {
        return _contexto.Emergencias.Any(o => o.OrdenID== EmergenciaId);
    }

    private bool Insertar(Emergencia Emergencia)
    {
        _contexto.Emergencias.Add(Emergencia);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public bool Modificar(Emergencia Emergencia)
    {
        _contexto.Entry(Emergencia).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        _contexto.Entry(Emergencia).State = EntityState.Detached;
        return cantidad > 0;
    }
    
    public List<Emergencia> GetEmergenciasDetalles()
    {
        return _contexto.Emergencias.ToList();
    }

        public bool Eliminar(Emergencia Emergencia)
        {
            _contexto.Entry(Emergencia).State=EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM Emergencia WHERE OrdenID={Emergencia.OrdenID};");
            _contexto.Entry(Emergencia).State = EntityState.Detached;
            return _contexto.SaveChanges()>0;
        }   

        public Emergencia? Buscar(int EmergenciaID)
        {
            return _contexto.Emergencias
                    .Where(o => o.OrdenID==EmergenciaID ).AsNoTracking().SingleOrDefault();
                    
        }
        public List<Emergencia> GetList()
        {
            return _contexto.Emergencias.AsNoTracking().ToList();
        }
    }
}