
namespace dataBaseProject
{
    partial class FormRecipeBook
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьРецептToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxRecipeFiles = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxRecipe = new System.Windows.Forms.RichTextBox();
            this.pictureBoxRecipePhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxCookingMethod = new System.Windows.Forms.RichTextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonChangePhoto = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(479, 1);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРецептToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(586, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // добавитьРецептToolStripMenuItem
            // 
            this.добавитьРецептToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйToolStripMenuItem});
            this.добавитьРецептToolStripMenuItem.Name = "добавитьРецептToolStripMenuItem";
            this.добавитьРецептToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.добавитьРецептToolStripMenuItem.Text = "Добавить рецепт";
            // 
            // создатьНовыйToolStripMenuItem
            // 
            this.создатьНовыйToolStripMenuItem.Name = "создатьНовыйToolStripMenuItem";
            this.создатьНовыйToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.создатьНовыйToolStripMenuItem.Text = "Создать новый";
            this.создатьНовыйToolStripMenuItem.Click += new System.EventHandler(this.создатьНовыйToolStripMenuItem_Click);
            // 
            // listBoxRecipeFiles
            // 
            this.listBoxRecipeFiles.FormattingEnabled = true;
            this.listBoxRecipeFiles.Location = new System.Drawing.Point(12, 29);
            this.listBoxRecipeFiles.Name = "listBoxRecipeFiles";
            this.listBoxRecipeFiles.Size = new System.Drawing.Size(152, 316);
            this.listBoxRecipeFiles.TabIndex = 3;
            this.listBoxRecipeFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipeFiles_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // richTextBoxRecipe
            // 
            this.richTextBoxRecipe.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxRecipe.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxRecipe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBoxRecipe.Location = new System.Drawing.Point(170, 40);
            this.richTextBoxRecipe.Name = "richTextBoxRecipe";
            this.richTextBoxRecipe.ReadOnly = true;
            this.richTextBoxRecipe.Size = new System.Drawing.Size(275, 130);
            this.richTextBoxRecipe.TabIndex = 4;
            this.richTextBoxRecipe.Text = "";
            // 
            // pictureBoxRecipePhoto
            // 
            this.pictureBoxRecipePhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxRecipePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRecipePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRecipePhoto.Location = new System.Drawing.Point(451, 40);
            this.pictureBoxRecipePhoto.Name = "pictureBoxRecipePhoto";
            this.pictureBoxRecipePhoto.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxRecipePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRecipePhoto.TabIndex = 5;
            this.pictureBoxRecipePhoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Рецепт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Способ приготовления";
            // 
            // richTextBoxCookingMethod
            // 
            this.richTextBoxCookingMethod.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxCookingMethod.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxCookingMethod.Location = new System.Drawing.Point(170, 189);
            this.richTextBoxCookingMethod.Name = "richTextBoxCookingMethod";
            this.richTextBoxCookingMethod.ReadOnly = true;
            this.richTextBoxCookingMethod.Size = new System.Drawing.Size(275, 130);
            this.richTextBoxCookingMethod.TabIndex = 4;
            this.richTextBoxCookingMethod.Text = "";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(170, 322);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(123, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Редактировать ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(322, 322);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(123, 23);
            this.buttonSaveChanges.TabIndex = 9;
            this.buttonSaveChanges.Text = "Сохранить изменения";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Visible = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonChangePhoto
            // 
            this.buttonChangePhoto.Location = new System.Drawing.Point(451, 168);
            this.buttonChangePhoto.Name = "buttonChangePhoto";
            this.buttonChangePhoto.Size = new System.Drawing.Size(127, 23);
            this.buttonChangePhoto.TabIndex = 10;
            this.buttonChangePhoto.Text = "Изменить фото";
            this.buttonChangePhoto.UseVisualStyleBackColor = true;
            this.buttonChangePhoto.Visible = false;
            this.buttonChangePhoto.Click += new System.EventHandler(this.buttonChangePhoto_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(451, 322);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(127, 22);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "Удалить рецепт";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // FormRecipeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 351);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonChangePhoto);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxRecipePhoto);
            this.Controls.Add(this.richTextBoxCookingMethod);
            this.Controls.Add(this.richTextBoxRecipe);
            this.Controls.Add(this.listBoxRecipeFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormRecipeBook";
            this.Text = "RecipeBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRecipeBook_FormClosing);
            this.Load += new System.EventHandler(this.FormRecipeBook_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьРецептToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxRecipeFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxRecipe;
        private System.Windows.Forms.PictureBox pictureBoxRecipePhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxCookingMethod;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonChangePhoto;
        private System.Windows.Forms.Button buttonRemove;
    }
}

