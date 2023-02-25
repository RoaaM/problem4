using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // this allow us to use bitmap class


namespace ProblemFour
{
    public class ImageStatistics
    {
        /* here we define a method called calculate wich takes a bitmap object
           as a parameter and return a tuple containing four values: mean, std, min, max
        */
        public static (double mean, double stdDev, int minGrayValue, int maxGrayValue) Calculate(Bitmap image)
        {
            // here we get the dimention of the image
            int width = image.Width;
            int height = image.Height;


            // initialize some value we will use it to calculate the image statistics
            
            double sumGrayValues = 0;  //is the sum of all gray values in the image 
            double squaredSumGrayValues = 0;  //is the sum of the squared gray values in the image
            int minGrayValue = 255;  //is the minimum gray value found in the image (0)
            int maxGrayValue = 0;   //is the maximum gray value found in the image (255)


            // this will loop through every pixel in the image and calculate the image statistics
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int grayValue = pixelColor.R; // grayscale image, so R, G, and B are all equal

                    sumGrayValues += grayValue;
                    squaredSumGrayValues += grayValue * grayValue;

                    if (grayValue < minGrayValue)
                    {
                        minGrayValue = grayValue;
                    }

                    if (grayValue > maxGrayValue)
                    {
                        maxGrayValue = grayValue;
                    }
                }
            }

            // and here we will calculate the final image statistics and return all values in a tuple
            int totalPixels = width * height;
            double meanGrayValue = sumGrayValues / totalPixels;
            double stdDevGrayValue = Math.Sqrt((squaredSumGrayValues / totalPixels) - (meanGrayValue * meanGrayValue));

            return (meanGrayValue, stdDevGrayValue, minGrayValue, maxGrayValue);
        }
    }
}

