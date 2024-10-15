namespace Viv_Admin_GruppProjekt
{
    partial class AdminMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelReceiptName = new Label();
            labelTypeOfReceipt = new Label();
            labelDiscription = new Label();
            labelSearchInstructions = new Label();
            textBoxDescriptionOfReceipt = new TextBox();
            listBoxSearchResults = new ListBox();
            checkBoxReceiptName = new CheckBox();
            checkBoxReceiptType = new CheckBox();
            buttonSearchReceipts = new Button();
            textBoxUserSearch = new TextBox();
            buttonSave = new Button();
            textBoxReceiptName = new TextBox();
            comboBoxTypeOfReceipt = new ComboBox();
            labelInstruction = new Label();
            buttonClearSearch = new Button();
            buttonShowAll = new Button();
            labelNameSearches = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelReceiptName
            // 
            labelReceiptName.AutoSize = true;
            labelReceiptName.Location = new Point(103, 96);
            labelReceiptName.Name = "labelReceiptName";
            labelReceiptName.Size = new Size(143, 25);
            labelReceiptName.TabIndex = 0;
            labelReceiptName.Text = "Name of Receipt";
            // 
            // labelTypeOfReceipt
            // 
            labelTypeOfReceipt.AutoSize = true;
            labelTypeOfReceipt.Location = new Point(103, 174);
            labelTypeOfReceipt.Name = "labelTypeOfReceipt";
            labelTypeOfReceipt.Size = new Size(133, 25);
            labelTypeOfReceipt.TabIndex = 1;
            labelTypeOfReceipt.Text = "Type of Receipt";
            // 
            // labelDiscription
            // 
            labelDiscription.AutoSize = true;
            labelDiscription.Location = new Point(103, 311);
            labelDiscription.Name = "labelDiscription";
            labelDiscription.Size = new Size(186, 25);
            labelDiscription.TabIndex = 2;
            labelDiscription.Text = "Description of Receipt";
            // 
            // labelSearchInstructions
            // 
            labelSearchInstructions.AutoSize = true;
            labelSearchInstructions.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearchInstructions.Location = new Point(533, 18);
            labelSearchInstructions.Name = "labelSearchInstructions";
            labelSearchInstructions.Size = new Size(494, 76);
            labelSearchInstructions.TabIndex = 3;
            labelSearchInstructions.Text = "Please search the database of Receipts\r\n in order to delete of change them";
            // 
            // textBoxDescriptionOfReceipt
            // 
            textBoxDescriptionOfReceipt.Location = new Point(105, 356);
            textBoxDescriptionOfReceipt.Multiline = true;
            textBoxDescriptionOfReceipt.Name = "textBoxDescriptionOfReceipt";
            textBoxDescriptionOfReceipt.Size = new Size(274, 173);
            textBoxDescriptionOfReceipt.TabIndex = 4;
            // 
            // listBoxSearchResults
            // 
            listBoxSearchResults.FormattingEnabled = true;
            listBoxSearchResults.ItemHeight = 25;
            listBoxSearchResults.Location = new Point(577, 275);
            listBoxSearchResults.Name = "listBoxSearchResults";
            listBoxSearchResults.Size = new Size(342, 254);
            listBoxSearchResults.TabIndex = 5;
            listBoxSearchResults.DoubleClick += listBoxSearchResults_DoubleClick;
            // 
            // checkBoxReceiptName
            // 
            checkBoxReceiptName.AutoSize = true;
            checkBoxReceiptName.Location = new Point(577, 176);
            checkBoxReceiptName.Name = "checkBoxReceiptName";
            checkBoxReceiptName.Size = new Size(147, 29);
            checkBoxReceiptName.TabIndex = 6;
            checkBoxReceiptName.Text = "Receipt Name";
            checkBoxReceiptName.UseVisualStyleBackColor = true;
            // 
            // checkBoxReceiptType
            // 
            checkBoxReceiptType.AutoSize = true;
            checkBoxReceiptType.Location = new Point(749, 176);
            checkBoxReceiptType.Name = "checkBoxReceiptType";
            checkBoxReceiptType.Size = new Size(137, 29);
            checkBoxReceiptType.TabIndex = 7;
            checkBoxReceiptType.Text = "Receipt Type";
            checkBoxReceiptType.UseVisualStyleBackColor = true;
            // 
            // buttonSearchReceipts
            // 
            buttonSearchReceipts.Location = new Point(817, 122);
            buttonSearchReceipts.Name = "buttonSearchReceipts";
            buttonSearchReceipts.Size = new Size(147, 34);
            buttonSearchReceipts.TabIndex = 8;
            buttonSearchReceipts.Text = "Search Receipts";
            buttonSearchReceipts.UseVisualStyleBackColor = true;
            buttonSearchReceipts.Click += buttonSearchReceipts_Click;
            // 
            // textBoxUserSearch
            // 
            textBoxUserSearch.Location = new Point(561, 125);
            textBoxUserSearch.Name = "textBoxUserSearch";
            textBoxUserSearch.Size = new Size(250, 31);
            textBoxUserSearch.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(195, 540);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(182, 34);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save new Receipt";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxReceiptName
            // 
            textBoxReceiptName.Location = new Point(105, 128);
            textBoxReceiptName.Name = "textBoxReceiptName";
            textBoxReceiptName.Size = new Size(272, 31);
            textBoxReceiptName.TabIndex = 11;
            // 
            // comboBoxTypeOfReceipt
            // 
            comboBoxTypeOfReceipt.FormattingEnabled = true;
            comboBoxTypeOfReceipt.Location = new Point(111, 211);
            comboBoxTypeOfReceipt.Name = "comboBoxTypeOfReceipt";
            comboBoxTypeOfReceipt.Size = new Size(273, 33);
            comboBoxTypeOfReceipt.TabIndex = 12;
            // 
            // labelInstruction
            // 
            labelInstruction.AutoSize = true;
            labelInstruction.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInstruction.Location = new Point(28, 32);
            labelInstruction.Name = "labelInstruction";
            labelInstruction.Size = new Size(423, 38);
            labelInstruction.TabIndex = 13;
            labelInstruction.Text = "Please Enter New Receipt Details";
            // 
            // buttonClearSearch
            // 
            buttonClearSearch.Location = new Point(671, 535);
            buttonClearSearch.Name = "buttonClearSearch";
            buttonClearSearch.Size = new Size(140, 39);
            buttonClearSearch.TabIndex = 14;
            buttonClearSearch.Text = "Clear Search";
            buttonClearSearch.UseVisualStyleBackColor = true;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(499, 535);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(155, 39);
            buttonShowAll.TabIndex = 15;
            buttonShowAll.Text = "Show All";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // labelNameSearches
            // 
            labelNameSearches.AutoSize = true;
            labelNameSearches.Location = new Point(577, 238);
            labelNameSearches.Name = "labelNameSearches";
            labelNameSearches.Size = new Size(198, 25);
            labelNameSearches.TabIndex = 16;
            labelNameSearches.Text = "Receipt Name and Type";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(832, 535);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(140, 39);
            buttonClose.TabIndex = 17;
            buttonClose.Text = "Close Program";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1039, 610);
            Controls.Add(buttonClose);
            Controls.Add(labelNameSearches);
            Controls.Add(buttonShowAll);
            Controls.Add(buttonClearSearch);
            Controls.Add(labelInstruction);
            Controls.Add(comboBoxTypeOfReceipt);
            Controls.Add(textBoxReceiptName);
            Controls.Add(buttonSave);
            Controls.Add(textBoxUserSearch);
            Controls.Add(buttonSearchReceipts);
            Controls.Add(checkBoxReceiptType);
            Controls.Add(checkBoxReceiptName);
            Controls.Add(listBoxSearchResults);
            Controls.Add(textBoxDescriptionOfReceipt);
            Controls.Add(labelSearchInstructions);
            Controls.Add(labelDiscription);
            Controls.Add(labelTypeOfReceipt);
            Controls.Add(labelReceiptName);
            Name = "AdminMainForm";
            Text = "Form Create and Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelReceiptName;
        private Label labelTypeOfReceipt;
        private Label labelDiscription;
        private Label labelSearchInstructions;
        private TextBox textBoxDescriptionOfReceipt;
        private ListBox listBoxSearchResults;
        private CheckBox checkBoxReceiptName;
        private CheckBox checkBoxReceiptType;
        private Button buttonSearchReceipts;
        private TextBox textBoxUserSearch;
        private Button buttonSave;
        private TextBox textBoxReceiptName;
        private ComboBox comboBoxTypeOfReceipt;
        private Label labelInstruction;
        private Button buttonClearSearch;
        private Button buttonShowAll;
        private Label labelNameSearches;
        private Button buttonClose;
    }
}
