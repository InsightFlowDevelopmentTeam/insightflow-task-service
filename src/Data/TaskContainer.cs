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
                //Documento 1
                new TaskModel
                {
                    DocumentId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
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
                    DocumentId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
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
                    DocumentId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    UserId = Guid.Parse("a08799f8-746f-46b4-8134-2ef211fe705a"),
                    Title = "Implementar Endpoints de Users Service",
                    Comments = "Recordar validar duplicidad de emails.",
                    CompleteDescription = "Desarrollar el CRUD completo para la gestión de usuarios y conexión simulada.",
                    State = "Completado",
                    ExpirationDate = "20/01/2026",
                    IsActive = true
                },

                //Documento 2
                new TaskModel
                {
                    DocumentId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    UserId = Guid.Parse("2db519ca-4836-4e01-977f-ec518a081d54"), 
                    Title = "Desarrollo de Prototipo UI Móvil",
                    Comments = null,
                    CompleteDescription = null,
                    State = "Completado",
                    ExpirationDate = "15/02/2026", 
                    IsActive = true 
                },

                new TaskModel
                {
                    DocumentId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    UserId = Guid.Parse("9fd8ec52-3aa4-4097-86fa-2c576bc06e01"), 
                    Title = "Implementación Backend de Pagos",
                    Comments = "Integrar Stripe.",
                    CompleteDescription = null,
                    State = "En Progreso",
                    ExpirationDate = "28/02/2026",
                    IsActive = true
                },

                new TaskModel
                {
                    DocumentId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    UserId = Guid.Parse("a08799f8-746f-46b4-8134-2ef211fe705a"),
                    Title = "Documentación Técnica de API",
                    Comments = null,
                    CompleteDescription = "Generar Swagger y PDF de endpoints.",
                    State = "Pendiente",
                    ExpirationDate = "05/03/2026",
                    IsActive = true
                },

                //Documento 3
                new TaskModel
                {
                    DocumentId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    UserId = Guid.Parse("2db519ca-4836-4e01-977f-ec518a081d54"), 
                    Title = "Configuración de Base de Datos",
                    Comments = "Revisar índices.",
                    CompleteDescription = null,
                    State = "Completado",
                    ExpirationDate = "10/01/2026", 
                    IsActive = true 
                },

                new TaskModel
                {
                    DocumentId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    UserId = Guid.Parse("9fd8ec52-3aa4-4097-86fa-2c576bc06e01"), 
                    Title = "Testing de Integración Frontend",
                    Comments = null,
                    CompleteDescription = "Pruebas E2E con Cypress.",
                    State = "Pendiente",
                    ExpirationDate = "22/02/2026",
                    IsActive = true
                },

                new TaskModel
                {
                    DocumentId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    UserId = Guid.Parse("a08799f8-746f-46b4-8134-2ef211fe705a"),
                    Title = "Refactorización de Servicios de Auth",
                    Comments = "Migrar a OAuth2.",
                    CompleteDescription = null,
                    State = "En Progreso",
                    ExpirationDate = "15/03/2026",
                    IsActive = true
                }
            };
        }
    }
}