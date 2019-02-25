using System;
using System.Windows.Forms;

namespace Assignment {
    public partial class StaffForm : Form {

        public Staff.Staff Staff;





        public StaffForm() {
            InitializeComponent();
            Staff = new Staff.Staff();
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e) {

        }

        private void addButton_Click(object sender, EventArgs e) {
            qualificationsListbox.Items.Add(qualificationTextbox.Text);
            qualificationTextbox.Clear();
        }

        private void changeButton_Click(object sender, EventArgs e) {
            if (qualificationsListbox.SelectedIndex >= 0)
                qualificationsListbox.Items[qualificationsListbox.SelectedIndex] = qualificationTextbox.Text;
            qualificationTextbox.Clear();
        }

        private void ingredientsListbox_SelectedIndexChanged(object sender, EventArgs e) {
            if (qualificationsListbox.SelectedIndex >= 0)
                qualificationTextbox.Text = qualificationsListbox.Text;
            else
                qualificationTextbox.Text = "";
        }

        private void ingredientsListbox_SelectedValueChanged(object sender, EventArgs e) {

        }

        private void okButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Staff = new Staff.Staff {
                Name = nameTextbox.Text
            };

            foreach (string ingredient in qualificationsListbox.Items)
                Staff.Qualifications.Add(ingredient);

            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if( qualificationsListbox.SelectedIndex >= 0 )
            qualificationsListbox.Items.RemoveAt(qualificationsListbox.SelectedIndex);
        }
    }
}
