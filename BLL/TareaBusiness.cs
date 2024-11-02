using DAL;
using Entity.Model;
using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BLL
{
    public class TareaBusiness
    {
        private TareaDao TareaDao = new TareaDao();

        public void crearNuevaTarea(TareaEntity tarea)
        {
            try
            {
                if(tarea.Descripcion.Length <= 5)
                {
                    throw new Exception("La descripcion de la tarea debe tener mas de 5 caracteres");
                }
                if(tarea.FechaTarea < DateTime.Today)
                {
                    throw new Exception("La fecha de la tarea debe ser posterior a la fecha de hoy");
                }
                tarea.FechaRegistro = DateTime.Today;
                TareaDao.crearNuevaTarea(tarea);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void modificarTarea(int idTarea, string nuevaDescripcion, DateTime nuevaFecha)
        {
            try
            {
                if (nuevaDescripcion.Length <= 5)
                {
                    throw new Exception("La descripcion de la tarea debe tener mas de 5 caracteres");
                }
                if (nuevaFecha < DateTime.Today)
                {
                    throw new Exception("La fecha de la tarea debe ser posterior a la fecha de hoy");
                }
                TareaDao.modificarTarea(idTarea, nuevaDescripcion, nuevaFecha);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void eliminarTarea(int idTarea)
        {
            try
            {
                TareaDao.eliminarTarea(idTarea);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TareaEntity> GetAll()
        {
            try
            {
                return TareaDao.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
