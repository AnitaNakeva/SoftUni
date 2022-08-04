using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private int capacity;
        private List<Item> items;

        public Bag(int capacity=100)
        {
            this.items = new List<Item>();
            this.Capacity = capacity;
        }

        public int Capacity 
        { 
            get
            { 
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        private int GetSum()
        {
            int sum = 0;
            foreach(var item in this.items)
            {
                sum += item.Weight;
            }

            return sum;
        }

        public int Load => GetSum();

        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();

        public void AddItem(Item item)
        {
            if(GetSum()+item.Weight>this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }
            var itemToFind = this.items.FirstOrDefault(x => x.GetType().Name == name);
            if(itemToFind==null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }
            this.items.Remove(itemToFind);

            return itemToFind;
        }
    }
}
