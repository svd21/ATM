using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    /// <summary>
    /// Перечислимый тип "Купюра"
    /// </summary>
    enum Bill
    {
        FIFTY = 50,             // 50 рублей
        ONE_HUNDRED = 100,      // 100 рублей
        TWO_HUNDRED = 200,      // 200 рублей
        FIVE_HUNDRED = 500,     // 500 рублей
        ONE_THOUSAND = 1000,    // 1000 рублей
        TWO_THOUSAND = 2000,    // 2000 рублей
        FIVE_THOUSAND = 5000    // 5000 рублей
    }

    /// <summary>
    /// Класс "Банкомат"
    /// </summary>
    class ATM
    {
        /// <summary>
        /// Рандомизатор
        /// </summary>
        private readonly static Random r = new Random();

        /// <summary>
        /// Хранилище денег
        /// Представляет собой словарь пар "Купюра-Количество"
        /// Пара (Bill.FIVE_HUNDRED, 4) означает, что
        /// в хранилище находится 4 купюры номиналом 500 рублей
        /// </summary>
        private Dictionary<Bill, int> bills;

        /// <summary>
        /// Список конфискованных карт
        /// </summary>
        private List<Card> cards;

        /// <summary>
        /// Конструктор класса "Банкомат" по умолчанию
        /// </summary>
        public ATM()
        {
            bills = new Dictionary<Bill, int>();
            cards = new List<Card>();
        }

        /// <summary>
        /// Ассоциативный массив всех денег банкомата
        /// </summary>
        /// <returns>Массив</returns>
        public Dictionary<Bill, int> GetBills()
        {
            return bills;
        }

        /// <summary>
        /// Список изъятых карт
        /// </summary>
        /// <returns>Список</returns>
        public List<Card> GetCards()
        {
            return cards;
        }

        /// <summary>
        /// Загрузка в банкомат нескольких купюр одного номинала
        /// </summary>
        /// <param name="bill">Номинал купюры</param>
        /// <param name="count">Количество купюр</param>
        public void AddBills(Bill bill, int count)
        {
            if (!bills.ContainsKey(bill))
                bills[bill] = count;
            else
                bills[bill] += count;
        }

        /// <summary>
        /// Проверка выдачи суммы денег
        /// имеющимися в банкомате купюрами
        /// </summary>
        /// <param name="amount">Сумма денег</param>
        /// <returns>Список купюр (пустой, 
        /// если выдать нельзя)</returns>
        public List<int> CheckMoney(int amount, bool withdraw = false)
        {
            List<int> b = new List<int>();

            for (int i = 0; i < 7; i++)
                b.Add(0);

            // Выдача купюр 5000
            if (amount >= 5000)
            {
                b[0] = Math.Min(amount / 5000, bills[Bill.FIVE_THOUSAND]);
                amount -= b[0] * 5000;
            }

            // Выдача купюр 2000
            if (amount >= 2000)
            {
                b[1] = Math.Min(amount / 2000, bills[Bill.TWO_THOUSAND]);
                amount -= b[1] * 2000;
            }

            // Выдача купюр 1000
            if (amount >= 1000)
            {
                b[2] = Math.Min(amount / 1000, bills[Bill.ONE_THOUSAND]);
                amount -= b[2] * 1000;
            }

            // Выдача купюр 500
            if (amount >= 500)
            {
                b[3] = Math.Min(amount / 500, bills[Bill.FIVE_HUNDRED]);
                amount -= b[3] * 500;
            }

            // Выдача купюр 200
            if (amount >= 200)
            {
                b[4] = Math.Min(amount / 200, bills[Bill.TWO_HUNDRED]);
                amount -= b[4] * 200;
            }

            // Выдача купюр 100
            if (amount >= 100)
            {
                b[5] = Math.Min(amount / 100, bills[Bill.ONE_HUNDRED]);
                amount -= b[5] * 100;
            }

            // Выдача купюр 50
            if (amount >= 50)
            {
                b[6] = Math.Min(amount / 50, bills[Bill.FIFTY]);
                amount -= b[6] * 50;
            }

            // Если вся сумма не выдана
            if (amount != 0)
                // Банкомат не может выдать данную сумму
                return new List<int>();

            if (withdraw)
            {
                // Изъятие нужных купюр из банкомата
                b.Reverse();
                var nom = Enum.GetValues(typeof(Bill));
                for (int i = 0; i < nom.Length; i++)
                    bills[(Bill)nom.GetValue(i)] -= b[i];
            }
            return b;
        }

        /// <summary>
        /// Заполнение банкомата случайным набором купюр
        /// </summary>
        /// <returns></returns>
        public static ATM CreateATM()
        {
            ATM atm = new ATM();
            // Купюр каждого номинала от 0 до 99
            foreach (Bill bill in Enum.GetValues(typeof(Bill)))
                atm.AddBills(bill, r.Next(100));
            return atm;
        }

        /// <summary>
        /// Изъятие карты
        /// </summary>
        /// <param name="card">карта</param>
        public void WithdrawCard(Card card)
        {
            cards.Add(card);
        }
    }
}
