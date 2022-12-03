/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Enter number :");
string numberStr = Console.ReadLine() ?? "";

if(int.TryParse(numberStr, out int number)){
  
  string str = number.ToString();
  if(str.Length < 3){
    Console.WriteLine($"The number {str} doesn't has third digital");
  }else{
    Console.WriteLine($"Third digit from string is {str[2]}");
  }
}else{
  Console.WriteLine($"invalid input");
}

//get third digit from mathematic without string
int GetThirdDigitalOfNumber(int num)
{
  int number = num;
  int i = 0;
  var digits = new List<int>();
  
  while(number > 0)
  {
    digits.Add(number);
    number/= 10;
    i++;
  }

  int lenght = digits.Count;
  if(lenght < 3 )
  {
    Console.WriteLine($"The number {num} doesn't has third digital");
    return -1;
  }
  else
  {
    int res = digits[lenght - 3] - (digits[lenght - 2] * 10);
    Console.WriteLine($"Third digit from math is {res}");
    return res;
  }
}

GetThirdDigitalOfNumber(number);