  
  while(true)
  {
    Console.Write("Enter a lower case letter (a-z): ");
    
    char lowercaseLetter = Console.ReadKey().KeyChar;
     System.Console.WriteLine();
     if (lowercaseLetter <= 'z'&&lowercaseLetter >= 'a' )
      {
            char uppercaseLetter = (char)(lowercaseLetter - 'a' + 'A');
            Console.WriteLine(uppercaseLetter);
      }
      else
            Console.WriteLine("Invalid input. Please use a lowercase letter");
  } 