public class Program
{
    static void Main(string[] args)
    {
        bool menu = true;
        int option;
        while (menu)
        {
            try
            {
                Console.Clear();
                Statistics.ShowMenu();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            Statistics.AskAListOfValues();
                            break;
                        }
                    case 2:
                        {
                            if (!Statistics.HasValues())
                            {
                                Console.Clear();
                                Console.WriteLine("Primero debe ingresar una serie de números.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Media: " + Statistics.CalculateMean());
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 3:
                        {
                            if (!Statistics.HasValues())
                            {
                                Console.Clear();
                                Console.WriteLine("Primero debe ingresar una serie de números.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Mediana: " + Statistics.CalculateMedian());
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 4:
                        {
                            if (!Statistics.HasValues())
                            {
                                Console.Clear();
                                Console.WriteLine("Primero debe ingresar una serie de números.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Moda: " + Statistics.CalculateMode());
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 5:
                        {
                            if (!Statistics.HasValues())
                            {
                                Console.Clear();
                                Console.WriteLine("Primero debe ingresar una serie de números.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Desviación estándar: " + Statistics.CalculateStandardDeviation());
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 6:
                        {
                            if (!Statistics.HasValues())
                            {
                                Console.Clear();
                                Console.WriteLine("Primero debe ingresar una serie de números.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Statistics.ClearList();
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            menu = false;
                            break;
                        }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ingresa un número del 0 al 6 " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
