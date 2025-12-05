using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.src.Dtos
{
    /// <summary>
    /// Dto utilizado para editar una tarea existente.
    /// Contiene únicamente los campos que pueden modificarse.
    /// </summary>
    public class EditTaskDto
    {
        /// <summary>
        /// Identificador del usuario responsable de la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo es opcional. Se utiliza cuando se desea reasignar la tarea a otro usuario.
        /// </remarks>
        public Guid? UserId {get; set;}

        /// <summary>
        /// Nuevo título de la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo es opcional. Se utiliza para renombrar la tarea.
        /// </remarks>
        public string? Title {get; set;} 

        /// <summary>
        /// Nueva descripción completa de la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo es opcional.
        /// </remarks>
        public string? CompleteDescription {get; set;}

        /// <summary>
        /// Nuevo estado de la tarea.
        /// </summary>
        /// <remarks>
        /// Debe ser uno de los siguientes valores:
        /// <list type="bullet">
        /// <item>Pendiente</item>
        /// <item>En Progreso</item>
        /// <item>Completado</item>
        /// </list>
        /// Este campo es opcional.
        /// </remarks>
        [RegularExpression(@"^(Pendiente|En Progreso|Completado)$", ErrorMessage = "El estado ingresado no es válido.")]
        public string? State {get; set;} 

        /// <summary>
        /// Nueva fecha de finalización de la tarea.
        /// </summary>
        /// <remarks>
        /// Debe tener el formato <c>dd/mm/yyyy</c>.  
        /// Este campo es opcional.
        /// </remarks>
        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])\/(0[1-9]|1[0-2])\/\d{4}$", ErrorMessage = "La fecha debe tener el formato dd/mm/yyyy.")]
        public string? ExpirationDate {get;set;} 

         /// <summary>
        /// Comentarios agregados a la tarea por el usuario que la modifica.
        /// </summary>
        /// <remarks>
        /// Este campo es opcional.
        /// </remarks>
        public string? Comments {get;set;} 

    }
}