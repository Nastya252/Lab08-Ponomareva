// using System.Diagnostics.Metrics;

// int lessonNumber = 1;
// int totalLessons = 5;
// while (lessonNumber <= totalLessons) {
//     Console.WriteLine($"Пара {totalLessons}");
//     totalLessons--;
// }
// Console.WriteLine("Пары закончились");


// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 0;
// while (grade != -1) {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count+=1;
//     grade = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Всего введено оценок {count}");


// int sum = 0;
// int count = 0;
// int max = 0;
// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1) {
//     sum += grade;
//     count++;
//     if (grade > max) {
//         max = grade;
//     }
//     else {
//         max = max;
//     }
//     grade = int.Parse(Console.ReadLine());
// }
// if (count > 0) {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     Console.WriteLine($"Наибольший балл: {max}");
// } else {
//     Console.WriteLine("Оценок не было введено");
// }


// string correctPassword = "qwerty123";
// int incorrectPassword = 0;
// while (true) {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();
//     if (password == correctPassword) {
//         Console.WriteLine("Доступ разрешён");
//         Console.WriteLine($"Количество неверных попыток {incorrectPassword}");
//         break;
//     }
//     incorrectPassword+=1;
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }


// string answer;
// do {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");
// Console.WriteLine("Дневник сохранён");


/*
Задача А. С помощью цикла-счётчика выведите 
таблицу умножения на число N 
(от 1 до 10), где N задаётся в коде.
*/
// int n = 7;
// int num = 1;
// while (num <11) {
//     Console.WriteLine($"{num} * {n} = {num*n}");
//     num+=1;
// }


/*
Задача Г. С помощью бесконечного цикла и 
break реализуйте программу, которая 
запрашивает у пользователя целые числа, 
пока он не введёт число, кратное 7, а затем 
выводит «Найдено!» и останавливается.
*/
// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine());
// while (true) {
//     if (num % 7 == 0) {
//         Console.WriteLine("Найдено!");
//         break;
//     }
//     Console.WriteLine("Введите следующее число:");
//     num = int.Parse(Console.ReadLine());
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

/*
Вариант 3. Таблица квадратов 
С помощью цикла-счётчика выведите таблицу квадратов чисел от 1 до N 
(например: 1 → 1, 2 → 4, 3 → 9, …). 
Подсказка: цикл-счётчик. 
*/
// int n = 7;
// int i = 1;
// while (i<=n) {
//     Console.WriteLine($"{i} * {n} = {i*n}");
//     i++;
// }

/*
Вариант 6. Количество цифр в числе 
Считайте с клавиатуры целое положительное число и 
посчитайте, сколько в нём цифр, с помощью цикла 
(подсказка: пока число не станет равным 0, делите его на 10 
нацело и увеличивайте счётчик). 
Подсказка: цикл-счётчик, где условие — число != 0.
*/
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
int count = 0;
while (n!=0) {
    n = n/10;
    count++;
}
Console.WriteLine(count);