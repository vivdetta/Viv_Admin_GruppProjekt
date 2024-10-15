using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viv_Admin_GruppProjekt.Models;
using Viv_Admin_GruppProjekt.Services;

namespace Viv_Admin_GruppProjekt
{
    public partial class UpdateDeleteForm : Form
    {
        ReceptService receptService;
        Recept originalRecept;
        AdminMainForm adminMainForm;

        public UpdateDeleteForm(Recept sentRecept, ReceptService sharedReceptService, AdminMainForm mainForm)
        {
            InitializeComponent();
            receptService = sharedReceptService;  // Use the shared ReceptService
            adminMainForm = mainForm; // Reference to main form
            originalRecept = sentRecept;


            textBoxName.Text = sentRecept.Name;
            textBoxType.Text = sentRecept.TypeOfRecept;
            textBoxDescription.Text = sentRecept.Description;
        }


    private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Please enter a Receipt Name.");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxType.Text))
            {
                MessageBox.Show("Please enter a Receipt Type.");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxDescription.Text))
            {
                MessageBox.Show("Please enter a Receipt Description.");
                return;
            }
            else
            {
                Recept updatedRecept = new Recept
                {
                    Name = textBoxName.Text,
                    TypeOfRecept = textBoxType.Text,
                    Description = textBoxDescription.Text,

                };
                receptService.UpdateRecept(originalRecept, updatedRecept);
                MessageBox.Show("Your Receipt has been updated");
                adminMainForm.Show();
                this.Hide();

            }


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            receptService.DeleteRecept(originalRecept);
            MessageBox.Show("Your Receipt has been deleted");
            adminMainForm.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            adminMainForm.Show();
            this.Hide();
        }
    }
}
