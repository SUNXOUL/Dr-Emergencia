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

        public bool Existe(int PacienteId)
        {
            return _contexto.Pacientes.Any(o => o.PacienteID== PacienteId);
        }

        private bool Insertar(Paciente Paciente)
        {
            _contexto.Pacientes.Add(Paciente);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        public bool Modificar(Paciente Paciente)
        {
            _contexto.Entry(Paciente).State = EntityState.Modified;
            int cantidad = _contexto.SaveChanges();
            _contexto.Entry(Paciente).State = EntityState.Detached;
            return cantidad > 0;
        }
    
        public List<Paciente> GetPacientesDetalles()
        {
            return _contexto.Pacientes.ToList();
        }

        public bool Eliminar(Paciente Paciente)
        {
            _contexto.Entry(Paciente).State=EntityState.Deleted;
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM Paciente WHERE PacienteID={Paciente.PacienteID};");
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM Emergencia WHERE PacienteID={Paciente.PacienteID};");
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM EmergenciaA WHERE PacienteID={Paciente.PacienteID};");
            _contexto.Entry(Paciente).State = EntityState.Detached;
            return _contexto.SaveChanges()>0;
        }   

        public Paciente? Buscar(int PacienteID)
        {
            return _contexto.Pacientes
                    .Where(o => o.PacienteID==PacienteID ).AsNoTracking().SingleOrDefault();
                    
        }
        public List<Paciente> GetList()
        {
            return _contexto.Pacientes.Where(o=>o.Visible == true).AsNoTracking().ToList();
        }
        public bool hidden(Paciente Paciente)
        {
            _contexto.Entry(Paciente).State = EntityState.Modified;
            int cantidad = _contexto.SaveChanges();
            _contexto.Database.ExecuteSqlRaw($"UPDATE Pacientes SET Visible = false  WHERE PacienteID={Paciente.PacienteID}");
            _contexto.Database.ExecuteSqlRaw($"UPDATE Emergencias SET Visible = false  WHERE PacienteID={Paciente.PacienteID}");
            _contexto.Database.ExecuteSqlRaw($"UPDATE EmergenciaAs SET Visible = false  WHERE PacienteID={Paciente.PacienteID}");
            _contexto.Entry(Paciente).State = EntityState.Detached;
            return cantidad > 0;
        }

    }
}