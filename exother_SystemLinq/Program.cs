using System;
using static System.Console;
using System.Linq;

Clear();

string text="(1,2) (2,3) (4,5) (9,7)"
                .Replace("(", "")  // Таким образом убираем ненужные нам скобочки
                .Replace(")", "");
WriteLine(text);

var data = text.Split(" ")  // Разбиваем строку чере сепаратор ПРОБЕЛ
                .Select(item => item.Split(','))  //Получаем массив  масивов
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1]))) // Таким образом получаем массив кортежей и присваем точкам координат икс и игрик
                .Where(e=> e.x%2==0) // СОбираем только те точки для которых первая координата чётная
                .Select(point=> (point.x*10, point.y))  // Это если хотим присвоить навсегда
                .ToArray(); // Таким образом преобразовываем нашу строку в массив

for (int i = 0; i < data.Length; i++)
{
    //WriteLine(data[i].x*10);  // Указываем координату точки массива и умножаем на 10
    //for (int k = 0; k < data[i].Length; k++)
    //{
    //    WriteLine(data[i][k]);  //Подмассив элемента
    //}
    WriteLine(data[i]);
    WriteLine();
}