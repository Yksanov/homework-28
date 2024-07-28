using System.Runtime.InteropServices;
using System.Xml;

namespace OOP_lesson28;

public class Lamp
{
    public bool TurnedOn { get; set; }

    public string GetLampStatus()
    {
        TurnedOn = true;
        return "Лампа включена";
    }
}