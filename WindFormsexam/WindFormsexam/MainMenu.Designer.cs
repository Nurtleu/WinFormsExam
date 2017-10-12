namespace WindFormsexam
{
    partial class MainMenu
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Мука"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Сахар"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Печенье"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClearItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderWeight,
            this.columnHeaderKg});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(448, 435);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Наименование";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderWeight
            // 
            this.columnHeaderWeight.Text = "Вес,     Кг";
            this.columnHeaderWeight.Width = 107;
            // 
            // columnHeaderKg
            // 
            this.columnHeaderKg.Text = "Цена";
            this.columnHeaderKg.Width = 59;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(799, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 34);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(685, 86);
            this.textBoxItemName.Multiline = true;
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(214, 31);
            this.textBoxItemName.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(685, 141);
            this.textBoxWeight.Multiline = true;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(214, 31);
            this.textBoxWeight.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(466, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование товара";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight.Location = new System.Drawing.Point(466, 152);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(40, 20);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Вес";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(777, 204);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(122, 34);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Отправить товар";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClearItem
            // 
            this.buttonClearItem.BackColor = System.Drawing.Color.White;
            this.buttonClearItem.Location = new System.Drawing.Point(645, 204);
            this.buttonClearItem.Name = "buttonClearItem";
            this.buttonClearItem.Size = new System.Drawing.Size(116, 34);
            this.buttonClearItem.TabIndex = 7;
            this.buttonClearItem.Text = "Очистить";
            this.buttonClearItem.UseVisualStyleBackColor = false;
            this.buttonClearItem.Click += new System.EventHandler(this.ButtonClearItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(903, 488);
            this.Controls.Add(this.buttonClearItem);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listView1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderWeight;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ColumnHeader columnHeaderKg;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClearItem;
    }
}