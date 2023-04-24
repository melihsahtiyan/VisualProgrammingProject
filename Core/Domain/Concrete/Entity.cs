using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Concrete
{
    public class Entity
    {
        public int Id { get; set; }

        public Entity()
        {

        }

        public Entity(int id)
        {
            Id = id;
        }
    }
}
