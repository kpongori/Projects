using System;
using System.Collections.Generic;
using System.IO;

namespace AbstractFactory
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> contents;

        public Page (string title, string author)
        {
            contents = new List<Item> ();
            this.title = title;
            this.author = author;
        }
        public void Add (Item item)
        {
            contents.Add (item);
        }
        public void Output ()
        {
            string filename = title + ".html";
            using (StreamWriter w = new StreamWriter (filename))
            {
                w.WriteLine (MakeHTML ());
                Console.WriteLine (filename + "を作成しました。");
            }
        }
        public abstract string MakeHTML ();
    }
}