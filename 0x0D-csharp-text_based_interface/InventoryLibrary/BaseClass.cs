using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    class BaseClass
    {
        String id;
        DateTime date_created;
        DateTime date_updated;
        public BaseClass()
        {
            this.id = System.Guid.NewGuid().ToString();
            this.date_created = this.date_updated = DateTime.Now;
        }
    }
}
