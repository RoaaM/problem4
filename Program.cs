using ProblemFour;
using System.Drawing;


namespace YourProjectName
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance(object) of Bitmap class and give it the image
            Bitmap image = new Bitmap("C:\\Users\\roaas\\Desktop\\ProblemFour\\ProblemFour\\coalagray.jpeg");
            /* This line calls the static Calculate method of the ImageStatistics class, passing the Bitmap object 
             * created in the previous line as an argument. The resulting statistics are stored in a new variable named statistics.*/
            var statistics = ImageStatistics.Calculate(image);
            // and thats how i want my output look like
            Console.WriteLine($"Mean gray value: {statistics.mean}");
            Console.WriteLine($"Standard deviation: {statistics.stdDev}");
            Console.WriteLine($"Minimum gray value: {statistics.minGrayValue}");
            Console.WriteLine($"Maximum gray value: {statistics.maxGrayValue}");

        }
    }
}
