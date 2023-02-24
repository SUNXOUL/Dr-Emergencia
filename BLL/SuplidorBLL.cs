using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DrEmergencias
{
    public class SuplidorBLL
    {
    private Contexto _contexto;
    public SuplidorBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(Suplidor Suplidor)
    {
        if (!Existe(Suplidor.SuplidorID))
            return Insertar(Suplidor);
        else
            return Modificar(Suplidor);
    }

    public bool Existe(int SuplidorId)
    {
        return _contexto.Suplidores.Any(o => o.SuplidorID== SuplidorId);
    }

    private bool Insertar(Suplidor Suplidor)
    {
        _contexto.Suplidores.Add(Suplidor);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public bool Modificar(Suplidor Suplidor)
    {
        _contexto.Entry(Suplidor).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        _contexto.Entry(Suplidor).State = EntityState.Detached;
        return cantidad > 0;
    }
    
    public List<Suplidor> GetSuplidorsDetalles()
    {
        return _contexto.Suplidores.ToList();
    }

        public bool Eliminar(Suplidor Suplidor)
        {
            _contexto.Entry(Suplidor).State=EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM Suplidor WHERE SuplidorID={Suplidor.SuplidorID};");
            _contexto.Entry(Suplidor).State = EntityState.Detached;
            return _contexto.SaveChanges()>0;
        }   

        public Suplidor? Buscar(int SuplidorID)
        {
            return _contexto.Suplidores
                    .Where(o => o.SuplidorID==SuplidorID ).AsNoTracking().SingleOrDefault();
                    
        }
        public List<Suplidor> GetList()
        {
            return _contexto.Suplidores.AsNoTracking().ToList();
        }
    }
}