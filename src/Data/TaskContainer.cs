using System;
using System.Collections.Generic;
using System.Linq;
using TaskService.src.Model;

namespace TaskService.src.Data
{
    /// <summary>
    /// Representa un contenedor de tareas (utilizado como base de datos).
    /// </summary>
    public class TaskContainer
    {
        /// <summary>
        /// Lista que almacena todas las tareas.
        /// </summary>
        public List<TaskModel> Tasks {get; set;} = new();
    }
}