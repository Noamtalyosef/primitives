string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

      while(true)
      {
        Console.WriteLine("Enter a string to search");
        string input = Console.ReadLine();
        bool isInputFaound= sentence.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;
       System.Console.WriteLine(isInputFaound);
      }