﻿Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] sourceArray = new string [m];


void ArrayFirst(string [] sourceArray)
{
  for (int i = 0; i < sourceArray.Length; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     sourceArray[i] = Console.ReadLine();
  }
}


string [] ThreeSymbol(string [] sourceArray)
{
  int n = 0;
  for (int i = 0;i<sourceArray.Length;i++)
  {
    if(sourceArray[i].Length <=3)
    n++;
  }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<sourceArray.Length;i++)
  {
    if(sourceArray[i].Length <=3)
    {
        rez[j] = sourceArray[i];
        j++;
    }
  }
  return rez;
}

