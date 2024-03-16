namespace TRPO_Lab3.Lib
{
    public class SphereLayer
    {
        public static double FindArea(double radius1, double radius2, double height)
        {
            return Math.PI / 6 * height * (3*radius1*radius1 + 3*radius2*radius2 + height*height);
        }
    }
}
