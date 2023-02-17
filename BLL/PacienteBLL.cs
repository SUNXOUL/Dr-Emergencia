using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class PacienteBLL
    {
    private Contexto _contexto;
    public PacienteBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(Paciente Paciente)
    {
        if (!Existe(Paciente.PacienteID))
            return Insertar(Paciente);
        else
            return Modificar(Paciente);
    }

    public bool Existe(int PacienteID)
    {
        return _contexto.Paciente.Any(o => o.PacienteID == PacienteID);
    }

    private bool Insertar(Paciente Paciente)
    {
        _contexto.Paciente.Add(Paciente);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    private bool Modificar(Paciente Paciente)
    {
        _contexto.Entry(Paciente).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }
    
    public List<Paciente> GetPaciente()
    {
        return _contexto.Paciente.ToList();
    }

        public bool Eliminar(Paciente Paciente)
        {
            Console.WriteLine("eliminado");
            _contexto.Entry(Paciente).State=EntityState.Deleted;
            return _contexto.SaveChanges()>0;
        }   

        public Paciente? Buscar(int PacienteID)
        {
            return _contexto.Paciente
                    .Where(o => o.PacienteID==PacienteID).AsNoTracking().SingleOrDefault();
                    
        }
        public List<Paciente> GetList()
        {
            return _contexto.Paciente.AsNoTracking().ToList();
        }
    }
}