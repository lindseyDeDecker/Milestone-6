namespace Milestone_2._1
{
    partial class inventoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            inventoryButton = new Button();
            dataInfo = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            addInventory = new Button();
            btnSaveChanges = new Button();
            btnDecreaseInventory = new Button();
            btnNewBook = new Button();
            lblTitle = new Label();
            lblQty = new Label();
            lblAuthor = new Label();
            lblIsbn = new Label();
            lblPrice = new Label();
            lblGenre = new Label();
            txtTitle = new TextBox();
            txtQty = new TextBox();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtIsbn = new TextBox();
            txtGenre = new TextBox();
            btnRemoveRow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataInfo).BeginInit();
            SuspendLayout();
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.FromArgb(255, 128, 255);
            inventoryButton.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            inventoryButton.Location = new Point(55, 21);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(193, 68);
            inventoryButton.TabIndex = 0;
            inventoryButton.Text = "Display Inventory";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += lblInventory_Click;
            // 
            // dataInfo
            // 
            dataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInfo.Columns.AddRange(new DataGridViewColumn[] { Title, Author, Price, Quantity, ISBN, Genre });
            dataInfo.Location = new Point(55, 108);
            dataInfo.Name = "dataInfo";
            dataInfo.Size = new Size(1078, 462);
            dataInfo.TabIndex = 3;
            dataInfo.CellMouseClick += dataInfo_CellMouseClick;
   
            dataInfo.UserDeletingRow += dataInfo_UserDeletingRow;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 3;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Author.HeaderText = "Author";
            Author.Name = "Author";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "C2";
            Price.DefaultCellStyle = dataGridViewCellStyle1;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Quantity
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // ISBN
            // 
            ISBN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ISBN.DefaultCellStyle = dataGridViewCellStyle3;
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            // 
            // Genre
            // 
            Genre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            // 
            // addInventory
            // 
            addInventory.BackColor = Color.FromArgb(255, 128, 255);
            addInventory.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            addInventory.Location = new Point(281, 22);
            addInventory.Name = "addInventory";
            addInventory.Size = new Size(167, 67);
            addInventory.TabIndex = 4;
            addInventory.Text = "Increase inventory by 1";
            addInventory.UseVisualStyleBackColor = false;
            addInventory.Click += addInventory_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(255, 128, 255);
            btnSaveChanges.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            btnSaveChanges.Location = new Point(971, 22);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(162, 68);
            btnSaveChanges.TabIndex = 5;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnDecreaseInventory
            // 
            btnDecreaseInventory.BackColor = Color.FromArgb(255, 128, 255);
            btnDecreaseInventory.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            btnDecreaseInventory.Location = new Point(496, 22);
            btnDecreaseInventory.Name = "btnDecreaseInventory";
            btnDecreaseInventory.Size = new Size(167, 67);
            btnDecreaseInventory.TabIndex = 6;
            btnDecreaseInventory.Text = "Decrease inventory by 1";
            btnDecreaseInventory.UseVisualStyleBackColor = false;
            btnDecreaseInventory.Click += btnDecreaseInventory_Click;
            // 
            // btnNewBook
            // 
            btnNewBook.BackColor = Color.FromArgb(255, 128, 255);
            btnNewBook.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            btnNewBook.Location = new Point(1030, 651);
            btnNewBook.Name = "btnNewBook";
            btnNewBook.Size = new Size(167, 67);
            btnNewBook.TabIndex = 7;
            btnNewBook.Text = "Add New Book";
            btnNewBook.UseVisualStyleBackColor = false;
            btnNewBook.Click += btnNewBook_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.MediumSlateBlue;
            lblTitle.Location = new Point(55, 599);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 22);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Title";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.BackColor = Color.MediumSlateBlue;
            lblQty.Location = new Point(55, 696);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(75, 22);
            lblQty.TabIndex = 10;
            lblQty.Text = "Quantity";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.MediumSlateBlue;
            lblAuthor.Location = new Point(403, 599);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(63, 22);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author";
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.BackColor = Color.MediumSlateBlue;
            lblIsbn.Location = new Point(403, 696);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(45, 22);
            lblIsbn.TabIndex = 12;
            lblIsbn.Text = "ISBN";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.MediumSlateBlue;
            lblPrice.Location = new Point(751, 599);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(48, 22);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Price";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.BackColor = Color.MediumSlateBlue;
            lblGenre.Location = new Point(751, 696);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(57, 22);
            lblGenre.TabIndex = 14;
            lblGenre.Text = "Genre";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(141, 605);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 29);
            txtTitle.TabIndex = 15;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(149, 697);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 29);
            txtQty.TabIndex = 16;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(505, 603);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 29);
            txtAuthor.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(833, 603);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 29);
            txtPrice.TabIndex = 18;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(496, 700);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(100, 29);
            txtIsbn.TabIndex = 19;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(847, 699);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 29);
            txtGenre.TabIndex = 20;
            // 
            // btnRemoveRow
            // 
            btnRemoveRow.BackColor = Color.FromArgb(255, 128, 255);
            btnRemoveRow.Font = new Font("Open Sans", 14F, FontStyle.Bold);
            btnRemoveRow.Location = new Point(718, 21);
            btnRemoveRow.Name = "btnRemoveRow";
            btnRemoveRow.Size = new Size(167, 67);
            btnRemoveRow.TabIndex = 21;
            btnRemoveRow.Text = "Remove a Book from Inventory";
            btnRemoveRow.UseVisualStyleBackColor = false;
            btnRemoveRow.Click += btnRemoveRow_Click;
            // 
            // inventoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(1219, 801);
            Controls.Add(btnRemoveRow);
            Controls.Add(txtGenre);
            Controls.Add(txtIsbn);
            Controls.Add(txtPrice);
            Controls.Add(txtAuthor);
            Controls.Add(txtQty);
            Controls.Add(txtTitle);
            Controls.Add(lblGenre);
            Controls.Add(lblPrice);
            Controls.Add(lblIsbn);
            Controls.Add(lblAuthor);
            Controls.Add(lblQty);
            Controls.Add(lblTitle);
            Controls.Add(btnNewBook);
            Controls.Add(btnDecreaseInventory);
            Controls.Add(btnSaveChanges);
            Controls.Add(addInventory);
            Controls.Add(dataInfo);
            Controls.Add(inventoryButton);
            Font = new Font("Open Sans", 12F);
            Margin = new Padding(4);
            Name = "inventoryForm";
            ShowIcon = false;
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dataInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inventoryButton;
        private DataGridView dataInfo;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Genre;
        private Button addInventory;
        private Button btnSaveChanges;
        private Button btnDecreaseInventory;
        private Button btnNewBook;
        private Label lblTitle;
        private Label lblQty;
        private Label lblAuthor;
        private Label lblIsbn;
        private Label lblPrice;
        private Label lblGenre;
        private TextBox txtTitle;
        private TextBox txtQty;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtIsbn;
        private TextBox txtGenre;
        private Button btnRemoveRow;
    }
}
