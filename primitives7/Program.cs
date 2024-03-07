// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

while(true)
{
   bool isNum = false;
   double num=-1;
   System.Console.WriteLine("please enter a number to convert");
    while(!isNum)
    {
        if(!double.TryParse(Console.ReadLine(),out num)||num <1)
        {
            System.Console.WriteLine("please enter a valid number (1+)");
        }
        else{
            isNum = true;
        }
    } 

     System.Console.WriteLine("I--> inches to centimeters");
     System.Console.WriteLine("G--> galos to litters");
     System.Console.WriteLine("M--> miles to kilometers");
     System.Console.WriteLine("P--> Pounds to litters");

    bool isAction= false;
    while(!isAction)
    {
        char letterAction= Console.ReadKey().KeyChar;
         System.Console.WriteLine();
        switch (letterAction)
        {
              case 'I':
              System.Console.WriteLine(ToCm(num)); 
              isAction = true;   
              break;

              case 'G':
              System.Console.WriteLine(ToLitters(num));
              isAction=true;
                break;

              case 'M':
              System.Console.WriteLine(ToKm(num));
              isAction=true;
                break;

              case 'P':
              System.Console.WriteLine(ToKg(num));
              isAction=true;
                break;

            default:
            System.Console.WriteLine("invalid input");
            isAction=true;
            break;
        }
    }
}







double ToCm(double inches)=>inches*0.303;

double ToKm(double miles)=>miles*0.6213;

double ToKg(double pounds)=>pounds*0.453 ;

double ToLitters(double gallons)=> gallons*3.78;

