using System.Collections.Generic;

namespace Solid1 
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    // Single Responsibility!!!
    internal class Item // entity
    {
        // properties...
    }

    internal class Order // entity layer
    {
        internal List<Item> ItemList { get; set; }
    }

    internal class OrderService // service layer
    {
        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    } 

    internal class OrderPrinter // service layer (might be as utility)
    {
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }

    internal class OrderRepository // repo (db management)
    {
        public void Load() {/*...*/} 
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
    
    internal class ItemRepository // repo (db management)
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
    

    class Program
    {
        static void Main()
        {
        }
    }
}
