// namespace OOP_lesson28;
//
// public class help
// {
// namespace OOP_lesson28;
//
// class Program
// {
//     //Опишем несколько разнообразных делегатов
//     delegate void Message();
//     delegate int Options(int x, int y);
//     delegate int UnaryOperation(int x);
//     
//     static void Main(string[] args)
//     {
//         Operation operation = Sum;  // Вызов глобального метода Sum = 15
//         Console.WriteLine(operation(5, 10));
//
//         operation = Math.StaticSum;  // Вызов статического метода
//         Console.WriteLine(operation(4,2)); 
//
//         Math math = new Math(5);
//         operation = math.Multiply;  // Вызов метода экземпляра LocalSum = 95
//         Console.WriteLine(operation(5,12));
//
//         operation = math.Subtract;
//         Console.WriteLine(operation(1000,3));
//
//         Math.MathOperation operation2 = math.SmartSum;  // Вызов метода экземпляра SmartSum = 11 (здесь используется член класса _val который инициализирован в конструкторе
//         Console.WriteLine(operation2(4,2));  
//         Console.WriteLine("_______________________________________\n");
//         Message msg = () => Console.WriteLine("Hello World");
//         msg();
//
//         Options sum = (x, y) => x + y;
//         int a = 5, b = 3;
//         Console.WriteLine($"{a} + {b} = {sum(a,b)}");
//     }
//
//
//     static int Sum(int x, int y) => x + y;
//     delegate int Operation(int a, int b);
//
//     class Math
//     {
//         private int val;
//         public Math(int val) => this.val = val;
//
//         public delegate int MathOperation(int x, int y);
//         
//         public static int StaticSum(int x, int y) => x + y;
//         public int Subtract(int x, int y) => x - y;
//         public int Multiply(int x, int y) => x * y;
//         public int? Divide(int x, int b) => x / b;
//         public int SmartSum(int x, int y) => x + y + val;
//     }
// }
// }