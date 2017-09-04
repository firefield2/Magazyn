namespace Magazyn
{
    partial class LocalizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizationForm));
            this.localizationListBox = new System.Windows.Forms.ListBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.localizationNameGB = new System.Windows.Forms.GroupBox();
            this.localizationNameTB = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.mainGroupBox.SuspendLayout();
            this.localizationNameGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // localizationListBox
            // 
            this.localizationListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localizationListBox.DisplayMember = "Name";
            this.localizationListBox.FormattingEnabled = true;
            this.localizationListBox.ItemHeight = 16;
            this.localizationListBox.Location = new System.Drawing.Point(12, 12);
            this.localizationListBox.Name = "localizationListBox";
            this.localizationListBox.Size = new System.Drawing.Size(201, 212);
            this.localizationListBox.TabIndex = 1;
            this.localizationListBox.ValueMember = "Name";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(10, 22);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 35);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edytuj";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(10, 63);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 35);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(10, 104);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 35);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mainGroupBox.Controls.Add(this.DeleteButton);
            this.mainGroupBox.Controls.Add(this.AddButton);
            this.mainGroupBox.Controls.Add(this.EditButton);
            this.mainGroupBox.Location = new System.Drawing.Point(219, 32);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(172, 156);
            this.mainGroupBox.TabIndex = 6;
            this.mainGroupBox.TabStop = false;
            // 
            // localizationNameGB
            // 
            this.localizationNameGB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.localizationNameGB.Controls.Add(this.localizationNameTB);
            this.localizationNameGB.Controls.Add(this.CancelButton);
            this.localizationNameGB.Controls.Add(this.confirmButton);
            this.localizationNameGB.Location = new System.Drawing.Point(219, 32);
            this.localizationNameGB.Name = "localizationNameGB";
            this.localizationNameGB.Size = new System.Drawing.Size(172, 156);
            this.localizationNameGB.TabIndex = 7;
            this.localizationNameGB.TabStop = false;
            this.localizationNameGB.Text = "Nazwa kategorii";
            this.localizationNameGB.Visible = false;
            // 
            // localizationNameTB
            // 
            this.localizationNameTB.Location = new System.Drawing.Point(10, 28);
            this.localizationNameTB.Name = "localizationNameTB";
            this.localizationNameTB.Size = new System.Drawing.Size(150, 23);
            this.localizationNameTB.TabIndex = 6;
            this.localizationNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.localizationNameTB_KeyDown);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(10, 104);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 35);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(10, 63);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(150, 35);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // LocalizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(403, 230);
            this.Controls.Add(this.localizationListBox);
            this.Controls.Add(this.localizationNameGB);
            this.Controls.Add(this.mainGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LocalizationForm";
            this.Text = "Lokalizacje";
            this.mainGroupBox.ResumeLayout(false);
            this.localizationNameGB.ResumeLayout(false);
            this.localizationNameGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox localizationListBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox localizationNameGB;
        private System.Windows.Forms.TextBox localizationNameTB;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}