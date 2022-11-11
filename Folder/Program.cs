Console.Clear(); 

Console.WriteLine("Введите размермерость массива ");
int size  = Convert.ToInt32(Console.ReadLine());

string[] arrayString = new string[size];
  for (int i=0; i<size; i++)
{
  Console.WriteLine($"Введите {i+1}-й элемент: ");
  string element = Convert.ToString(Console.ReadLine()??"");
  arrayString[i] = element;
}
string[] arrayTotal = new string[size];
int len = 3;
int pos = 0;
  for (int j=0; j<size; j++)
{
  if (arrayString[j].Length<=len)
  {
    arrayTotal[pos] = arrayString[j]; 
    pos++;
  }
}
Console.WriteLine("Результат: ");
 
PrintArray(arrayTotal);

void PrintArray(string[] array)
{
  for (int i=0; i<array.Length;i++)
  {
  Console.Write(array[i]);   
  }
}