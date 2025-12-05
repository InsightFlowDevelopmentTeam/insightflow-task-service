using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskService.src.Dto;
using TaskService.src.Dtos;

namespace TaskService.src.Interface
{
    /// <summary>
    /// Interfaz del repositorio de tareas
    /// Define la forma en que se obtiene y gestiona la informacion de tareas
    /// </summary>
    public interface ITaskRepository
    {
        /// <summary>
        /// Crea una nueva tarea en el sistema.
        /// </summary>
        /// <param name="request">
        /// Dto con la información necesaria para crear la tarea.
        /// </param>
        /// <returns>Un 
        /// ResponseCreateTaskDto con los datos de la tarea recién creada.
        /// </returns>
        public ResponseCreateTaskDto CreateTask (CreateTaskDto request);

        /// <summary>
        /// Obtiene todas las tareas asociadas a un documento específico.
        /// </summary>
        /// <param name="DocumentId">
        /// Identificador del documento.
        /// </param>
        /// <returns>
        /// Lista de ResponseGetTaskByDocumentDto que representan las tareas asociadas al documento.
        /// </returns>
        public List<ResponseGetTaskByDocumentDto> GetTaskByDocumentId (Guid DocumentId);

        /// <summary>
        /// Obtiene una tarea específica mediante su identificador único.
        /// </summary>
        /// <param name="Id">
        /// Identificador de la tarea.
        /// </param>
        /// <returns>
        /// Un ResponseGetTaskDto con la información detallada de la tarea, 
        /// o <c>null</c> si la tarea no existe.
        /// </returns>
        public ResponseGetTaskDto? GetTaskById (Guid Id);

        /// <summary>
        /// Edita los datos de una tarea existente.
        /// </summary>
        /// <param name="Id">
        /// Identificador de la tarea a editar.
        /// </param>
        /// <param name="request">
        /// Dto con los datos actualizados.
        /// </param>
        /// <returns>
        /// Un ResponseEditTaskDto con la información actualizada de la tarea.
        /// </returns>
        public ResponseEditTaskDto EditTask(Guid Id, EditTaskDto request);

        /// <summary>
        /// Alterna el estado de papelera (activo/inactivo) de una tarea (implememntado como soft delete).
        /// </summary>
        /// <param name="Id">
        /// Identificador de la tarea.
        /// </param>
        /// <returns>
        /// <c>true</c> si la operación fue exitosa; de lo contrario, <c>false</c>.
        /// </returns>
        public bool ToggleTrashCan(Guid Id);
    }
}