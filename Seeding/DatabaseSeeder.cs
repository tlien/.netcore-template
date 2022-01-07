using System;
using System.Collections.Generic;
using System.Linq;
using Template.Entities;

namespace Template.Seeding
{
    public class DatabaseSeeder
    {
        private readonly TestContext _context;

        public DatabaseSeeder(TestContext context)
        {
            _context = context;
        }

        public void SeedDatabase()
        {
            var databaseIsAlreadySeeded = _context.Entities.Any() || _context.ChildEntities.Any();
            if (databaseIsAlreadySeeded)
            {
                return;
            }

            AddParents();
            AddChildren();
        }

        private void AddParents()
        {
            var parents = new List<Entity>()
            {
                new()
                {
                    Name = "Test1",
                    Description = "Test1 description"
                },
                new()
                {
                    Name = "Test2",
                    Description = "Test2 description"
                },
                new()
                {
                    Name = "Test3",
                    Description = "Test3 description"
                }
            };

            _context.AddRange(parents);
            _context.SaveChanges();
        }

        private void AddChildren()
        {
            var parents = _context.Entities.ToList();
            var children = parents
                .Select(parent =>
                    new ChildEntity {Name = "Child", Age = new Random().Next(1, 25), ParentId = parent.Id})
                .ToList();

            _context.AddRange(children);
            _context.SaveChanges();
        }
    }
}