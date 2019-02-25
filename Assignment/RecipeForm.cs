using System;
using System.Windows.Forms;

namespace Assignment {
    public partial class RecipeForm : Form {

        public Recipe.Recipe Recipe;





        public RecipeForm() {
            InitializeComponent();
            Recipe = new Recipe.Recipe();
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e) {

        }

        private void addButton_Click(object sender, EventArgs e) {
            if (ingredientTextbox.Text.Length > 0) {
                ingredientsListbox.Items.Add(ingredientTextbox.Text);
                ingredientTextbox.Clear();
            }
        }

        private void changeButton_Click(object sender, EventArgs e) {
            if (ingredientsListbox.SelectedIndex >= 0)
                ingredientsListbox.Items[ingredientsListbox.SelectedIndex] = ingredientTextbox.Text;
            ingredientTextbox.Clear();
        }

        private void ingredientsListbox_SelectedIndexChanged(object sender, EventArgs e) {
            if (ingredientsListbox.SelectedIndex >= 0)
                ingredientTextbox.Text = ingredientsListbox.Text;
            else
                ingredientTextbox.Text = "";
        }

        private void ingredientsListbox_SelectedValueChanged(object sender, EventArgs e) {

        }

        private void okButton_Click(object sender, EventArgs e) {
            if (nameTextbox.Text.Length > 0 && ingredientsListbox.Items.Count > 0) {
                DialogResult = DialogResult.OK;
                Recipe = new Recipe.Recipe {
                    Name = nameTextbox.Text
                };

                foreach (string ingredient in ingredientsListbox.Items)
                    Recipe.Ingredients.Add(ingredient);
            }
            else
                DialogResult = DialogResult.Cancel;

            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if( ingredientsListbox.SelectedIndex >= 0 )
            ingredientsListbox.Items.RemoveAt(ingredientsListbox.SelectedIndex);
        }
    }
}
