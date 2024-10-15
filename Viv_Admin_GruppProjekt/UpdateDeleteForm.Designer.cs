namespace Viv_Admin_GruppProjekt
{
    partial class UpdateDeleteForm
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
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonBack = new Button();
            labelNameOfReceipt = new Label();
            labelTypeOfReceipt = new Label();
            labelDescriptionOfReceipt = new Label();
            textBoxType = new TextBox();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(555, 101);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(138, 59);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save Changes";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(555, 186);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(138, 67);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete Recept";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(555, 279);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(138, 65);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back to Main";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelNameOfReceipt
            // 
            labelNameOfReceipt.AutoSize = true;
            labelNameOfReceipt.Location = new Point(105, 43);
            labelNameOfReceipt.Name = "labelNameOfReceipt";
            labelNameOfReceipt.Size = new Size(143, 25);
            labelNameOfReceipt.TabIndex = 3;
            labelNameOfReceipt.Text = "Name of Receipt";
            // 
            // labelTypeOfReceipt
            // 
            labelTypeOfReceipt.AutoSize = true;
            labelTypeOfReceipt.Location = new Point(105, 135);
            labelTypeOfReceipt.Name = "labelTypeOfReceipt";
            labelTypeOfReceipt.Size = new Size(133, 25);
            labelTypeOfReceipt.TabIndex = 4;
            labelTypeOfReceipt.Text = "Type of Receipt";
            // 
            // labelDescriptionOfReceipt
            // 
            labelDescriptionOfReceipt.AutoSize = true;
            labelDescriptionOfReceipt.Location = new Point(105, 220);
            labelDescriptionOfReceipt.Name = "labelDescriptionOfReceipt";
            labelDescriptionOfReceipt.Size = new Size(186, 25);
            labelDescriptionOfReceipt.TabIndex = 5;
            labelDescriptionOfReceipt.Text = "Description of Receipt";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(105, 172);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(303, 31);
            textBoxType.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(105, 83);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(303, 31);
            textBoxName.TabIndex = 8;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(110, 266);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(300, 145);
            textBoxDescription.TabIndex = 9;
            // 
            // UpdateDeleteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(textBoxType);
            Controls.Add(labelDescriptionOfReceipt);
            Controls.Add(labelTypeOfReceipt);
            Controls.Add(labelNameOfReceipt);
            Controls.Add(buttonBack);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Name = "UpdateDeleteForm";
            Text = "UpdateDeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonDelete;
        private Button buttonBack;
        private Label labelNameOfReceipt;
        private Label labelTypeOfReceipt;
        private Label labelDescriptionOfReceipt;
        private TextBox textBoxType;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
    }
}