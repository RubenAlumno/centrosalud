using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gestor
    {
        centrosaludEntities contexto = new centrosaludEntities();
        public string addPaciente(paciente paciente)
        {
            if (paciente == null)
            {
                return "El paciente está vacia";
            }
            if (String.IsNullOrWhiteSpace(paciente.nombreCompleto) || String.IsNullOrWhiteSpace(paciente.direccion) || String.IsNullOrWhiteSpace(paciente.telefono) || String.IsNullOrWhiteSpace(paciente.localidad))
            {
                return "Te faltan datos";
            }
            try
            {
                var nombre = contexto.pacientes.ToList().Where(pac => pac.nombreCompleto.ToUpper() == paciente.nombreCompleto.ToUpper()).ToList();
                if (nombre.Count() != 0)
                {
                    return "Ya existe este paciente en la BD";
                }
            }
            catch (Exception exc)
            {
                return "Error en la BD por favor contacte con un Administrador del Programa.";
            }
            try
            {
                
           
                contexto.pacientes.Add(paciente);
                int numero = contexto.SaveChanges();
                if (numero != 0)
                {
                    return "";
                }
                else
                {
                    return "Error al añadir el paciente";
                }
            }
            catch (Exception exc)
            {
                return "Error al añadir paciente: " + exc.Message;
            }
        }
        public string addMedico(especialista medico)
        {
            if (medico == null)
            {
                return "El medico está vacia";
            }
            if (String.IsNullOrWhiteSpace(medico.nombre) || String.IsNullOrWhiteSpace(medico.telefono))
            {
                return "Te faltan datos";
            }
            try
            {
                var nombre = contexto.especialistas.ToList().Where(med => med.nombre.ToUpper() == medico.nombre.ToUpper()).ToList();
                if (nombre.Count() != 0)
                {
                    return "Ya existe este medico en la BD";
                }
            }
            catch (Exception exc)
            {
                return "Error en la BD por favor contacte con un Administrador del Programa.";
            }
            try
            {
                contexto.especialistas.Add(medico);
                int numero = contexto.SaveChanges();
                if (numero != 0)
                {
                    return "";
                }
                else
                {
                    return "Error al añadir el medico";
                }
            }
            catch (Exception exc)
            {
                return "Error al añadir medico: " + exc.Message;
            }
        }
        public string buscarMedicoPorID(string id)
        {
            if (int.TryParse(id, out int numero))
            {
                try
                {
                    var paciente = contexto.especialistas.ToList().Where(med => med.id == numero).ToList();
                    if (paciente.Count() != 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Error no ha sido encontrado ningún medico con esa id";
                    }
                }
                catch (Exception exc)
                {

                    return "Error en la BD por favor contacte con un Administrador del Programa.";
                }
            }
            else
            {
                return "Error no pusiste un numero en la ID";
            }
        }

        public List<cita> buscarCitasPorMedico(string nombre, DateTime dtpFecha)
        {
            List<cita> citas = new List<cita>();
            int id = buscarIdMedico(nombre);
            try
            {
                var citasBuscadas = contexto.citas.ToList().Where(cit => cit.especialistashacenespecialidade.especialista.id == id && cit.fecha == dtpFecha).ToList();
                citas = citasBuscadas;
                return citas;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public List<cita> buscarCitasPorPaciente(string nombre)
        {
            List<cita> citas = new List<cita>();
            int id = buscarIdPaciente(nombre);
            try
            {
                var citasBuscadas = contexto.citas.ToList().Where(cit => cit.idpaciente == id).ToList();
                citas = citasBuscadas;
                return citas;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public paciente buscarDatosPaciente(string idString)
        {
            paciente paciente;
            int id = int.Parse(idString);
            try
            {
                var pacienteBuscado = contexto.pacientes.ToList().Where(pac => pac.id == id).ToList();
                paciente = pacienteBuscado[0];
                return paciente;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public especialista buscarDatosMedico(string idString)
        {
            especialista especialista;
            int id = int.Parse(idString);
            try
            {
                var especialistaBuscado = contexto.especialistas.ToList().Where(esp => esp.id == id).ToList();
                especialista = especialistaBuscado[0];
                return especialista;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public string borrarCita(cita miCita)
        {
            try
            {
                contexto.citas.Remove(miCita);
                int numero = contexto.SaveChanges();
                if (numero != 0)
                {
                    return "";
                }
                else
                {
                    return "Error al eliminar la cita";
                }
            }
            catch (Exception exc)
            {
                return "Error en la BD: " + exc.Message;
            }
            

        }

        public cita buscarCita(DateTime time, int idMedico, TimeSpan horaTime)
        {
            try
            {
                var fechaExiste = (from cita in contexto.citas
                                   where cita.fecha == time && cita.especialistashacenespecialidade.especialista.id == idMedico && cita.hora == horaTime
                                   select cita).ToList();
                if (fechaExiste.Count() != 0)
                {
                    return fechaExiste[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public string buscarPacientoPorID(string id)
        {
            if(int.TryParse(id,out int numero))
            {
                try
                {
                    var paciente = contexto.pacientes.ToList().Where(pac => pac.id == numero).ToList();
                    if (paciente.Count() != 0)
                    {
                        return "";      
                    }
                    else
                    {
                        return "Error no ha sido encontrado ningún paciente con esa id";
                    }
                }
                catch (Exception exc)
                {
                    
                    return "Error en la BD por favor contacte con un Administrador del Programa.";
                }
            }
            else
            {
                return "Error no pusiste un numero en la ID";
            }
        }

        public string buscarPacientoPorNombre(string nombre)
        {
                try
                {
                    var paciente = contexto.pacientes.ToList().Where(pac => pac.nombreCompleto.ToUpper() == nombre.ToUpper()).ToList();
                    if (paciente.Count() != 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Error no ha sido encontrado ningún paciente con ese nombre";
                    }
                }
                catch (Exception exc)
                {

                    return "Error en la BD por favor contacte con un Administrador del Programa.";
                }
        }

        public string buscarMedicoPorNombreBuscador(string nombre)
        {
            try
            {
                var medico = contexto.especialistas.ToList().Where(esp => esp.nombre.ToUpper() == nombre.ToUpper()).ToList();
                if (medico.Count() != 0)
                {
                    return "";
                }
                else
                {
                    return "Error no ha sido encontrado ningún medico con ese nombre";
                }
            }
            catch (Exception exc)
            {

                return "Error en la BD por favor contacte con un Administrador del Programa.";
            }
        }
        public especialista encontradoMedicoPorID(string id)
        {
            if (int.TryParse(id, out int numero))
            {
                try
                {
                    var medico = contexto.especialistas.ToList().Where(med => med.id == numero).ToList();
                    if (medico.Count() != 0)
                    {
                        return medico[0];
                    }
                    else
                    {
                        especialista medicoVacio = new especialista("Error no ha sido encontrado ningún paciente con esa id","Error");
                        return medicoVacio;
                    }
                }
                catch (Exception exc)
                {
                    especialista medicoVacio = new especialista("Error en la BD por favor contacte con un Administrador del Programa.", "Error");
                    return medicoVacio;
                }
            }
            else
            {
                especialista medicoVacio = new especialista("Error no pusiste un numero en la ID", "Error");
                return medicoVacio;
            }
        }
        public paciente encontradoPacientoPorID(string id)
        {
            if (int.TryParse(id, out int numero))
            {
                try
                {
                    var paciente = contexto.pacientes.ToList().Where(pac => pac.id == numero).ToList();
                    if (paciente.Count() != 0)
                    {
                        return paciente[0];
                    }
                    else
                    {
                        paciente pacienteVacio = new paciente("Error no ha sido encontrado ningún paciente con esa id", "Error", "Error", "Error");
                        return pacienteVacio;
                    }
                }
                catch (Exception exc)
                {
                    paciente pacienteVacio = new paciente("Error en la BD por favor contacte con un Administrador del Programa.", "Error", "Error", "Error");
                    return pacienteVacio;
                }
            }
            else
            {
                paciente pacienteVacio = new paciente("Error no pusiste un numero en la ID", "Error", "Error", "Error");
                return pacienteVacio;
            }
        }
        public paciente encontradoPacientoPorNombre(string nombre)
        {
                try
                {
                    var paciente = contexto.pacientes.ToList().Where(pac => pac.nombreCompleto.ToUpper() == nombre.ToUpper()).ToList();
                    if (paciente.Count() != 0)
                    {
                        return paciente[0];
                    }
                    else
                    {
                        paciente pacienteVacio = new paciente("Error no ha sido encontrado ningún paciente con ese nombre", "Error", "Error", "Error");
                        return pacienteVacio;
                    }
                }
                catch (Exception exc)
                {
                    paciente pacienteVacio = new paciente("Error en la BD por favor contacte con un Administrador del Programa.", "Error", "Error", "Error");
                    return pacienteVacio;
                }
        }
        public especialista encontradoMedicoPorNombre(string nombre)
        {
            try
            {
                var medico = contexto.especialistas.ToList().Where(med => med.nombre.ToUpper() == nombre.ToUpper()).ToList();
                if (medico.Count() != 0)
                {
                    return medico[0];
                }
                else
                {
                    especialista especialistaVacio = new especialista("Error no ha sido encontrado ningún medico con ese nombre", "Error");
                    return especialistaVacio;
                }
            }
            catch (Exception exc)
            {
                especialista especialistaVacio = new especialista("Error en la BD por favor contacte con un Administrador del Programa.", "Error");
                return especialistaVacio;
            }
        }
        public paciente buscarPacientePorNombre(string nombre)
        {
            try
            {
                var paciente = contexto.pacientes.ToList().Where(pac => pac.nombreCompleto.ToUpper() == nombre.ToUpper()).ToList();
                return paciente[0];
            }
            catch (Exception exc)
            {
                paciente pacienteVacio = new paciente("Fallo en la BD, contacte con el administrador","Error","Error","Error");
                return pacienteVacio;
            }
        }

        public especialista buscarMedicoPorNombre(string nombre)
        {
            try
            {
                var especialista = contexto.especialistas.ToList().Where(esp => esp.nombre.ToUpper() == nombre.ToUpper()).ToList();
                return especialista[0];
            }
            catch (Exception exc)
            {
                especialista especialistaVacio = new especialista("Fallo en la BD, contacte con el administrador","Error");
                return especialistaVacio;
            }
        }
        public string addEspecialidad(especialidad especialidad)
        {
            if (especialidad == null)
            {
                return "La especialidad está vacia";
            }
            if (String.IsNullOrWhiteSpace(especialidad.nombre))
            {
                return "Te faltan datos";
            }
            try
            {
                var nombre = contexto.especialidads.ToList().Where(esp => esp.nombre.ToUpper() == especialidad.nombre.ToUpper()).ToList();
                if (nombre.Count() != 0)
                {
                    return "Ya existe esta especialidad en la BD";
                }
            }
            catch (Exception exc)
            {
                return "Error en la BD por favor contacte con un Administrador del Programa.";
            }
            try
            {
                contexto.especialidads.Add(especialidad);
                int numero = contexto.SaveChanges();
                if (numero != 0)
                {
                    return "";
                }
                else
                {
                    return "Error al añadir la especialidad";
                }
            }
            catch (Exception exc)
            {
                return "Error al añadir especialidad: " + exc.Message;
            }
        }

        public string updatePaciente(paciente pacienteElegido)
        {
            if (pacienteElegido == null)
            {
                return "El paciente está vacio";
            }
            if (String.IsNullOrWhiteSpace(pacienteElegido.nombreCompleto)|| String.IsNullOrWhiteSpace(pacienteElegido.direccion)|| String.IsNullOrWhiteSpace(pacienteElegido.localidad)|| String.IsNullOrWhiteSpace(pacienteElegido.telefono))
            {
                return "Te faltan datos";
            }
            try
            {
                int numero = contexto.SaveChanges();
                if (numero != 0)
                {
                    return "";
                }
                else
                {
                    return "Error al actualizar el paciente";
                }
            }
            catch (Exception exc)
            {
                return "Error al actualizar el paciente: " + exc.Message;
            }
        }

        public string updateEspecialista(especialista especialistaElegido)
        {
            if (especialistaElegido == null)
            {
                return "El paciente está vacio";
            }
            if (String.IsNullOrWhiteSpace(especialistaElegido.nombre) || String.IsNullOrWhiteSpace(especialistaElegido.telefono))
            {
                return "Te faltan datos";
            }
            try
            {
                int numero = contexto.SaveChanges();
                if (numero != 0)
                {
                    return "";
                }
                else
                {
                    return "Error al actualizar el medico";
                }
            }
            catch (Exception exc)
            {
                return "Error al actualizar el medico: " + exc.Message;
            }
        }

        public string updateEspecialidad(especialidad especialidadElegida)
        {
            if (especialidadElegida == null)
            {
                return "La especialidad está vacio";
            }
            if (String.IsNullOrWhiteSpace(especialidadElegida.nombre))
            {
                return "Te faltan datos";
            }
            try
            {
                int numero = contexto.SaveChanges();
                if (numero != 0)
                {
                    return "";
                }
                else
                {
                    return "Error al actualizar el medico";
                }
            }
            catch (Exception exc)
            {
                return "Error al actualizar el medico: " + exc.Message;
            }
        }
        public especialidad buscarEspecialidadPorNombre(String nombre)
        {
            try
            {
                var especialidad = contexto.especialidads.ToList().Where(esp => esp.nombre.ToUpper() == nombre.ToUpper()).ToList();
                return especialidad[0];
            }
            catch (Exception exc)
            {
                especialidad especialidadVacio = new especialidad("Fallo en la BD, contacte con el administrador");
                return especialidadVacio;
            }
            
        }

        public List<especialista> AllEspecialistas()
        {
            try
            {
                return contexto.especialistas.ToList();
            }
            catch (Exception exc)
            {
                List<especialista> especilistas = new List<especialista>();
                especilistas.Add(new especialista("Fallo en la BD, contacte con el administrador", "Error"));
                return especilistas;
            }
            
        }
        public List<paciente> AllPacientes()
        {
            try
            {
                return contexto.pacientes.ToList();
            }
            catch (Exception exc)
            {
                List<paciente> pacientes = new List<paciente>();
                pacientes.Add(new paciente("Fallo en la BD, contacte con el administrador", "Error","Error","Error"));
                return pacientes;
            }
            
        }

        public int buscarIdPaciente(string nombre)
        {
            try
            {
                var paciente = (from pac in contexto.pacientes
                                where pac.nombreCompleto.ToUpper() == nombre.ToUpper()
                                select pac.id).ToList();
                return paciente[0];
            }
            catch (Exception exc)
            {
                return 1;
            }
            
        }
        public int buscarIdEspecialidad(String nombre)
        {
            try
            {
                var especialidad = (from esp in contexto.especialidads
                              where esp.nombre.ToUpper() == nombre.ToUpper()
                              select esp.id).ToList();
                return especialidad[0];
            }
            catch (Exception exc)
            {
                return 1;
            }
        }

        public int buscarIdMedico(String nombre)
        {
            try
            {
                var medico = (from med in contexto.especialistas
                              where med.nombre.ToUpper() == nombre.ToUpper()
                              select med.id).ToList();
                return medico[0];
            }
            catch (Exception exc)
            {
                return 1;
            }
        }

        public string addCita(cita nueva)
        {
            if (nueva == null)
            {
                return "Los datos están vacios";
            }
            try
            {
                //contexto.especialista[especialidad.]
                contexto.citas.Add(nueva);
                int numero = contexto.SaveChanges();
                if (numero != 0)
                {
                    return "";
                }
                else
                {
                    return "Error al añadir la especialidad al medico";
                }
            }
            catch (Exception exc)
            {
                return "Error al añadir especialidad al medico: " + exc.Message;
            }
        }

        public especialistashacenespecialidade buscarEspecialitasHacenEspecialidadesPorID(int idMedico, int idEspecialidad)
        {
            try
            {
                var especialidadHacen = contexto.especialistashacenespecialidades.ToList().Where(esp => esp.idespecialista == idMedico && esp.idespecialidad == idEspecialidad).ToList();
                return especialidadHacen[0];
            }
            catch (Exception exc)
            {
                especialistashacenespecialidade especialistashacenespecialidade = new especialistashacenespecialidade(new especialidad("Error en la BD, por favor contacte con un administrador"), new especialista("Error en la BD, por favor contacte con un administrador", "Error"));
                return especialistashacenespecialidade;
            }
            
        }

        public List<especialidad> AllEspecialidades()
        {
            try
            {
                return contexto.especialidads.ToList();
            }
            catch (Exception exc)
            {
                List<especialidad> especialidades = new List<especialidad>();
                especialidades.Add(new especialidad("Fallo en la BD, contacte con el administrador"));
                return especialidades;
            }
            
        }
        public especialista selectMedicoID(String nombre)
        {
            try
            {
                var idLeido = (from med in contexto.especialistas
                               where med.nombre.ToUpper() == nombre.ToUpper()
                               select med).ToList();
                List<especialista> medico = idLeido;
                return medico[0];
            }
            catch (Exception exc)
            {
                especialista especialista = new especialista("Fallo en la BD, contacte con el administrador","Error");
                return especialista;
            }
            
        }

        public string comprobarFecha(DateTime time, int idMedico, TimeSpan horaExacta)
        {
            try
            {
                var fechaExiste = (from cita in contexto.citas
                                   where cita.fecha == time && cita.especialistashacenespecialidade.especialista.id == idMedico && cita.hora == horaExacta
                                   select cita).ToList();
                if (fechaExiste.Count() != 0)
                {
                    return "La cita ya esta ocupada por otra persona por favor eliga otra hora, o fecha";
                }
            }
            catch (Exception exc)
            {
                return "Error en la BD por favor contacte con un Administrador del Programa.";
            }  
            if(horaExacta.Hours <8 || horaExacta.Hours > 15)
            {
                return "No puede pedir una cita fuera de las horas habituales, pida una de las 8:00 a las 15:00 ambas incluidas";
            }
            if (time.DayOfWeek.ToString() == "Saturday" || time.DayOfWeek.ToString() == "Sunday")
            {
                return "No puede pedir una cita un Sabado o un Domingo, debe pedirlas de lunes a viernes";
            }
            if(time == DateTime.Today)
            {
                if(horaExacta.Hours < DateTime.Now.Hour || horaExacta.Hours == DateTime.Now.Hour && horaExacta.Minutes < DateTime.Now.Minute)
                {
                    return "No puede pedir una cita en una hora que ya ha pasado";
                }
            }
            return "";
        }

        public especialidad selectEspecialidadID(String nombre)
        {
            try
            {
                var idLeido = (from esp in contexto.especialidads
                               where esp.nombre.ToUpper() == nombre.ToUpper()
                               select esp).ToList();
                List<especialidad> especialidad = idLeido;
                return especialidad[0];
            }
            catch (Exception exc)
            {
                especialidad especialidad = new especialidad("Error en la BD, por favor contacte con el administrador");
                return especialidad;
            }
            
        }
        public string addEspecialidadMedico(especialistashacenespecialidade especialistasHacenEspecialidades)
        {
            if (especialistasHacenEspecialidades == null)
            {
                return "Los datos están vacios";
            }
            try
            {
                var datos = contexto.especialistashacenespecialidades.ToList().Where(esp => esp.especialidad == especialistasHacenEspecialidades.especialidad && esp.especialista == especialistasHacenEspecialidades.especialista).ToList();
                if (datos.Count() != 0)
                {
                    return "Este medico ya tiene esta especialidad";
                }
            }
            catch (Exception exc)
            {
                return "Error en la BD por favor contacte con un Administrador del Programa.";
            }
            
            try
            {
                //contexto.especialista[especialidad.]
                especialista miespecialista = especialistasHacenEspecialidades.especialista;
                especialistasHacenEspecialidades.id = contexto.especialistashacenespecialidades.Count();
                miespecialista.especialistashacenespecialidades.Add(especialistasHacenEspecialidades);
                contexto.Entry(miespecialista).State = System.Data.Entity.EntityState.Modified;
                int numero = contexto.SaveChanges();
                if (numero != 0)
                {
                    return "";
                }
                else
                {
                    return "Error al añadir la especialidad al medico";
                }
            }
            catch (Exception exc)
            {
                return "Error al añadir especialidad al medico: " + exc.Message;
            }
        }
        public List<string> buscarMedicos(especialidad especialidadElegida)
        {
            List<string> especialistas = new List<string>();
            try
            {
                var medicosConEspecialidad = contexto.especialistashacenespecialidades.ToList().Where(esp => esp.idespecialidad == especialidadElegida.id).ToList();
                foreach (especialistashacenespecialidade medicoEspecialidad in medicosConEspecialidad)
                {
                    foreach (especialista medico in contexto.especialistas)
                    {
                        if (medico.id == medicoEspecialidad.idespecialista)
                        {
                            especialistas.Add(medico.nombre);
                            break;
                        }
                    }
                }
                return especialistas;
            }
            catch (Exception exc)
            {
                especialistas.Add("Error en la BD,por favor contacte con un administrador");
                return especialistas;
            }
            
        }
    }
}
