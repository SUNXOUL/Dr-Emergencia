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
            

            foreach(var item in compra.Detalle)
            {
                var articulo = _contexto.Articulos.Find(item.ArticuloId);
                articulo.Existencia += item.cantidad;
                
                
                
            }

            _contexto.OrdenCompras.Add(compra);

            return _contexto.SaveChanges() > 0;

        }

        private bool Modificar(OrdenCompras compra)
        {
            
            var Compra_Anterior =  _contexto.OrdenCompras
            .Where(c => c.CompraId == compra.CompraId)
            .Include(c => c.Detalle)
            .AsNoTracking().SingleOrDefault();

            //Restar inventario del detalle de la Compra_Anterior
            foreach( var item in Compra_Anterior.Detalle)
            {
                var articulo = _contexto.Articulos.Find(item.ArticuloId);
                articulo.Existencia -= item.cantidad;
                
            }

            _contexto.Database.ExecuteSqlRaw($"DELETE FROM ComprasDetalle WHERE CompraId{compra.CompraId}");

            //Sumar el nuevo inventario que ya esta modificado

            foreach(var item in compra.Detalle)
            {
                var articulo = _contexto.Articulos.Find(item.ArticuloId);

                articulo.Existencia += item.cantidad;
                

                _contexto.Entry(item).State = EntityState.Added;
            }

            _contexto.Entry(compra).State = EntityState.Modified;

            var modificado = _contexto.SaveChanges() > 0;
            _contexto.Entry(compra).State = EntityState.Detached;
            return modificado;

            
        }
        public bool Eliminar(OrdenCompras compra)
        {

            

            foreach(var item in compra.Detalle)
            {
                var articulo = _contexto.Articulos.Find(item.ArticuloId);
                articulo.Existencia -= item.cantidad;
                
            }

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
            return _contexto.OrdenCompras.Where(o => o.Visible==true).AsNoTracking().ToList();
        }

        
    }
        
    
}
