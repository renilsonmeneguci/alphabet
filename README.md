# alphabet

The Alphabet is a package for characters or index of the alphabet (ABC).

To use, simply install via NuGet with the following command:

`Install-Package Alphabet`

He has two static methods, which are:
  - GetCharacterFromIndex();
  
      This method is responsible for the alphabetic character of the index, as shown in the example:
      
      ```
      var character = AlphabetService.GetCharacterFromIndex(10);
      console.WriteLine("Character:" + character); 
      //result: Characetr: j
      ```
  - GetIndexFromCharacter();
  
      This method is responsible for the alphabetic index of the character, as shown in the example:
      
      ```
      var index = AlphabetService.GetIndexFromCharacter("j");
      Console.WriteLine("Index:" + index);
      //result: Characetr: 10
      ```

# License

Copyright © 2016 Renilson Andrade Meneguci renilsonmeneguci@gmail.com

This work is free. You can redistribute it and/or modify it under the terms of the Do What The Fuck You Want To Public License, Version 2, as published by Sam Hocevar. See the COPYING file for more details.
