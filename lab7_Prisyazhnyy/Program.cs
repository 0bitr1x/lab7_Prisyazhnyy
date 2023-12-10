//сборник задач/тема 7/средний уровень/вариант 11
try
{
    Console.Write("Введите количество товаров: ");
    int n = int.Parse(Console.ReadLine());
    Product[] products = new Product[n];

    for (int i = 0; i < n; i++)
    {
        if(n > 1) Console.WriteLine($"Товар {i+1})");
        products[i] = new Product();
        Console.Write("Введите наименование товара: ");
        products[i].name = Console.ReadLine();
        Console.Write("Введите дату производства YYYY.HH.DD: ");
        products[i].date = DateOnly.Parse(Console.ReadLine());
        Console.Write("Введите срок годности: ");
        products[i].ternDate = int.Parse(Console.ReadLine());
        Console.Write("Введите цену: ");
        products[i].price = double.Parse(Console.ReadLine());
        Console.Write("Введите серию товара: ");
        products[i].numSeries = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    for(int i = 0;i < products.Length;i++) 
    {
        if (n > 1) Console.WriteLine($"Товар {i + 1})");
        Console.WriteLine($"Наименование товара - {products[i].name}");
        Console.WriteLine($"Годен до - {products[i].date.AddDays(products[i].ternDate)}");
        Console.WriteLine();
    }

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Product
{
    public string name;
    public DateOnly date;
    public int ternDate;
    public double price;
    public int numSeries;
}