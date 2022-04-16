using System;
using System.Linq;

namespace ATM
{
    /// <summary>
    /// Перечислимый тип "Операция"
    /// </summary>
    public enum Operation
    {
        NONE = 0,       // пустая операция
        WITHDRAW = 1,   // снятие
        BALANCE = 2,    // проверка баланса
        TRANSFER = 3,   // перевод
        CANCEL = 4,     // отмена
    }

    /// <summary>
    /// Класс "Счет"
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Рандомизатор
        /// </summary>
        private static readonly Random r = new Random();

        /// <summary>
        /// Номер счета
        /// </summary>
        private string number;

        /// <summary>
        /// Сумма денег на счету
        /// </summary>
        private double balance;

        /// <summary>
        /// Свойство "Номер счета"
        /// </summary>
        public string Number
        {
            get 
            { 
                return number; 
            }
            
            set 
            {
                // Проверка, что все символы строки - цифры
                if (value.All(x => char.IsDigit(x)))
                    number = value;
                else
                    throw new ArgumentException("Номер должен содержать только цифры!");
            }
        }

        /// <summary>
        /// Свойство "Сумма денег"
        /// </summary>
        public double Balance
        {
            get 
            { 
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        /// <summary>
        /// Конструктор счета
        /// </summary>
        /// <param name="number">Номер счета</param>
        /// <param name="balance">Баланс счета</param>
        public Account(string number, double balance)
        {
            Number = number;
            Balance = balance;
        }

        /// <summary>
        /// Проверка возможности снятия/перевода суммы со счета
        /// </summary>
        /// <param name="amount">Сумма денег</param>
        /// <returns>Возможность</returns>
        public bool CheckMoney(double amount)
        {
            return Balance >= amount;
        }

        /// <summary>
        /// Снятие денег со счета
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(double amount)
        {
            // Если сумма денег доступна на счету
            if (CheckMoney(amount))
                Balance -= amount;
            else
                throw new ArgumentException("Недостаточно денег для снятия!");
        }

        /// <summary>
        /// Перевод суммы денег на другой номер карты
        /// </summary>
        /// <param name="number">Номер карты</param>
        /// <param name="amount">Сумма денег</param>
        public void Transfer(string number, double amount)
        {
            // Если сумма денег доступна на счету
            if (CheckMoney(amount))
            {
                // Если другой счет существует
                if (CentralBank.GetInstance().CheckCard(number))
                {
                    // Снятие с текущего
                    Balance -= amount;
                    // Перевод на другой
                    CentralBank.GetInstance().GetCard(number).Holder.Balance += amount;
                }
                else
                    throw new ArgumentException("Неверный номер счета!");
            }
            else
                throw new ArgumentException("Недостаточно денег для перевода!");
        }

        /// <summary>
        /// Создание счета со случайными данными
        /// </summary>
        /// <returns></returns>
        public static Account CreateAccount()
        {
            string number = "";
            // Номер счета из 30 цифр
            for (int i = 0; i < 30; i++)
                number += (char)('0' + r.Next(10));
            // Случайная сумма на счету от 0 до 100000
            return new Account(number, Math.Round(r.NextDouble() * 100000, 2));
        }
    }
}
