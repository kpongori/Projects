namespace Prototype
{
    public abstract class Product
    {
        public abstract void Use (string s);
        public Product CreateClone ()
        {
            Product p = null;
            p = MemberwiseClone () as Product;
            return p;
        }
    }
}