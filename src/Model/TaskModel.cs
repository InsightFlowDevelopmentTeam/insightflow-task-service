using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.src.Model
{
    /// <summary>
    /// Entidad que representa una tarea en el sistema
    /// Modelo de datos para tarea
    /// </summary>
    public class TaskModel
    {
        /// <summary>
        /// Identificador único de la tarea.
        /// </summary>
        /// <remarks>
        /// Se inicializa automáticamente con un Guid.NewGuid()/>.
        /// </remarks>
        public Guid Id {get; set;} = Guid.NewGuid();

        /// <summary>
        /// Identificador único del documento al que pertenece la tarea.
        /// </summary>
        public Guid DocumentId {get; set;} 

        /// <summary>
        /// Identificador único del usuario responsable de la tarea.
        /// </summary>
        public Guid UserId {get; set;}

        /// <summary>
        /// Título de la tarea.
        /// </summary>
        public string Title {get; set;} = string.Empty!;

        /// <summary>
        /// Comentarios adicionales asociados a la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo puede ser nulo.
        /// </remarks>
        public string? Comments {get;set;} 

        /// <summary>
        /// Descripción completa de la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo pueder ser nulo.
        /// </remarks>
        public string? CompleteDescription{get; set;}
        
        /// <summary>
        /// Estado actual de la tarea.
        /// </summary>
        /// <remarks>
        /// Puede contener valores como "Pendiente", "En Progreso" o "Completado".
        /// </remarks>
        public string State {get; set;} = string.Empty!;

        /// <summary>
        /// Fecha límite de finalización de la tarea.
        /// </summary>
        /// <remarks>
        /// Se almacena como cadena en formato <c>dd/mm/yyyy</c>.
        /// </remarks>
        public string ExpirationDate {get;set;} = string.Empty!;

        // <summary>
        /// Indica si la tarea está activa o ha sido enviada a la papelera (soft delete).
        /// </summary>
        /// <remarks>
        /// <c>true</c> indica que la tarea está activa.  
        /// <c>false</c> indica que ha sido enviada a la papelera.
        /// </remarks>
        public bool IsActive {get; set;} = true; 
    }
}