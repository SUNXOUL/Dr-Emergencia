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

            bool Guardo = _contexto.SaveChanges() > 0;

            _contexto.Entry(compra).State = EntityState.Detached;

            return Guardo;

        }

        private bool Modificar(OrdenCompras compra)
        {
            

          
            

            _contexto.OrdenCompras.Update(compra);
            var modificado = _contexto.SaveChanges() > 0;
            _contexto.Entry(compra).State = EntityState.Detached;
            return modificado;

            
        }
        public bool Eliminar(OrdenCompras compra)
        {


            _contexto.Database.ExecuteSqlRaw($"UPDATE OrdenCompras SET Visible = false WHERE CompraId = {compra.CompraId}");
            _contexto.Database.ExecuteSqlRaw($"UPDATE ComprasDetalle SET Visible = false WHERE CompraId = {compra.CompraId}");
            return _contexto.SaveChanges() > 0;
        }

        public OrdenCompras? Buscar(int compraId)
        {
            return _contexto.OrdenCompras
                .Include(c => c.Detalle)
                .Where(c => c.CompraId == compraId && c.Visible == true)
                .AsNoTracking()
                .SingleOrDefault();
        }

        
        public List<OrdenCompras> GetList()
        {
            return _contexto.OrdenCompras.Where(o => o.Visible==true && (o.Estado.Contains("Esperando") || o.Estado.Contains("Recibida")) ).AsNoTracking().ToList();
        }

        public List<OrdenCompras> FindList(int Buscado)
        {
            return _contexto.OrdenCompras.Where(o=>o.Visible == true && o.CompraId == Buscado).AsNoTracking().ToList();
        }

        
    }
        
    
}
