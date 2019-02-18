using Assignment.Animals;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{




    public partial class MainForm : Form{
        private AnimalManager mAnimalManager;
        private Dictionary<string, CategoryConfiguration> mCategoriesConfigurations;
        private Dictionary<string, SpeciesConfiguration> mSpeciesConfigurations;


        public MainForm(){
            InitializeComponent();

            // Our animal manager
            mAnimalManager = new AnimalManager();



            // Configrure categories
            mCategoriesConfigurations = new Dictionary<string, CategoryConfiguration> {
                { "Mammal", new CategoryConfiguration("Mammal", mammalInput) },
                { "Bird",   new CategoryConfiguration("Bird",   birdInput) }
            };

            // COnfigure species
            mSpeciesConfigurations = new Dictionary<string, SpeciesConfiguration> {
                { "Cat",   new SpeciesConfiguration("Cat",  catInput, mCategoriesConfigurations["Mammal"] ) },
                { "Dog",   new SpeciesConfiguration("Dog",  dogInput, mCategoriesConfigurations["Mammal"] ) },
                { "Swan",  new SpeciesConfiguration("Swan", swanInput, mCategoriesConfigurations["Bird"]   ) },
                { "Crow",  new SpeciesConfiguration("Crow", crowInput, mCategoriesConfigurations["Bird"]   ) }
            };

            foreach(string category in mCategoriesConfigurations.Keys){
                categoryListbox.Items.Add(category);
            }
            categoryListbox.SelectedIndex = 0;
            animalGenderListView.SelectedIndex = 0;
        }




        /*
         * Updates the UI in response to a selected category
         */
        void OnCategorySelected(string category) {
            speciesListbox.Items.Clear();

            // category can be null if showAllCategoriesCheckbox is checked
            foreach (SpeciesConfiguration species in mSpeciesConfigurations.Values) {
                if (null == category || species.categoryConfiguration.name.Equals(category))
                    speciesListbox.Items.Add(species.name);
            }

            if( speciesListbox.Items.Count > 0)
                speciesListbox.SelectedIndex = 0;
        }



        /*
         * Event handler for the category list
         */
        private void categoryListbox_SelectedIndexChanged(object sender, EventArgs e) {
            OnCategorySelected(categoryListbox.SelectedItem.ToString());
        }

        /*
         * Updates the UI when the user checks/unchecks "Show all species"
         */
        private void showAllCategoriesCheckbox_CheckedChanged(object sender, EventArgs e) {
            categoryListbox.Enabled = !showAllCategoriesCheckbox.Checked;

            // Change category to <null> so the species listbox displays all species
            OnCategorySelected(showAllCategoriesCheckbox.Checked ? null : categoryListbox.Text);
        }

        /*
         * Updates the UI when the user selects a species
         */
        private void speciesListbox_SelectedIndexChanged(object sender, EventArgs e) {
            // Activate correct panel for the selected species
            // Category panel must also be actived from here, because we could be showing animals from
            // all categories in the listview.
            SpeciesConfiguration speciesConfiguration = mSpeciesConfigurations[speciesListbox.Text];
            speciesConfiguration.inputPanel.BringToFront();
            speciesConfiguration.categoryConfiguration.inputPanel.BringToFront();
        }



        /*
         * Adds an animal with the current specification to the list.
         */
        private void addAnimalButton_Click(object sender, EventArgs e) {
            // Determine which type of animal to create, and use the correct UI elements to set it's properties
            Animal animal = mAnimalManager.CreateAnimal(
                speciesListbox.Text,
                new Dictionary<String, Object>(){
                    { "mammalTeethCount",       (int)mammalTeethCountUpDown.Value },
                    { "catClawLength",          (double)catClawLengthUpDown.Value },
                    { "dogTailLength",          (double)dogTailLengthUpDown.Value },
                    { "birdWingSpan",           (double)birdWingSpanUpDown.Value },
                    { "swanColor",              swanColorTextbox.Text },
                    { "crowWeight",             (double)crowWeightUpDown.Value },
                }
            );

            // Set common animal properties
            animal.Name = animalNameTextbox.Text;
            animal.age = (int)animalAgeUpDown.Value;
            animal.Gender = animalGenderListView.SelectedItem.ToString();

            mAnimalManager.Add(animal);

            // Add the animal to the list
            animalsListView.Items.Add(new ListViewItem( new string[]{ animal.ID, animal.GetSpecies(), animal.Name, animal.age.ToString(), animal.Gender, animal.GetSpecialCharacteristics() } ));
        }


        /*
         * Reloads all animals from the AnimalManager and displays them in the list.
         */
        private void DisplayAnimals() {
            animalsListView.Items.Clear();
            for (int i = 0; i < mAnimalManager.Count; i++) {
                Animal animal = mAnimalManager.GetAt(i);
                animalsListView.Items.Add(new ListViewItem(new string[] { animal.ID, animal.GetSpecies(), animal.Name, animal.age.ToString(), animal.Gender, animal.GetSpecialCharacteristics() }));
            }
        }


        /*
         * Updates the eating type and feeding schedule when the user selects an animal in the list.
         */
        private void animalsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            Animal animal = mAnimalManager.GetAt(e.Item.Index);
            if( null != animal) {
                eaterTypeTextBox.Text = animal.GetEaterType().ToString();
                feedingScheduleTextBox.Text = animal.GetFoodSchedule().ToString();
            }
        }


        /*
         * Sorts the animals using different algorithems based on which column is clicked.
         */
        private void animalsListView_ColumnClick(object sender, ColumnClickEventArgs e) {
            IComparer<Animal> comparer = null;

            if (animalsListView.Columns[e.Column].Text.Equals("ID"))
                comparer = new IdComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Name"))
                comparer = new NameComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Species"))
                comparer = new SpeciesComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Age"))
                comparer = new AgeComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Gender"))
                comparer = new GenderComparer();

            if (animalsListView.Columns[e.Column].Text.Equals("Special characteristics"))
                comparer = new SpecialCharacteristicsComparer();

            if (null != comparer) {
                mAnimalManager.Sort(comparer);
                DisplayAnimals();
            }
        }
    }






    /* 
     * Class that represents a configuration for a category (for example which 
     * input panel to display).
     */
    class CategoryConfiguration {
        public string name;
        public Panel inputPanel;

        public CategoryConfiguration(string name, Panel inputPanel) {
            this.name = name;
            this.inputPanel = inputPanel;
        }
    }


    /* 
     * Class that represents a configuration for a species (for example which 
     * input panel to display).
     */
    class SpeciesConfiguration {
        public string name;
        public Panel inputPanel;
        public CategoryConfiguration categoryConfiguration;

        public SpeciesConfiguration(string name, Panel inputPanel, CategoryConfiguration categoryConfiguration) {
            this.name = name;
            this.inputPanel = inputPanel;

            // Determines which category configuration to use for this species
            this.categoryConfiguration = categoryConfiguration;
        }
    }


}
