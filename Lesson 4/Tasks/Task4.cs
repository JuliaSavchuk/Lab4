namespace Lesson_4
{
    internal class Task4
    {
        public static int CalculateExpression(string input)
        {
            string[] operands = input.Split('*');

            int result = int.Parse(operands[0]);

            for (int i = 1; i < operands.Length; i++)
            {
                result *= int.Parse(operands[i]);
            }

            return result;
        }
    }
}
