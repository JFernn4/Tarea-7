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
                AskNumber();
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Clear();
                menu = false;
                break;
            }
        case 6:
            {
                Console.Clear();
                AskNumber();
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
static void AskNumber()
{
    List<int> valuesList = new List<int>();
    Console.WriteLine("Ingrese su cantidad de números");
    int nNumber = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < nNumber; i++)
    {
        Console.WriteLine($"Ingresa el número {i + 1}");
        int values=Convert.ToInt32(Console.ReadLine());
        valuesList.Add(values);
    }
}

{
}