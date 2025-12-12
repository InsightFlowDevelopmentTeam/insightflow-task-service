using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TaskService.src.Dto;
using TaskService.src.Dtos;
using TaskService.src.Interface;

namespace TaskService.src
{
    // <summary>
    /// Controlador encargado de CRUD de tareas 
    /// </summary>
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        /// <summary>
        /// Constructor del controlador que inyecta el repositorio de tareas.
        /// </summary>
        /// <param name="taskRepository">
        /// Repositorio encargado de manejar la lógica de acceso a datos para tareas.
        /// </param>
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        /// <summary>
        /// Crea una nueva tarea en el sistema.
        /// </summary>
        /// <param name="request">
        /// Dto con datos necesarios para crear la tarea.
        /// </param>
        /// <returns>
        /// Un objeto IActionResult que contiene un mensaje de confirmación
        /// y los datos de la tarea creada.
        /// </returns>
        [HttpPost("tasks")]
        public IActionResult CreateTask(CreateTaskDto request)
        {
            try
            {

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result =  _taskRepository.CreateTask(request);

                return Ok(new
                {
                    message = "Tarea creada con exito",
                    Task = result
                });
                
            }
            catch (Exception e)
            {
                return StatusCode(500, new { message = e.Message });
            }
        }

        /// <summary>
        /// Obtiene todas las tareas asociadas a un documento específico.
        /// </summary>
        /// <param name="documentId">
        /// Identificador único del documento.
        /// </param>
        /// <returns>
        /// Un objeto IActionResult que contiene las tareas encontradas.
        /// </returns>
        [HttpGet("documents/{documentId}/tasks")]
        public IActionResult GetTaskByDocumentId(Guid documentId)
        {
            try
            {
                
                var tasks = _taskRepository.GetTaskByDocumentId(documentId);

                var response = new
                {
                    message = "Tareas Obtenidas con exito",
                    Tasks = tasks
                };

                return Ok(response);
            }
            catch (Exception e)
            {
                
                return StatusCode(500, new { message = e.Message });
            }
        }

        /// <summary>
        /// Obtiene una tarea específica según su identificador único.
        /// </summary>
        /// <param name="Id">
        /// Identificador único de la tarea.
        /// </param>
        /// <returns>
        /// Un objeto IActionResult con la tarea solicitada, 
        /// o un error si no se encuentra.
        /// </returns>
        [HttpGet("tasks/{Id}")]
        public IActionResult GetTaskById (Guid Id)
        {
            try
            {
                var task = _taskRepository.GetTaskById(Id);

                if(task == null)
                {
                    return NotFound("Error: Tarea no encontrada");
                }

                var response = new
                {
                    message = "Tareas Obtenidas con exito",
                    Task = task
                };

                return Ok(response);
            }
            catch (Exception e)
            {
                
                return StatusCode(500, new { message = e.Message });
            }
        }

        /// <summary>
        /// Edita una tarea existente mediante su identificador único.
        /// </summary>
        /// <param name="Id">
        /// Identificador único de la tarea a editar.
        /// </param>
        /// <param name="request">
        /// Dto con los datos con los cambios a aplicar.
        /// </param>
        /// <returns>
        /// Un objeto IActionResult que contiene los datos de la tarea editada.
        /// </returns>
        [HttpPut("tasks/{Id}")]
        public IActionResult EditTask(Guid Id, EditTaskDto request)
        {
            try
            {

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result =  _taskRepository.EditTask(Id,request);

                return Ok(new
                {
                    message = "Tarea Editada con exito",
                    Task = result
                });
                
            }
            catch (Exception e)
            {
                return StatusCode(500, new { message = e.Message });
            }
        }

        /// <summary>
        /// Cambia el estado de una tarea entre activa y papelera (Soft Delete).
        /// </summary>
        /// <param name="Id">
        /// Identificador único de la tarea.
        /// </param>
        /// <returns>
        /// Un objeto IActionResult con un mensaje indicando el nuevo estado.
        /// </returns>
        [HttpPatch("tasks/{Id}")]
        public IActionResult ToggleTrashCan(Guid Id)
        {
            try
            {

                var result =  _taskRepository.ToggleTrashCan(Id);

                return Ok(new
                {
                    message = result ? "Tarea restaurada" : "Tarea enviada a papelera",
                    isActive = result
                });
                
            }
            catch (Exception e)
            {
                return StatusCode(500, new { message = e.Message });
            }
        }




    }
}