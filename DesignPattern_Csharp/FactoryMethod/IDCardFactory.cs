using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public class IDCardFactory : Factory
    {
        // private List<string> owners;
        private Dictionary<int, string> cards;

        public IDCardFactory ()
        {
            // owners = new List<string> ();
            cards = new Dictionary<int, string> ();
        }

        protected override Product CreateProduct (string owner)
        {
            int id = cards.Count;
            return new IDCard (owner, id);
        }
        protected override void RegisterProduct (Product product)
        {
            // owners.Add (((IDCard) product).GetOwner ());
            var card = (IDCard) product;
            int id = card.GetId ();
            if (cards.ContainsKey (id))
            {
                Console.WriteLine (id + " is already Exist.");
                return;
            }
            cards.Add (id, card.GetOwner ());
        }
        public IEnumerable<string> GetOwners ()
        {
            // return owners;
            return cards.Values;
        }
    }
}