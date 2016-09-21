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
