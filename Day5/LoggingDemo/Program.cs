// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//We use exception filter to add conditions to catch blocks.
 //ex: catch(DivideByZeroException ex) when (some condition) { //handle exception }
 //ex in terms of user define exception:
 //catch(DailyLimitExceededException ex) when (some condition) { //handle exception }
 //condition can be any boolean expression that evaluates to true or false. like checking exception properties or other variables.

 //Most common implementatino of exception filter is logging.
 //Case study based on logging:
 //if there is a need to log only specific exceptions based on certain conditions. like logging only critical exceptions or exceptions occurring in specific modules.
 //we can use exception filters to achieve this.
 //Step 1: Define a logging method that logs exception details based on certain conditions.
 //ex. LogException(Exception ex) to log exception details to a file, database or monitoring system.
 //ex. we can add conditions inside this method to log only specific exceptions.
 //Step 2: Use exception filters in catch blocks to call the logging method based on certain conditions.
 //Step 3: Handle the exception as needed after logging.
 //Step 4: Test the implementation to ensure that only the desired exceptions are logged based on the specified conditions.
 //Step 5: Refine the conditions and logging logic as needed based on feedback and requirements.

//  Business Scenario
// A large enterprise order-processing system handles:
// User input validation

// Business rule checks

// External service calls

// Database operations
// objective :  
// The logging team reports log noise:
// Too many logs for expected business errors

// Critical failures getting buriedThe system must log only critical exceptions, while handling known exceptions silently or gracefully.

//creating a file using File.Create() method in default directory
