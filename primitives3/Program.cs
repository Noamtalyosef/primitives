// See https://aka.ms/new-console-template for more information

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
    
    int[] numbers = new int[numOfValues];

    while(counter != numOfValues)
    {
        System.Console.WriteLine($"please enter the {counter+1} value ");
        bool isValue = false;
        int value=0;
        while(!isValue)
        {
            if(!int.TryParse(Console.ReadLine(),out value )||value >200||value<=0)
            {
               System.Console.WriteLine("please enter a positive number between 1- 200");
            }
            else
            {
                isValue = true;
            }
        }
        numbers[counter] = value;
        counter++;
     
    }


  System.Console.WriteLine("here your numbers in reverse");
  for(int i = numOfValues-1;i>=0;i--)
  {
    System.Console.WriteLine(numbers[i]);
  }
 
 Console.ReadKey();

}