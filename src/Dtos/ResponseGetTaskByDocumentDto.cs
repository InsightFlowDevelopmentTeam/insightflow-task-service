using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.src.Dtos
{
    /// <summary>
    /// Dto de respuesta utilizado para obtener una tarea asociada a un documento específico.
    /// Proporciona información resumida de la tarea.
    /// </summary>
    public class ResponseGetTaskByDocumentDto
    {
        /// <summary>
        /// Identificador único de la tarea.
        /// </summary>
        /// <remarks>
        public Guid Id {get; set;}

        /// <summary>
        /// Identificador único del usuario asignado a la tarea.
        /// </summary>
        public Guid UserId {get; set;}

        /// <summary>
        /// Título de la tarea.
        /// </summary>
        public string Title {get; set;} = string.Empty!;

        /// <summary>
        /// Estado actual de la tarea.
        /// </summary>
        public string State {get; set;} = string.Empty!;

        /// <summary>
        /// Fecha de finalización de la tarea.
        /// </summary>
        public string ExpirationDate {get;set;} = string.Empty!;

        /// <summary>
        /// Indica si tarea esta activa o no (Soft Delete).
        /// </summary> 
        public bool IsActive {get; set;} = true; 
    }
}