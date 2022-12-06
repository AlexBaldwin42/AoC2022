using System.IO;

var lines = File.ReadLines("calories.txt");

List<int> caloriesForElves = new List<int>();

int currentElfCount = 0;
foreach(var line in lines){
  if(line != ""){
    currentElfCount += int.Parse(line);
  }else{
    caloriesForElves.Add(currentElfCount);
    currentElfCount = 0;
  }
}

int top3 =0;
var ordered = caloriesForElves.OrderByDescending(i=> i).ToList();
for (int i = 0; i < 3; i++){
  top3 +=  ordered[i];
}
//Console.WriteLine(caloriesForElves());
Console.WriteLine(top3);
