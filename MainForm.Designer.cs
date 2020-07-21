namespace Library
{
    partial class MainForm
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
            this.labelBooks = new System.Windows.Forms.Label();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonEditAuthor = new System.Windows.Forms.Button();
            this.buttonRemoveAuthor = new System.Windows.Forms.Button();
            this.dataGridViewSimilar = new System.Windows.Forms.DataGridView();
            this.dataGridViewOther = new System.Windows.Forms.DataGridView();
            this.labelSimilar = new System.Windows.Forms.Label();
            this.labelAuthorOther = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOther)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.BackColor = System.Drawing.Color.Transparent;
            this.labelBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBooks.Location = new System.Drawing.Point(12, 9);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(52, 17);
            this.labelBooks.TabIndex = 0;
            this.labelBooks.Text = "Books";
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(565, 200);
            this.dataGridViewBooks.TabIndex = 23;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAuthors.Location = new System.Drawing.Point(12, 321);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(64, 17);
            this.labelAuthors.TabIndex = 2;
            this.labelAuthors.Text = "Authors";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(12, 264);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBook.TabIndex = 3;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Location = new System.Drawing.Point(229, 264);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(75, 23);
            this.buttonEditBook.TabIndex = 4;
            this.buttonEditBook.Text = "Edit Book";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Location = new System.Drawing.Point(472, 264);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(90, 23);
            this.buttonRemoveBook.TabIndex = 5;
            this.buttonRemoveBook.Text = "Remove Book";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAuthors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(12, 360);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(545, 200);
            this.dataGridViewAuthors.TabIndex = 6;
            this.dataGridViewAuthors.SelectionChanged += new System.EventHandler(this.dataGridViewAuthors_SelectionChanged);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(12, 584);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAuthor.TabIndex = 7;
            this.buttonAddAuthor.Text = "Add Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // buttonEditAuthor
            // 
            this.buttonEditAuthor.Location = new System.Drawing.Point(229, 584);
            this.buttonEditAuthor.Name = "buttonEditAuthor";
            this.buttonEditAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonEditAuthor.TabIndex = 8;
            this.buttonEditAuthor.Text = "Edit Author";
            this.buttonEditAuthor.UseVisualStyleBackColor = true;
            this.buttonEditAuthor.Click += new System.EventHandler(this.buttonEditAuthor_Click);
            // 
            // buttonRemoveAuthor
            // 
            this.buttonRemoveAuthor.Location = new System.Drawing.Point(472, 584);
            this.buttonRemoveAuthor.Name = "buttonRemoveAuthor";
            this.buttonRemoveAuthor.Size = new System.Drawing.Size(90, 23);
            this.buttonRemoveAuthor.TabIndex = 9;
            this.buttonRemoveAuthor.Text = "Remove Author";
            this.buttonRemoveAuthor.UseVisualStyleBackColor = true;
            this.buttonRemoveAuthor.Click += new System.EventHandler(this.buttonRemoveAuthor_Click);
            // 
            // dataGridViewSimilar
            // 
            this.dataGridViewSimilar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSimilar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSimilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSimilar.Location = new System.Drawing.Point(634, 42);
            this.dataGridViewSimilar.Name = "dataGridViewSimilar";
            this.dataGridViewSimilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSimilar.Size = new System.Drawing.Size(543, 200);
            this.dataGridViewSimilar.TabIndex = 10;
            // 
            // dataGridViewOther
            // 
            this.dataGridViewOther.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewOther.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOther.Location = new System.Drawing.Point(634, 356);
            this.dataGridViewOther.Name = "dataGridViewOther";
            this.dataGridViewOther.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOther.Size = new System.Drawing.Size(445, 200);
            this.dataGridViewOther.TabIndex = 11;
            // 
            // labelSimilar
            // 
            this.labelSimilar.AutoSize = true;
            this.labelSimilar.BackColor = System.Drawing.Color.Transparent;
            this.labelSimilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimilar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSimilar.Location = new System.Drawing.Point(631, 9);
            this.labelSimilar.Name = "labelSimilar";
            this.labelSimilar.Size = new System.Drawing.Size(188, 17);
            this.labelSimilar.TabIndex = 12;
            this.labelSimilar.Text = "Books in the same genre";
            // 
            // labelAuthorOther
            // 
            this.labelAuthorOther.AutoSize = true;
            this.labelAuthorOther.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthorOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorOther.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAuthorOther.Location = new System.Drawing.Point(631, 321);
            this.labelAuthorOther.Name = "labelAuthorOther";
            this.labelAuthorOther.Size = new System.Drawing.Size(157, 17);
            this.labelAuthorOther.TabIndex = 13;
            this.labelAuthorOther.Text = "Books by this author";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1204, 631);
            this.Controls.Add(this.labelAuthorOther);
            this.Controls.Add(this.labelSimilar);
            this.Controls.Add(this.dataGridViewOther);
            this.Controls.Add(this.dataGridViewSimilar);
            this.Controls.Add(this.buttonRemoveAuthor);
            this.Controls.Add(this.buttonEditAuthor);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.dataGridViewAuthors);
            this.Controls.Add(this.buttonRemoveBook);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.labelAuthors);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.labelBooks);
            this.MinimumSize = new System.Drawing.Size(1220, 670);
            this.Name = "MainForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOther)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonEditAuthor;
        private System.Windows.Forms.Button buttonRemoveAuthor;
        private System.Windows.Forms.DataGridView dataGridViewSimilar;
        private System.Windows.Forms.DataGridView dataGridViewOther;
        private System.Windows.Forms.Label labelSimilar;
        private System.Windows.Forms.Label labelAuthorOther;
    }
}

