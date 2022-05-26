namespace OS1
{
    partial class start
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
            this.HelloUserLabel = new System.Windows.Forms.Label();
            this.searchByNameLabel = new System.Windows.Forms.Label();
            this.searchByIDLabel = new System.Windows.Forms.Label();
            this.processesLabel = new System.Windows.Forms.Label();
            this.searchByNameTextBox = new System.Windows.Forms.TextBox();
            this.searchByIdTextBox = new System.Windows.Forms.TextBox();
            this.killButton = new System.Windows.Forms.Button();
            this.dataGrid_processes = new System.Windows.Forms.DataGridView();
            this.refresh_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_processes)).BeginInit();
            this.SuspendLayout();
            // 
            // HelloUserLabel
            // 
            this.HelloUserLabel.AutoSize = true;
            this.HelloUserLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HelloUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloUserLabel.Location = new System.Drawing.Point(358, 9);
            this.HelloUserLabel.Name = "HelloUserLabel";
            this.HelloUserLabel.Size = new System.Drawing.Size(1043, 82);
            this.HelloUserLabel.TabIndex = 0;
            this.HelloUserLabel.Text = "Welcome to our Task Manager";
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.AutoSize = true;
            this.searchByNameLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchByNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNameLabel.Location = new System.Drawing.Point(595, 234);
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(237, 32);
            this.searchByNameLabel.TabIndex = 4;
            this.searchByNameLabel.Text = "search by name:";
            // 
            // searchByIDLabel
            // 
            this.searchByIDLabel.AutoSize = true;
            this.searchByIDLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchByIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByIDLabel.Location = new System.Drawing.Point(641, 299);
            this.searchByIDLabel.Name = "searchByIDLabel";
            this.searchByIDLabel.Size = new System.Drawing.Size(191, 32);
            this.searchByIDLabel.TabIndex = 5;
            this.searchByIDLabel.Text = "search by ID:";
            // 
            // processesLabel
            // 
            this.processesLabel.AutoSize = true;
            this.processesLabel.BackColor = System.Drawing.Color.Cyan;
            this.processesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processesLabel.Location = new System.Drawing.Point(56, 292);
            this.processesLabel.Name = "processesLabel";
            this.processesLabel.Size = new System.Drawing.Size(258, 55);
            this.processesLabel.TabIndex = 6;
            this.processesLabel.Text = "Processes";
            // 
            // searchByNameTextBox
            // 
            this.searchByNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNameTextBox.Location = new System.Drawing.Point(855, 231);
            this.searchByNameTextBox.Name = "searchByNameTextBox";
            this.searchByNameTextBox.Size = new System.Drawing.Size(270, 39);
            this.searchByNameTextBox.TabIndex = 7;
            this.searchByNameTextBox.Text = "Enter Name...";
            this.searchByNameTextBox.TextChanged += new System.EventHandler(this.searchByNameTextBox_TextChanged_1);
            // 
            // searchByIdTextBox
            // 
            this.searchByIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByIdTextBox.Location = new System.Drawing.Point(855, 292);
            this.searchByIdTextBox.Name = "searchByIdTextBox";
            this.searchByIdTextBox.Size = new System.Drawing.Size(260, 39);
            this.searchByIdTextBox.TabIndex = 8;
            this.searchByIdTextBox.Text = "Enter ID...";
            this.searchByIdTextBox.TextChanged += new System.EventHandler(this.searchByIdTextBox_TextChanged);
            // 
            // killButton
            // 
            this.killButton.BackColor = System.Drawing.Color.Red;
            this.killButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killButton.Location = new System.Drawing.Point(1130, 602);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(437, 166);
            this.killButton.TabIndex = 14;
            this.killButton.Text = "Kill Process";
            this.killButton.UseVisualStyleBackColor = false;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            // 
            // dataGrid_processes
            // 
            this.dataGrid_processes.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGrid_processes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_processes.Location = new System.Drawing.Point(57, 366);
            this.dataGrid_processes.Name = "dataGrid_processes";
            this.dataGrid_processes.RowHeadersWidth = 62;
            this.dataGrid_processes.RowTemplate.Height = 28;
            this.dataGrid_processes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_processes.Size = new System.Drawing.Size(1058, 651);
            this.dataGrid_processes.TabIndex = 16;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Lime;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(1130, 801);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(437, 166);
            this.refresh_btn.TabIndex = 17;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OS1.Properties.Resources.Linux;
            this.ClientSize = new System.Drawing.Size(1960, 1165);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.dataGrid_processes);
            this.Controls.Add(this.killButton);
            this.Controls.Add(this.searchByIdTextBox);
            this.Controls.Add(this.searchByNameTextBox);
            this.Controls.Add(this.processesLabel);
            this.Controls.Add(this.searchByIDLabel);
            this.Controls.Add(this.searchByNameLabel);
            this.Controls.Add(this.HelloUserLabel);
            this.Name = "start";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_processes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloUserLabel;
        private System.Windows.Forms.Label searchByNameLabel;
        private System.Windows.Forms.Label searchByIDLabel;
        private System.Windows.Forms.Label processesLabel;
        private System.Windows.Forms.TextBox searchByNameTextBox;
        private System.Windows.Forms.TextBox searchByIdTextBox;
        private System.Windows.Forms.Button killButton;
        private System.Windows.Forms.DataGridView dataGrid_processes;
        private System.Windows.Forms.Button refresh_btn;
    }
}

