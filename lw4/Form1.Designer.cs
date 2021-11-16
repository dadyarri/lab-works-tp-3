
using System;
using System.Collections.Generic;

namespace lw4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReaderNameTextBox = new System.Windows.Forms.TextBox();
            this.ReaderNameLabel = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.CreateReaderTab = new System.Windows.Forms.TabPage();
            this.CreateReaderButton = new System.Windows.Forms.Button();
            this.CreateBookTab = new System.Windows.Forms.TabPage();
            this.CreateBookButton = new System.Windows.Forms.Button();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.AuthorNameTextBox = new System.Windows.Forms.TextBox();
            this.AuthorNameLabel = new System.Windows.Forms.Label();
            this.ListBooksTab = new System.Windows.Forms.TabPage();
            this.ListOfBooks = new System.Windows.Forms.DataGridView();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.LibraryCard = new System.Windows.Forms.TabPage();
            this.LibraryCardsUpdateButton = new System.Windows.Forms.Button();
            this.ReaderLabel = new System.Windows.Forms.Label();
            this.ReadersComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl1.SuspendLayout();
            this.CreateReaderTab.SuspendLayout();
            this.CreateBookTab.SuspendLayout();
            this.ListBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfBooks)).BeginInit();
            this.LibraryCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReaderNameTextBox
            // 
            this.ReaderNameTextBox.Location = new System.Drawing.Point(17, 31);
            this.ReaderNameTextBox.Name = "ReaderNameTextBox";
            this.ReaderNameTextBox.Size = new System.Drawing.Size(167, 23);
            this.ReaderNameTextBox.TabIndex = 0;
            // 
            // ReaderNameLabel
            // 
            this.ReaderNameLabel.AutoSize = true;
            this.ReaderNameLabel.Location = new System.Drawing.Point(17, 13);
            this.ReaderNameLabel.Name = "ReaderNameLabel";
            this.ReaderNameLabel.Size = new System.Drawing.Size(83, 15);
            this.ReaderNameLabel.TabIndex = 2;
            this.ReaderNameLabel.Text = "Имя читателя";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.CreateReaderTab);
            this.TabControl1.Controls.Add(this.CreateBookTab);
            this.TabControl1.Controls.Add(this.ListBooksTab);
            this.TabControl1.Controls.Add(this.LibraryCard);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(776, 426);
            this.TabControl1.TabIndex = 3;
            // 
            // CreateReaderTab
            // 
            this.CreateReaderTab.Controls.Add(this.CreateReaderButton);
            this.CreateReaderTab.Controls.Add(this.ReaderNameTextBox);
            this.CreateReaderTab.Controls.Add(this.ReaderNameLabel);
            this.CreateReaderTab.Location = new System.Drawing.Point(4, 24);
            this.CreateReaderTab.Name = "CreateReaderTab";
            this.CreateReaderTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateReaderTab.Size = new System.Drawing.Size(768, 398);
            this.CreateReaderTab.TabIndex = 0;
            this.CreateReaderTab.Text = "Создать читателя";
            this.CreateReaderTab.UseVisualStyleBackColor = true;
            // 
            // CreateReaderButton
            // 
            this.CreateReaderButton.Location = new System.Drawing.Point(17, 60);
            this.CreateReaderButton.Name = "CreateReaderButton";
            this.CreateReaderButton.Size = new System.Drawing.Size(167, 23);
            this.CreateReaderButton.TabIndex = 3;
            this.CreateReaderButton.Text = "Создать читателя";
            this.CreateReaderButton.UseVisualStyleBackColor = true;
            this.CreateReaderButton.Click += new System.EventHandler(this.CreateReaderButton_Click);
            // 
            // CreateBookTab
            // 
            this.CreateBookTab.Controls.Add(this.CreateBookButton);
            this.CreateBookTab.Controls.Add(this.BookNameTextBox);
            this.CreateBookTab.Controls.Add(this.BookNameLabel);
            this.CreateBookTab.Controls.Add(this.AuthorNameTextBox);
            this.CreateBookTab.Controls.Add(this.AuthorNameLabel);
            this.CreateBookTab.Location = new System.Drawing.Point(4, 24);
            this.CreateBookTab.Name = "CreateBookTab";
            this.CreateBookTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateBookTab.Size = new System.Drawing.Size(768, 398);
            this.CreateBookTab.TabIndex = 1;
            this.CreateBookTab.Text = "Создать книгу";
            this.CreateBookTab.UseVisualStyleBackColor = true;
            // 
            // CreateBookButton
            // 
            this.CreateBookButton.Location = new System.Drawing.Point(20, 113);
            this.CreateBookButton.Name = "CreateBookButton";
            this.CreateBookButton.Size = new System.Drawing.Size(167, 23);
            this.CreateBookButton.TabIndex = 7;
            this.CreateBookButton.Text = "Создать книгу";
            this.CreateBookButton.UseVisualStyleBackColor = true;
            this.CreateBookButton.Click += new System.EventHandler(this.CreateBookButton_Click);
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(20, 84);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(167, 23);
            this.BookNameTextBox.TabIndex = 5;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(20, 66);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(94, 15);
            this.BookNameLabel.TabIndex = 6;
            this.BookNameLabel.Text = "Название книги";
            // 
            // AuthorNameTextBox
            // 
            this.AuthorNameTextBox.Location = new System.Drawing.Point(20, 40);
            this.AuthorNameTextBox.Name = "AuthorNameTextBox";
            this.AuthorNameTextBox.Size = new System.Drawing.Size(167, 23);
            this.AuthorNameTextBox.TabIndex = 3;
            // 
            // AuthorNameLabel
            // 
            this.AuthorNameLabel.AutoSize = true;
            this.AuthorNameLabel.Location = new System.Drawing.Point(20, 22);
            this.AuthorNameLabel.Name = "AuthorNameLabel";
            this.AuthorNameLabel.Size = new System.Drawing.Size(71, 15);
            this.AuthorNameLabel.TabIndex = 4;
            this.AuthorNameLabel.Text = "Имя автора";
            // 
            // ListBooksTab
            // 
            this.ListBooksTab.Controls.Add(this.ListOfBooks);
            this.ListBooksTab.Controls.Add(this.UpdateDataButton);
            this.ListBooksTab.Location = new System.Drawing.Point(4, 24);
            this.ListBooksTab.Name = "ListBooksTab";
            this.ListBooksTab.Size = new System.Drawing.Size(768, 398);
            this.ListBooksTab.TabIndex = 2;
            this.ListBooksTab.Text = "Список книг";
            this.ListBooksTab.UseVisualStyleBackColor = true;
            // 
            // ListOfBooks
            // 
            this.ListOfBooks.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfBooks.Location = new System.Drawing.Point(3, 33);
            this.ListOfBooks.Name = "ListOfBooks";
            this.ListOfBooks.RowTemplate.Height = 25;
            this.ListOfBooks.Size = new System.Drawing.Size(762, 362);
            this.ListOfBooks.TabIndex = 1;
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Location = new System.Drawing.Point(618, 3);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(147, 23);
            this.UpdateDataButton.TabIndex = 0;
            this.UpdateDataButton.Text = "Обновить данные";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // LibraryCard
            // 
            this.LibraryCard.Controls.Add(this.LibraryCardsUpdateButton);
            this.LibraryCard.Controls.Add(this.ReaderLabel);
            this.LibraryCard.Controls.Add(this.ReadersComboBox);
            this.LibraryCard.Location = new System.Drawing.Point(4, 24);
            this.LibraryCard.Name = "LibraryCard";
            this.LibraryCard.Size = new System.Drawing.Size(768, 398);
            this.LibraryCard.TabIndex = 3;
            this.LibraryCard.Text = "Читательские билеты";
            this.LibraryCard.UseVisualStyleBackColor = true;
            // 
            // LibraryCardsUpdateButton
            // 
            this.LibraryCardsUpdateButton.Location = new System.Drawing.Point(618, 3);
            this.LibraryCardsUpdateButton.Name = "LibraryCardsUpdateButton";
            this.LibraryCardsUpdateButton.Size = new System.Drawing.Size(147, 23);
            this.LibraryCardsUpdateButton.TabIndex = 2;
            this.LibraryCardsUpdateButton.Text = "Обновить данные";
            this.LibraryCardsUpdateButton.UseVisualStyleBackColor = true;
            this.LibraryCardsUpdateButton.Click += new System.EventHandler(this.LibraryCardsUpdateButton_Click);
            // 
            // ReaderLabel
            // 
            this.ReaderLabel.AutoSize = true;
            this.ReaderLabel.Location = new System.Drawing.Point(16, 8);
            this.ReaderLabel.Name = "ReaderLabel";
            this.ReaderLabel.Size = new System.Drawing.Size(57, 15);
            this.ReaderLabel.TabIndex = 1;
            this.ReaderLabel.Text = "Читатель";
            // 
            // ReadersComboBox
            // 
            this.ReadersComboBox.FormattingEnabled = true;
            this.ReadersComboBox.Location = new System.Drawing.Point(16, 29);
            this.ReadersComboBox.Name = "ReadersComboBox";
            this.ReadersComboBox.Size = new System.Drawing.Size(175, 23);
            this.ReadersComboBox.TabIndex = 0;
            this.ReadersComboBox.SelectionChangeCommitted += new System.EventHandler(this.ReadersComboBox_SelectionChangeCommited);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "LabWork #4 by dadyarri";
            this.TabControl1.ResumeLayout(false);
            this.CreateReaderTab.ResumeLayout(false);
            this.CreateReaderTab.PerformLayout();
            this.CreateBookTab.ResumeLayout(false);
            this.CreateBookTab.PerformLayout();
            this.ListBooksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfBooks)).EndInit();
            this.LibraryCard.ResumeLayout(false);
            this.LibraryCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox ReaderNameTextBox;
        private System.Windows.Forms.Label ReaderNameLabel;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage CreateReaderTab;
        private System.Windows.Forms.Button CreateReaderButton;
        private System.Windows.Forms.TabPage CreateBookTab;
        private System.Windows.Forms.TabPage ListBooksTab;
        internal System.Windows.Forms.TextBox AuthorNameTextBox;
        private System.Windows.Forms.Label AuthorNameLabel;
        private System.Windows.Forms.Button CreateBookButton;
        internal System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.DataGridView ListOfBooks;
        private System.Windows.Forms.TabPage LibraryCard;
        private System.Windows.Forms.ComboBox ReadersComboBox;
        private System.Windows.Forms.Label ReaderLabel;
        private System.Windows.Forms.Button LibraryCardsUpdateButton;
    }
}

