using System;
using System.Collections.Generic;
using System.Text;

namespace ItUniver.Domain.Entities
{
    /// <summary>
    /// Сущность, с первичным ключем с типа <see cref="int"/>
    /// </summary>
    public abstract class Entity : Entity<int>, IEntity
    {

    }
}
