using System.Collections.Generic;

namespace Template.Entities
{
    public class Entity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ChildEntity> Children { get; set; }
    }
}