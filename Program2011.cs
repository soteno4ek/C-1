//делегаты

// // public delegate void MyDelegate(string prompt);
// //
// // internal class Program
// // {
// //     private static void Main(string[] args)
// //     {
// //         MyDelegate myDelegate = Log;
// //         // myDelegate("Это лог");
// //         myDelegate += Error;
// //         // myDelegate("Это ошибка");
// //         myDelegate -= Log;
// //         // myDelegate("Только одна ошибка");
// //         myDelegate -= Info;
// //         myDelegate("Что же будет?");
// //     }
// //
// //     public static void Log(string msg)
// //     {
// //         Console.WriteLine("Log: " + msg);
// //     }
// //
// //     public static void Error(string msg)
// //     {
// //         Console.WriteLine("Error: " + msg);
// //     }
// //
// //     public static void Info(string msg)
// //     {
// //         Console.WriteLine("Info: " + msg);
// //     }
// //
// // }
//
// // public delegate List<int> ListDelegate(List<int> list);
// // internal class Program
// // {
// //     private static void Main(string[] args)
// //     {
// //         ListDelegate listDelegate = SortList;
// //         var list = new List<int> { 6, 11, 2, 5, 6 };
// //         listDelegate(list);
// //         foreach (var item in list)
// //         {
// //             Console.Write(item + " ");
// //         }
// //
// //         Console.WriteLine();
// //
// //         listDelegate += DeleteList;
// //         listDelegate(list);
// //         foreach (var item in list)
// //         {
// //             Console.Write(item + " ");
// //         }
// //     }
// //
// //     public static void RunDelegate(List<int> list, ListDelegate listDelegate)
// //     {
// //         var l = listDelegate(list);
// //         foreach (var item in l)
// //         {
// //             Console.Write(item + " ");
// //         }
// //         Console.WriteLine();
// //     }
// //
// //     //сортировка
// //     public static List<int> SortList(List<int> list)
// //     {
// //         var result = new List<int>();
// //         result = list;
// //         result.Sort();
// //         return result;
// //     }
// //     
// //     //удаление первый и последний
// //     public static List<int> DeleteList(List<int> list)
// //     {
// //         var result = new List<int>();
// //         result = list;
// //         if (result.Count > 0)
// //         {
// //             result.RemoveAt(0);
// //             if (result.Count > 0)
// //             {
// //                 result.RemoveAt(-1);
// //             }
// //         }
// //         return result;
// //     }
// // }
//
// using System;
// using System.Net.Security;
//
// public delegate List<int> ListDelegate(List<int> list);
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         ListDelegate listDelegate = SortList;
//         var list = new List<int>() { 6, 9, 2, 5, 1, 0 };
//         RunDelegate(list, listDelegate);
//         listDelegate += DeleteList;
//         RunDelegate(list, listDelegate);
//         listDelegate += DeleteList;
//         RunDelegate(list, listDelegate);
//     }
//
//     public static void RunDelegate(List<int> list, ListDelegate listDelegate)
//     {
//         var l = listDelegate(list);
//         foreach (var item in l)
//         {
//             Console.Write(item + " ");
//         }
//         Console.WriteLine();
//     }
//
//     //сортировка
//     public static List<int> SortList(List<int> list)
//     {
//         var result = new List<int>();
//         result = list;
//         result.Sort();
//         return result;
//     }
//     
//     //удаление первый и последний
//     public static List<int> DeleteList(List<int> list)
//     {
//         var result = new List<int>();
//         result = list;
//         if (result.Count > 0)
//         {
//             result.RemoveAt(0);
//             if (result.Count > 0)
//             {
//                 result.RemoveAt(result.Count -1);
//             }
//         }
//         return result;
//     }
// }


// //linq-запросы
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         List<string> list = new List<string>()
//             { "Ваня", "Никита", "Витя", "Полина", "Паша" };
//         //все имена из 4 букв, которые начинаются на букву "В"
//         // var result = from n in list
//         //     where n.Length == 4 && n[0] == 'В'
//         //     select n;
//         // foreach (var n in result)
//         // {
//         //     Console.WriteLine(n);
//         // }
//         
//         //вывести в алфавитном порядке все имена на букву "П"
//         var res = from n in list
//             where n[0] == 'П'
//             orderby n
//             select n;
//         foreach (var n in res)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }

//linq-запросы
internal class Program
{
    private static void Main(string[] args)
    {
        List<Pizza> pizza = new List<Pizza>();
        pizza.Add(new Pizza("Пепперони", 30, 500));
        pizza.Add(new Pizza("Сырная", 10, 300));
        pizza.Add(new Pizza("Грибная", 20, 250));
        pizza.Add(new Pizza("Куриная", 30, 570));
        pizza.Add(new Pizza("Гавайская", 35, 700));
        
        //получить название всех пицц с диаметром больше 25 и дешевле 550
        Console.WriteLine("получить название всех пицц с диаметром больше 25 и дешевле 550");
        var result1 = from n in pizza
            where n.Diameter > 25 && n.Price < 550
            select n.Name;
        
        foreach (var n in result1)
        {
             Console.WriteLine(n);
        }
        
        Console.WriteLine();
        //получить название и цену всех пицц на букву "Г"
        Console.WriteLine("получить название и цену всех пицц на букву \"Г\"");
        var result2 = from n in pizza
            where n.Name[0] == 'Г'
            select (n.Name, n.Price);
        
        foreach (var n in result2)
        {
            Console.Write(n);
            Console.WriteLine();
        }
        
        Console.WriteLine();
        //получить сумму цен всех пицц с диаметром 30
        Console.WriteLine("получить сумму цен всех пицц с диаметром 30");
        var result3 = (from n in pizza
            where n.Diameter == 30
            select n.Price).Sum();

        Console.WriteLine(result3);
    }
}
