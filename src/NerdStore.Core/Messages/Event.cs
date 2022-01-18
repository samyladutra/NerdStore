using MediatR;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NerdStore.Core.Messages
{
    //INotification é apenas uma interface de marcação. Ou seja, é utilizada apenas para saber o que
    //determinada classe que a implementa está entregando
    [NotMapped]
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}

