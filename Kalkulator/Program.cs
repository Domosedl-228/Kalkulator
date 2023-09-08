

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Введите выражение:");
        string expression = Console.ReadLine();

        try
        {
            double result = EvaluateExpression(expression);
            Console.WriteLine("Результат: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }

    static double EvaluateExpression(string expression)
    {
        return Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
    }
}
