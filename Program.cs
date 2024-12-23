namespace lb13
{
    /// <summary>
    /// Этот класс представлен в виде простого калькулятора.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Вычисляет сумму двух целых чисел.
        /// </summary>
        /// <param name="a">Первое число для сложения.</param>
        /// <param name="b">Второе число для сложения.</param>
        /// <returns>Сумма параметров a и b.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Генерируется, если одно из чисел меньше нуля.
        /// </exception>
        public int Sum(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentOutOfRangeException("Числа не должны быть отрицательными");

            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Sum(1, 2));
        }
    }
}
