using System;
using HashPasswords;
using PR_22._101_Dmitriev_PR5.Models;

namespace PR_22._101_Dmitriev_PR5
{
    internal class Program
    {
        static void Main()
        {
            var db = Helper.GetContext();
            while (true)
            {
                Console.WriteLine("Команды:\n1 - создать учётную запись для пользователя\n2 - обновить пользователя\n3 - удалить пользователя\n4 - завершить работу программы");
                Console.Write("Введите команду из списка: ");
                int commandNumber = Convert.ToInt32(Console.ReadLine());

                switch (commandNumber)
                {
                    case 1: // Добавление пользователя
                        Console.WriteLine("Создание новой учётной записи для пользователя\n\n");


                        Console.Write("Введите логин: ");
                        string login = Console.ReadLine();

                        Console.Write("Введите пароль: ");
                        string password = Console.ReadLine();

                        string hashedPassword = Hash.hashPassword(password);
                        Console.WriteLine($"Хешированный пароль пользователя: {hashedPassword}\n");

                        User user = new User { Login = login, Password = hashedPassword };

                        db.User.Add(user);
                        db.SaveChanges();
                        //Helper.CreateUser(user); // Не работает

                        Console.WriteLine("Учётная запись доабвлена");
                        break;

                    case 2: // Обновление пользователя
                        Console.WriteLine("Обновление информации о пользователе\n\n");


                        Console.Write("Введите ID пользователя, которого хотите обновить: ");
                        int userId = Convert.ToInt32(Console.ReadLine());

                        user = db.User.Find(userId);

                        if (user != null)
                        {
                            Console.Write("Введите новый логин (оставьте пустым, если не хотите изменять): ");
                            string newLogin = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newLogin))
                            {
                                user.Login = newLogin;
                            }

                            Console.Write("Введите новый пароль (оставьте пустым, если не хотите изменять): ");
                            string newPassword = Hash.hashPassword(Console.ReadLine()); // Хеширование пароля
                            if (!string.IsNullOrEmpty(newPassword))
                            {
                                user.Password = newPassword;
                            }

                            Helper.UpdateUser(user); // А здесь уже работает...

                            Console.WriteLine($"Пользователь с ID = {userId} успешно обновлён");
                        }
                        else
                        {
                            Console.WriteLine($"Пользователь с ID = {userId} не найден в базе данных.");
                        }
                        break;

                    case 3: // Удаление пользователя
                        Console.WriteLine("Удаление пользователя\n\n");


                        Console.Write("Введите ID пользователя, которого хотите удалить: ");
                        userId = Convert.ToInt32(Console.ReadLine());

                        db.User.Remove(db.User.Find(userId));
                        db.SaveChanges();
                        //Helper.RemoveUser(userId); // А это опять не работает...

                        Console.WriteLine("Пользователь успешно удален.");
                        break;

                    case 4: // Завершение работы
                        Console.WriteLine("Завершение работы . . .");
                        return;

                    default:
                        Console.WriteLine("Такой команды не существует! Введите команду 1, 2, 3 или 4: ");
                        commandNumber = int.Parse(Console.ReadLine());
                        break;
                }
            }
                                   
        }
    }
}
