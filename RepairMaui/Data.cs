using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace RepairMaui
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string Functionality { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Guarantee { get; set; }
        public int FaultsCount { get; set; }
        public int State { get; set; }
        public int ChargePerson { get; set; }
        public DateTime LastInspection { get; set; }
        public int Section { get; set; }
        public int FactoryRoom { get; set; }
    }

    public class FactoryRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Section { get; set; }
        public List<int> Machines { get; set; }
        public int ChargePerson { get; set; }
    }
    internal class Data
    {
        static void Fill()
        {
            List<Machine> machines = new List<Machine>();
            List<FactoryRoom> factoryRooms = new List<FactoryRoom>();

            System.Random random = new System.Random();
            string[] companies = { "KitchenAid", "Bosch", "Electrolux", "Siemens", "Miele" };
            string[] countries = { "USA", "Germany", "Sweden", "Germany", "Germany" };
            string[] machineNames = {
            "Планетарный миксер", "Пароконвектомат", "Тестомес", "Фритюрница", "Гриль",
            "Кофемашина", "Соковыжималка", "Мясорубка", "Блендер", "Микроволновая печь",
            "Печь для пиццы", "Вакуумный упаковщик", "Льдогенератор", "Посудомоечная машина",
            "Плита", "Пароварка", "Слайсер", "Тостер", "Шприц для колбас", "Куттер",
            "Мармит", "Сушилка для овощей", "Кипятильник", "Термос", "Мармит для супа",
            "Печь для хлеба", "Кофемолка", "Миксер", "Соковыжималка для цитрусовых", "Электрическая сковорода"
        };
            string[] functionalities = {
            "Смешивает ингредиенты для теста и кремов",
            "Готовит блюда на пару и запекает",
            "Замешивает тесто для хлеба и выпечки",
            "Жарит продукты в масле",
            "Готовит мясо и овощи на гриле",
            "Готовит кофе различных видов",
            "Извлекает сок из фруктов и овощей",
            "Перемалывает мясо и другие продукты",
            "Смешивает и измельчает ингредиенты",
            "Разогревает и готовит пищу",
            "Выпекает пиццу",
            "Упаковывает продукты в вакуумные пакеты",
            "Производит лед",
            "Моет посуду",
            "Готовит пищу на плите",
            "Готовит пищу на пару",
            "Нарезает продукты на тонкие ломтики",
            "Поджаривает хлеб",
            "Наполняет оболочки колбасным фаршем",
            "Измельчает и смешивает продукты",
            "Поддерживает пищу в теплом состоянии",
            "Сушит овощи и фрукты",
            "Кипятит воду",
            "Поддерживает напитки в теплом состоянии",
            "Поддерживает супы в теплом состоянии",
            "Выпекает хлеб",
            "Перемалывает кофе",
            "Смешивает ингредиенты",
            "Извлекает сок из цитрусовых",
            "Жарит продукты на электрической поверхности"
        };

            for (int i = 0; i < 30; i++)
            {
                machines.Add(new Machine
                {
                    Id = i + 1,
                    Name = machineNames[i],
                    Model = $"V{random.Next(1000, 9999)}",
                    Company = companies[random.Next(companies.Length)],
                    Country = countries[random.Next(countries.Length)],
                    Functionality = functionalities[i],
                    PurchaseDate = DateTime.Now.AddYears(-random.Next(1, 10)),
                    Guarantee = random.Next(1, 21),
                    FaultsCount = random.Next(0, 10),
                    State = random.Next(0, 5),
                    ChargePerson = random.Next(1, 25),
                    LastInspection = DateTime.Now.AddMonths(-random.Next(1, 48)),
                    Section = random.Next(1, 3),
                    FactoryRoom = random.Next(1, 6)
                });
            }

            for (int i = 1; i <= 5; i++)
            {
                factoryRooms.Add(new FactoryRoom
                {
                    Id = i,
                    Name = $"Цех {i}",
                    Section = random.Next(1, 4),
                    Machines = new List<int>(),
                    ChargePerson = random.Next(1, 26)
                });
            }

            foreach (var machine in machines)
            {
                factoryRooms[machine.FactoryRoom - 1].Machines.Add(machine.Id);
            }

            // Вывод информации о машинах и цехах
            //foreach (var machine in machines)
            //{
            //    Console.WriteLine($"ID: {machine.Id}, Name: {machine.Name}, Model: {machine.Model}, Company: {machine.Company}, Country: {machine.Country}, Functionality: {machine.Functionality}, PurchaseDate: {machine.PurchaseDate.ToShortDateString()}, Guarantee: {machine.Guarantee}, FaultsCount: {machine.FaultsCount}, State: {machine.State}, ChargePerson: {machine.ChargePerson}, LastInspection: {machine.LastInspection.ToShortDateString()}, Section: {machine.Section}, FactoryRoom: {machine.FactoryRoom}");
            //}

            //foreach (var room in factoryRooms)
            //{
            //    Console.WriteLine($"FactoryRoom ID: {room.Id}, Name: {room.Name}, Section: {room.Section}, ChargePerson: {room.ChargePerson}, Machines: {string.Join(", ", room.Machines)}");
            //}
        }
    }
}


