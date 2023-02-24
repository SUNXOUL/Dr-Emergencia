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

    public bool Guardar(Salida Salida)
    {
        if (!Existe(Salida.OrdenID))
            return Insertar(Salida);
        else
            return Modificar(Salida);
    }

    public bool Existe(int OrdenID)
    {
        return _contexto.Salidas.Any(o => o.OrdenID== OrdenID);
    }

    private bool Insertar(Salida Salida)
    {
        _contexto.Salidas.Add(Salida);
        int cantidad = _contexto.SaveChanges();
        _contexto.Database.ExecuteSqlRaw($"UPDATE Articulos SET Existencia = Existencia - {Salida.Cantidad}  WHERE ArticuloID={Salida.ArticuloID}");
        return cantidad > 0;
    }

    public bool Modificar(Salida Salida)
    {
        _contexto.Entry(Salida).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        _contexto.Entry(Salida).State = EntityState.Detached;
        return cantidad > 0;
    }
    
    public List<Salida> GetSalidasDetalles()
    {
        return _contexto.Salidas.ToList();
    }

        public bool Eliminar(Salida Salida)
        {
            _contexto.Entry(Salida).State=EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM Salida WHERE OrdenID={Salida.OrdenID};");
            _contexto.Entry(Salida).State = EntityState.Detached;
            return _contexto.SaveChanges()>0;
        }   

        public Salida? Buscar(int OrdenID)
        {
            return _contexto.Salidas
                    .Where(o => o.OrdenID==OrdenID ).AsNoTracking().SingleOrDefault();
                    
        }
        public List<Salida> GetList()
        {
            return _contexto.Salidas.Where(o=>o.Visible == true).AsNoTracking().ToList();
        }
                public bool hidden(Salida Salida)
        {
            _contexto.Entry(Salida).State = EntityState.Modified;
            int cantidad = _contexto.SaveChanges();
            _contexto.Database.ExecuteSqlRaw($"UPDATE Salidas SET Visible = false  WHERE SalidaID={Salida.OrdenID}");
                    _contexto.Database.ExecuteSqlRaw($"UPDATE Articulos SET Existencia = Existencia + {Salida.Cantidad}  WHERE ArticuloID={Salida.ArticuloID}");
            _contexto.Entry(Salida).State = EntityState.Detached;
            return cantidad > 0;
        }
    }
}