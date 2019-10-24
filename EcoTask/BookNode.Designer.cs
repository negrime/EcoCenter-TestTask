namespace EcoTask
{
    partial class BookNodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookNodeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelAuthorPS = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAddNode = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonParse = new System.Windows.Forms.Button();
            this.textBoxLinkToParse = new System.Windows.Forms.TextBox();
            this.labelParse = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelParse);
            this.groupBox1.Controls.Add(this.textBoxLinkToParse);
            this.groupBox1.Controls.Add(this.buttonParse);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.labelYear);
            this.groupBox1.Controls.Add(this.textBoxYear);
            this.groupBox1.Controls.Add(this.labelCategory);
            this.groupBox1.Controls.Add(this.textBoxCategory);
            this.groupBox1.Controls.Add(this.labelAuthorPS);
            this.groupBox1.Controls.Add(this.labelAuthor);
            this.groupBox1.Controls.Add(this.textBoxAuthor);
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 323);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(6, 264);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 17);
            this.labelPrice.TabIndex = 14;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(6, 284);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(163, 22);
            this.textBoxPrice.TabIndex = 13;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitKeyPress);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(6, 205);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 17);
            this.labelYear.TabIndex = 12;
            this.labelYear.Text = "Год";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(6, 225);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(163, 22);
            this.textBoxYear.TabIndex = 11;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitKeyPress);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(6, 147);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(77, 17);
            this.labelCategory.TabIndex = 10;
            this.labelCategory.Text = "Категория";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(6, 167);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(163, 22);
            this.textBoxCategory.TabIndex = 9;
            // 
            // labelAuthorPS
            // 
            this.labelAuthorPS.AutoSize = true;
            this.labelAuthorPS.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorPS.Location = new System.Drawing.Point(-4, 110);
            this.labelAuthorPS.Name = "labelAuthorPS";
            this.labelAuthorPS.Size = new System.Drawing.Size(416, 18);
            this.labelAuthorPS.TabIndex = 8;
            this.labelAuthorPS.Text = " (несколько авторов следует вводить чрез точку с запятой \";\"";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(6, 65);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 17);
            this.labelAuthor.TabIndex = 7;
            this.labelAuthor.Text = "Автор";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(6, 85);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(163, 22);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(6, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 17);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Название";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(6, 38);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(163, 22);
            this.textBoxTitle.TabIndex = 0;
            // 
            // buttonAddNode
            // 
            this.buttonAddNode.Location = new System.Drawing.Point(292, 358);
            this.buttonAddNode.Name = "buttonAddNode";
            this.buttonAddNode.Size = new System.Drawing.Size(139, 26);
            this.buttonAddNode.TabIndex = 6;
            this.buttonAddNode.Text = "Добавить запись";
            this.buttonAddNode.UseVisualStyleBackColor = true;
            this.buttonAddNode.Click += new System.EventHandler(this.ButtonAddNode_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(11, 358);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(139, 26);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(219, 65);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(100, 28);
            this.buttonParse.TabIndex = 15;
            this.buttonParse.Text = "Запарсить";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.ButtonParse_Click);
            // 
            // textBoxLinkToParse
            // 
            this.textBoxLinkToParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLinkToParse.Location = new System.Drawing.Point(219, 38);
            this.textBoxLinkToParse.Name = "textBoxLinkToParse";
            this.textBoxLinkToParse.Size = new System.Drawing.Size(183, 22);
            this.textBoxLinkToParse.TabIndex = 16;
            this.textBoxLinkToParse.Text = "https://www.labirint.ru/books/401209/";
            // 
            // labelParse
            // 
            this.labelParse.AutoSize = true;
            this.labelParse.Location = new System.Drawing.Point(216, 18);
            this.labelParse.Name = "labelParse";
            this.labelParse.Size = new System.Drawing.Size(120, 17);
            this.labelParse.TabIndex = 17;
            this.labelParse.Text = "Книга с labirint.ru";
            // 
            // BookNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 407);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddNode);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookNodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление книги";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelAuthorPS;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonAddNode;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelParse;
        private System.Windows.Forms.TextBox textBoxLinkToParse;
        private System.Windows.Forms.Button buttonParse;
    }
}