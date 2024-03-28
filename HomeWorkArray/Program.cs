Console.WriteLine("Введите размерность матрицы через пробел");
string[] size = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

string rawFirstDimension = (size[0]);
string rawSecondDimension = (size[1]) ;

int firstDimension = int.Parse(rawFirstDimension);
int secondDimension = int.Parse(rawSecondDimension);
int theSizeOfTheMatrix = firstDimension * secondDimension;
string lessЕhanFour = "числа";
string overFour = "чисел";
string strNumbers;

if (theSizeOfTheMatrix > 4)
    strNumbers = overFour;
else
    strNumbers = lessЕhanFour;

if (!int.TryParse(rawFirstDimension, out firstDimension) ||
    !int.TryParse(rawSecondDimension, out secondDimension))
    throw new Exception("Вы ввели не правильное колличество чисел в матрицу");

var array = new int[firstDimension, secondDimension];
Console.WriteLine($"Введите {theSizeOfTheMatrix} {strNumbers}  через пробел") ;
string rawStr = Console.ReadLine();
if (rawStr == null) 
    throw new Exception("Нужно ввести числа в матрицу ");

var rawArray = rawStr.Split(' ');

if (rawArray.Length != firstDimension * secondDimension)
    throw new Exception("Не совпвдает с колличеством значений в матрице");

for (int i = 0; i < firstDimension; i++)
{
    for (int j = 0; j < secondDimension; j++)
    {
        int next;
        if (int.TryParse(rawArray[i * secondDimension + j], out next))
            array[i, j] = next;
        else
            throw new Exception("Нужно вводить числа");
    }
}

Console.WriteLine("Ваша матрица");
for (int i = 0; i < firstDimension; i++)
{
    for (int j = 0; j < secondDimension; j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}