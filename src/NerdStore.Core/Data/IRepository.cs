using NerdStore.Core.DomainObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
