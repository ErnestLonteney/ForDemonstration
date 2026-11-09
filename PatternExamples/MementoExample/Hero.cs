using System;
using System.Collections.Generic;
using System.Text;

namespace MementoExample
{
    internal class Hero
    {
        public required string Name { get; init; }

        public byte Level { get; set; } 

        public TypeHero Type { get; set; }

        public string[] Items { get; set; } = [];

        public void Fight()
        {
            Console.WriteLine($"Hero {Name} is fighting");
        }

        public void ShowItems()
        {
            Console.WriteLine($"Items: {string.Join(", ", Items)}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Level: {Level}, Type: {Type}");
        }

        public StorageBack PackStorage()
        {
            return new StorageBack
            {
                DateOfPacking = DateTime.Now,
                Items = Items,
                Level = Level,
                Type = Type
            };
        }

        public void UnpackStorage(StorageBack storageBack)
        {
            Items = storageBack.Items;
            Level = storageBack.Level;
            Type = storageBack.Type;
        }
    }
}
