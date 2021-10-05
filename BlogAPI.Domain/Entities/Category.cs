using BlogAPI.Shared.Entities;

namespace BlogAPI.Domain.Entities
{
    public class Category : Entity
    {
        public Category(string name, int parentId)
        {
            Name = name;
            ParentId = parentId;
        }

        public string Name { get; private set; }
        public int ParentId { get; private set; }

        public void Update(string name, int parentId)
        {
            Name = name;
            ParentId = parentId;
        }
    }
}
