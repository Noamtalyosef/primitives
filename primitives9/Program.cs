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
            if(!int.TryParse(Console.ReadLine(),out value )||value >200||value<0)
            {
               System.Console.WriteLine("please enter a positive number between 0- 200");
            }
            else
            {
                isValue = true;
            }
        }
        numbers[counter] = value;
        counter++;
     
    }

     
    for(int i=0;i<numbers.Length-1;i++)//bouble sort (o(n2))
    {
        int x =0;
        int j =1;
       for(;j<numbers.Length;j++,x++)
       {
            if(numbers[x]>numbers[j])
            {
                int temp = numbers[j];
                numbers[j]= numbers[x];
                numbers[x]= temp;
            }

       }
       
    }

    foreach(var num in numbers)
    {
        System.Console.Write(num+",\t");
    }


}