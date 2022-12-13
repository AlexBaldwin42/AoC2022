// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var lines = File.ReadLines("input.txt");


// find doubles
int GetScore(char letter){
   if((byte)letter > 96){
     // Lower case
     return (byte)letter-96;
   }
   return (byte)letter-38;
}
int score = 0;
string FindDouble(string one,string two){
  char foundChar = '=';
  String allFinds = ""; 
        Console.WriteLine($"");
  foreach(char onechar in one){
    foreach(char twochar in two){
      if(onechar == twochar){
//        if(foundChar != '=')throw new Exception($"found extra{foundChar} twochar {twochar}");
        foundChar = twochar;
        score += GetScore(foundChar);
        Console.Write($"About to remove {twochar} from {two}");
        two = two.Replace(twochar.ToString(), "");
        Console.WriteLine($" removed {two}");
        allFinds += (twochar);
        break;
      }
    }
  }
  if(foundChar == '=')  throw new Exception("booo");
  return allFinds;
}
foreach(string line in lines){
  int length =  line.Length;
  string one = line.Substring(0,length/2 );
  string two = line.Substring(length/2, length/2 );
  Console.Write($"left {one} right {two}" );
  string doubleFound =  FindDouble(one, two);
  Console.WriteLine($" double {doubleFound}" );
  //score += GetScore(doubleFound);
 if(doubleFound.Length >1)break; 
//  break;
}
Console.WriteLine($"Score {score}");
//foreach(char i in "abcdefghzABCZ"){
 // Console.WriteLine($"{i} {GetScore(i)}");

//

// calculate priorities
