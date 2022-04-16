
namespace ATM
{
    partial class CentralBankForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accountsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.accountsView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsView
            // 
            this.accountsView.AllowUserToAddRows = false;
            this.accountsView.AllowUserToDeleteRows = false;
            this.accountsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.accountsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountsView.Location = new System.Drawing.Point(0, 0);
            this.accountsView.MultiSelect = false;
            this.accountsView.Name = "accountsView";
            this.accountsView.ReadOnly = true;
            this.accountsView.RowHeadersWidth = 51;
            this.accountsView.RowTemplate.Height = 24;
            this.accountsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.accountsView.Size = new System.Drawing.Size(800, 450);
            this.accountsView.TabIndex = 0;
            // 
            // CentralBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accountsView);
            this.Name = "CentralBankForm";
            this.Text = "Центральный банк";
            this.Load += new System.EventHandler(this.CentralBankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountsView;
    }
}