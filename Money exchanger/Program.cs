
    float rublesInWallet;
    float dollarsInWallet;

    int rubToUsd = 64, usdTorub = 66;

    float exchangeCurrentlyCoount;

    string desiredOperation;

    Console.WriteLine("Добро пожаловать в обменик");
while (true)
{
    Console.Write("Введите баланс рублей: ");
    rublesInWallet = Convert.ToSingle(Console.ReadLine());
    Console.Write("Введите баланс доллоров: ");
    dollarsInWallet = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Выберете не обхадимую операцию");
    Console.WriteLine("1 - обменять рубли на доллоры");
    Console.WriteLine("2 - обменять доллоры на рубли");

    Console.Write("Ваш выбор: ");
    desiredOperation = Console.ReadLine();

    switch (desiredOperation)
    {
        case "1":
            Console.WriteLine("Обмен рублей на доллоры");
            Console.Write("Сколько вы хотите обменять? ");
            exchangeCurrentlyCoount = Convert.ToSingle(Console.ReadLine());
            if (rublesInWallet >= exchangeCurrentlyCoount)
            {
                rublesInWallet -= exchangeCurrentlyCoount;
                dollarsInWallet += exchangeCurrentlyCoount / rubToUsd;
            }
            else
            {
                Console.WriteLine("Недопустимое количество рубелей");
            }
            break;
        case "2":
            Console.WriteLine("Обмен доллоров на рубли");
            Console.Write("Сколько вы хотите обменять? ");
            exchangeCurrentlyCoount = Convert.ToSingle(Console.ReadLine());
            if (dollarsInWallet >= exchangeCurrentlyCoount)
            {
                dollarsInWallet -= exchangeCurrentlyCoount;
                rublesInWallet += exchangeCurrentlyCoount * usdTorub;
            }
            else
            {
                Console.WriteLine("Недопустимое количество доллоров");
            }
            break;
        default:
            Console.WriteLine("Я не знаю такой операции");
            break;

    }
    Console.WriteLine($"Ваш баланс: {rublesInWallet} рублей, " + $"{dollarsInWallet} доллоров.");
}