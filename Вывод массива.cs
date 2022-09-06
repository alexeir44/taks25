int [] RandomArray = {0, 0, 0, 0, 0, 0, 0, 0};
byte i;

// Код программы
for (i = 0; i<RandomArray.Length; i++)
    RandomArray[i] = new Random().Next(0, 100); // Вместо рандома, можно организовать пользовательский ввод.

Console.WriteLine("Программа сгенерировала следующий массив: ");

for (i = 0; i<RandomArray.Length; i++)
    Console.Write(RandomArray[i]+" ");