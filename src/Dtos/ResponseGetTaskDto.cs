using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.src.Dtos
{
    /// <summary>
    /// Dto de respuesta utilizado para obtener una tarea.
    /// Proporciona toda la información relevante asociada a una tarea específica.
    /// </summary>
    public class ResponseGetTaskDto
    {    
        /// <summary>
        /// Identificador único del usuario asignado a la tarea.
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
        /// Este campo puede ser nulo.
        /// </remarks>
        public string? CompleteDescription{get; set;}
        
        /// <summary>
        /// Estado actual de la tarea.
        /// </summary>
        public string State {get; set;} = string.Empty!;

        /// <summary>
        /// Fecha de finalización de la tarea.
        /// </summary>
        public string ExpirationDate {get;set;} = string.Empty!;

        /// <summary>
        /// Comentarios de la tarea.
        /// </summary>
        public string? Comments {get;set;} 
    }
}