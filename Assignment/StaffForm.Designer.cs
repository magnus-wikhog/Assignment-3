namespace Assignment {
    partial class StaffForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qualificationTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qualificationsListbox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(57, 15);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(295, 20);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.qualificationTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.qualificationsListbox);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.changeButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qualifications";
            // 
            // qualificationTextbox
            // 
            this.qualificationTextbox.Location = new System.Drawing.Point(86, 19);
            this.qualificationTextbox.Name = "qualificationTextbox";
            this.qualificationTextbox.Size = new System.Drawing.Size(251, 20);
            this.qualificationTextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qualification";
            // 
            // qualificationsListbox
            // 
            this.qualificationsListbox.FormattingEnabled = true;
            this.qualificationsListbox.Location = new System.Drawing.Point(111, 59);
            this.qualificationsListbox.Name = "qualificationsListbox";
            this.qualificationsListbox.Size = new System.Drawing.Size(226, 134);
            this.qualificationsListbox.TabIndex = 3;
            this.qualificationsListbox.SelectedIndexChanged += new System.EventHandler(this.ingredientsListbox_SelectedIndexChanged);
            this.qualificationsListbox.SelectedValueChanged += new System.EventHandler(this.ingredientsListbox_SelectedValueChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(18, 117);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(18, 88);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 59);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(156, 265);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 296);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox qualificationTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox qualificationsListbox;
        private System.Windows.Forms.Button okButton;
    }
}