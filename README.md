# KSU SWE 3643 Software Testing and Quality Assurance: Web-Based Calculator


## Table of Contents

-[Team Members](#team-members)

-[Architecture](#architecture)

-[Environment](#environment)

-[Executing the Web Application](#executing-the-web-application)

-[Executing Unit Tests](#executing-unit-tests)

-[Reviewing Unit Test Coverage](#reviewing-unit-tests-coverage)

-[Executing End-To-End Tests](#executing-end-to-end-tests)

-[Final Video Presentation](#final-video-presentation)

# Team members 
Karizma Quiroz

# Architecture
Briefly describe the architecture of the application (use diagrams):
The appications's system is designed for the Calculator Logic and the Calculator Unit Test to be located in seperate files/projects. The "CalculatorLogic" project contains the logic for how the calculator operates, specifically mathematical operations. While the "CalculatorLogicUnitTest", references the "CalculatorLogic" to perform tests. These tests should achieve 100% coverage for different states of the code. These states can either be failing (throwing exceptions) or succeding (returning a function). From there the Web Server App will reference the "CalculatorsLogic". 
Please Note: There is currently no Web Server Application, as this project is incomplete and may not function correctly.

System Architecture Diagram
![Architecture](https://github.com/user-attachments/assets/968fae2a-f6fa-402f-b8bc-1859c468f2e3)

PlantUML Code
		@startuml
		allowmixing
		
		package "Calculator Logic Module" #lightblue
		{
		    class CalculatorLogic {
		        + ComputeSampleStandardDeviation()
		        + ComputePopulationStandardDeviation()
		        + ComputeMean()
		        + ComputeZScore()
		        + ComputeSingleLinearRegression()
		        + PredictYValue()
		    }
		
		    
		
		}
		
		package "CalculatorLogic Unit Tests via NUnit" #lightyellow
		{
		  class CalculatorLogicUnitTests {
		    + ComputeSampleStandardDeviation_ValidListInputs_ReturnsCorrectResult()
		    + ComputeSampleStandardDeviation_ValidList1OrMore_ThrowsArgumentException()
		    + ComputeStandardDeviation_ListAllZeros_ThrowsArgumentException()
		    + ComputeSampleStandardDeviation_EmptyNullList_ThrowsArgumentException()
		    + ComputePopulationStandardDeviation_ValidList2OrMore_ReturnsCorrectResult()
		    + ComputePopulationStandardDeviation_ListAllZeros_ThrowsArgumentException()
		    + ComputePopulationStandardDeviation_EmptyNullList_ThrowsArgumentException()
		    + ComputePopulationStandardDeviation_List1Sample_ThrowsArgumentException()
		    + ComputeMean_ValidList_ThrowsArgumentException()
		    + ComputeMean_EmptyList_ThrowsArgumentException()
		    + ComputeZScore_ValidList_ThrowsArgumentException()
		    + ComputeZScore_Missing1OrMoreParameters_ThrowsArgumentException()
		    + ComputeZScore_MeanEqualsZero_ThrowsArgumentException()
		    + ComputeSingleLinearRegressionEquation_ValidListXYParameters_ReturnsCorrectlyResult()
		    + ComputingSingleLinearRegressionEquation_AllXValuesSame_ThrowsArgumentException()
		    + ComputingSingleLinearRegressionEquation_AllYValuesSame_ThrowsArgumentException()
		    + ComputingSingleLinearRegressionEquation_AllXYValuesAreZero_ThrowsArgumentException()
		    + PredictYFromMXPlusB_ValidListParameters_ReturnsCorrectResult()
		    + PredictYFromMXMinusB_Missing3OrMoreParameters_ThrowsArgumentException()
		  }
		
		  CalculatorLogicUnitTests --> CalculatorLogic : References 
		  
		
		}
		
		package "Calculator Web Server App" #lightblue
		{
		   class Models
		   class Views
		   class Controllers
		
		   Controllers --> Views
		   Controllers --> Models
		   Controllers --> CalculatorLogic
		   
		}
		
		package "Calculator End-To-End Tests via Playwright" #lightyellow {
		  class CalculatorEndToEndTests {
		     + CalculatorUI_ListofValues_CalculatesMean()
		     + CalcuatlorUI_EmptyListOfValues_DisplaysError()
		     + CalculatorUI_InvalidListOfValues_DisplaysError()
		  }
		
		    CalculatorEndToEndTests --> Controllers : HTTP Call via\n Headless Browser
		}
		
		cloud #yellow {
		  hide circle
		  class Browser
		  Browser <--> Controllers : HTTP Call
		}
		@enduml

# Environment 
This project was completed using JetBrains IDE Rider. 
To do a similar project:

1) Install Git and use .Net8
 
 2) Download Rider to your console. Make sure Rider is operational when starting.
  
  3) For this project create a Calculator Logic and a Calculator Logic Unit Test.
   		- These should be located in the same root repository and file. However, these two projects are to be seperated from each other.
     		- The Calculator Logic will hold the mathimatical operation for the Calculator Logic project, while the Calculator Logic Unit Test project will reference the CalculatorLogic module.
       
4) Once you finished the consoles project push your work to github.com. This helps to save your work if you were to lose the files on your machine.
       
5) Access your command line.
	On a machine that uses Windows, you open the "Start" menu and type "cmd" and click "Command Prompt". When first doing this make sure Git is installed by entering git --version.

Please Note: For my project, I used Windows 11.

To configure PlayWrite for end-to-end testing:
	1. For Windows consoles download playwrite.
	2. 


## Executing the Web Application

Could not figure out how to do the web application. 
Describe detailed steps to build and execute the web application from the command line(terminal/console). 
The last step will describe how to connect to the running web application from a browser on the same machine. This often requires a port. 
.....

## Executing Unit tests
To execute the unit test from the command line. 

1) Clone the repository to your machine

Go to the git hub repo and click the green button "<> Code". This is located on the top right of the repository, then click the "Local" tab. Click the subtab "HTTPS" and copy the link to your clipboard.

![githubClone](https://github.com/user-attachments/assets/67b04070-87c3-4954-b793-d5d30c7712a4)

2) Open the command line on your machine

On Windows, go to the "Start" menu and type "cmd" and click "Command Prompt".

3) Choose a specific directory

From there choose where you wish to place your cloned repository. To choose a specified location use "cd" command, following this by the name of the directory like "Downloads". For myself, I would like to place the repository in my downloads directory. Therefore, I would type "cd Downloads".

![cmd downloads](https://github.com/user-attachments/assets/9168deab-53c8-48bf-a133-a4917c49dfd4)

4) Clone the repository
Once you choose your chosen directory, use the command "git clone". Followed by the repository link.

Should look like this: "git clone https://github.com/karizmaquiroz/SWE3643Project.git".

![cmd clone](https://github.com/user-attachments/assets/6d50f544-5bdb-47e1-b4b4-488d6e4290cc)

5) Image of repository once cloned

![cmd example](https://github.com/user-attachments/assets/7999fac1-9055-4d5d-ab6b-01e7abc66345)

## Reviewing Unit Test Coverage
Note the coverage achieved in the Calculator Logic module and include the screenshot of your graphic from Jestbrains IDE. Calculator Logic must receive 100% test coverage of all statements and paths.

## Executing End-To-End tests
Describe the detailed steps to build and execute all your end-to-end unit tests from the command line.


## Final Video Presentation

Karizma Quiroz SWE3643 Project Fall Semester
[Youtube link:](https://youtu.be/SQHk3NZCXmE)




