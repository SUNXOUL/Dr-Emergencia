using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DrEmergencias
{
    public class SalidaBLL
    {
    private Contexto _contexto;
    public SalidaBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(OrdenInventario OrdenInventario)
    {
        if (!Existe(OrdenInventario.OrdenID))
            return Insertar(OrdenInventario);
        else
            return Modificar(OrdenInventario);
    }

    public bool Existe(int OrdenID)
    {
        return _contexto.Salidas.Any(o => o.OrdenID== OrdenID);
    }

    private bool Insertar(OrdenInventario OrdenInventario)
    {
        _contexto.Salidas.Add(OrdenInventario);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public bool Modificar(OrdenInventario OrdenInventario)
    {
        _contexto.Entry(OrdenInventario).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        _contexto.Entry(OrdenInventario).State = EntityState.Detached;
        return cantidad > 0;
    }
    
    public List<OrdenInventario> GetOrdenInventariosDetalles()
    {
        return _contexto.Salidas.ToList();
    }

        public bool Eliminar(OrdenInventario OrdenInventario)
        {
            _contexto.Entry(OrdenInventario).State=EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM OrdenInventario WHERE OrdenID={OrdenInventario.OrdenID};");
            _contexto.Entry(OrdenInventario).State = EntityState.Detached;
            return _contexto.SaveChanges()>0;
        }   

        public OrdenInventario? Buscar(int OrdenID)
        {
            return _contexto.Salidas
                    .Where(o => o.OrdenID==OrdenID ).AsNoTracking().SingleOrDefault();
                    
        }
        public List<OrdenInventario> GetList()
        {
            return _contexto.Salidas.AsNoTracking().ToList();
        }
    }
}