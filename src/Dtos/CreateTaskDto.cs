using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.src.Dto
{
    /// <summary>
    /// Dto utilizado para la creación de una nueva tarea.
    /// Contiene la información necesaria para registrar una tarea en el sistema.
    /// </summary>
    public class CreateTaskDto
    {

        /// <summary>
        /// Identificador unico del documento asociado a la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo es obligatorio.
        /// </remarks>
        [Required(ErrorMessage = "Id de Documento es Requerido")]
        public Guid DocumentId {get; set;} 


        /// <summary>
        /// Identificador único del usuario creador o responsable de la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo es obligatorio.
        /// </remarks>
        [Required(ErrorMessage = "Id de Usuario es Requerido")]
        public Guid UserId {get; set;}

        /// <summary>
        /// Título de la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo es obligatorio y debe describir brevemente la tarea.
        /// </remarks>
        [Required(ErrorMessage = "Titulo de Tarea es Requerido")]
        public string Title {get; set;} = string.Empty!;

        /// <summary>
        /// Descripción completa y detallada de la tarea.
        /// </summary>
        /// <remarks>
        /// Este campo es opcional.
        /// </remarks>
        public string? CompleteDescription {get; set;}

        /// <summary>
        /// Estado actual de la tarea.
        /// </summary>
        /// <remarks>
        /// Debe ser uno de los siguientes valores:
        /// <list type="bullet">
        /// <item>Pendiente</item>
        /// <item>En Progreso</item>
        /// <item>Completado</item> 
        /// </list>
        /// Este campo es obligatorio.
        /// </remarks>
        [Required(ErrorMessage = "Estado de Tarea es Requerido")]
        [RegularExpression(@"^(Pendiente|En Progreso|Completado)$", ErrorMessage = "El estado ingresado no es válido.")]
        public string State {get; set;} = string.Empty!;

        /// <summary>
        /// Fecha de finalización esperada de la tarea.
        /// </summary>
        /// <remarks>
        /// Debe estar en formato <c>dd/mm/yyyy</c>.  
        /// Este campo es obligatorio.
        /// </remarks>
        [Required(ErrorMessage = "Fecha de Finalizacion Requerida")]
        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])\/(0[1-9]|1[0-2])\/\d{4}$", ErrorMessage = "La fecha debe tener el formato dd/mm/yyyy.")]
        public string ExpirationDate {get;set;} = string.Empty!;

    }
}