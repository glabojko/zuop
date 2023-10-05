namespace zuop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w zakładzie utylizacji odpadów przemysłowych.");
            Shredder shredder1 = new Shredder(30);
            Squeezer squeezer1 = new Squeezer(10);
            Burner burner1 = new Burner(5);
            var paperDailyCapacity = shredder1.GetCapacity();
            var metalDailyCapacity = squeezer1.GetCapacity();
            var otherDailyCapacity = burner1.GetCapacity();


            Console.Write("Podaj ile papieru chcesz oddać do utylizacji (rozdrabnianiu): ");
            int paper = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj ile metalu chcesz oddać do utylizacji (zgniataniu): ");
            int metal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj ile innych odpadów chcesz oddać do utylizacji (spalaniu): ");
            int other = Convert.ToInt32(Console.ReadLine());

            double daysPaper = paper / paperDailyCapacity;
            double daysMetal = metal / metalDailyCapacity;
            double daysOther = other / otherDailyCapacity;

            Console.WriteLine($"Potrzebujemy {daysPaper} dni żeby zutylizować Twój papier");
            Console.WriteLine($"Potrzebujemy {daysMetal} dni żeby zutylizować Twój metal");
            Console.WriteLine($"Potrzebujemy {daysOther} dni żeby zutylizować Twój metal");



        }
    }
}