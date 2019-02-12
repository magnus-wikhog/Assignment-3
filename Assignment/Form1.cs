using Assignment.Animals;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{




    public partial class Form1 : Form{
        private AnimalManager mAnimalManager;
        private Dictionary<string, CategoryConfiguration> mCategoriesConfigurations;
        private Dictionary<string, SpeciesConfiguration> mSpeciesConfigurations;


        public Form1(){
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
            Animal animal;
            switch (speciesListbox.Text) {
                case "Cat": animal = new Cat((int)mammalTeethCountUpDown.Value, (double)catClawLengthUpDown.Value); break;
                case "Dog": animal = new Dog((int)mammalTeethCountUpDown.Value, (double)dogTailLengthUpDown.Value); break;
                case "Swan": animal = new Swan((double)birdWingSpanUpDown.Value, swanColorTextbox.Text); break;
                case "Crow": animal = new Crow((double)birdWingSpanUpDown.Value, (double)crowWeightUpDown.Value); break;
                default: return; // Don't add anything if it's an unknown species name
            }

            // Set common animal properties
            animal.name = animalNameTextbox.Text;
            animal.age = (int)animalAgeUpDown.Value;
            animal.gender = animalGenderCombo.Text;

            // Add the animal to the list and get a generated ID in return
            string id = mAnimalManager.AddAnimal(animal);
            animalsListView.Items.Add(new ListViewItem( new string[]{ id, animal.GetType().Name, animal.name, animal.age.ToString(), animal.gender, animal.GetSpecialCharacteristics() } ));
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
