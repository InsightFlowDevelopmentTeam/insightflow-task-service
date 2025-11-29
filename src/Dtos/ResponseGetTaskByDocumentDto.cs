using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskService.src.Dtos
{
    public class ResponseGetTaskByDocumentDto
    {
        public Guid Id {get; set;} = Guid.NewGuid();

        public Guid UserId {get; set;}

        public string Title {get; set;} = string.Empty!;

        public string State {get; set;} = string.Empty!;

        public string ExpirationDate {get;set;} = string.Empty!;
    }
}