using System;

namespace AbstractFactory
{
    public abstract class Factory
    {
        public static Factory GetFactory (string classname)
        {
            Factory factory = null;
            Type type = Type.GetType ("AbstractFactory." + classname);
            if (type == null)
            {
                Console.WriteLine (classname + " is invalid.");
                return null;
            }
            factory = Activator.CreateInstance (type) as Factory;
            return factory;
        }

        public abstract Link CreateLink (string caption, string url);
        public abstract Tray CreateTray (string caption);
        public abstract Page CreatePage (string title, string author);
    }
}