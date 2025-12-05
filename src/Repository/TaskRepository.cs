using System;
using System.Collections.Generic;
using System.Linq;
using TaskService.src.Data;
using TaskService.src.Dto;
using TaskService.src.Dtos;
using TaskService.src.Interface;
using TaskService.src.Mapper;
using TaskService.src.Model;

namespace TaskService.src.Repository
{
    /// <summary>
    /// Implementacion de patron Repository utilizado para encapsular las operaciones con la clase contenedora
    /// Maneja el acceso a datos y lógica de negocio para las tareas
    /// </summary>
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskContainer _container;

        /// <summary>
        /// Constructor del repositorio de tareas
        /// </summary>
        /// <param name="container">Contexto de la clase contenedora para operaciones </param>
        public TaskRepository(TaskContainer container)
        {
            _container = container;
        }

        /// <summary>
        /// Crea una nueva tarea en el sistema.
        /// </summary>
        /// <param name="request">
        /// Dto con la información necesaria para crear la tarea.
        /// </param>
        /// <returns>Un 
        /// ResponseCreateTaskDto con los datos de la tarea recién creada.
        /// </returns>
        public ResponseCreateTaskDto CreateTask(CreateTaskDto request)
        {
            var TaskRequest = new TaskModel
            {
                DocumentId = request.DocumentId,
                UserId = request.UserId,
                Title = request.Title,
                CompleteDescription = request.CompleteDescription,
                State = request.State,
                ExpirationDate = request.ExpirationDate

            };

            _container.Tasks.Add(TaskRequest);

            return TaskRequest.ToCreateTaskResponse();
        }

        /// <summary>
        /// Obtiene todas las tareas asociadas a un documento específico.
        /// </summary>
        /// <param name="DocumentId">
        /// Identificador del documento.
        /// </param>
        /// <returns>
        /// Lista de ResponseGetTaskByDocumentDto que representan las tareas asociadas al documento.
        /// </returns>
        public List<ResponseGetTaskByDocumentDto> GetTaskByDocumentId(Guid DocumentId)
        {
            var result = _container.Tasks.Where( t => t.DocumentId == DocumentId && t.IsActive)
            .Select(t => new ResponseGetTaskByDocumentDto
            {
                Id = t.Id,
                UserId = t.UserId,
                Title = t.Title,
                State = t.State,
                ExpirationDate = t.ExpirationDate

            }).ToList();

            return result;
        }

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
        public ResponseGetTaskDto? GetTaskById (Guid Id)
        {
            var result = _container.Tasks.FirstOrDefault(t => t.Id == Id && t.IsActive);

            if (result == null) 
            {
                return null; 
            }

            return result.ToGetTaskResponse();
        }

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
        public ResponseEditTaskDto EditTask(Guid Id, EditTaskDto request)
        {
            var exist = _container.Tasks.FirstOrDefault(t => t.Id == Id);

            if(exist == null)
            {
                throw new Exception("Error: Tarea no encontrada");
            }

            if (request.UserId.HasValue && request.UserId.Value != Guid.Empty)
            {    
                exist.UserId = request.UserId.Value;
            }

            if(!string.IsNullOrEmpty(request.Title))
            {
                exist.Title = request.Title;
            }

            if(!string.IsNullOrEmpty(request.CompleteDescription))
            {
                exist.CompleteDescription = request.CompleteDescription;
            }

            if(!string.IsNullOrEmpty(request.State))
            {
                exist.State = request.State;
            }

            if(!string.IsNullOrEmpty(request.ExpirationDate))
            {
                exist.ExpirationDate = request.ExpirationDate;
            }

            if(!string.IsNullOrEmpty(request.Comments))
            {
                exist.Comments = request.Comments;
            }

        

            return exist.ToGetEditResponse();

        }

        /// <summary>
        /// Alterna el estado de papelera (activo/inactivo) de una tarea (implememntado como soft delete).
        /// </summary>
        /// <param name="Id">
        /// Identificador de la tarea.
        /// </param>
        /// <returns>
        /// <c>true</c> si la operación fue exitosa; de lo contrario, <c>false</c>.
        /// </returns>
        public bool ToggleTrashCan(Guid Id)
        {
            var exist = _container.Tasks.FirstOrDefault(t => t.Id == Id);

            if(exist == null)
            {
                throw new Exception ("Error: Tarea no encontrada");
            }     

            exist.IsActive = !exist.IsActive;

            return exist.IsActive;

        }
    }
}