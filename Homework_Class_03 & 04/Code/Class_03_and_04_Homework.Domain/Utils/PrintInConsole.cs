namespace Class_03_and_04_Homework.Domain.Utils
{
    public static class PrintInConsole
    {
        public static void Print<T>(T item)
        {
            Console.WriteLine($"Item: {item}");
        }

        public static void PrintCollection<T>(List<T> collection)
        {
            Console.WriteLine("Collection items:");
            foreach (var item in collection)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
