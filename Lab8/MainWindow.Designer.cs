namespace Lab8 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editPublishName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editPages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editPrice = new System.Windows.Forms.TextBox();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tempCatalogBox = new System.Windows.Forms.ListBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.writeBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.editFind = new System.Windows.Forms.TextBox();
            this.countTxt = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.readBtn = new System.Windows.Forms.Button();
            this.fileBox = new System.Windows.Forms.ListBox();
            this.discountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавити книгу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва книги";
            // 
            // editName
            // 
            this.editName.Location = new System.Drawing.Point(53, 87);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(100, 22);
            this.editName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Назва видавництва";
            // 
            // editPublishName
            // 
            this.editPublishName.Location = new System.Drawing.Point(53, 150);
            this.editPublishName.Name = "editPublishName";
            this.editPublishName.Size = new System.Drawing.Size(136, 22);
            this.editPublishName.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(53, 214);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата видання";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Кількість сторінок";
            // 
            // editPages
            // 
            this.editPages.Location = new System.Drawing.Point(53, 280);
            this.editPages.Name = "editPages";
            this.editPages.Size = new System.Drawing.Size(123, 22);
            this.editPages.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ціна (грн)";
            // 
            // editPrice
            // 
            this.editPrice.Location = new System.Drawing.Point(53, 349);
            this.editPrice.Name = "editPrice";
            this.editPrice.Size = new System.Drawing.Size(100, 22);
            this.editPrice.TabIndex = 10;
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(53, 423);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(94, 30);
            this.addBookBtn.TabIndex = 11;
            this.addBookBtn.Text = "Добавити";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(55, 389);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 16);
            this.errorText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Створений каталог";
            // 
            // tempCatalogBox
            // 
            this.tempCatalogBox.FormattingEnabled = true;
            this.tempCatalogBox.ItemHeight = 16;
            this.tempCatalogBox.Location = new System.Drawing.Point(344, 58);
            this.tempCatalogBox.Name = "tempCatalogBox";
            this.tempCatalogBox.Size = new System.Drawing.Size(190, 260);
            this.tempCatalogBox.TabIndex = 14;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(344, 381);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(109, 32);
            this.sortBtn.TabIndex = 15;
            this.sortBtn.Text = "Сортувати";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // writeBtn
            // 
            this.writeBtn.Location = new System.Drawing.Point(344, 419);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(138, 32);
            this.writeBtn.TabIndex = 16;
            this.writeBtn.Text = "Записати в файл";
            this.writeBtn.UseVisualStyleBackColor = true;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Пошук за видавництвом";
            // 
            // editFind
            // 
            this.editFind.Location = new System.Drawing.Point(589, 58);
            this.editFind.Name = "editFind";
            this.editFind.Size = new System.Drawing.Size(164, 22);
            this.editFind.TabIndex = 18;
            this.editFind.TextChanged += new System.EventHandler(this.editFind_TextChanged);
            // 
            // countTxt
            // 
            this.countTxt.AutoSize = true;
            this.countTxt.Location = new System.Drawing.Point(589, 92);
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(85, 16);
            this.countTxt.TabIndex = 19;
            this.countTxt.Text = "Знайдено: 0";
            // 
            // resultBox
            // 
            this.resultBox.FormattingEnabled = true;
            this.resultBox.ItemHeight = 16;
            this.resultBox.Location = new System.Drawing.Point(589, 122);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(186, 244);
            this.resultBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(816, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Виведення з файлу";
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(819, 54);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(146, 30);
            this.readBtn.TabIndex = 22;
            this.readBtn.Text = "Вивести з файлу";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // fileBox
            // 
            this.fileBox.FormattingEnabled = true;
            this.fileBox.ItemHeight = 16;
            this.fileBox.Location = new System.Drawing.Point(819, 122);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(164, 244);
            this.fileBox.TabIndex = 23;
            // 
            // discountBtn
            // 
            this.discountBtn.Location = new System.Drawing.Point(345, 339);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(108, 32);
            this.discountBtn.TabIndex = 24;
            this.discountBtn.Text = "Знижка";
            this.discountBtn.UseVisualStyleBackColor = true;
            this.discountBtn.Click += new System.EventHandler(this.discountBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 465);
            this.Controls.Add(this.discountBtn);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.countTxt);
            this.Controls.Add(this.editFind);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.tempCatalogBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.editPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editPages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.editPublishName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editPublishName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editPages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editPrice;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox tempCatalogBox;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button writeBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox editFind;
        private System.Windows.Forms.Label countTxt;
        private System.Windows.Forms.ListBox resultBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.ListBox fileBox;
        private System.Windows.Forms.Button discountBtn;
    }
}

