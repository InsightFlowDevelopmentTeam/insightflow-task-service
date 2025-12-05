using System;
using System.Collections.Generic;
using System.Linq;
using TaskService.src.Dto;
using TaskService.src.Dtos;
using TaskService.src.Model;

namespace TaskService.src.Mapper
{
    /// <summary>
    /// Clase estática que contiene métodos de extensión para mapear
    /// entidades TaskModel a sus respectivos Dtos de respuesta.
    /// </summary>

    public static  class TaskMappers
    {
        /// <summary>
        /// Convierte un TaskModel en un ResponseCreateTaskDto.
        /// </summary>
        /// <param name="task">
        /// La tarea que se desea convertir.
        /// </param>
        /// <returns>
        /// Un Dto con los datos generados tras la creación de la tarea.
        /// </returns>

        public static ResponseCreateTaskDto ToCreateTaskResponse(this TaskModel task)
        {
            return new ResponseCreateTaskDto
            {
                Id  = task.Id,
                DocumentId = task.DocumentId,
                UserId = task.UserId,
                Title = task.Title,
                CompleteDescription = task.CompleteDescription,
                State = task.State,
                ExpirationDate = task.ExpirationDate
            };
        }

         /// <summary>
        /// Convierte un TaskModel en un ResponseGetTaskDto
        /// </summary>
        /// <param name="task">
        /// La tarea que se desea convertir.
        /// </param>
        /// <returns>
        /// Un Dto con los datos mapeados de la tarea.
        /// </returns>
        public static ResponseGetTaskDto ToGetTaskResponse (this TaskModel task)
        {
            return  new ResponseGetTaskDto
            {
                UserId = task.UserId,
                Title = task.Title,
                CompleteDescription = task.CompleteDescription,
                State = task.State,
                ExpirationDate = task.ExpirationDate,
                Comments = task.Comments

            };
        }

        /// <summary>
        /// Convierte un TaskModel en un ResponseEditTaskDto
        /// para la obtención de una tarea luego de ser editada.
        /// </summary>
        /// <param name="task">
        /// La tarea que se desea convertir.
        /// </param>
        /// <returns>
        /// Un Dto con la información actualizada de la tarea.
        /// </returns>
        public static ResponseEditTaskDto ToGetEditResponse (this TaskModel task)
        {
            return  new ResponseEditTaskDto
            {
                Id = task.Id,
                UserId = task.UserId,
                Title = task.Title,
                CompleteDescription = task.CompleteDescription,
                State = task.State,
                ExpirationDate = task.ExpirationDate,
                Comments = task.Comments

            };
        }
    }
}