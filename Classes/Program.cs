namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var modelX = new Car("Tesla", "X", 2018);
            var model3 = new Car("Tesla", "3", 2018);
            var carList = new List<Car>() { modelX, model3};
            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
        }
    }
}