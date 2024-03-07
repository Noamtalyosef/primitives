string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

      while(true)
      {
        int counter1 =0;
        foreach (var letter in sentence)
        {
            if(letter==' ')
            {
               counter1++;
            }
        }
        string[] words = new string[counter1+1];


        string word ="";
        int counter2=0;
         foreach(var letter in sentence)
         {
          if(letter!=' ')
          {
          word+=letter;
             
          }
          else
          {
        
            words[counter2]=word;
            word="";
            counter2++;
          }

         } 
         
        Console.WriteLine("Enter a string to search");
         
         

        string input = Console.ReadLine();
       
         bool isFound= false;
        for(int i= 0;i<words.Length-1;i++)
        {
           
            if(words[i]==input)
            {
                System.Console.WriteLine($"true,  index: {i}");
                sentence = sentence.Replace(words[i],string.Empty);
                 System.Console.WriteLine($"now the sentence is:\n{sentence}");
                 isFound=true;
            }
        }
         
        if(!isFound)
        {
            System.Console.WriteLine("word dosent found");
        }
         
      }