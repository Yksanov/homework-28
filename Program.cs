using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace OOP_lesson28;

class Program
{
   public delegate string ReadState();
    
    static void Main(string[] args)
    {
        Lamp lamp = new Lamp();
        Cat cat = new Cat();
        Man man = new Man();
        ReadState readState = lamp.GetLampStatus;
        readState += cat.WhatIdDoingNow;
        readState += man.WhatHeIsDoingNow;
        foreach (var read in readState.GetInvocationList())
        {
            string result = ((ReadState)read)();
            Console.WriteLine(result);
        }
    }
}