using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    /// <summary>
    /// Класс "Карта"
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Рандомизатор
        /// </summary>
        private static readonly Random r = new Random();

        /// <summary>
        /// Номер карты
        /// </summary>
        private string number;

        /// <summary>
        /// Свойство "Номер карты"
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
                if (value.Length == 16 && value.All(x => char.IsDigit(x)))
                    number = value;
                else
                    throw new ArgumentException("Номер карты должен быть длины 16 и " +
                        "содержать только цифры!");
            }
        }

        /// <summary>
        /// Счет
        /// </summary>
        private Account account;

        /// <summary>
        /// Свойство "Владелец карты"
        /// </summary>
        public Account Holder
        {
            get 
            {
                return account;
            }

            set
            {
                account = value;
            }
        }

        /// <summary>
        /// PIN-код
        /// </summary>
        private string pin;

        /// <summary>
        /// Конструктор карты
        /// </summary>
        /// <param name="number">Номер</param>
        /// <param name="account">Счет</param>
        public Card(string number, Account account)
        {
            Number = number;
            Holder = account;
            pin = Number.Substring(0, 4);
        }

        /// <summary>
        /// Проверка кода
        /// </summary>
        /// <param name="pin">Код</param>
        /// <returns>Корректность</returns>
        public bool CheckPIN(string pin)
        {
            return this.pin == pin;
        }

        /// <summary>
        /// Создание карты со случайными данными
        /// </summary>
        /// <returns>Карта</returns>
        public static Card CreateCard()
        {
            string number = "";
            for (int i = 0; i < 16; i++)
                number += (char)('0' + r.Next(10));
            return new Card(number, Account.CreateAccount());
        }
    }
}
