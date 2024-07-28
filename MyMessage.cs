namespace OOP_lesson28;

// Объект сообщения
public class MyMessage
{
        public string MessageType { get; }
        public string Message { get; }

        public MyMessage(string type, string message)
        {
            MessageType = type;
            Message = message;
        }
}