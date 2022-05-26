using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace InventoryLibrary
{
    class JSONStorage : BaseClass
    {
        Dictionary<string, BaseClass> objects;

        Dictionary<string, BaseClass> All() { return objects; }

        void New(BaseClass obj)
        {
            objects[$"{obj.GetType().name}.{obj.id}"] = obj;
        }

        void Save()
        {
            File.WriteAllText("storage/inventory_manager.json", JsonSerializer.Serialize(objects));
        }

        void Load()
        {
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(File.ReadAllText("storage/inventory_manager.json"));
        }
    }
}
