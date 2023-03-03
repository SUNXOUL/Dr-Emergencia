using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;


namespace DrEmergencias
{
    public class OrdenComprasBLL
    {

        private Contexto _contexto;

        public OrdenComprasBLL(Contexto contexto)
        {
            this._contexto = contexto;
        }


        public bool Existe(int id)
        {
            return _contexto.OrdenCompras
                .Any(c => c.CompraId == id);
        }

        public bool Guardar(OrdenCompras compra)
        {
            if (!Existe(compra.CompraId))
                return this.Insertar(compra);
            else
                return this.Modificar(compra);
        }


        private bool Insertar(OrdenCompras compra)
        {
            _contexto.OrdenCompras.Add(compra);
            return _contexto.SaveChanges() > 0;
        }

        private bool Modificar(OrdenCompras compra)
        {

            _contexto.Entry(compra).State = EntityState.Modified;

            var guardo = _contexto.SaveChanges() > 0;
            _contexto.Entry(compra).State = EntityState.Detached;
            return guardo;
        }
        public bool Eliminar(OrdenCompras compra)
        {
            _contexto.Entry(compra).State = EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"UPDATE OrdebCompras SET Visible = false WHERE CompraId = {compra.CompraId}");
            _contexto.Database.ExecuteSqlRaw($"UPDATE ComprasDetalle SET Visible = false WHERE CompraId = {compra.CompraId}");
            return _contexto.SaveChanges() > 0;
        }

        public OrdenCompras? Buscar(int compraId)
        {
            return _contexto.OrdenCompras
                .Include(c => c.Detalle)
                .Where(c => c.CompraId == compraId)
                .AsNoTracking()
                .SingleOrDefault();
        }
        public List<OrdenCompras> GetList()
        {
            return _contexto.OrdenCompras.Where(o => o.Visible==true).AsNoTracking().ToList();
        }
    }
        
    
}
