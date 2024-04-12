namespace Lesson_4
{
    internal class Task2
    {
        public static void Tas2()
        {
            Console.WriteLine("Enter 0 and 1  ");
            string input = Console.ReadLine();

            try
            {
                int BinNum = Convert.ToInt32(input, 2);
                Console.WriteLine(BinNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введене число занадто велике або занадто мале.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильний формат введених даних.");
            }
        }
    }
}
