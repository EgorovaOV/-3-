﻿// Вид 1 ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Автор Егорова О. В.");
}
// Method1();просто чтобы он потом не выполнялся, а так без слешей

// Вид2 ничего не возвращают, но могут принимать аргументы
void Method2 (string msq)
{
    Console.WriteLine(msq);
}
//Method2("Текст сообщения");
// Вид2 ничего не возвращают, но могут принимать аргумент. 
// Варинат с именованными аргументами, когда указываем,
// какому аргументу какое значение хотим указать
 // это бывает нужно, когда методы принимают какое-то количество аргументов, отличное от одного
 void Method21 (string msq, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msq);
        i++;
    }
// если зациклилась программа ctrl+C
}
//Method21("Текст сообщения", 4);
// можем явно указывать какому аргументу какое значение хотим присвоить
// Method21(msq: "Текст сообщения", count: 4);
//необязательно писать попорядку, можно
//Method21(count:4, msq: "Новый текст");

// Вид 3: что-то возвращают но ничего не принимают
// указать тип данных значения которых мы ожидаем

int Method3()
{
    //тут произошла какая-то работа
    return DateTime.Now.Year;
}
// используем идентификатор переменной и через оператор присваивания калдаем туда нужные значения
//сюда положили результат
int year = Method3();
// и можем результат использовать
//Console.WriteLine(year);
//в дальнейшем использовать то значение и ту переменную, которую нам вернул метод

// Вид 4 - что-то принимают и что-то возвращают
// возвращать будем строку, передавать строку C
//string Method4(int count, string text)
//{
//возьмем цикл
//int i=0;
//потребуется переменная, куда положим результат конечный
//сначала положим в нее некое занчение "" пустая строка или так
//string result = String.Empty;

//while (i < count)
//{
  //  result = result + text;
  //  i++;
//}
//указываем переменную, значение которой хотим получить из метода
//return result;
//}
//чтобы вызвать метод, указываем нужную переменную
// и текст который мы будем склеивать 10 раз
//string res = Method4(10,"z");
//Console.WriteLine(res);

// цикл фор
string Method4(int count, string text)
{
//возьмем цикл

//потребуется переменная, куда положим результат конечный
//сначала положим в нее некое занчение "" пустая строка или так
string result = String.Empty;
//  пишем for, далее идет инициализация счетчика
// идет проверка условия
// и делается инкримент - увеличение счетчика
for ( int i=0; i < count; i++)
    {
    result = result + text;
    }
//указываем переменную, значение которой хотим получить из метода
return result;
}
//чтобы вызвать метод, указываем нужную переменную
// и текст который мы будем склеивать 10 раз
string res = Method4(10,"z");
Console.WriteLine(res);

// И вот еще - цикл внутри цикла. Пример вывод таблицы умножения на экран

for ( int i = 2; i <= 10; i++)
{
  for ( int j = 2; j <= 10; j++)
  {
   //  а тут произведение. ага -интерполяция строк
   Console.WriteLine($"{i} * {j} = {i * j}");
  }
  //после выполнения цикла вставим пустую строку чтобы было красиво
  Console.WriteLine();
}

//Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками, 
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
//маленькими “с”.

// ясна ли задача

//— Я думаю, — сказал князь, улыбаясь, — что, 
//ежели бы вас послали вместо нашего милого 
//Винценгероде, вы бы взяли приступом согласие 
//прусского короля. Вы так красноречивы. Вы 
//дадите мне чаю?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого "
+ "Винценгероде, вы бы взяли приступом согласие "
+ "прусского короля. Вы так красноречивы. Вы "
+ "дадите мне чаю?";
// string s = "qwerty"
//             012345
// обратитьтся к символу s[3] // r

// указ текст, конкретный символ, консретны йсимвол на который будем менять
string Replace(string text, char oldValue, char newValue)
{
    // чтобы себя не путать, заводим новую строку
    string result = string.Empty;

    // чтобы узнать длину строки, обратимся к свойству, показ кол-во символов в строке
    int length = text.Length;
    for (int i = 0;  i < length; i++)
    {
        //если текст совпал с тем который мы хотим заменить, то кладем туда новое
        if(text[i] == oldValue) result = result + $"{newValue}";
        //если не совпал, кладем туда текущий символ
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace (text, ' ' , '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

// Метод выбора 
// заведем массив, который будем отсортровывать

int [] arr = { 1, 5 , 4 , 3 , 2 , 6 , 7, 1, 1};

//выводим подзадачу вывода массива на экран
// вк ачестве аргумента приводим массив
void PrintArray(int[] array)
{
  // получение количества элементов
  int count = array.Length;

     for (int i = 0; i < count; i++)
     //цикл фор в котором пробегаем по всем элементам
     {
       // и показываем на экране
       Console.WriteLine($"{array[i]} ");
     }
     Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
         int minPosition = i;
         
         for (int j = i + 1;  j < array.Length; j++)
         {
             if(array[j] < array[minPosition] ) minPosition = j;
         }
         
         //меняем мин позицию с той позицией, которую нашли
         int temporary = array[i];
         array[i] = array [minPosition];
         array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);





