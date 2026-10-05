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