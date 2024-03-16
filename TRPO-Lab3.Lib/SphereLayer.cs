namespace TRPO_Lab3.Lib
{
    public class SphereLayer
    {
        public static double FindVolume(double radius1, double radius2, double height)
        {
            if (radius1 < 0 || radius2 < 0 || height < 0)
                throw new ArgumentException("Входные данные не должны быть отрицательными.");

            return Math.PI / 6 * height * (3 * radius1 * radius1 + 3 * radius2 * radius2 + height * height);
        }
    }
}
