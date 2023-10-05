namespace zuop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w zakładzie utylizacji odpadów przemysłowych.");
            Shredder zgniatarka1 = new Shredder(30);
            var paperDailyCapacity = zgniatarka1.GetCapacity();

            Console.Write("Podaj ile papieru chcesz oddać do utylizacji: ");
            int paper = Convert.ToInt32(Console.ReadLine());
            double daysNeeded = paper / paperDailyCapacity;
            Console.WriteLine($"Potrzebujemy {daysNeeded} dni żeby zutylizować Twój papier");



        }
    }
}