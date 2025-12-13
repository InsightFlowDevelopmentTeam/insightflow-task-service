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
                    Id = Guid.Parse("2d4ca0f1-53bf-4bb9-b1ab-7270616587e6"),
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
                    Id = Guid.Parse("bbfd49d2-44fa-4e50-943e-fb74a5d05421"),
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
                    Id = Guid.Parse("270fe47e-c831-4a9f-8bd7-f85b98a56bd9"),
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
                    Id = Guid.Parse("3b025a0b-6ca8-4e3f-a0ef-2a27715246e5"),
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
                    Id = Guid.Parse("7b9de913-16f5-4b5f-82ef-e2e83bde79ad"),
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
                    Id = Guid.Parse("43a4534d-c6ce-4530-8db3-af9fca0c689b"),
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
                    Id = Guid.Parse("28b62602-7b9f-453f-a418-d5f9277144b7"),
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
                    Id = Guid.Parse("e174f3aa-8330-4c7c-8b81-82f3850885cf"),
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
                    Id = Guid.Parse("c6708f3c-2a05-4707-bff7-0cb9144e9a68"),
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