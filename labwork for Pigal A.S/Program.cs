using System;

namespace labwork_for_Pigal_A.S
{
    class Program
    {

        static int Input()
        {
            string temp;
            int x;
            temp = Console.ReadLine();
            if (Int32.TryParse(temp, out int temp2))
            {
                x = temp2;
            }
            else
            {
                Console.WriteLine("ЦИФРЫЫЫЫЫ НУЖНЫ");
                while (!int.TryParse(Console.ReadLine(), out temp2))
                {
                    Console.WriteLine("ЦИФРЫЫЫЫЫ НУЖНЫ");                 
                }
                x = temp2;
            }
            return x;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите секунды");
            int sec = Input();
            Console.WriteLine("Введите минуты");
            int min = Input();
            Console.WriteLine("Введите часы");
            int hour = Input();
            min +=sec / 60;
            hour += min / 60;
            int day = hour / 24;
            sec %= 60;
            min %= 60;
            hour %= 24;
            Console.WriteLine($"{day}:{hour}:{min}:{sec}");
            Console.WriteLine("добавить хотите?");
            string selection = Console.ReadLine();
            switch(selection)
            {
                case "да":
                    {
                        Console.WriteLine("Что вы хотите добавить? 1 2 3 4");
                        string s = Console.ReadLine();
                        if (s == "1")
                        {
                            while (s == "1")
                            {
                                Console.WriteLine("Введите кол-во секунд");
                                sec = sec + Input();
                                min = sec / 60 + min;
                                hour = min / 60 + hour;
                                day = day + hour / 24;
                                hour %= 24;
                                min %= 60;
                                sec %= 60;
                                Console.WriteLine($"{day}:{hour}:{min}:{sec}");
                                Console.WriteLine("Для повторения операции введите 1");
                                s = Console.ReadLine();
                            }
                            goto case "добавить";
                        }
                        else if (s == "2")
                        {
                            while (s == "2")
                            {
                                Console.WriteLine("Введите кол-во минут");
                                min = Input() + min;
                                hour = min / 60 + hour;
                                day = day + hour / 24;
                                hour %= 24;
                                min %= 60;
                                Console.WriteLine($"{day}:{hour}:{min}:{sec}");
                                Console.WriteLine("Для повторения операции введите 2");
                                s = Console.ReadLine();
                            }
                            goto case "добавить";
                        }
                        else
                        {
                            if (s == "3")
                            {
                                while (s == "3")
                                {
                                    Console.WriteLine("Введите кол-во часов");
                                    
                                    hour = Input() + hour;
                                    day = day + hour / 24;
                                    hour %= 24;

                                    Console.WriteLine($"{day}:{hour}:{min}:{sec}");
                                    Console.WriteLine("Для повторения операции введите 3");
                                    s = Console.ReadLine();
                                }
                                goto case "добавить";
                            }
                            else if(s=="4")
                            {   
                                    while (s == "4")
                                    {
                                        Console.WriteLine("Введите кол-во дней");
                                        day = day + Input();
                                        hour %= 24;
                                        min %= 60;
                                        sec %= 60;
                                        Console.WriteLine($"{day}:{hour}:{min}:{sec}");
                                    Console.WriteLine("Для повторения операции введите 4");
                                    s = Console.ReadLine();
                                    }
                                    goto case "добавить";
                            }
                            else
                            {
                                goto case "нет";
                            }
                        }
                    }
                case "добавить":
                    {
                        Console.WriteLine("Вы хотите добавить что-нибудь ещё? ДА или НЕТ");
                        string adding = Console.ReadLine();
                        adding.ToLower();
                        if (adding == "да")
                        {
                            goto case "да";
                        }
                        else
                        {
                            goto case "нет";
                        }
                    }
                case "нет":
                    {
                        Console.WriteLine("ну и ладно");
                        break;
                    }
            }
        }   
        
    }
}

