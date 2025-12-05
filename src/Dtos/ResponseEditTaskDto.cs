using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.src.Dtos
{
    /// <summary>
    /// Dto de respuesta utilizado al editar una tarea existente.
    /// Contiene la información actualizada de la tarea después de aplicar los cambios.
    /// </summary>
    public class ResponseEditTaskDto
    {
         /// <summary>
        /// Identificador único de la tarea editada.
        /// </summary>
        public Guid Id {get; set;} 

        /// <summary>
        /// Identificador único del usuario asignado a la tarea.
        /// </summary>
        public Guid UserId {get; set;}

        /// <summary>
        /// Título actualizado de la tarea.
        /// </summary>
        public string Title {get; set;} = string.Empty!;

        /// <summary>
        /// Descripción completa actualizada de la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo puede ser nulo.
        /// </remarks>
        public string? CompleteDescription {get; set;}

        /// <summary>
        /// Estado actualizado de la tarea.
        /// </summary>
        public string State {get; set;} = string.Empty!;

        /// <summary>
        /// Nueva fecha de finalización de la tarea.
        /// </summary>
        public string ExpirationDate {get;set;} = string.Empty!;

        /// <summary>
        /// Comentarios agregados durante la edición de la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo puede ser nulo.
        /// </remarks>
        public string? Comments {get;set;} 
    }
}