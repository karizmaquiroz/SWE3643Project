using NuGet.Frameworks;

namespace CalculatorLogicUnitTests;

using CalculatorLogic;

public class Tests
{

    
    //This is the start for the unit test coverages for computing sample standard deviation
    
    //preq-LOGIC-2
    [Test]
    public void ComputeSampleStandardDeviation_ValidListInputs_ReturnsCorrectResult()
    {
        //arrange
        List<double> valueListSample = new List<double>{9.0,6.0,8.0, 5.0, 7.0};
        
        //act
        double sampleStandardDeviation = CalculatorLogic.ComputeSampleStandardDeviation(valueListSample);
        
        //assert
        Assert.That(sampleStandardDeviation, Is.EqualTo(1.5811388300841898));
    }
    
    //preq-LOGIC-2
    [Test]
    public void ComputeSampleStandardDeviation_ValidList1OrMore_ThrowsArgumentException()
    {
        //arrange
        List<double> valueListSample = new List<double>{1.0};
        
        //act
        double sampleStandardDeviation = CalculatorLogic.ComputeSampleStandardDeviation(valueListSample);
        
        //assert
        Assert.That(sampleStandardDeviation, Is.EqualTo(1.5811388300841898));
    }

    //preq-LOGIC-2
    [Test]
    public void ComputeStandardDeviation_ListAllZeros_ThrowsArgumentException()
    {
        //arrange
        List<double> valueListSample = new List<double>{0.0, 0.0};
        //act
        double sampleStandardDeviation = CalculatorLogic.ComputeSampleStandardDeviation(valueListSample);
        //assert
        Assert.That(sampleStandardDeviation, Is.EqualTo(0.0));

    }

    //preq-LOGIC-2
    [Test]
    public void ComputeSampleStandardDeviation_EmptyNullList_ThrowsArgumentException()
    {
        //arrange
        List<double> sampleStandardDeviation = new List<double>();
        //act
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeSampleStandardDeviation(sampleStandardDeviation));
        
        //assert
        Assert.That(errorMessage.Message, Is.EqualTo("Value cannot be null."));
    }
    
    
    //This is the start for the unit test coverages for computing population standard deviation
    
    
    //preq-LOGIC-3
    [Test]
    public void ComputePopulationStandardDeviation_ValidList2OrMore_ReturnsCorrectResult()
    {
        //arrange
        List<double> valueListPopulation = new List<double>{9.0,6.0,8.0, 5.0, 7.0};
        
        //act
        double populationStandardDeviation = CalculatorLogic.ComputePopulationStandardDeviation(valueListPopulation);
        
        //assert
        Assert.That(populationStandardDeviation, Is.EqualTo(1.4142135623731));
    }

    //preq-LOGIC-3
    [Test]
    public void ComputePopulationStandardDeviation_ListAllZeros_ThrowsArgumentException()
    {
        //arrange
        List<double> valueListPopulation = new List<double>{0.0, 0.0};
        //act
        double populationStandardDeviation = CalculatorLogic.ComputeSampleStandardDeviation(valueListPopulation);
        //assert
        Assert.That(populationStandardDeviation, Is.EqualTo(0.0));

    }

    //preq-LOGIC-3
    [Test]
    public void ComputePopulationStandardDeviation_EmptyNullList_ThrowsArgumentException()
    {
        //arrange
        List<double> populationStandardDeviation = new List<double>();
        //act
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeSampleStandardDeviation(populationStandardDeviation));
        
        //assert
        Assert.That(errorMessage.Message, Is.EqualTo("Value cannot be null."));
    }
    //preq-LOGIC-3
    [Test]
    public void ComputePopulationStandardDeviation_List1Sample_ThrowsArgumentException()
    {
        //arrange
        List<double> valueListPopulation = new List<double>{1.0};
        
        //act
        double populationStandardDeviation = CalculatorLogic.ComputePopulationStandardDeviation(valueListPopulation);
        
        //assert
        Assert.That(populationStandardDeviation, Is.EqualTo(1.4142135623731));
    }
    
    //This is the start for the unit test coverages for compute mean
    
    //preq-LOGIC-4
    [Test]
    public void ComputeMean_ValidList_ThrowsArgumentException()
    {
        //arrange
        List<double> valueListMean = new List<double>{9.0,6.0,8.0, 5.0, 7.0};
        //act
        double mean = CalculatorLogic.ComputeMean(valueListMean);
        //assert
        Assert.That(mean, Is.EqualTo(35));
    }
    //preq-LOGIC-4
    [Test]
    public void ComputeMean_EmptyList_ThrowsArgumentException()
    {
        //arrange
        List<double> valueListMean = new List<double>();
        //act
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeMean(valueListMean));
        //assert
        Assert.That(errorMessage, Is.EqualTo("The list is empty."));
    }

    
    
    //This is the start for the unit test coverages for compute mean
    
    //preq_LOGIC-5
    [Test]
    public void ComputeZScore_ValidList_ThrowsArgumentException()
    {
        //arrange
        List<double> valueListZScore = new List<double>{11.5,7,1.5811388300841898};
        
        //act
        double zScore = CalculatorLogic.ComputeZScore(valueListZScore);
        //assert
        Assert.That(zScore, Is.EqualTo(2.846049894151541));
        
    }
    //preq_LOGIC-5
    [Test]
    public void ComputeZScore_Missing1OrMoreParameters_ThrowsArgumentException()
    {
        //arrange
        List<double> valueListZScore = new List<double>{11.5,0,};
        
        //act
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeZScore(valueListZScore));
        //assert
        Assert.That(errorMessage.Message, Is.EqualTo("The list is missing a parameter."));
    }
    //preq_LOGIC-5
    [Test]
    public void ComputeZScore_MeanEqualsZero_ThrowsArgumentException()
    {
        //arrange
        List<double> valueListZScore = new List<double>{11.5,7,0};
        
        //act
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.ComputeZScore(valueListZScore));
        //assert
        Assert.That(errorMessage.Message, Is.EqualTo("The list standard deviation can not be zero."));
    }
    
    
    //This is the start for the unit test coverages for computing single linear regression equation
    
    //preq-LOGIC-6
    [Test]
    public void ComputeSingleLinearRegressionEquation_ValidListXYParameters_ReturnsCorrectlyResult()
    {
        //arrange
        var dataForSingleLinearRegressionEquation = new List<(double x, double y)>
        {
            (1.47, 52.21),

            (1.5, 53.12),

            (1.52, 54.48),

            (1.55, 55.84),

            (1.57, 57.2),

            (1.6, 58.57),

            (1.63, 59.93),

            (1.65, 61.29),

            (1.68, 63.11),

            (1.7, 64.47),

            (1.73, 66.28),

            (1.75, 68.1),

            (1.78, 69.92),

            (1.8, 72.19),

            (1.83, 74.46),
        };
        //act
        string singleLinearRegressionEquation = CalculatorLogic.ComputeSingleLinearRegression(dataForSingleLinearRegressionEquation);
        //assert
        Assert.That(singleLinearRegressionEquation, Is.EqualTo("y = 61.272186542107434x + -39.061955918838656"));
    }
    //preq_LOGIC-6
    [Test]
    public void ComputingSingleLinearRegressionEquation_AllXValuesSame_ThrowsArgumentException()
    {
        //arrange
        var dataForSingleLinearRegressionEquation = new List<(double x, double y)>
        {
            (1,2),
            (1,3),
            (1, 4)
        };
        //act
        var errorMessage = Assert.Throws<InvalidOperationException>(() =>
            CalculatorLogic.ComputeSingleLinearRegression(dataForSingleLinearRegressionEquation));
        //assert
        Assert.That(errorMessage.Message, Is.EqualTo("The x values cant be the same."));
    }
    //preq-LOGIC-6
    [Test]
    public void ComputingSingleLinearRegressionEquation_AllYValuesSame_ThrowsArgumentException()
    {
        //arrange
        var dataForSingleLinearRegressionEquation = new List<(double x, double y)>
        {
            (2,1),
            (3,1),
            (4,1)
        };
        //act
        var errorMessage = Assert.Throws<InvalidOperationException>(() =>
            CalculatorLogic.ComputeSingleLinearRegression(dataForSingleLinearRegressionEquation));
        //assert
        Assert.That(errorMessage.Message, Is.EqualTo("The y values cant be the same."));

    }
    //preq-LOGIC-6
    [Test]
    public void ComputingSingleLinearRegressionEquation_AllXYValuesAreZero_ThrowsArgumentException()
    {
        //arrange
        var dataForLinearRegressionEquation = new List<(double x, double y)>
        {
            (0,0),
            (0,0),
            (0,0),
        };
        //act
        string singleLinearRegressionEquation = CalculatorLogic.ComputeSingleLinearRegression(dataForLinearRegressionEquation);
        //assert
        Assert.That(singleLinearRegressionEquation, Is.EqualTo("y = 0x + 0"));
    }
    
    
    //This is the start for the unit test coverages for predicting y from mx+b
    
    
    //preq_LOGIC-7
    [Test]
    public void PredictYFromMXPlusB_ValidListParameters_ReturnsCorrectResult()
    {
        //arrange
        List<double> valueForYValue = new List<double>
        {
            1.535,61.272186542107434, -39.061955918838656
        };
        //act
        double yValues = CalculatorLogic.PredictYValue(valueForYValue);
        //assert
        Assert.That(yValues, Is.EqualTo("y = 54.990850423296244"));
    }
    //preq-LOGIC-7
    [Test]
    public void PredictYFromMXMinusB_Missing3OrMoreParameters_ThrowsArgumentException()
    {
        //arrange
        List<double> valuesForYValue = new List<double> {1.0 };
        //act
        var errorMessage = Assert.Throws<ArgumentException>(() => CalculatorLogic.PredictYValue(valuesForYValue));
        //assert
        Assert.That(errorMessage.Message, Is.EqualTo("The list is missing a parameter, parameters must be three."));
    }
}