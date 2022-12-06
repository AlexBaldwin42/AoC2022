using System.IO;
using System.Collections.Generic;
var lines = File.ReadLines("input.txt");

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

// Part 2

var points = new Dictionary<char, int>();
points.Add('X', 1);
points.Add('Y', 2);
points.Add('Z', 3);
//x rock
//y paper
//z sci
var winningHand = new Dictionary<char, char>();
translate.Add('X', 'Y');
translate.Add('Y', 'Z');
translate.Add('Z', 'X');
// x lose y draw z wind
lines = File.ReadLines("input.txt");
myScore = 0;
foreach (var line  in lines)
{
  char elfHand = translate[line.Substring(0, 1)[0]]; 
  char myHand = line.Substring(2, 1)[0];

  Console.Write($"e:{words[elfHand]} M:{words[myHand]} ");

  if(myHand = 'X'){
    // find losing hand 
    winningHand.TryGetValue(elfHand).Key
  }



}

