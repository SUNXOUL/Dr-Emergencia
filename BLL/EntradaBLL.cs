using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;




namespace DrEmergencias
{

    public class EntradaBLL
    {
    private Contexto _contexto;
    public EntradaBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(Entrada Entrada)
    {
        if (!Existe(Entrada.OrdenID))
            return Insertar(Entrada);
        else
            return Modificar(Entrada);
    }

    public bool Existe(int OrdenID)
    {
        return _contexto.Entradas.Any(o => o.OrdenID== OrdenID);
    }

    private bool Insertar(Entrada Entrada)
    {
        _contexto.Entradas.Add(Entrada);
        int cantidad = _contexto.SaveChanges();
        _contexto.Database.ExecuteSqlRaw($"UPDATE Articulos SET Existencia = Existencia + {Entrada.Cantidad}  WHERE ArticuloID={Entrada.ArticuloID}");
        return cantidad > 0;
    }

    public bool Inventario(Entrada Entrada)
    {
       _contexto.Entradas.Add(Entrada);
        int cantidad = _contexto.SaveChanges();
        _contexto.Database.ExecuteSqlRaw($"UPDATE Articulos SET Existencia = {Entrada.Cantidad}  WHERE ArticuloID={Entrada.ArticuloID}");
       
        return cantidad > 0;
    }

    public bool Modificar(Entrada Entrada)
    {
        _contexto.Entry(Entrada).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        _contexto.Entry(Entrada).State = EntityState.Detached;
        return cantidad > 0;
    }
    
    public List<Entrada> GetEntradasDetalles()
    {
        return _contexto.Entradas.ToList();
    }

        public bool Eliminar(Entrada Entrada)
        {
            _contexto.Entry(Entrada).State=EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM Entrada WHERE OrdenID={Entrada.OrdenID};");
            _contexto.Entry(Entrada).State = EntityState.Detached;
            return _contexto.SaveChanges()>0;
        }   

        public Entrada? Buscar(int OrdenID)
        {
            return _contexto.Entradas
                    .Where(o => o.OrdenID==OrdenID ).AsNoTracking().SingleOrDefault();
                    
        }
        public List<Entrada> GetList()
        {
            return _contexto.Entradas.Where(o=>o.Visible == true).AsNoTracking().ToList();
        }
        public bool hidden(Entrada Entrada)
        {
            _contexto.Entry(Entrada).State = EntityState.Modified;
            int cantidad = _contexto.SaveChanges();
            _contexto.Database.ExecuteSqlRaw($"UPDATE Entradas SET Visible = false  WHERE EntradaID={Entrada.OrdenID}");
            _contexto.Database.ExecuteSqlRaw($"UPDATE Articulos SET Existencia = Existencia - {Entrada.Cantidad}  WHERE ArticuloID={Entrada.ArticuloID}");
            _contexto.Entry(Entrada).State = EntityState.Detached;
            return cantidad > 0;
        }
        
    }
}