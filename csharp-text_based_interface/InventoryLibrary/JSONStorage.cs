using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        private const string storageDirectory = "storage";
        private const string storageFile = "inventory_manager.json";

        public Dictionary<string, BaseClass> objects { get; private set; }

        public JSONStorage()
        {
            objects = new Dictionary<string, BaseClass>();
        }

        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        public void New(BaseClass obj)
        {
            string key = $"{obj.GetType().Name}.{obj.id}";
            if (!objects.ContainsKey(key))
                objects.Add(key, obj);
        }

        public void Save()
        {
            Directory.CreateDirectory(storageDirectory);
            string filePath = Path.Combine(storageDirectory, storageFile);
            string json = JsonSerializer.Serialize(objects, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(filePath, json);
        }

        public void Load()
        {
            string filePath = Path.Combine(storageDirectory, storageFile);
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(json);
            }
            else
                objects = new Dictionary<string, BaseClass>();
        }
    }
}
