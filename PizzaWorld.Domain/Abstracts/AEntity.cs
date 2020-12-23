using System;

namespace PizzaWorld.Domain.Abstracts
{
    public abstract class AEntity
    {
        public long EntityId { get; }
        // public Guid EnitiyGuid { get; set; }

        protected AEntity()
        {
            EntityId = DateTime.Now.Ticks;
            //EnitiyGuid = Guid.NewGuid();
        }
    }
}