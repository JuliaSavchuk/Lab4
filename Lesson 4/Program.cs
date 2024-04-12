namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----Task1----\n");
            Task1.Tas1();

            Console.WriteLine("\n-----Task2----\n");
            Task2.Tas2();

            Console.WriteLine("\n-----Task3----\n");
            try
            {
                CreditCard card = new CreditCard("1234567890123456", "John Doe", 123, new DateTime(2025, 12, 31));
                Console.WriteLine("Картка успішно створена.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.WriteLine("\n-----Task4----\n");
            Console.WriteLine("Введіть математичний вираз у вигляді цілих чисел і операторів *:");
            string input = Console.ReadLine();

            try
            {
                int result = Task4.CalculateExpression(input);
                Console.WriteLine("Результат: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталася помилка: " + ex.Message);
            }

        }
        

  
    }
}

//static void Main(string[] args)
//{
//    Console.WriteLine(Test(null));
//}
//public static string Test(string str)
//{
//    try
//    {
//        if (str == null)
//        {
//            throw new Exception("Error..");
//        }
//        return str + str;
//    }
//    catch (Exception ex)
//    {

//        return ex.Message;
//    }
//    finally
//    {
//        Console.WriteLine("End...");
//    }
//}