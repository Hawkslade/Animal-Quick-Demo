using AnimalClassification;
using System;
using System.Windows.Forms;

namespace QuickDemo
{
    public partial class FormMain : Form
    {
        AnimalCollection fullCollection;
        AnimalCollection filteredCollection;

        private bool filterTail = true;
        private bool hasTail = false;

        public FormMain()
        {
            InitializeComponent();

            fullCollection = new AnimalCollection();
            fullCollection.Add(new Animal("Baboon", AnimalCategory.Primate, true));
            fullCollection.Add(new Animal("Chimpanzee", AnimalCategory.Primate, true));
            fullCollection.Add(new Animal("Crocodile", AnimalCategory.Reptile, true));
            fullCollection.Add(new Animal("Hippopotamus", AnimalCategory.Mammal, true));
            fullCollection.Add(new Animal("Snake", AnimalCategory.Reptile, false));
            fullCollection.Add(new Animal("Lion", AnimalCategory.Mammal, true));
            fullCollection.Add(new Animal("Zebra", AnimalCategory.Mammal, true));
            fullCollection.Add(new Animal("Cheetah", AnimalCategory.Mammal, true));
            fullCollection.Add(new Animal("Gorilla", AnimalCategory.Primate, false));
            fullCollection.Add(new Animal("Giraffe", AnimalCategory.Mammal, true));
            fullCollection.Add(new Animal("Lizard", AnimalCategory.Reptile, true));
            SetFilteredCollection(fullCollection);

            cbCategory.Items.Add(AnimalCategory.Mammal);
            cbCategory.Items.Add(AnimalCategory.Primate);
            cbCategory.Items.Add(AnimalCategory.Reptile);
            cbCategory.SelectedIndex = 0;
        }

        private void SetFilteredCollection(AnimalCollection animalCollection)
        {
            filteredCollection = animalCollection;
            lvAnimals.Items.Clear();
            foreach (Animal animal in filteredCollection)
            {
                ListViewItem item = new ListViewItem(animal.Name);
                item.SubItems.Add(animal.Category.ToString());
                item.SubItems.Add(animal.HasTail ? "Tail" : "No tail");
                lvAnimals.Items.Add(item);
            }
        }

        private void chkFilterTail_CheckedChanged(object sender, EventArgs e)
        {
            filterTail = chkHasTail.Enabled = chkFilterTail.Checked;
        }

        private void chkHasTail_CheckedChanged(object sender, EventArgs e)
        {
            hasTail = chkHasTail.Checked;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // TODO: Consider doing this on one line using ? : operator.
            if (filterTail)
            {
                SetFilteredCollection(fullCollection.Categorise((AnimalCategory)cbCategory.SelectedItem, hasTail));
            }
            else
            {
                SetFilteredCollection(fullCollection.Categorise((AnimalCategory)cbCategory.SelectedItem));
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            SetFilteredCollection(fullCollection);
        }
    }
}
