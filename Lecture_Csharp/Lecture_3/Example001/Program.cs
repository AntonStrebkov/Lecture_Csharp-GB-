// Виды функций (методов) в программировании:
// Вид 1:
// Ничего не принимает и ничего не возвращает.

void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

// Вид 2:
// Что-то принимает и ничего не возвразает.

void Method2(string text, int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine(text);
    }
}
//Method2("текст", 5);

// Вид 3:
// ничего не принимает и что-то возвращает.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//System.Console.WriteLine(year);

// Вид 4:
// Что-то принимают и что-то возвращают.

string Method4(int count, string text)
{
string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(5, "qwer");
// System.Console.WriteLine(res);

// Цикл в цикле
// Таблица умножения
for (int i = 2; i < 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} x {j} = {i * j}");
        
    }
    //Console.WriteLine();
}


// — Я думаю, — сказал князь, улыбаясь, — что,
// ежели бы вас послали вместо нашего милого
// Винценгероде, вы бы взяли приступом согласие
// прусского короля. Вы так красноречивы. Вы
// дадите мне чаю?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            +    "ежели бы вас послали вместо нашего милого "
            +    "Винценгероде, вы бы взяли приступом согласие прусского короля. "
            +    "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             0123
// s[3] -> r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

//Упорядочить массив

int[] array = {1,6,8,3,5,2,8,5,3,1,6};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);

PrintArray(array);