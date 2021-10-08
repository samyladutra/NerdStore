using MediatR;
using System;

namespace NerdStore.Core.Messages
{
    //INotification é apenas uma interface de marcação. Ou seja, é utilizada apenas para saber o que
    //determinada classe que a implementa está entregando
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
