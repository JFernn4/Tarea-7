namespace Calculadora
{
    internal class Program
    {
        private static List<int> valuesList = new List<int>();
        static void Main(string[] args)
        {
            bool menu = true;
            int option;
            while (menu)
            {
                Console.Clear();
                ShowMenu();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            AskAListOfValues();
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Media:"+(Mean()));
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Mediana:"+(Median()));
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            ClearList();
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
        }
            static void ShowMenu()
            {
                Console.WriteLine("1. Ingresar números.");
                Console.WriteLine("2. Media.");
                Console.WriteLine("3. Mediana.");
                Console.WriteLine("4. Moda.");
                Console.WriteLine("5. Desviación estándar.");
                Console.WriteLine("6. Ingresar nuevos números.");
                Console.WriteLine("0. Salir.");
            }
            static void AskAListOfValues()
            {
                Console.WriteLine("Ingrese su cantidad de números");
                int nNumber = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < nNumber; i++)
                {
                    Console.WriteLine($"Ingresa el número {i + 1}");
                    int values=Convert.ToInt32(Console.ReadLine());
                    valuesList.Add(values);
                }
            }
            static double Mean()
            {
            double sum = 0;
            foreach (int value in valuesList)
            {
                sum += value;
            }
            return sum/valuesList.Count;
            }
            static int Median()
            {
            if (valuesList.Count % 2 !=0) //odd number of values
            {
                double medianOddPosition= (valuesList.Count/2);
                double medianOddPositionRounded = Math.Round(medianOddPosition);
                int medianOddPositionConvertedToInt= Convert.ToInt32(medianOddPositionRounded);
                int medianValue = valuesList[medianOddPositionConvertedToInt];
                return medianValue;
            }
            else //even number of values
            {
                int medianEvenPosition= ((valuesList.Count/2))-1;
                double medianAverage = ((valuesList[medianEvenPosition] + valuesList[medianEvenPosition + 1])/2.0);
                medianAverage= Math.Ceiling(medianAverage);
                int medianValue= Convert.ToInt32(medianAverage);
                return medianValue;
            }
            }
            static void ClearList()
            {
            valuesList.Clear(); 
            AskAListOfValues();
            }


}
}