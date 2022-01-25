using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoRascunhoIniciadoEvent : Event
    {
        public Guid ClientId { get; private set; }
        public Guid PedidoId { get; private set; }

        public PedidoRascunhoIniciadoEvent(Guid clientId, Guid pedidoId)
        {
            //TODO: para caso for persistir o pedido, é necessário saber qual a raiz de agregação gravada
            AggregateId = pedidoId;
            ClientId = clientId;
            PedidoId = pedidoId;
        }
    }
}
