using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    class Inventory : BaseClass
    {
        string user_id;
        string item_id;
        int quantity;

        public Inventory(string user_id, string item_id, int quantity)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            if (quantity < 0)
                this.quantity = 1;
            else
                this.quantity = quantity;
        }
    }
}
