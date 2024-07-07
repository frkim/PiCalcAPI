namespace Utils
{

    public class MathUtils
    {
        public static double EstimatePi(int iterations = 1000000)
        {
            // Estimate pi with iterations
            Random random = new Random();
            int insideCircle = 0;

            for (int i = 0; i < iterations; i++)
            {
                // Generate random points between -1.0 and 1.0 for both x and y
                double x = random.NextDouble() * 2 - 1;
                double y = random.NextDouble() * 2 - 1;

                // Check if the point is inside the quarter circle
                if (x * x + y * y <= 1)
                {
                    insideCircle++;
                }
            }

            // Estimate PI
            double piEstimate = 4.0 * insideCircle / iterations;

            return piEstimate;
        }
    }
}
