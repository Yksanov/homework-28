namespace OOP_lesson28;

public class MessageManager
{
    public delegate void MessageHalder(MyMessage msg);

    public event MessageHalder NewMessage;

    public void TakeMessage(MyMessage msg)
    {
        NewMessage.Invoke(msg);
    }

}