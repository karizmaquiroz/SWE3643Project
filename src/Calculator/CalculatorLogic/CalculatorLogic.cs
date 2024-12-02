

namespace CalculatorLogic;

public class CalculatorLogic
{
    
    //mean = add all values then divide the total by total numb of values

    
    
//compute sample standard deviation
    public static double ComputeSampleStandardDeviation(List<double> valuesListSample) 
    {
        //preq-LOGIC-3
        
        //throw exceptions: equal to 0 or 1 and any lines containing non-numeric values
        if (valuesListSample.Count == 0)
        {
            throw new ArgumentException("Values list can not be empty");
        }

        if (valuesListSample.Count == 1)
        {
            throw new ArgumentException("Values list can not contain one element");
        }

        if (valuesListSample.Any(anyNumber => double.IsNaN(anyNumber)))
        {
            throw new ArgumentException("Values list can not contain invalid numbers");
        }
        
        //computing sample stand dev
            // get sample mean(average)
            double mean = valuesListSample.Average();
            // get SqOfDiff
            double sqOfDiff = valuesListSample.Sum(number =>Math.Pow(number - mean, 2));
            //return Sqrt
            return Math.Sqrt(sqOfDiff/ (valuesListSample.Count - 1)); 
    }

//compute population standard deviation from a list of values
    public static double ComputePopulationStandardDeviation(List<double> valuesListPopulation)
    {
        //pre-LOGIC-4
        
        //throw exceptions: equal to 0 or 1 and any lines containing non-numeric values
        if (valuesListPopulation.Count == 0)
        {
            throw new ArgumentException("Values list can not be empty");
        }

        if (valuesListPopulation.Count == 1)
        {
            throw new ArgumentException("Values list can not contain one element");
        }

        if (valuesListPopulation.Any(anyNumber => double.IsNaN(anyNumber)))
        {
            throw new ArgumentException("Values list can not contain invalid numbers");
        }
        
        //computing population standard deviation
        double mean = valuesListPopulation.Average();
        double sqOfDiff = valuesListPopulation.Sum(number =>Math.Pow(number - mean, 2));
        return Math.Sqrt(sqOfDiff / (valuesListPopulation.Count));
    }

//compute mean(average) from a list of values
    public static double ComputeMean (List<double> valuesListMean)
    {
        //preq-LOGIC-5
        
        //throws exception
        if (valuesListMean.Count == 0)
        {
            throw new ArgumentException("Values list can not be empty");
        }

        if (valuesListMean.Any(anyNumber => double.IsNaN(anyNumber)))
        {
            throw new ArgumentException("Values list can not contain invalid numbers");
        }
        
        //compute mean
        return valuesListMean.Average();
        
    }

//compute a z-score from a value, mean, and standard deviation
    public static double ComputeZScore(List<double> valuesListZScore)
    {
        //preq-LOGIC-6
        
        
        //throw exceptions
        if (valuesListZScore.Count != 3)
        { throw new ArgumentException("The list must be exactly three.");}

        //first value for mean
        if (valuesListZScore[1] == 0) 
        {throw new ArgumentException("Mean can not be zero.");}
        
        //second value for standard dev
        if (valuesListZScore[2] == 0)
        {throw new ArgumentException("Standard deviation can not be zero.");}
        
        //compute z-score
        return (valuesListZScore[0]- valuesListZScore[1]) / valuesListZScore[2];
    }

//compute a single variable linear regression formula from a list of X,Y pairs
    public static string ComputeSingleLinearRegression(List<(double x, double y)> valueForSingleLinearRegression)
    {
        //preq-LOGIC-7
        
        //y = (y-intercept) + slope coeffiecent * independent vairable
        
        //throw exception
        if(valueForSingleLinearRegression.Count == 0){throw new ArgumentException("Values list can not be empty");}

        double x = valueForSingleLinearRegression[0].x;
        double y = valueForSingleLinearRegression[0].y;
        
        //throw exceptions
        if (valueForSingleLinearRegression.All(plot => plot.x == x))
        {
            throw new InvalidOperationException("The x value can not be the same");
        }
        if (valueForSingleLinearRegression.All(plot => plot.y == y))
        {
            throw new InvalidOperationException("The y value can not be the same");
        }
        
        //equation for computing single linear regression
        double sumOfX = 0.0;
        double sumOfY = 0.0;
        double sumOfXY = 0.0;
        double sumOfX2 = 0.0;

        for (int i = 0; i < valueForSingleLinearRegression.Count; i++)
        {
            (double x, double y) point = valueForSingleLinearRegression[i];
            sumOfX2 += point.x * point.x;
            sumOfX += point.x;
            sumOfY += point.y;
            sumOfXY += point.x * point.y;
        }
        
        double slope = (valueForSingleLinearRegression.Count * sumOfXY - sumOfX * sumOfY) / (valueForSingleLinearRegression.Count * sumOfX2 - sumOfX * sumOfY);
        double yIntercept = (sumOfY - slope * sumOfX) / valueForSingleLinearRegression.Count;
        
        return "y = " + slope + "x + " + yIntercept + "";
    }


//Predicit a Y value using the X,M(slope), and B(intercept) values of a single variable regression formula
    public static double PredictYValue(List<double> valueForYPrediction)
    {
        //throw exception
        if (valueForYPrediction.Count != 3)
        {
            throw new ArgumentException("The list must be exactly three.");
        }

        //computing y value
        return valueForYPrediction[0] = valueForYPrediction[1] + valueForYPrediction[2];
      
    }

}