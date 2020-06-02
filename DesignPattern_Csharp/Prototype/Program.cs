﻿using System;

namespace Prototype
{
    class Program
    {
        static void Main (string[] args)
        {
            // 準備
            Manager manager = new Manager ();
            UnderlinePen upen = new UnderlinePen ('~');
            MessageBox mbox = new MessageBox ('*');
            MessageBox sbox = new MessageBox ('/');
            manager.Register ("strong message", upen);
            manager.Register ("warning box", mbox);
            manager.Register ("slash box", sbox);

            // 生成
            Product p1 = manager.Create ("strong message");
            p1.Use ("Hello, world.");
            Product p2 = manager.Create ("warning box");
            p2.Use ("Hello, world.");
            Product p3 = manager.Create ("slash box");
            p3.Use ("Hello, world.");
        }
    }
}