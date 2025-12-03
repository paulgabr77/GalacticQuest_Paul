using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.DataModels
{
    internal class Player
    {
        private int _hp;
        private int _attack;
        private List<(string, int)> _items;
        private int _credits;

        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public List<(string, int)> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public int Credits
        {
            get { return _credits; }
            set { _credits = value; }
        }

        public Player()
        {
            _hp = 10;
            _attack = 2;
            _credits = 0;
            _items = new List<(string, int)>();
        }
        public Player(int hp, int attack, List<(string, int)> items, int credits)
        {
            _hp = hp;
            _attack = attack;
            _items = items;
            _credits = credits;
        }

        public void UpdateHp(int hp)
        {
            if (Hp + hp <= 0)
            {
                Hp = 0;
                OnDeath();
                return;
            }
            Hp += hp;
        }
        public void UpdateCredits(int credits)
        {
            if(Credits + credits < 0)
            {
                Console.WriteLine("Not enough credits for this transaction!");
                return;
            }
            Credits += credits;
        }
        public void ShowDetails()
        {
            //Console.WriteLine("Player :" + " Hp: " + Hp + " Attack: " + Attack);
            Console.WriteLine($"Player:\nHp: {Hp}\nAttack: {Attack}\nCredits: {Credits}\nItems: ");
            if(_items.Count == 0)
            {
                Console.WriteLine(" No items in inventory.");
                return;
            }
            else
            {
                for(int i = 0; i < _items.Count; i++)
                {
                    var item = _items[i];
                    Console.WriteLine($" {_items[i].Item1} (Value: {_items[i].Item2})");
                }
            }
        }
        public void AddItem((string, int) item)
        {
            _items.Add(item);
            Console.WriteLine($"Added item: {item.Item1} (Value: {item.Item2})");
        }
        public void RemoveItem(string itemRemoved)
        {
            int index = _items.FindIndex(i => i.Item1 == itemRemoved);
            if (index == -1)
            {
                Console.WriteLine($"Item {itemRemoved} not found in inventory.");
                return;
            }
            var removedItem = _items[index];
            _items.RemoveAt(index);
            Console.WriteLine($"Removed item: {removedItem.Item1}");
        }
        private void OnDeath()
        {
            Console.WriteLine("The player has fallen! Game Over...");
        }
    }
}
