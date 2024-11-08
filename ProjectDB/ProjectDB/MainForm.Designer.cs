namespace ProjectDB
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CatalogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCatalogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCatalogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCatalogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchByNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByAuthorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByPublisherMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByYearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByGenreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BookDG = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIsTaken = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CardDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnByDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LibrarianDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ReaderDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDG)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardDG)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarianDG)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CatalogMenuItem,
            this.CardMenuItem,
            this.поискToolStripMenuItem,
            this.сортироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1355, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CatalogMenuItem
            // 
            this.CatalogMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCatalogMenuItem,
            this.EditCatalogMenuItem,
            this.DeleteCatalogMenuItem});
            this.CatalogMenuItem.Name = "CatalogMenuItem";
            this.CatalogMenuItem.Size = new System.Drawing.Size(62, 20);
            this.CatalogMenuItem.Text = "Каталог";
            // 
            // AddCatalogMenuItem
            // 
            this.AddCatalogMenuItem.Name = "AddCatalogMenuItem";
            this.AddCatalogMenuItem.Size = new System.Drawing.Size(201, 22);
            this.AddCatalogMenuItem.Text = "Добавить издание";
            this.AddCatalogMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditCatalogMenuItem
            // 
            this.EditCatalogMenuItem.Name = "EditCatalogMenuItem";
            this.EditCatalogMenuItem.Size = new System.Drawing.Size(201, 22);
            this.EditCatalogMenuItem.Text = "Редактировать издание";
            this.EditCatalogMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // DeleteCatalogMenuItem
            // 
            this.DeleteCatalogMenuItem.Name = "DeleteCatalogMenuItem";
            this.DeleteCatalogMenuItem.Size = new System.Drawing.Size(201, 22);
            this.DeleteCatalogMenuItem.Text = "Удалить издание";
            this.DeleteCatalogMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // CardMenuItem
            // 
            this.CardMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCardMenuItem,
            this.EditCardMenuItem,
            this.DeleteCardMenuItem});
            this.CardMenuItem.Name = "CardMenuItem";
            this.CardMenuItem.Size = new System.Drawing.Size(130, 20);
            this.CardMenuItem.Text = "Карточки читателей";
            // 
            // AddCardMenuItem
            // 
            this.AddCardMenuItem.Name = "AddCardMenuItem";
            this.AddCardMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddCardMenuItem.Text = "Добавить";
            this.AddCardMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditCardMenuItem
            // 
            this.EditCardMenuItem.Name = "EditCardMenuItem";
            this.EditCardMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditCardMenuItem.Text = "Редактировать";
            this.EditCardMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // DeleteCardMenuItem
            // 
            this.DeleteCardMenuItem.Name = "DeleteCardMenuItem";
            this.DeleteCardMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteCardMenuItem.Text = "Удалить";
            this.DeleteCardMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchByNameMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // SearchByNameMenuItem
            // 
            this.SearchByNameMenuItem.Name = "SearchByNameMenuItem";
            this.SearchByNameMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SearchByNameMenuItem.Text = "По названию";
            this.SearchByNameMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // сортироватьToolStripMenuItem
            // 
            this.сортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByAuthorMenuItem,
            this.SortByPublisherMenuItem,
            this.SortByYearMenuItem,
            this.SortByGenreMenuItem});
            this.сортироватьToolStripMenuItem.Name = "сортироватьToolStripMenuItem";
            this.сортироватьToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.сортироватьToolStripMenuItem.Text = "Сортировать";
            // 
            // SortByAuthorMenuItem
            // 
            this.SortByAuthorMenuItem.Name = "SortByAuthorMenuItem";
            this.SortByAuthorMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SortByAuthorMenuItem.Text = "По автору";
            this.SortByAuthorMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SortByPublisherMenuItem
            // 
            this.SortByPublisherMenuItem.Name = "SortByPublisherMenuItem";
            this.SortByPublisherMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SortByPublisherMenuItem.Text = "По издательству";
            this.SortByPublisherMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SortByYearMenuItem
            // 
            this.SortByYearMenuItem.Name = "SortByYearMenuItem";
            this.SortByYearMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SortByYearMenuItem.Text = "По году издания";
            this.SortByYearMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // SortByGenreMenuItem
            // 
            this.SortByGenreMenuItem.Name = "SortByGenreMenuItem";
            this.SortByGenreMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SortByGenreMenuItem.Text = "По жанру";
            this.SortByGenreMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1355, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BookDG
            // 
            this.BookDG.AllowUserToAddRows = false;
            this.BookDG.AllowUserToDeleteRows = false;
            this.BookDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BookDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.BookAuthor,
            this.BookPublisher,
            this.BookYear,
            this.BookPlace,
            this.BookIsTaken});
            this.BookDG.Location = new System.Drawing.Point(6, 6);
            this.BookDG.Name = "BookDG";
            this.BookDG.ReadOnly = true;
            this.BookDG.RowHeadersVisible = false;
            this.BookDG.Size = new System.Drawing.Size(1333, 602);
            this.BookDG.TabIndex = 2;
            // 
            // BookID
            // 
            this.BookID.FillWeight = 45F;
            this.BookID.HeaderText = "№";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.FillWeight = 120F;
            this.BookName.HeaderText = "Название";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookAuthor
            // 
            this.BookAuthor.HeaderText = "Автор";
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.ReadOnly = true;
            // 
            // BookPublisher
            // 
            this.BookPublisher.FillWeight = 80F;
            this.BookPublisher.HeaderText = "Издательство";
            this.BookPublisher.Name = "BookPublisher";
            this.BookPublisher.ReadOnly = true;
            // 
            // BookYear
            // 
            this.BookYear.FillWeight = 80F;
            this.BookYear.HeaderText = "Год издания";
            this.BookYear.Name = "BookYear";
            this.BookYear.ReadOnly = true;
            // 
            // BookPlace
            // 
            this.BookPlace.HeaderText = "Расположение книги";
            this.BookPlace.Name = "BookPlace";
            this.BookPlace.ReadOnly = true;
            // 
            // BookIsTaken
            // 
            this.BookIsTaken.HeaderText = "Книга на руках у читателя";
            this.BookIsTaken.Name = "BookIsTaken";
            this.BookIsTaken.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1355, 640);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BookDG);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1347, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Печатные издания";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CardDG);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1347, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Карточки выдачи изданий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CardDG
            // 
            this.CardDG.AllowUserToAddRows = false;
            this.CardDG.AllowUserToDeleteRows = false;
            this.CardDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CardDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CardDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ReturnByDate});
            this.CardDG.Location = new System.Drawing.Point(7, 6);
            this.CardDG.Name = "CardDG";
            this.CardDG.ReadOnly = true;
            this.CardDG.RowHeadersVisible = false;
            this.CardDG.Size = new System.Drawing.Size(1333, 602);
            this.CardDG.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 45F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Библиотекарь";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Печатное издание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 80F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Читатель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 80F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата и время выдачи";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ReturnByDate
            // 
            this.ReturnByDate.HeaderText = "Вернуть до";
            this.ReturnByDate.Name = "ReturnByDate";
            this.ReturnByDate.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LibrarianDG);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1347, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Библиотекари";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LibrarianDG
            // 
            this.LibrarianDG.AllowUserToAddRows = false;
            this.LibrarianDG.AllowUserToDeleteRows = false;
            this.LibrarianDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibrarianDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LibrarianDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LibrarianDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibrarianDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.LibrarianDG.Location = new System.Drawing.Point(7, 6);
            this.LibrarianDG.Name = "LibrarianDG";
            this.LibrarianDG.ReadOnly = true;
            this.LibrarianDG.RowHeadersVisible = false;
            this.LibrarianDG.Size = new System.Drawing.Size(1333, 602);
            this.LibrarianDG.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 45F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Идентификатор";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 120F;
            this.dataGridViewTextBoxColumn7.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ReaderDG);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1347, 614);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Читатели";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ReaderDG
            // 
            this.ReaderDG.AllowUserToAddRows = false;
            this.ReaderDG.AllowUserToDeleteRows = false;
            this.ReaderDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReaderDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReaderDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReaderDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaderDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.ReaderDG.Location = new System.Drawing.Point(7, 6);
            this.ReaderDG.Name = "ReaderDG";
            this.ReaderDG.ReadOnly = true;
            this.ReaderDG.RowHeadersVisible = false;
            this.ReaderDG.Size = new System.Drawing.Size(1333, 602);
            this.ReaderDG.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.FillWeight = 45F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Идентификатор";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.FillWeight = 120F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 694);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDG)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardDG)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibrarianDG)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CatalogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCatalogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCatalogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCatalogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchByNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByAuthorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByPublisherMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByYearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByGenreMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView BookDG;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView CardDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnByDate;
        private System.Windows.Forms.DataGridView LibrarianDG;
        private System.Windows.Forms.DataGridView ReaderDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPlace;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BookIsTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}

