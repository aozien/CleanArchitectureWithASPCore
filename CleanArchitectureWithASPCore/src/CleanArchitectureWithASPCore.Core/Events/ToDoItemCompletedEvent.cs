using CleanArchitectureWithASPCore.Core.Entities;
using CleanArchitectureWithASPCore.SharedKernel;

namespace CleanArchitectureWithASPCore.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}