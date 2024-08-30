using System;
using System.Collections.Generic; // Necesario para List<>

namespace TodoApp.interfaces
{
    public class TaskItem
    {
        public string Id { get; set; } // Identificador de la tarea
        public string Title { get; set; } // Título de la tarea
        public DateTime TaskCreate { get; set; } // Fecha de creación de la tarea
        public List<SubTask> SubTasks { get; set; } = new List<SubTask>(); // Lista de subtareas

        public TaskItem()
        {
            // Constructor por defecto
        }
    }

    public class SubTask
    {
        public string Id { get; set; } // Identificador de la subtarea
        public string Title { get; set; } // Título de la subtarea
        public string Description { get; set; } // Descripción de la subtarea
        public bool IsCompleted { get; set; } // Estado de la subtarea

        public SubTask()
        {
            // Constructor por defecto
        }
    }
}
