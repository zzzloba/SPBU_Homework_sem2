﻿using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в симулятор собаки!\n");
            Console.Write("Перемещайте персонажа ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" по лабиринту с помощью клавиш стрелок.\n");
            Console.WriteLine("Ваша цель добраться до косточек 'X' и не врезатьсся в стены #\n");
            Console.WriteLine("Для выхода из игры нажмите Escape\n");
            Console.WriteLine("Нажмите пробел для старта");


            while (true)
            {
                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Вы вышли из игры.");
                    return;
                }
            }

            try
            {
                var eventLoop = new EventLoop();
                var game = new Game("map.txt");

                eventLoop.LeftHandler += game.OnLeft;
                eventLoop.RightHandler += game.OnRight;
                eventLoop.UpHandler += game.OnUp;
                eventLoop.DownHandler += game.OnDown;

                eventLoop.Run();
            }
            catch (Exceptions.HitWallException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Удачи в следующий раз.");
                Console.WriteLine();
            }
            catch (Exceptions.GotBonesException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Спасибо за игру!");
                Console.WriteLine();
            }
            catch (Exceptions.GoingOutOfScreenException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Оставайтесь в зоне видимости!");
                Console.WriteLine();
            }
        }
    }
}
