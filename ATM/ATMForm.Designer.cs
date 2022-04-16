
namespace ATM
{
    partial class ATMForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.cardBox = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.cashBox = new System.Windows.Forms.ListBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.requestItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.inquiryBox = new System.Windows.Forms.TextBox();
            this.layout.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 3;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.layout.Controls.Add(this.button0, 1, 3);
            this.layout.Controls.Add(this.button1, 0, 2);
            this.layout.Controls.Add(this.button2, 1, 2);
            this.layout.Controls.Add(this.button3, 2, 2);
            this.layout.Controls.Add(this.button4, 0, 1);
            this.layout.Controls.Add(this.button5, 1, 1);
            this.layout.Controls.Add(this.button6, 2, 1);
            this.layout.Controls.Add(this.button8, 1, 0);
            this.layout.Controls.Add(this.button9, 2, 0);
            this.layout.Controls.Add(this.buttonReset, 0, 3);
            this.layout.Controls.Add(this.buttonEnter, 2, 3);
            this.layout.Controls.Add(this.button7, 0, 0);
            this.layout.Enabled = false;
            this.layout.Location = new System.Drawing.Point(382, 181);
            this.layout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layout.Name = "layout";
            this.layout.RowCount = 4;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.Size = new System.Drawing.Size(209, 146);
            this.layout.TabIndex = 0;
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(71, 110);
            this.button0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(65, 34);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(2, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(71, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(140, 74);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button0_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(2, 38);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button0_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(71, 38);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 32);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button0_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(140, 38);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 32);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button0_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(71, 2);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 32);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(140, 2);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 32);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(2, 110);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(65, 34);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(140, 110);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(67, 34);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(2, 2);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 32);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button0_Click);
            // 
            // display
            // 
            this.display.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.Location = new System.Drawing.Point(10, 32);
            this.display.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(582, 138);
            this.display.TabIndex = 1;
            this.display.Enter += new System.EventHandler(this.display_Enter);
            // 
            // cardBox
            // 
            this.cardBox.Location = new System.Drawing.Point(10, 184);
            this.cardBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(149, 20);
            this.cardBox.TabIndex = 2;
            this.cardBox.TextChanged += new System.EventHandler(this.cardBox_TextChanged);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Enabled = false;
            this.buttonInsert.Location = new System.Drawing.Point(162, 183);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(110, 32);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Вставить карту";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // cashBox
            // 
            this.cashBox.FormattingEnabled = true;
            this.cashBox.Location = new System.Drawing.Point(9, 236);
            this.cashBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cashBox.Name = "cashBox";
            this.cashBox.Size = new System.Drawing.Size(73, 121);
            this.cashBox.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestItem,
            this.cashItem,
            this.cardsItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(600, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // requestItem
            // 
            this.requestItem.Name = "requestItem";
            this.requestItem.Size = new System.Drawing.Size(87, 20);
            this.requestItem.Text = "Запрос в ЦБ";
            this.requestItem.Click += new System.EventHandler(this.requestItem_Click);
            // 
            // cashItem
            // 
            this.cashItem.Name = "cashItem";
            this.cashItem.Size = new System.Drawing.Size(117, 20);
            this.cashItem.Text = "Хранилище денег";
            this.cashItem.Click += new System.EventHandler(this.cashItem_Click);
            // 
            // cardsItem
            // 
            this.cardsItem.Name = "cardsItem";
            this.cardsItem.Size = new System.Drawing.Size(111, 20);
            this.cardsItem.Text = "Хранилище карт";
            this.cardsItem.Click += new System.EventHandler(this.cardsItem_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Enabled = false;
            this.buttonWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWithdraw.Location = new System.Drawing.Point(375, 40);
            this.buttonWithdraw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(73, 32);
            this.buttonWithdraw.TabIndex = 6;
            this.buttonWithdraw.Text = "Снятие";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Visible = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // buttonBalance
            // 
            this.buttonBalance.Enabled = false;
            this.buttonBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBalance.Location = new System.Drawing.Point(453, 40);
            this.buttonBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(64, 32);
            this.buttonBalance.TabIndex = 7;
            this.buttonBalance.Text = "Баланс";
            this.buttonBalance.UseVisualStyleBackColor = true;
            this.buttonBalance.Visible = false;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Enabled = false;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTransfer.Location = new System.Drawing.Point(522, 40);
            this.buttonTransfer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(64, 32);
            this.buttonTransfer.TabIndex = 8;
            this.buttonTransfer.Text = "Перевод";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Visible = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Enabled = false;
            this.buttonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYes.Location = new System.Drawing.Point(375, 76);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(74, 32);
            this.buttonYes.TabIndex = 9;
            this.buttonYes.Text = "Да";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Visible = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Enabled = false;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNo.Location = new System.Drawing.Point(453, 76);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(64, 32);
            this.buttonNo.TabIndex = 10;
            this.buttonNo.Text = "Нет";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Visible = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(522, 76);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(64, 32);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // inquiryBox
            // 
            this.inquiryBox.Location = new System.Drawing.Point(99, 236);
            this.inquiryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inquiryBox.Multiline = true;
            this.inquiryBox.Name = "inquiryBox";
            this.inquiryBox.ReadOnly = true;
            this.inquiryBox.Size = new System.Drawing.Size(260, 121);
            this.inquiryBox.TabIndex = 12;
            // 
            // ATMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.inquiryBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonBalance);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.cashBox);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.display);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ATMForm";
            this.Text = "Банкомат";
            this.layout.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.TextBox cardBox;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ListBox cashBox;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem requestItem;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox inquiryBox;
        private System.Windows.Forms.ToolStripMenuItem cashItem;
        private System.Windows.Forms.ToolStripMenuItem cardsItem;
    }
}

