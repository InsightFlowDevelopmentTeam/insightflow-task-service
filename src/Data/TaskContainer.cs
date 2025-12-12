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
        public List<TaskModel> Tasks {get; set;} 

        public TaskContainer()
        {
            Tasks = new List<TaskModel>
            {
                new TaskModel
                {
                    DocumentId = Guid.Parse("c6257b20-d138-4806-a95c-e9c4e93961c4"),
                    UserId = Guid.Parse("2db519ca-4836-4e01-977f-ec518a081d54"), 
                    Title = "Configurar Pipeline CI/CD en GitHub Actions",
                    Comments = "Prioridad alta para el despliegue automático.",
                    CompleteDescription = "Configurar el workflow para construir la imagen Docker y subirla a Docker Hub al hacer merge a main.",
                    State = "En Progreso",
                    ExpirationDate = "19/01/2026", 
                    IsActive = true 
                },

                new TaskModel
                {
                    DocumentId = Guid.Parse("d80be803-f1f9-4aa3-ab3a-3cf641714d89"),
                    UserId = Guid.Parse("9fd8ec52-3aa4-4097-86fa-2c576bc06e01"), 
                    Title = "Diseñar Componentes de Tablero Kanban",
                    Comments = "Usar librería de Drag and Drop.",
                    CompleteDescription = "Crear las columnas visuales para Pendiente, En Progreso y Completado en el frontend.",
                    State = "Pendiente",
                    ExpirationDate = "30/01/2026",
                    IsActive = true
                },

                new TaskModel
                {
                    DocumentId = Guid.Parse("707e90a5-68b2-4618-b91a-1e50924205a2"),
                    UserId = Guid.Parse("a08799f8-746f-46b4-8134-2ef211fe705a"),
                    Title = "Implementar Endpoints de Users Service",
                    Comments = "Recordar validar duplicidad de emails.",
                    CompleteDescription = "Desarrollar el CRUD completo para la gestión de usuarios y conexión simulada.",
                    State = "Completado",
                    ExpirationDate = "20/01/2026",
                    IsActive = true
                },
            };
        }
    }
}