/*    Написать программу, которая из имеющегося массива строк формирует массив из строк, 
      длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
      либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
      лучше обойтись исключительно массивами.    */

string[] Arr_1 = new string[11] { "Морок", "Мо", "Куло", "№!;;", "ло", "коло", "ков", "ково", "@%**^", "!", "Утро" }; 
string[] Arr_2 = new string[Arr_1.Length];
void Selection(string[] Arr_1, string[] Arr_2)
{
      int word = 0;
      for (int i = 0; i < Arr_1.Length; i++)
      {
            if (Arr_1[i].Length <= 3)
            {
                  Arr_2[word] = Arr_1[i];
                  word++;
            }
      }
}
void PrintArray(string[] array)
{
      for (int i = 0; i < array.Length; i++)
      {
            Console.Write($"{array[i]} ");
      }
      Console.WriteLine();
}
Console.Write("Сделали выборку из массива: ");
PrintArray(Arr_1);
Selection(Arr_1, Arr_2);
Console.WriteLine("Получившийся массив из строк: ");
PrintArray(Arr_2);