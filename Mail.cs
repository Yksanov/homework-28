namespace OOP_lesson28;

// Объект почта, который принимает сообщения с типом email
public class Mail
{
    // здесь можно добавить доп. реализацию при необходимости
    public void Message(MyMessage msg)
    {
        ReceiveMail(msg);
    }
    
    private void ReceiveMail(MyMessage msg)
    {
        if (msg.MessageType == "email")
        {
            Console.WriteLine($"Получил письмо {msg.Message}");
        }
    }
}