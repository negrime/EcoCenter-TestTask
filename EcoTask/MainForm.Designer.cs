namespace EcoTask
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonOpenXML = new System.Windows.Forms.Button();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.buttonSaveHTML = new System.Windows.Forms.Button();
            this.buttonDeleteNode = new System.Windows.Forms.Button();
            this.buttonAddNode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookDataGridView.Location = new System.Drawing.Point(12, 82);
            this.bookDataGridView.MultiSelect = false;
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowHeadersWidth = 51;
            this.bookDataGridView.RowTemplate.Height = 24;
            this.bookDataGridView.Size = new System.Drawing.Size(998, 441);
            this.bookDataGridView.TabIndex = 0;
            this.bookDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDataGridView_CellEndEdit);
            // 
            // buttonOpenXML
            // 
            this.buttonOpenXML.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenXML.Name = "buttonOpenXML";
            this.buttonOpenXML.Size = new System.Drawing.Size(171, 51);
            this.buttonOpenXML.TabIndex = 1;
            this.buttonOpenXML.Text = "Открыть XML";
            this.buttonOpenXML.UseVisualStyleBackColor = true;
            this.buttonOpenXML.Click += new System.EventHandler(this.ButtonOpenXML_Click);
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Location = new System.Drawing.Point(223, 12);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(171, 51);
            this.buttonSaveXML.TabIndex = 2;
            this.buttonSaveXML.Text = "Сохранить XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.ButtonSaveXML_Click);
            // 
            // buttonSaveHTML
            // 
            this.buttonSaveHTML.Location = new System.Drawing.Point(839, 12);
            this.buttonSaveHTML.Name = "buttonSaveHTML";
            this.buttonSaveHTML.Size = new System.Drawing.Size(171, 51);
            this.buttonSaveHTML.TabIndex = 3;
            this.buttonSaveHTML.Text = "Отчет в HTML";
            this.buttonSaveHTML.UseVisualStyleBackColor = true;
            this.buttonSaveHTML.Click += new System.EventHandler(this.ButtonSaveHTML_Click);
            // 
            // buttonDeleteNode
            // 
            this.buttonDeleteNode.Location = new System.Drawing.Point(12, 533);
            this.buttonDeleteNode.Name = "buttonDeleteNode";
            this.buttonDeleteNode.Size = new System.Drawing.Size(171, 51);
            this.buttonDeleteNode.TabIndex = 4;
            this.buttonDeleteNode.Text = "Удалить запись";
            this.buttonDeleteNode.UseVisualStyleBackColor = true;
            this.buttonDeleteNode.Click += new System.EventHandler(this.ButtonDeleteNode_Click);
            // 
            // buttonAddNode
            // 
            this.buttonAddNode.Location = new System.Drawing.Point(223, 533);
            this.buttonAddNode.Name = "buttonAddNode";
            this.buttonAddNode.Size = new System.Drawing.Size(171, 51);
            this.buttonAddNode.TabIndex = 5;
            this.buttonAddNode.Text = "Добавить запись";
            this.buttonAddNode.UseVisualStyleBackColor = true;
            this.buttonAddNode.Click += new System.EventHandler(this.ButtonAddNode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 596);
            this.Controls.Add(this.buttonAddNode);
            this.Controls.Add(this.buttonDeleteNode);
            this.Controls.Add(this.buttonSaveHTML);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.buttonOpenXML);
            this.Controls.Add(this.bookDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт книг";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.Button buttonOpenXML;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.Button buttonSaveHTML;
        private System.Windows.Forms.Button buttonDeleteNode;
        private System.Windows.Forms.Button buttonAddNode;
    }
}

