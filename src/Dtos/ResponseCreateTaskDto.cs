using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.src.Dto
{
    /// <summary>
    /// Dto de respuesta utilizado al crear una nueva tarea.
    /// Contiene los datos finales de la tarea registrada en el sistema.
    /// </summary>
    public class ResponseCreateTaskDto
    {
        /// <summary>
        /// Identificador único de la tarea creada.
        /// </summary>
        public Guid Id {get; set;} 

        /// <summary>
        /// Identificador único del documento asociado a la tarea.
        /// </summary>
        public Guid DocumentId {get; set;} 

        /// <summary>
        /// Identificador único del usuario creador.
        /// </summary>
        public Guid UserId {get; set;}

        /// <summary>
        /// Título de la tarea.
        /// </summary>
        public string Title {get; set;} = string.Empty!;

        /// <summary>
        /// Descripción completa de la tarea.
        /// </summary>
        /// <remarks>
        /// Puede ser nulo.
        /// </remarks>
        public string? CompleteDescription{get; set;}

         /// <summary>
        /// Estado actual de la tarea.
        /// </summary>
        public string State {get; set;} = string.Empty!;

        /// <summary>
        /// Fecha de finalización establecida para la tarea.
        /// </summary>
        /// <remarks>
        /// Se almacena como cadena en formato <c>dd/mm/yyyy</c>.
        /// </remarks>
        public string ExpirationDate {get;set;} = string.Empty!;
    }
}