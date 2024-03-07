// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
while(true)
{
   bool isnumOfValues=false;
   int numOfValues=0;
   System.Console.WriteLine("please enter a number for values");
   while(!isnumOfValues)
   {
    if(!int.TryParse(Console.ReadLine(),out  numOfValues)||numOfValues<1||numOfValues>20)
    {
      System.Console.WriteLine("please enter a valid number between 1 - 20");
    }
    else {
        isnumOfValues = true;
    }
   }
    
    int counter =0;
    int sum = 0;

    while(counter != numOfValues)
    {
         System.Console.WriteLine($"please enter the {counter+1} value ");
        bool isValue = false;
        int value=0;
        while(!isValue)
        {
            if(!int.TryParse(Console.ReadLine(),out value )||value >int.MaxValue/numOfValues||value<=0)
            {
               System.Console.WriteLine("please enter a positive number");
            }
            else
            {
                isValue = true;
            }
        }
        sum+=value;
        counter++;
    }

  System.Console.WriteLine($"avrage is  {AVG(sum,counter)}");  


   double AVG(double sum, double valuesNum) => sum/valuesNum;
  
 Console.ReadKey();

}