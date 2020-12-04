using System;
using System.Collections.Generic;
using System.Text;
namespace ITLA.Core.Entidades
{
    public class Tarea
    {
        public int Alumno_ID { get; set; }
        public int ID_Tarea { get; set; }
        public DateTime Fecha_Hora_Tarea { get; set; }
        public string Descripcion { get; set; }
    }
}
