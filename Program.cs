using System;

namespace ChatBot
{
    class Program
    {
        static int num = 0;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; //Установка белого цвета текста
            Console.WriteLine("Политический тест от _Vova2307_");
            Console.Title = "Политический тест"; //Установка имени окна

            int answer;

            Console.WriteLine("Для прододжения нажмите любую клавишу...");
            Console.ReadKey();

            //Экономическая ось
            Console.WriteLine("Экономическая ось. Количество вопросов: 28");
            answer = Questsion("Я за отмену МРОТ(Минимальный Размер Оплаты Труда)");
            answer -= Questsion("Вся промышленность должна быть в руках государства");
            answer += Questsion("Международная торговля - выгодно");
            answer -= Questsion("Вмешательство государства в экономику необходимо для построения благосостояния жителей");
            answer += Questsion("Рынок, как правило, лучше распределяет ресурсы, чем государство");
            answer -= Questsion("Налоги на богатых должны быть увеличены для обеспечения бедных");
            answer -= Questsion("Государство должно вводить пособия бедным");
            answer -= Questsion("Пенсионные системы должны быть в руках государства");
            answer -= Questsion("Государственные регулирования цен хорошо способствуют экономике");
            answer += Questsion("Образование для тех, кто может платить больше, должно быть лучше");
            answer += Questsion("Здравохранение для тех, кто можнт платить больше, должно быть лучше");
            answer -= Questsion("Государство должно распределять богатство между бедными и богатыми");
            answer -= Questsion("Рыночная экономика приносит больше вреда, чем пользы");
            answer += Questsion("Контроллирование цен со стороны государства недопустимо");
            answer += Questsion("Государственные программы на создание рабочих мест, как правило, плохая идея");
            answer -= Questsion("Государство должно поддерживать анти-монопольные программы");
            answer += Questsion("Допустимо иметь больше земли, чем это необходимо для жизни");
            answer += Questsion("Вмешательство государства в экономику, как правило, приводит только к большим проблемам");
            answer += Questsion("Рынок благоприятно влияет на права рабочих");
            answer += Questsion("В целом, профсоюзы приносят больше вреда, чем пользы");
            answer -= Questsion("Государство лучше распределяет средства, чем частные корпорации");
            answer += Questsion("Как правило, частные компании эффективнее государственных");
            answer -= Questsion("Широкое участие государства в экономике не несёт особого вреда");
            answer -= Questsion("Равенство важнее экономического роста");
            answer += Questsion("Плановая экономика приносит больше вреда, чем пользы");
            answer -= Questsion("Высокие налоги для корпораций приносят больше вреда, чем пользы");
            answer += Questsion("Право собственности - неприкосновенно");
            answer += Questsion("Лучше, чтобы вся экономиика строилась на частных предприятиях");

            Console.WriteLine("Все вопросы из экономической оси пройдены! Вычисление ответа...");
            answer = GetValue(answer, 28);

            if(answer <= -75) //Если процентов плановой экономики больше 75
            {
                Console.ForegroundColor = ConsoleColor.Green; //Установка зеленого цвета текста
                Console.WriteLine("Экономическая ось: Крайне социалистическая");
                Console.WriteLine("Процентов плановой экономики: {0}", Math.Abs(answer));
                Console.WriteLine("Процентов рыночной экономики: {0}", 100 - Math.Abs(answer));
                Console.ForegroundColor = ConsoleColor.White; //Возврат цвета
            } else if(answer > -75 && answer <= -50) //Если процентов плановой экономики меньше 75 и больше 50
            {
                Console.ForegroundColor = ConsoleColor.Green; //Установка зеленого цвета текста
                Console.WriteLine("Экономическая ось: Социалистическая");
                Console.WriteLine("Процентов плановой экономики: {0}", Math.Abs(answer));
                Console.WriteLine("Процентов рыночной экономики: {0}", 100 - Math.Abs(answer));
                Console.ForegroundColor = ConsoleColor.White; //Возврат цвета
            } else if(answer > -50 && answer <= -10) //Если процентов плановой экономики меньше 50 и больше 10
            {
                Console.ForegroundColor = ConsoleColor.Green; //Установка зеленого цвета текста
                Console.WriteLine("Экономическая ось: Смешанная с левым уклоном");
                Console.WriteLine("Процентов плановой экономики: {0}", Math.Abs(answer));
                Console.WriteLine("Процентов рыночной экономики: {0}", 100 - Math.Abs(answer));
                Console.ForegroundColor = ConsoleColor.White; //Возврат цвета
            } else if(answer > -10 && answer <= 10) //Если процентов плановой экономики меньше 10 и процентов рыночной экономики меньше 10
            {
                Console.ForegroundColor = ConsoleColor.Green; //Установка зеленого цвета текста
                Console.WriteLine("Экономическая ось: Смешанная");
                if(answer > -10 && answer < 0)
                {
                    Console.WriteLine("Процентов плановой экономики: {0}", Math.Abs(answer));
                    Console.WriteLine("Процентов рыночной экономики: {0}", 100 - Math.Abs(answer));
                } else
                {
                    Console.WriteLine("Процентов плановой экономики: {0}", 100 - Math.Abs(answer));
                    Console.WriteLine("Процентов рыночной экономики: {0}", Math.Abs(answer));
                }
            }

            Console.ReadKey();
        }

        static int Questsion(string txt)
        {
            int answer;
            num += 1;

            Console.ForegroundColor = ConsoleColor.Green; //Установка цвета на зелёный
            Console.WriteLine(num + ". " + txt); //Вывод вопроса на экран
            Console.ForegroundColor = ConsoleColor.White; //Возврат цвета

            Console.WriteLine("Выберите ответ:" +
                "\n1. Полностью согласен" +
                "\n2. Скорее согласен" +
                "\n3. Не уверен/Не знаю" +
                "\n4. Скорее не согласен" +
                "\n5. Полностью не согласен"); //Вывод выбора варианта ответа

            while(true) //Бесконечный цикл для уверенности в обработке ошибок
            {
                try
                {
                    Console.Write("Ваш ответ: ");
                    answer = Int32.Parse(Console.ReadLine());
                    if(answer > 0 & answer < 6)
                    {
                        answer -= 3; //Установка для выражения
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red; //Установка красного цвета текста
                    Console.WriteLine("Ошибка: Ответ не из списка! Пожалуйста, введите ваш ответ снова.");
                    Console.ForegroundColor = ConsoleColor.White; //Возврат цвета
                } catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red; //Установка красного цвета текста
                    Console.WriteLine("Ошибка: Введено не число! Пожалуйста, проверьте ваш ответ.");
                    Console.ForegroundColor = ConsoleColor.White; //Возврат цвета текста
                } catch
                {
                    Console.ForegroundColor = ConsoleColor.Red; //Установка красного цвета текста
                    Console.WriteLine("Ошибка: Неизвестная ошибка.");
                    Console.ForegroundColor = ConsoleColor.White; //Возврат цвета текста
                }
            }

            return answer;
        }
        static int GetValue(int answer, int questsoins)
        {
            double percent = answer / questsoins * 4; //Вычисление значения
            percent = percent * 100; //Приведение к процентной системе
            answer = (int) percent;
            if(answer < 0)
            {
                answer -= 50;
            } else
            {
                answer += 50;
            }
            return answer; //Возврат ответа
        }

    }
}
