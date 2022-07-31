using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class ProcessMessage
    {
        private bool pizdec = false;
        string UserClan = "";
        string UserName = "";
        public string GetResponse(string message)
        {
        if(!pizdec)
            {
                if(message == "/start")
                {
                    return "ку, хочешь сыграть в текстовый квест?(да или нет?)";
                }
                if (message == "да")
                {
                    return "Пока что есть один квест, Напиши \'Тени Пика'без скобок";     
                }
                if(message == "Тени Пика")
                {
                    return "Ты попал в мир шиноби, пора тебе выбрать клан. Всего три клана: Учихи, Узумаки и Ли. Выбери один и напиши название.";
                }
                if (message == "Учихи" || message == "клан Учихи")
                {
                    message = UserClan;
                    return "Хороший выбор. Учихи хороши, главная их особенность это их глаза. Пора придумать ник. Его длина не должна быть больше 10 и меньше 3 символов.";
                }
                else if (message == "Узумаки" || message == "клан Узумаки")
                {
                    message = UserClan;
                    return "Хороший выбор. Узумаки хороши, главная их особенность это большой объём чакры. Пора придумать ник. Его длина не должна быть больше 10 и меньше 3 символов.";
                }
                else if (message == "Ли" || message == "клан Ли")
                {
                    UserClan = message;
                    return "Хороший выбор. Ли хороши, главная их особенность это большая физическая сила. Пора придумать ник. Его длина не должна быть больше 10 и меньше 3 символов.";
                }
                if(message.Length <= 10 && message.Length >=3 )
                {
                   UserName = message;
                    return "Ну что пора узнать о своем профиле." + "Твоё имя:"  + UserName + " Твой клан: " + UserClan;
                }
                else
                {
                    return "Неизвестная команда. Иди нахер";
                }

                
            }













            return "";
            /*switch (message)
            {
                case "/start":
                    return "ку, хочешь сыграть в текстовый квест?(да или нет?)";


                case "да":
                    return "Пока что есть один квест, Напиши \'Тени Пика'без скобок";
                case "Тени Пика":
                    return "Ты попал в мир шиноби, пора тебе выбрать клан. Всего три клана: Учихи, Узумаки и Ли. Выбери один и напиши название.";

                default:
                    if (message == "Учихи" || message == "клан Учихи")
                    {
                        message = UserClan;
                        return "Хороший выбор. Учихи хороши, главная их особенность это их глаза.";
                    }
                    else if (message == "Узумаки" || message == "клан Узумаки")
                    {
                        message = UserClan;
                        return "Хороший выбор. Узумаки хороши, главная их особенность это большой объём чакры.";
                    }
                    else if (message == "Ли" || message == "клан Ли")
                    {
                        message = UserClan;
                        return "Хороший выбор. Ли хороши, главная их особенность это большая физическая сила.";
                    }
                    else
                    {
                        return "Неизвестная команда";
                    }

            }*/
        }
        public string Clans(string message)
        {
            if (message == "Учихи" || message == "клан Учихи")
            {
                message = UserClan;
                return "Хороший выбор. Учихи хороши, главная их особенность это их глаза.";
            }
            else if (message == "Узумаки" || message == "клан Узумаки")
            {
                message = UserClan;
                return "Хороший выбор. Узумаки хороши, главная их особенность это большой объём чакры.";
            }
            else if(message == "Ли" || message == "клан Ли")
            {
                message = UserClan;
                return "Хороший выбор. Ли хороши, главная их особенность это большая физическая сила.";
            }
            else
            {
                return "Неизвестная команда";
            }
        }
    }
}
