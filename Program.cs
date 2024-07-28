using System.Net.WebSockets;
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
        
        Console.WriteLine("Задания 2\n");
        Console.WriteLine("Отправка сообщения");
        Console.WriteLine("Введите тип сообщения: ");
        string type = Console.ReadLine();
        Console.WriteLine("Введите сообщение: ");
        string message = Console.ReadLine();

        MyMessage myMessage = new MyMessage(type, message);
        MessageManager messageManager = new MessageManager();

        Phone phone = new Phone();
        Mail mail = new Mail();

        messageManager.NewMessage += phone.Message;
        messageManager.NewMessage += mail.Message;
        messageManager.TakeMessage(myMessage);
    }
}