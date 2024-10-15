using System.Windows.Forms;
using Viv_Admin_GruppProjekt.Models;
using Viv_Admin_GruppProjekt.Services;

namespace Viv_Admin_GruppProjekt
{
    public partial class AdminMainForm : Form
    {
        ReceptService receptService = new ReceptService();
        public AdminMainForm()
        {
            InitializeComponent();
            receptService.OpenReceptsAndWriteToList();

            // Add predefined types to the ComboBox
            comboBoxTypeOfReceipt.Items.Add("Kött");
            comboBoxTypeOfReceipt.Items.Add("Fisk");
            comboBoxTypeOfReceipt.Items.Add("Sallader");
            comboBoxTypeOfReceipt.Items.Add("Soppor");
            comboBoxTypeOfReceipt.Items.Add("Desserter/Kakor");

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxReceiptName.Text))
            {
                MessageBox.Show("Please enter a Receipt Name.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(comboBoxTypeOfReceipt.Text))
            {
                MessageBox.Show("Please enter a Receipt Type.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBoxDescriptionOfReceipt.Text))
            {
                MessageBox.Show("Please enter a Description of the Receipt.");
                return;

            }
            else
            {
                Recept newRecept = new Recept();
                newRecept.Name = textBoxReceiptName.Text;
                newRecept.TypeOfRecept = comboBoxTypeOfReceipt.Text;
                newRecept.Description = textBoxDescriptionOfReceipt.Text;

                receptService.CreateRecept(newRecept);
                MessageBox.Show("Your new receipt has been saved!");

                textBoxReceiptName.Clear();
                textBoxDescriptionOfReceipt.Clear();
            }
        }

        private void buttonSearchReceipts_Click(object sender, EventArgs e)
        {
            {
                // Get the search term from the textbox
                string searchTerm = textBoxUserSearch.Text.Trim();

                // Get the search options from the checkboxes
                bool searchByName = checkBoxReceiptName.Checked;
                bool searchByType = checkBoxReceiptType.Checked;

                // Call the search function in the service class
                var searchResults = receptService.SearchRecepts(searchTerm, searchByName, searchByType);

                // Display the search results in the list box
                listBoxSearchResults.Items.Clear();
                if (searchResults.Count > 0)
                {
                    var orderedSearchRecepts = searchResults
                                 .OrderBy(recept => recept.TypeOfRecept)
                                 .ThenBy(recept => recept.Name); // Correct use of ThenBy
                    foreach (var recept in orderedSearchRecepts)

                    {
                        listBoxSearchResults.Items.Add($"{recept.Name}, {recept.TypeOfRecept}");
                    }
                }
                else
                {
                    MessageBox.Show("No results found.");
                }
            }
        }

        private void listBoxSearchResults_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxSearchResults.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            string selectedReceipt = listBoxSearchResults.SelectedItem.ToString();

            DialogResult userChoice = MessageBox.Show($"You selected: {selectedReceipt}\n" +
                $" Would you like to edit or delete these details?", "Please Confirm", MessageBoxButtons.YesNo);

            if (userChoice == DialogResult.Yes)
            {
                Recept receptToEdit = receptService.FromStringToObject(selectedReceipt);

                if (receptToEdit == null)
                {
                    MessageBox.Show("Recept not found. Please try again.");
                    return;
                }

                // Pass the shared ReceptService and reference to AdminMainForm to the UpdateDeleteForm
                UpdateDeleteForm updateDeleteForm = new UpdateDeleteForm(receptToEdit, receptService, this);
                updateDeleteForm.Show();
                this.Hide();
                listBoxSearchResults.Items.Clear();
            }
        }


        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            var allReceptsKnown = receptService.GetRecepts();
            var orderedRecepts = allReceptsKnown
                                 .OrderBy(recept => recept.TypeOfRecept)
                                 .ThenBy(recept => recept.Name); // Correct use of ThenBy

            listBoxSearchResults.Items.Clear(); // Clear existing items to avoid duplication
            foreach (var recept in orderedRecepts)
            {
                listBoxSearchResults.Items.Add($"{recept.Name},{recept.TypeOfRecept}");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
