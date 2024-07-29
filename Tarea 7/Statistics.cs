public class Statistics
{
    private static List<int> valuesList = new List<int>();

    public static void ShowMenu()
    {
        Console.WriteLine("1. Ingresar números.");
        Console.WriteLine("2. Media.");
        Console.WriteLine("3. Mediana.");
        Console.WriteLine("4. Moda.");
        Console.WriteLine("5. Desviación estándar.");
        Console.WriteLine("6. Ingresar nuevos números.");
        Console.WriteLine("0. Salir.");
    }

    public static void AskAListOfValues()
    {
        Console.WriteLine("Ingrese la cantidad de números");
        int nNumber = 0;

        while (true)
        {
            try
            {
                nNumber = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Por favor, ingrese un número entero." + ex.Message);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Ingrese la cantidad de números");
            }
        }

        for (int i = 0; i < nNumber; i++)
        {
            int value = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Ingresa el número {i + 1}");
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Por favor, ingrese un número entero." + ex.Message);
                    Console.ReadKey();
                }
            }
            valuesList.Add(value);
        }
    }

    public static double CalculateMean()
    {
        double sum = 0;
        foreach (int value in valuesList)
        {
            sum += value;
        }
        return sum / valuesList.Count;
    }

    public static int CalculateMedian()
    {
        valuesList.Sort();
        if (valuesList.Count % 2 != 0) // Odd number of values
        {
            int medianIndex = valuesList.Count / 2;
            return valuesList[medianIndex];
        }
        else // Even number of values
        {
            int medianIndex1 = (valuesList.Count / 2) - 1;
            int medianIndex2 = medianIndex1 + 1;
            return (valuesList[medianIndex1] + valuesList[medianIndex2]) / 2;
        }
    }

    public static int CalculateMode()
    {
        return valuesList.GroupBy(value => value).OrderByDescending(group => group.Count()).First().Key;
    }

    public static void ClearList()
    {
        valuesList.Clear();
        AskAListOfValues();
    }

    public static double CalculateStandardDeviation()
    {
        double mean = CalculateMean();
        double sumOfSquaresOfDifferences = 0;
        foreach (int value in valuesList)
        {
            double difference = value - mean;
            sumOfSquaresOfDifferences += difference * difference;
        }
        return Math.Sqrt(sumOfSquaresOfDifferences / valuesList.Count);
    }

    public static bool HasValues()
    {
        return valuesList.Count > 0;
    }
}