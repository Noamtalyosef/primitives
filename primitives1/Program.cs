// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

while(true)
{
    bool isSymbol= false;
    int symbol=0;
    System.Console.WriteLine("please enter a symbol");
    while(!isSymbol)
    {
        if(!int.TryParse(Console.ReadLine(),out symbol)||symbol<0||symbol - 10 >=0)
        {
            System.Console.WriteLine("please enter a positive one digit  number as symbol");
        }
        else {
            isSymbol = true;
        }
    }
    bool isWidth =false;
    int width=0;
    System.Console.WriteLine("please enter a width");
    while(!isWidth)
    {
        if(!int.TryParse(Console.ReadLine(),out width)||width<0||width>20)
        {
            System.Console.WriteLine("please enter a positive number between 0-20");
        }
        else
        {
            isWidth = true;

            
        }

         
    }


    
  PrintRectangle(symbol,width);

    void PrintRectangle(int symbol, int width)
    {
        for(int i = width;i>0;i--)
        {
            for(int j = 0; j< i; j++)
            {
                System.Console.Write(symbol);
            }
            System.Console.WriteLine();
        }
    }
}