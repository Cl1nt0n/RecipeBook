using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBaseProject
{
    public partial class FormAdd : Form
    {
        public FormAdd(ref Dictionary<string, string> recipes, ref Dictionary<string, string> recipeImage, ref Dictionary<string, string> cookingMethods)
        {
            InitializeComponent();

            _recipes = recipes;
            _cookingMethods = cookingMethods;
            _recipeImages = recipeImage;
        }

        Dictionary<string, string> _recipes;
        Dictionary<string, string> _cookingMethods;
        Dictionary<string, string> _recipeImages;

        string imageFile;

        private void FormAdd_Load(object sender, EventArgs e)
        {
            openFileDialogPhoto.InitialDirectory = @"D:\clessons\dataBaseProject";
            openFileDialogPhoto.Filter = "(*.jpeg)|*.png|All files (*.*)|*.*";
        }

        private void buttonLoadPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxRecipePic.Image = (Bitmap)Image.FromFile(openFileDialogPhoto.FileName);
                imageFile = openFileDialogPhoto.FileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _recipes.Add(textBoxRecipeName.Text, textBoxRecipe.Text);
            _cookingMethods.Add(textBoxRecipeName.Text, textBoxCookingMethod.Text);
            _recipeImages.Add(textBoxRecipeName.Text, imageFile);

            this.Close();
        }
    }
}
