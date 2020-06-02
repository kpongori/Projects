using System;

namespace FactoryMethod
{
    public class IDCard : Product
    {
        private string owner;
        private int id;
        internal IDCard (string owner, int id)
        {
            Console.WriteLine ("id = " + id + ", " + owner + "のカードを作ります。");
            this.owner = owner;
            this.id = id;
        }

        public override void Use ()
        {
            Console.WriteLine (owner + "のカードを使います。");
        }
        public string GetOwner ()
        {
            return owner;
        }

        public int GetId ()
        {
            return id;
        }
    }
}