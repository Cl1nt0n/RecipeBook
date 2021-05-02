
namespace dataBaseProject
{
    partial class FormAdd
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
            this.textBoxRecipeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRecipe = new System.Windows.Forms.TextBox();
            this.pictureBoxRecipePic = new System.Windows.Forms.PictureBox();
            this.buttonLoadPhoto = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCookingMethod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipePic)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRecipeName
            // 
            this.textBoxRecipeName.Location = new System.Drawing.Point(72, 6);
            this.textBoxRecipeName.Name = "textBoxRecipeName";
            this.textBoxRecipeName.Size = new System.Drawing.Size(188, 20);
            this.textBoxRecipeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Нзвание:";
            // 
            // textBoxRecipe
            // 
            this.textBoxRecipe.Location = new System.Drawing.Point(12, 54);
            this.textBoxRecipe.Multiline = true;
            this.textBoxRecipe.Name = "textBoxRecipe";
            this.textBoxRecipe.Size = new System.Drawing.Size(248, 106);
            this.textBoxRecipe.TabIndex = 2;
            // 
            // pictureBoxRecipePic
            // 
            this.pictureBoxRecipePic.BackColor = System.Drawing.Color.White;
            this.pictureBoxRecipePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRecipePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRecipePic.InitialImage = null;
            this.pictureBoxRecipePic.Location = new System.Drawing.Point(266, 24);
            this.pictureBoxRecipePic.Name = "pictureBoxRecipePic";
            this.pictureBoxRecipePic.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxRecipePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRecipePic.TabIndex = 3;
            this.pictureBoxRecipePic.TabStop = false;
            // 
            // buttonLoadPhoto
            // 
            this.buttonLoadPhoto.Location = new System.Drawing.Point(266, 158);
            this.buttonLoadPhoto.Name = "buttonLoadPhoto";
            this.buttonLoadPhoto.Size = new System.Drawing.Size(128, 23);
            this.buttonLoadPhoto.TabIndex = 4;
            this.buttonLoadPhoto.Text = "Загрузить фото";
            this.buttonLoadPhoto.UseVisualStyleBackColor = true;
            this.buttonLoadPhoto.Click += new System.EventHandler(this.buttonLoadPhoto_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 291);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(138, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить рецепт";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Рецепт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Способ приготовления";
            // 
            // textBoxCookingMethod
            // 
            this.textBoxCookingMethod.Location = new System.Drawing.Point(12, 179);
            this.textBoxCookingMethod.Multiline = true;
            this.textBoxCookingMethod.Name = "textBoxCookingMethod";
            this.textBoxCookingMethod.Size = new System.Drawing.Size(248, 106);
            this.textBoxCookingMethod.TabIndex = 2;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoadPhoto);
            this.Controls.Add(this.pictureBoxRecipePic);
            this.Controls.Add(this.textBoxCookingMethod);
            this.Controls.Add(this.textBoxRecipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRecipeName);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRecipeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRecipe;
        private System.Windows.Forms.PictureBox pictureBoxRecipePic;
        private System.Windows.Forms.Button buttonLoadPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCookingMethod;
    }
}