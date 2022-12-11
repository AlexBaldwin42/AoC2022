using System.IO;
using System.Collections.Generic;
var lines = File.ReadLines("input.txt");

calcPart2();
void calcPart2(){

  // Part 2

  var points = new Dictionary<char, int>();
  points.Add('A', 1);
  points.Add('B', 2);
  points.Add('C', 3);
  var words = new Dictionary<char, string> ();
  words.Add( 'A', "Rock    ");
  words.Add('B',  "Paper   ");
  words.Add( 'C', "Scissors");
  var winlosttieWords = new Dictionary<char, string> ();
  winlosttieWords.Add( 'X', "Lose");
  winlosttieWords.Add('Y', "Draw");
  winlosttieWords.Add( 'Z', "Win");
  //x lose
  //y draw 
  //z win 
  // A Rock
  // B Paper
  // C Scissors
  var winningHand = new Dictionary<char, char>();
  winningHand.Add('A', 'B');
  winningHand.Add('B', 'C');
  winningHand.Add('C', 'A');

  // x lose y draw z wind
  lines = File.ReadLines("input.txt");
  int myScore = 0;
  foreach (var line  in lines)
  {
    char elfHand =line.Substring(0, 1)[0]; 
    //char myHand = line.Substring(2, 1)[0];
    char winLostTie =line.Substring(2,1)[0];
    char myHand = ' ';

    switch(winLostTie){
      case 'X':
        // Lose
        myHand =winningHand.Where(i=> i.Value == elfHand).Select(i=> i.Key).First();
        break;
      case 'Y':
 
        // drawk
        myHand = elfHand;
        myScore += 3;
        break;
      case 'Z':

        // win
        myHand = winningHand[elfHand];
        myScore += 6;
        break;
    }
    Console.WriteLine($"Elf: {words[elfHand]} Mine: {words[myHand]} {winlosttieWords[winLostTie]}");
    myScore += points[myHand];
    

//    Console.Write($"e:{words[elfHand]} M:{words[myHand]} ");



  }
  Console.WriteLine($"myScore {myScore}");
}



//calcPart1();
void calcPart1(){

  var translate = new Dictionary<char, char> ();
  translate.Add('A', 'X');
  translate.Add('B', 'Y');
  translate.Add('C', 'Z');

  var points = new Dictionary<char, int>();
  points.Add('X', 1);
  points.Add('Y', 2);
  points.Add('Z', 3);

  var words = new Dictionary<char, string> ();
  words.Add( 'X', "rock");
  words.Add('Y', "Paper");
  words.Add( 'Z', "Scissors");


  int elfScore = 0;
  int myScore = 0; 
  foreach (var line  in lines)
  {
    char elfHand = translate[line.Substring(0, 1)[0]]; 
    char myHand = line.Substring(2, 1)[0];
    Console.Write($"e:{words[elfHand]} M:{words[myHand]} ");

    elfScore += points[elfHand];
    myScore += points[myHand];
    //x rock
    //y paper
    //z sci 
    if(elfHand != myHand)
    {
      if(elfHand == 'X' )
      {
        if(myHand == 'Y'){
          myScore += 6;
          Console.WriteLine("i win");
        }else if(myHand == 'Z'){
          Console.WriteLine("elf win");
          elfScore +=6;
        }
      }
      else if(elfHand == 'Y' )
      {
        if(myHand == 'Z'){
          myScore += 6;
          Console.WriteLine("i win");
        }else if(myHand == 'X'){
          elfScore +=6;
          Console.WriteLine("elf win");
        }
      }

      else if(elfHand == 'Z' )
      {
        if(myHand == 'X'){
          Console.WriteLine("i win");
          myScore += 6;
        }else if(myHand == 'Y'){
          elfScore +=6;
          Console.WriteLine("elf win");
        }
      }

    }else{
      Console.WriteLine(" tie");
      myScore+=3;
      elfScore+=3;
    }

  }

  Console.WriteLine($"myscore {myScore} elfscore{elfScore}");

}
