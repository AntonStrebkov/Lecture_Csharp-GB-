//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Exponentiation(int number //3, int degree //5)
{
  int result = 1;
  int index = 0;
  while(index //0 <= degree //5)
  {
    result = result * number;
    //1       //1      //3
    index++;
  }
  return result;
}

void WriteExponentiation(int number, int degree)
{
  Console.Write($"{number}, {degree} -> {Exponentiation(number, degree)}")
}
WriteExponentiation(Exponentiation(3, 5));
WriteExponentiation(Exponentiation(2, 4));

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Sum(int num)
         //452
{
 int result = 0;
 int len = num.Length;
               //3
 for(i = 0; i < len ; i++;)
          //0 < 3
 {
  result = result + num % 10;
  //0       //0       //2
  num = num / 10;
  
  //2 = 2 + 
 }
 
 return result;
}


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int num)
{
  int[] arr = new int[num];
  
  for(i = 0; i < num; i++;)
  {
    arr[i] = new Random().Next(1, 51);
    
  }
  return arr;
}

void WriteArray(int[] arr)
{
  len = arr.Length;
  for(j = 0; j < len; j++)
  {
  Console.Write($"{arr[i]}, ");
  }
}






