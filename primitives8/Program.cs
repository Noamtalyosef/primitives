

while(true)
{
    int[] numbers = new int[10];
    int counter =0;
    System.Console.WriteLine("please enter 10 positive numbers");
    while(counter!=10)
    {
       
         int num;
        if(!int.TryParse(Console.ReadLine(), out num ) || num<0||num>2000)
        {
            System.Console.WriteLine("please enter a positive number (1-2000) ");
        }
        else 
        {
            numbers[counter] = num;
            counter++;
        }
    }
     
    
    
        foreach(var num in numbers)
        {
            bool isPrime =true;
            for(int i=2;i<2000;i++)
            {
                if(num%i==0 && i!=num)
                {
                    isPrime=false;
                }
            }
            if(isPrime&&num!=1)
            System.Console.WriteLine(num+",\t");
        }

    
    
}