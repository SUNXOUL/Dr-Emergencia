using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DrEmergencias
{
    public class ArticuloBLL
    {
    private Contexto _contexto;
    public ArticuloBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(Articulo Articulo)
    {
        if (!Existe(Articulo.ArticuloID))
            return Insertar(Articulo);
        else
            return Modificar(Articulo);
    }

    public bool Existe(int ArticuloId)
    {
        return _contexto.Articulos.Any(o => o.ArticuloID== ArticuloId);
    }

    private bool Insertar(Articulo Articulo)
    {
        _contexto.Articulos.Add(Articulo);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public bool Modificar(Articulo Articulo)
    {
        _contexto.Entry(Articulo).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        _contexto.Entry(Articulo).State = EntityState.Detached;
        return cantidad > 0;
    }
    
    public List<Articulo> GetArticulosDetalles()
    {
        return _contexto.Articulos.ToList();
    }

        public bool Eliminar(Articulo Articulo)
        {
            _contexto.Entry(Articulo).State=EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM Articulo WHERE ArticuloID={Articulo.ArticuloID};");
            _contexto.Entry(Articulo).State = EntityState.Detached;
            return _contexto.SaveChanges()>0;
        }   

        public Articulo? Buscar(int ArticuloID)
        {
            return _contexto.Articulos
                    .Where(o => o.ArticuloID==ArticuloID ).AsNoTracking().SingleOrDefault();
                    
        }
        public List<Articulo> GetList()
        {
            return _contexto.Articulos.Where(o=>o.Visible == true).AsNoTracking().ToList();
        }
        public bool hidden(Articulo Articulo)
        {
            _contexto.Entry(Articulo).State = EntityState.Modified;
            int cantidad = _contexto.SaveChanges();
            _contexto.Database.ExecuteSqlRaw($"UPDATE Articulos SET Visible = false  WHERE ArticuloID={Articulo.ArticuloID}");
            _contexto.Entry(Articulo).State = EntityState.Detached;
            return cantidad > 0;
        }
    }
}