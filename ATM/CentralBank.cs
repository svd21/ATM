using System.Collections.Generic;

namespace ATM
{
    /// <summary>
    /// Класс "Центральный банк"
    /// </summary>
    public class CentralBank
    {
        /// <summary>
        /// Объект ЦБ
        /// </summary>
        private static CentralBank instance;

        /// <summary>
        /// Список счетов
        /// </summary>
        private List<Account> accounts;

        /// <summary>
        /// Список карт
        /// </summary>
        private List<Card> cards;

        /// <summary>
        /// Конструктор ЦБ
        /// </summary>
        private CentralBank()
        {
            accounts = new List<Account>();
            cards = new List<Card>();
        }

        /// <summary>
        /// Получение объекта ЦБ
        /// </summary>
        /// <returns></returns>
        public static CentralBank GetInstance()
        {
            if (instance == null)
            {
                instance = new CentralBank();
                for (int i = 0; i < 10; i++)
                    instance.AddCard(Card.CreateCard());
            }
            return instance;
        }

        /// <summary>
        /// Список счетов
        /// </summary>
        public List<Account> Accounts
        {
            get
            {
                return accounts;
            }
        }

        /// <summary>
        /// Список карт
        /// </summary>
        public List<Card> Cards
        {
            get
            {
                return cards;
            }
        }

        /// <summary>
        /// Добавление карты
        /// </summary>
        /// <param name="card">Карта</param>
        public void AddCard(Card card)
        {
            cards.Add(card);
            accounts.Add(card.Holder);
        }

        /// <summary>
        /// Проверка существования карты
        /// </summary>
        /// <param name="number">Номер карты</param>
        /// <returns>Существование</returns>
        public bool CheckCard(string number)
        {
            return cards.FindIndex(x => x.Number == number) != -1;
        }

        /// <summary>
        /// Получение карты
        /// </summary>
        /// <param name="number">Номер</param>
        /// <returns>Карта</returns>
        public Card GetCard(string number)
        {
            return cards.Find(x => x.Number == number);
        }

        /// <summary>
        /// Проверка возможности операции
        /// </summary>
        /// <param name="account">Счет</param>
        /// <param name="amount">Сумма</param>
        /// <returns>Возможность</returns>
        public bool CheckOperation(Account account, double amount)
        {
            int index = accounts.IndexOf(account);
            if (index == -1)
                return false;
            return accounts[index].CheckMoney(amount);
        }

        /// <summary>
        /// Снятие денег
        /// </summary>
        /// <param name="account">Счет</param>
        /// <param name="amount">Сумма</param>
        public void Withdraw(Account account, double amount)
        {
            if (!CheckOperation(account, amount))
                return;
            accounts[accounts.IndexOf(account)].Withdraw(amount);
        }

        /// <summary>
        /// Перевод денег
        /// </summary>
        /// <param name="account">Текущий счет</param>
        /// <param name="number">Номер карты для перевода</param>
        /// <param name="amount">Сумма денег</param>
        public void Transfer(Account account, string number, double amount)
        {
            if (!CheckOperation(account, amount))
                return;
            accounts[accounts.IndexOf(account)].Transfer(number, amount);

        }

        /// <summary>
        /// Получение баланса
        /// </summary>
        /// <param name="number">Номер карты</param>
        /// <returns>Баланс</returns>
        public double GetBalance(string number)
        {
            if (!CheckCard(number))
                return double.NaN;
            return GetCard(number).Holder.Balance;
        }
    }
}
