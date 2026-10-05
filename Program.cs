using System.Diagnostics.Metrics;

int lessonNumber = 1;
int totalLessons = 5;
while (lessonNumber <= totalLessons) {
    Console.WriteLine($"Пара {totalLessons}");
    totalLessons--;
}
Console.WriteLine("Пары закончились");


Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int count = 0;
while (grade != -1) {
    Console.WriteLine($"Оценка принята: {grade}");
    count+=1;
    grade = int.Parse(Console.ReadLine());
}
Console.WriteLine("Ввод завершён");
Console.WriteLine($"Всего введено оценок {count}");


int sum = 0;
int count = 0;
int max = 0;
Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
while (grade != -1) {
    sum += grade;
    count++;
    if (grade > max) {
        max = grade;
    }
    else {
        max = max;
    }
    grade = int.Parse(Console.ReadLine());
}
if (count > 0) {
    Console.WriteLine($"Средний балл: {(double)sum / count}");
    Console.WriteLine($"Наибольший балл: {max}");
} else {
    Console.WriteLine("Оценок не было введено");
}


string correctPassword = "qwerty123";
int incorrectPassword = 0;
while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();
    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        Console.WriteLine($"Количество неверных попыток {incorrectPassword}");
        break;
    }
    incorrectPassword+=1;
    Console.WriteLine("Неверный пароль, попробуйте снова");
}


