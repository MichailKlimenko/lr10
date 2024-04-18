using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр10
{
    // Класс, представляющий базовую технику
    public class Equipment
    {
        public string Name { get; set; }
        public int Voltage { get; set; }

        public Equipment(string name, int voltage)
        {
            Name = name;
            Voltage = voltage;
        }
    }

    // Класс, представляющий компьютер
    public class Computer : Equipment
    {
        public Computer(string name, int voltage) : base(name, voltage) { }
    }

    // Класс, представляющий принтер
    public class Printer : Equipment
    {
        public Printer(string name, int voltage) : base(name, voltage) { }
    }

    // Класс, представляющий босса
    public class Boss
    {
        // Создаем делегаты для событий
        public delegate void UpgradeEventHandler(string message);
        public delegate void TurnOnEventHandler(string message);

        // Создаем события
        public event UpgradeEventHandler Upgraded;
        public event TurnOnEventHandler TurnedOn;

        // Метод для улучшения техники
        public void UpgradeEquipment(Equipment equipment)
        {
            // Увеличиваем напряжение на 10
            equipment.Voltage += 10;

            // Генерируем событие Upgraded
            Upgraded?.Invoke($"{equipment.Name} был улучшен. Новое напряжение: {equipment.Voltage}");
        }

        // Метод для включения техники
        public void TurnOnEquipment(Equipment equipment)
        {
            // Проверяем, не превышает ли напряжение допустимый порог
            if (equipment.Voltage >= 220)
            {
                TurnedOn?.Invoke($"{equipment.Name} включен.");
            }
            else
            {
                TurnedOn?.Invoke($"{equipment.Name} не включен из-за недостаточного напряжения.");
            }
        }
    }
}
