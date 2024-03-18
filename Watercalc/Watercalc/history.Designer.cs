namespace Watercalc
{
    partial class History
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
            btn_exit = new Button();
            dataGrid = new DataGridView();
            col_index = new DataGridViewTextBoxColumn();
            col_name = new DataGridViewTextBoxColumn();
            col_consump = new DataGridViewTextBoxColumn();
            col_pay = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(1029, 580);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(118, 108);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { col_index, col_name, col_consump, col_pay });
            dataGrid.Location = new Point(30, 27);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.Size = new Size(440, 661);
            dataGrid.TabIndex = 1;
            // 
            // col_index
            // 
            col_index.HeaderText = "Index";
            col_index.Name = "col_index";
            col_index.ReadOnly = true;
            // 
            // col_name
            // 
            col_name.HeaderText = "Name";
            col_name.Name = "col_name";
            col_name.ReadOnly = true;
            // 
            // col_consump
            // 
            col_consump.HeaderText = "Consumption";
            col_consump.Name = "col_consump";
            col_consump.ReadOnly = true;
            // 
            // col_pay
            // 
            col_pay.HeaderText = "Pay";
            col_pay.Name = "col_pay";
            col_pay.ReadOnly = true;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 700);
            Controls.Add(dataGrid);
            Controls.Add(btn_exit);
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "history";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_exit;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn col_index;
        private DataGridViewTextBoxColumn col_name;
        private DataGridViewTextBoxColumn col_consump;
        private DataGridViewTextBoxColumn col_pay;
    }
}