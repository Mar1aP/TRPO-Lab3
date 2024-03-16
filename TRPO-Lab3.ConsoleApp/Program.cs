using TRPO_Lab3.Lib;

namespace TRPO_Lab3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа по нахождению объёма шарового слоя");

            Console.WriteLine("Первый радиус: ");
            double radius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Второй радиус: ");
            double radius2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Высота слоя: ");
            double height = Convert.ToDouble(Console.ReadLine());

            try
            {
                Console.WriteLine("Объём шарового слоя: " + SphereLayer.FindVolume(radius1, radius2, height));
            }
            catch(ArgumentException exc)
            {
                Console.WriteLine("Ошибка при расчёте: " + exc.Message);
            }
        }
    }
}
