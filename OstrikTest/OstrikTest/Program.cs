using System;
using InspectorLib;

namespace OstrikTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса FunctionInsp
            FunctionInsp inspector = new FunctionInsp();

            // Выводим имя главного инспектора
            Console.WriteLine($"Главный инспектор: {inspector.GetInspector()}");

            // Выводим название автоинспекции
            Console.WriteLine($"Название автоинспекции: {inspector.GetCarInspection()}");

            // Пытаемся изменить имя главного инспектора
            if (inspector.SetInspector("Иванов И.И."))
            {
                Console.WriteLine("Главный инспектор изменен.");
            }
            else
            {
                Console.WriteLine("Не удалось изменить главного инспектора.");
            }

            // Выводим обновленное имя главного инспектора
            Console.WriteLine($"Новый главный инспектор: {inspector.GetInspector()}");

            // Генерируем и выводим госномер
            string numberPlate = inspector.GenerateNumber();
            Console.WriteLine($"Сгенерированный госномер: {numberPlate}");

            // Выводим список сотрудников
            Console.WriteLine("Список сотрудников:");
            foreach (var worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }

            // Добавляем нового сотрудника и выводим обновленный список сотрудников
            inspector.AddWorker("Кириллов к.к.");
            Console.WriteLine("Добавлен новый сотрудник.");
            Console.WriteLine("Обновленный список сотрудников:");
            foreach (var worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }
        }
    }
}
