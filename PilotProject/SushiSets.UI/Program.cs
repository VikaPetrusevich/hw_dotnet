﻿using Sushi.BL;
ISushiSetService setCollectionService = new SushiSetService();

#region logic
var sushiSet = new SushiSet()
{
    Id = 1,

    Name = "СУПЕР ФИЛАДЕЛЬФИЯ СЕТ",

    Description = "Суши-сет из трех роллов Филадельфия с огурцом, Филадельфия Нью, Филадельфия Фреш.",

    Weight = 900,

    Price = 42.90M
};

var sushiSet2 = new SushiSet()
{
    Id = 2,

    Name = "ШОУ-РОЛЛЗ",

    Description = "Суши-сет из шести роллов: Филадельфия мини, Ролл с лососем и авокадо, Коста, Сезам с чука, Тигра, Гринвуд.",

    Weight = 1200,

    Price = 62.90M
};



setCollectionService.AddSet(sushiSet);
setCollectionService.AddSet(sushiSet2);

#endregion

var userWantExit = false;
while (!userWantExit) 
{
    Console.WriteLine("Нажмите 1 для вывода меню суши сетов.");
    Console.WriteLine("Нажмите 2 для просмотра заказов в корзине.");
    Console.WriteLine("Нажмите 3 для оформления заказа.");
    Console.WriteLine("Нажмите 4 для выхода.");
    var choose = int.Parse(Console.ReadKey().KeyChar.ToString());
    MainMenuHandle(choose, ref userWantExit);
}

void MainMenuHandle(int key,ref bool userWantExit) 
{
    Console.WriteLine("\n************************************");
    switch (key)
    {
        case 1: DisplaySushiSetHandle();
            break;
        case 2: Console.WriteLine("Вы выбрали просмотр корзины.");
            break;
        case 3: Console.WriteLine("Вы выбрали оформление заказа.");
            break;
        case 4: ExistHandle(ref userWantExit);
            break;
        default:
            Console.WriteLine("Вы сделали неправильный выбор.");
            break;
    }
}

void DisplaySushiSetHandle() 
{
    var isBack = false;
    while (!isBack)
    {
        Console.WriteLine("Меню суши сетов.");
        var sushiSetList = setCollectionService.GetSushiList();
        foreach (var item in sushiSetList)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("Выберете номер суши-сета для добавения его в корзину заказов.");
        Console.WriteLine("Нажмите 0 для выхода из меню.");
        var choose = int.Parse(Console.ReadKey().KeyChar.ToString());
        if (choose == 0)
        {
            isBack = true;
        }
        else
        {

        }
    }
    
}

void ExistHandle(ref bool userWantExit) 
{ 
    userWantExit = true;
    Console.WriteLine("Вы выбрали выход.");
}