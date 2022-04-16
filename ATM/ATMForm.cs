using System;
using System.Windows.Forms;

namespace ATM
{
    /// <summary>
    /// Форма "Банкомат"
    /// </summary>
    public partial class ATMForm : Form
    {
        /// <summary>
        /// Центральный банк
        /// </summary>
        private CentralBank cb;

        /// <summary>
        /// Банкомат
        /// </summary>
        private ATM atm;

        /// <summary>
        /// Номер карты
        /// </summary>
        private string card = "";

        /// <summary>
        /// PIN-код
        /// </summary>
        private string pin = "";

        /// <summary>
        /// Переводимые деньги
        /// </summary>
        private double transferMoney = 0;

        /// <summary>
        /// Вводимые данные
        /// </summary>
        private string data = "";

        /// <summary>
        /// Попытки ввода PIN-кода
        /// </summary>
        private int attempt = 3;

        /// <summary>
        /// Текущая операция
        /// </summary>
        private Operation op;

        /// <summary>
        /// Необходимость печати справки
        /// </summary>
        private bool print = false;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public ATMForm()
        {
            InitializeComponent();
            cb = CentralBank.GetInstance();
            atm = ATM.CreateATM();
            display.AppendText("ВСТАВЬТЕ КАРТУ" + Environment.NewLine);
        }

        /// <summary>
        /// Запрос в ЦБ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void requestItem_Click(object sender, EventArgs e)
        {
            new CentralBankForm(cb).ShowDialog();
        }

        /// <summary>
        /// Вставка карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            op = Operation.NONE;
            if (cb.CheckCard(cardBox.Text) &&
                (atm.GetCards().FindIndex(x => x.Number == cardBox.Text) == -1))
            {
                buttonInsert.Enabled = false;
                cardBox.Enabled = false;
                display.Clear();
                card = cardBox.Text;
                display.AppendText("ВВЕДИТЕ PIN-КОД" + Environment.NewLine);
                layout.Enabled = true;
            }
            else
            {
                display.AppendText("КАРТА НЕ РАСПОЗНАНА" + Environment.NewLine);
                await System.Threading.Tasks.Task.Delay(3000);
                display.Clear();
                attempt = 3;
                display.AppendText("ВСТАВЬТЕ КАРТУ" + Environment.NewLine);
            }
        }

        /// <summary>
        /// Отключение курсора у дисплея
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void display_Enter(object sender, EventArgs e)
        {
            cashBox.Focus();
        }

        /// <summary>
        /// Обработка слота для карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cardBox_TextChanged(object sender, EventArgs e)
        {
            if (op == Operation.WITHDRAW)
                buttonEnter_Click(sender, e);
            buttonInsert.Enabled = cardBox.Text.Length == 16;
        }

        /// <summary>
        /// Обработка нажатия клавиш 0-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button0_Click(object sender, EventArgs e)
        {
            if (op == Operation.NONE)
            {
                pin += (sender as Button).Text;
                display.AppendText("*");
            }
            else
            {
                data += (sender as Button).Text;
                display.AppendText((sender as Button).Text);
            }
        }

        /// <summary>
        /// Обработка нажатия клавиши Сброс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            pin = "";
            data = "";
            display.Text = display.Text.Remove(display.Text.LastIndexOf(Environment.NewLine));
            display.AppendText("\r\n");
        }

        /// <summary>
        /// Обработка нажатия клавиши Ввод
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            if (op == Operation.WITHDRAW)
            {
                Card c = cb.GetCard(card);
                double a = double.Parse(data);
                if (cb.CheckOperation(c.Holder, a))
                {
                    var bills = atm.CheckMoney((int)a, cardBox.Text.Length == 0);
                    if (bills.Count > 0)
                    {
                        display.Clear();
                        display.AppendText("ВЫТАЩИТЕ КАРТУ" + Environment.NewLine);
                        layout.Enabled = false;
                        cardBox.Enabled = true;
                        if (cardBox.Text.Length == 0)
                        {
                            for (int i = 0; i < bills.Count; i++)
                                if (bills[i] > 0)
                                    cashBox.Items.Add($"{bills[i]} x " +
                                        $"{(int)Enum.GetValues(typeof(Bill)).GetValue(i)}");
                            cb.Withdraw(c.Holder, a);
                            if (print)
                            {
                                inquiryBox.Clear();
                                inquiryBox.AppendText($"Номер карты: {c.Number}" + Environment.NewLine);
                                inquiryBox.AppendText($"Снято: {a} рублей" + Environment.NewLine);
                                inquiryBox.AppendText($"Остаток: {cb.GetBalance(c.Number)}" + Environment.NewLine);
                            }
                            display.Clear();
                            await System.Threading.Tasks.Task.Delay(3000);
                            attempt = 3;
                            display.AppendText("ВСТАВЬТЕ КАРТУ" + Environment.NewLine);
                            cashBox.Items.Clear();
                            inquiryBox.Clear();
                            op = Operation.CANCEL;
                        }
                    }
                    else
                    {
                        display.Clear();
                        display.AppendText("В БАНКОМАТЕ НЕТ ЗАПРОШЕННОЙ СУММЫ"
                            + Environment.NewLine);
                        await System.Threading.Tasks.Task.Delay(3000);
                        display.Clear();
                        layout.Enabled = false;
                        buttonWithdraw.Enabled = buttonWithdraw.Visible = true;
                        buttonBalance.Enabled = buttonBalance.Visible = true;
                        buttonTransfer.Enabled = buttonTransfer.Visible = true;
                        buttonCancel.Enabled = buttonCancel.Visible = true;
                    }
                }
                else
                {
                    display.Clear();
                    display.AppendText("НЕДОСТАТОЧНО ДЕНЕГ НА СЧЕТУ" + Environment.NewLine);
                    op = Operation.NONE;
                    await System.Threading.Tasks.Task.Delay(3000);
                    display.Clear();
                    layout.Enabled = false;
                    buttonWithdraw.Enabled = buttonWithdraw.Visible = true;
                    buttonBalance.Enabled = buttonBalance.Visible = true;
                    buttonTransfer.Enabled = buttonTransfer.Visible = true;
                    buttonCancel.Enabled = buttonCancel.Visible = true;
                }
            }
            else if (op == Operation.TRANSFER && transferMoney == 0)
            {
                Card c = cb.GetCard(card);
                transferMoney = double.Parse(data);
                if (cb.CheckOperation(c.Holder, transferMoney))
                {
                    display.Clear();
                    display.AppendText("ВВЕДИТЕ НОМЕР СЧЕТА" + Environment.NewLine);
                }
                else
                {
                    display.Clear();
                    display.AppendText("НЕДОСТАТОЧНО ДЕНЕГ НА СЧЕТУ" + Environment.NewLine);
                    op = Operation.NONE;
                    await System.Threading.Tasks.Task.Delay(3000);
                    display.Clear();
                    layout.Enabled = false;
                    buttonWithdraw.Enabled = buttonWithdraw.Visible = true;
                    buttonBalance.Enabled = buttonBalance.Visible = true;
                    buttonTransfer.Enabled = buttonTransfer.Visible = true;
                    buttonCancel.Enabled = buttonCancel.Visible = true;
                }
                data = "";
                transferMoney = 0;
            }
            else if (op == Operation.TRANSFER)
            {
                Card c = cb.GetCard(card);
                if (cb.CheckCard(data))
                {
                    display.Clear();
                    display.AppendText("ПЕРЕВОД ОСУЩЕСТВЛЕН" + Environment.NewLine);
                    cb.Transfer(c.Holder, data, transferMoney);
                    if (print)
                    {
                        inquiryBox.Clear();
                        inquiryBox.AppendText($"Номер карты: {c.Number}" + Environment.NewLine);
                        inquiryBox.AppendText($"Номер перевода: {data}" + Environment.NewLine);
                        inquiryBox.AppendText($"Переведено: {transferMoney} рублей" + Environment.NewLine);
                        inquiryBox.AppendText($"Остаток: {cb.GetBalance(c.Number)}" + Environment.NewLine);
                    }
                }
                else
                {
                    display.Clear();
                    display.AppendText("НЕКОРРЕКТНЫЙ НОМЕР СЧЕТА" + Environment.NewLine);
                    op = Operation.NONE;
                    await System.Threading.Tasks.Task.Delay(3000);
                    display.Clear();
                    layout.Enabled = false;
                    buttonWithdraw.Enabled = buttonWithdraw.Visible = true;
                    buttonBalance.Enabled = buttonBalance.Visible = true;
                    buttonTransfer.Enabled = buttonTransfer.Visible = true;
                    buttonCancel.Enabled = buttonCancel.Visible = true;
                }
                data = "";
                transferMoney = 0;
            }
            else if (op == Operation.NONE)
            {
                Card c = cb.GetCard(card);
                if (c.CheckPIN(pin))
                {
                    display.Clear();
                    display.AppendText("УСПЕШНЫЙ ВХОД" + Environment.NewLine);
                    buttonWithdraw.Enabled = buttonWithdraw.Visible = true;
                    buttonBalance.Enabled = buttonBalance.Visible = true;
                    buttonTransfer.Enabled = buttonTransfer.Visible = true;
                    buttonCancel.Enabled = buttonCancel.Visible = true;
                    layout.Enabled = false;
                }
                else
                {
                    display.Clear();
                    display.AppendText($"НЕВЕРНЫЙ КОД. ОСТАЛОСЬ ПОПЫТОК: {--attempt}"
                        + Environment.NewLine);
                    if (attempt == 0)
                    {
                        display.AppendText("КАРТА ИЗЪЯТА");
                        cardBox.Clear();
                        cardBox.Enabled = true;
                        await System.Threading.Tasks.Task.Delay(3000);
                        display.Clear();
                        attempt = 3;
                        display.AppendText("ВСТАВЬТЕ КАРТУ" + Environment.NewLine);
                        atm.WithdrawCard(c);
                    }
                    else
                        display.AppendText("ВВЕДИТЕ PIN-КОД" + Environment.NewLine);
                }
                pin = "";
                data = "";
            }
        }

        /// <summary>
        /// Обработка нажатия клавиши Снятие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            op = Operation.WITHDRAW;
            display.Clear();
            display.AppendText("ВЫ ЖЕЛАЕТЕ СПРАВКУ ПО ОПЕРАЦИИ?" + Environment.NewLine);
            buttonWithdraw.Enabled = buttonWithdraw.Visible = false;
            buttonBalance.Enabled = buttonBalance.Visible = false;
            buttonTransfer.Enabled = buttonTransfer.Visible = false;
            buttonYes.Enabled = buttonYes.Visible = true;
            buttonNo.Enabled = buttonNo.Visible = true;
            buttonCancel.Enabled = buttonCancel.Visible = false;
        }

        /// <summary>
        /// Обработка нажатия клавиши Баланс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBalance_Click(object sender, EventArgs e)
        {
            op = Operation.BALANCE;
            display.Clear();
            display.AppendText("ВЫ ЖЕЛАЕТЕ СПРАВКУ ПО ОПЕРАЦИИ?" + Environment.NewLine);
            buttonWithdraw.Enabled = buttonWithdraw.Visible = false;
            buttonBalance.Enabled = buttonBalance.Visible = false;
            buttonTransfer.Enabled = buttonTransfer.Visible = false;
            buttonYes.Enabled = buttonYes.Visible = true;
            buttonNo.Enabled = buttonNo.Visible = true;
            buttonCancel.Enabled = buttonCancel.Visible = false;
        }

        /// <summary>
        /// Обработка нажатия клавиши Перевод
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            op = Operation.TRANSFER;
            display.Clear();
            display.AppendText("ВЫ ЖЕЛАЕТЕ СПРАВКУ ПО ОПЕРАЦИИ?" + Environment.NewLine);
            buttonWithdraw.Enabled = buttonWithdraw.Visible = false;
            buttonBalance.Enabled = buttonBalance.Visible = false;
            buttonTransfer.Enabled = buttonTransfer.Visible = false;
            buttonYes.Enabled = buttonYes.Visible = true;
            buttonNo.Enabled = buttonNo.Visible = true;
            buttonCancel.Enabled = buttonCancel.Visible = false;
        }

        /// <summary>
        /// Обработка нажатия клавиши Да/Нет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonYes_Click(object sender, EventArgs e)
        {
            print = sender == buttonYes;

            if (op == Operation.WITHDRAW)
            {
                display.Clear();
                display.AppendText("ВВЕДИТЕ СУММУ" + Environment.NewLine);
                layout.Enabled = true;
                buttonYes.Enabled = buttonYes.Visible = false;
                buttonNo.Enabled = buttonNo.Visible = false;
            }

            if (op == Operation.BALANCE)
            {
                Card c = cb.GetCard(card);
                display.Clear();
                display.AppendText($"ОСТАТОК: {cb.GetBalance(c.Number)}" + Environment.NewLine);
                if (print)
                {
                    inquiryBox.Clear();
                    inquiryBox.AppendText($"Номер карты: {c.Number}" + Environment.NewLine);
                    inquiryBox.AppendText($"Остаток: {cb.GetBalance(c.Number)}" + Environment.NewLine);
                }
                buttonYes.Enabled = buttonYes.Visible = false;
                buttonNo.Enabled = buttonNo.Visible = false;
                await System.Threading.Tasks.Task.Delay(3000);
                display.Clear();
                buttonWithdraw.Enabled = buttonWithdraw.Visible = true;
                buttonBalance.Enabled = buttonBalance.Visible = true;
                buttonTransfer.Enabled = buttonTransfer.Visible = true;
                buttonCancel.Enabled = buttonCancel.Visible = true;
                inquiryBox.Clear();
            }

            if (op == Operation.TRANSFER)
            {
                display.Clear();
                display.AppendText("ВВЕДИТЕ СУММУ" + Environment.NewLine);
                layout.Enabled = true;
                buttonYes.Enabled = buttonYes.Visible = false;
                buttonNo.Enabled = buttonNo.Visible = false;
            }
        }

        /// <summary>
        /// Обработка нажатия клавиши Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonCancel_Click(object sender, EventArgs e)
        {
            display.Clear();
            display.AppendText("ЗАБЕРИТЕ КАРТУ" + Environment.NewLine);
            await System.Threading.Tasks.Task.Delay(1000);
            op = Operation.CANCEL;
            cardBox.Clear();
            cashBox.Items.Clear();
            inquiryBox.Clear();
            layout.Enabled = false; 
            buttonWithdraw.Enabled = buttonWithdraw.Visible = false;
            buttonBalance.Enabled = buttonBalance.Visible = false;
            buttonTransfer.Enabled = buttonTransfer.Visible = false;
            buttonCancel.Enabled = buttonCancel.Visible = false;
            buttonYes.Enabled = buttonYes.Visible = false;
            buttonNo.Enabled = buttonNo.Visible = false;
            display.Clear();
            attempt = 3;
            data = "";
            display.AppendText("ВСТАВЬТЕ КАРТУ" + Environment.NewLine);
            op = Operation.NONE;
        }

        /// <summary>
        /// Выдача денег
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cashItem_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (var bill in atm.GetBills())
                text += $"{bill.Value} x {(int)bill.Key}" + Environment.NewLine;
            MessageBox.Show(text);
        }

        /// <summary>
        /// Изъятие карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cardsItem_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (var card in atm.GetCards())
                text += $"{card.Number}" + Environment.NewLine;
            MessageBox.Show(text);
        }
    }
}
