using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class CentralBankForm : Form
    {
        private CentralBank cb;

        public CentralBankForm(CentralBank cb)
        {
            InitializeComponent();
            this.cb = cb;
        }

        private void CentralBankForm_Load(object sender, EventArgs e)
        {
            accountsView.ColumnCount = 3;
            accountsView.Columns[0].HeaderText = "Номер карты";
            accountsView.Columns[1].HeaderText = "Номер счета";
            accountsView.Columns[2].HeaderText = "Баланс";

            foreach (Card c in cb.Cards)
            {
                accountsView.Rows.Add();
                accountsView.Rows[accountsView.Rows.Count - 1].Cells[0].Value = c.Number;
                accountsView.Rows[accountsView.Rows.Count - 1].Cells[1].Value = c.Holder.Number;
                accountsView.Rows[accountsView.Rows.Count - 1].Cells[2].Value = c.Holder.Balance;
            }
        }
    }
}
