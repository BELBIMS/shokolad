int money = 15; // Переменная, обозначающая количество денег
int price = 1; // Переменная, обозначающая стоимость шоколадки
int wrap = 3; // Переменная, обозначающая количество обёрток для обмена на шоколадку

int a = money / price; // Вычисляет, сколько шоколадок можно купить на имеющиеся деньги
int choc = a + (a - 1) / (wrap - 1); // Вычисляет, сколько шоколадок можно получить за счёт обмена обёрток
Console.WriteLine(choc); // Выводит результат на экран - общее количество шоколадок, которые можно получить
