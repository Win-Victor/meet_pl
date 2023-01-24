// 1й тип методов
void method1() // Метод без аргументов, который можно вызвать. Он не принимает ничего и ничего не возвращает. 
{
    System.Console.WriteLine("Автор...");
}

method1(); // Вызоп этого типа методов.

// 2й тип методов
void method2(string msg) // метод с аргументом. Метод ничего не возвращает, но может выводить в консоль.
{
    System.Console.WriteLine(msg);
}

method2("Текст для вывода."); // Вызов такого метода.

// Можно использоват именованные аргументы. Хотя они получаются больше позиционные, чем именнованные.
void method21(string msg, int count)
{
    int i = 0;
    while (i <= count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

method21("Сообщение из метода.", 4);

method21(count: 3, msg: "Сообщение из метода."); // а вот так именнованный аргумент

// 3й тип методов ничего не принимает, но что-то может вернуть - return
// приэтом обязательно нужно указывать тип данные, который он может вернуть.

int method3()
{
    return DateTime.Now.Year;
}

int year = method3(); // вызов стандартный, но нужна переменная куда return нам присвоит значения.
System.Console.WriteLine(year); // а в консоль вызываем уже переменную.

// 4й метод принимает аргументы и возвращает результат. Обязательно указать тип данных, которые вернет метод.
string method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string newText = method4(3, "сообщение\n");
System.Console.WriteLine(newText);

// цикл for
string method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // (инициализация счетчика; условие выхода из цикла; инкремент)
    {
        result += text;
    }
    return result;
}

string newText41 = method41(3, "сообщ\n");
System.Console.WriteLine(newText41);

// цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
                + "ежели бы вас послали вместо нашего милого Винценгероде,"
                + "вы бы взяли приступом согласие прусского короля."
                + "Вы так красноречивы. Вы дадите мне чаю?";

string replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}


// System.Console.WriteLine(text);
string newMyText = replase(text, ' ', '*');
System.Console.WriteLine(newMyText);
