using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBaseProject
{
    public partial class FormRecipeBook : Form
    {
        public FormRecipeBook()
        {
            InitializeComponent();
        }

        Dictionary<string, string> recipes = new Dictionary<string, string>();
        Dictionary<string, string> cookingMethods = new Dictionary<string, string>();
        Dictionary<string, string> recipeImages = new Dictionary<string, string>();

        string imageFile;

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxRecipeFiles.Items.Clear();
            foreach (var item in recipes)
            {
                if (item.Key.Contains(textBoxSearch.Text))
                {
                    listBoxRecipeFiles.Items.Add(item.Key);
                }
            }
        }

        private void FormRecipeBook_Load(object sender, EventArgs e)
        {
            StreamReader recipesNameStream = new StreamReader(@"D:\clessons\dataBaseProject\recipe.txt");
            string stringRecipeName = recipesNameStream.ReadToEnd();
            recipesNameStream.Close();

            string[] recipeArray = stringRecipeName.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < recipeArray.Length; i++)
            {
                string[] wholeRecipe = new string[4];
                wholeRecipe = recipeArray[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                recipes.Add(wholeRecipe[0], wholeRecipe[1]);
                cookingMethods.Add(wholeRecipe[0], wholeRecipe[2]);
                recipeImages.Add(wholeRecipe[0], wholeRecipe[3]);
            }
            foreach (var item in recipes)
            {
                listBoxRecipeFiles.Items.Add(item.Key);
            }

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
        }

        private void listBoxRecipeFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecipeFiles.SelectedItem != null)
            {
                richTextBoxRecipe.Text = recipes[listBoxRecipeFiles.SelectedItem.ToString()];
                richTextBoxCookingMethod.Text = cookingMethods[listBoxRecipeFiles.SelectedItem.ToString()];
                pictureBoxRecipePhoto.Image = Image.FromFile(recipeImages[listBoxRecipeFiles.SelectedItem.ToString()]);
            }
        }

        private void создатьНовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd newForm = new FormAdd(ref recipes, ref recipeImages, ref cookingMethods);
            newForm.ShowDialog();
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBoxRecipeFiles.Items.Clear();
            foreach (var item in recipes)
            {
                listBoxRecipeFiles.Items.Add(item.Key);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            richTextBoxCookingMethod.ReadOnly = false;
            richTextBoxRecipe.ReadOnly = false;
            buttonChangePhoto.Visible = true;
            buttonSaveChanges.Visible = true;

            imageFile = recipeImages[listBoxRecipeFiles.SelectedItem.ToString()];
        }

        private void buttonChangePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxRecipePhoto.Image = (Bitmap)Image.FromFile(openFileDialog.FileName);
                imageFile = openFileDialog.FileName;
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            richTextBoxCookingMethod.ReadOnly = true;
            richTextBoxRecipe.ReadOnly = true;
            buttonChangePhoto.Visible = false;
            buttonSaveChanges.Visible = false;

            recipes[listBoxRecipeFiles.SelectedItem.ToString()] = richTextBoxRecipe.Text;
            cookingMethods[listBoxRecipeFiles.SelectedItem.ToString()] = richTextBoxCookingMethod.Text;
            recipeImages[listBoxRecipeFiles.SelectedItem.ToString()] = imageFile;
        }

        private void FormRecipeBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter recipeStream = new StreamWriter(@"D:\clessons\dataBaseProject\recipe.txt");
            foreach (var recipeName in recipes)
            {
                recipeStream.Write($"{recipeName.Key}|{recipeName.Value}|{cookingMethods[recipeName.Key]}|{recipeImages[recipeName.Key]}@");
            }
            recipeStream.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            recipes.Remove(listBoxRecipeFiles.SelectedItem.ToString());
            cookingMethods.Remove(listBoxRecipeFiles.SelectedItem.ToString());
            recipeImages.Remove(listBoxRecipeFiles.SelectedItem.ToString());
            listBoxRecipeFiles.Items.Remove(listBoxRecipeFiles.SelectedItem);

            richTextBoxCookingMethod.Text = string.Empty;
            richTextBoxRecipe.Text = string.Empty;
            pictureBoxRecipePhoto.Image = null;
        }
    }
}
