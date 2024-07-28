namespace OOP_lesson28;

// Объект телефон, который принимает сообщения с типом sms
public class Phone
{
    // здесь можно добавить доп. реализацию при необходимости
    
    private void ReceiveSms(MyMessage msg)
    {
        if (msg.MessageType == "sms")
        {
            Console.WriteLine($"Получил смс {msg.Message}");
        }
    }
}