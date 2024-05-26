namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");
            Console.WriteLine("Tell me how many wheels your vehicle has, and i'll tell you what kind of vehicle you are driving");
            var wheelCount = int.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();


        }
    }
}
