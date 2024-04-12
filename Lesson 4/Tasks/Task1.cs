namespace Lesson_4
{
    internal class Task1
    {
        public static void Tas1()
        {
            Console.WriteLine("Введіть рядок з цифрами від 0 до 9:");
            string input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);
                Console.WriteLine($"Введене число: {number}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переповнення! Введене число занадто велике або занадто мале для типу int.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильний формат введених даних. Будь ласка, введіть лише цифри від 0 до 9.");
            }
        }
    }
}
