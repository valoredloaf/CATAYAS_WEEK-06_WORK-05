namespace CATAYAS_WEEK_06_WORK_05
{
    partial class ucProductListing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpItemDetails = new System.Windows.Forms.GroupBox();
            this.cmboxAmount = new System.Windows.Forms.ComboBox();
            this.txtboxAmount = new System.Windows.Forms.TextBox();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblboxItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.grpItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpItemDetails
            // 
            this.grpItemDetails.Controls.Add(this.cmboxAmount);
            this.grpItemDetails.Controls.Add(this.txtboxAmount);
            this.grpItemDetails.Controls.Add(this.txtboxDescription);
            this.grpItemDetails.Controls.Add(this.label2);
            this.grpItemDetails.Controls.Add(this.label1);
            this.grpItemDetails.Location = new System.Drawing.Point(30, 22);
            this.grpItemDetails.Name = "grpItemDetails";
            this.grpItemDetails.Size = new System.Drawing.Size(607, 101);
            this.grpItemDetails.TabIndex = 0;
            this.grpItemDetails.TabStop = false;
            this.grpItemDetails.Text = "Item Details";
            // 
            // cmboxAmount
            // 
            this.cmboxAmount.FormattingEnabled = true;
            this.cmboxAmount.Location = new System.Drawing.Point(306, 64);
            this.cmboxAmount.Name = "cmboxAmount";
            this.cmboxAmount.Size = new System.Drawing.Size(121, 21);
            this.cmboxAmount.TabIndex = 4;
            this.cmboxAmount.SelectedIndexChanged += new System.EventHandler(this.cmboxAmount_SelectedIndexChanged);
            // 
            // txtboxAmount
            // 
            this.txtboxAmount.Location = new System.Drawing.Point(106, 65);
            this.txtboxAmount.Name = "txtboxAmount";
            this.txtboxAmount.Size = new System.Drawing.Size(184, 20);
            this.txtboxAmount.TabIndex = 3;
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Location = new System.Drawing.Point(106, 29);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(453, 20);
            this.txtboxDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // lblboxItems
            // 
            this.lblboxItems.FormattingEnabled = true;
            this.lblboxItems.Location = new System.Drawing.Point(30, 129);
            this.lblboxItems.Name = "lblboxItems";
            this.lblboxItems.Size = new System.Drawing.Size(726, 238);
            this.lblboxItems.TabIndex = 1;
            this.lblboxItems.Click += new System.EventHandler(this.lblboxItems_SelectedIndexChanged);
            this.lblboxItems.SelectedIndexChanged += new System.EventHandler(this.ucProductListing_Load);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(643, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(643, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.BackColor = System.Drawing.Color.Red;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrompt.Location = new System.Drawing.Point(30, 381);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(726, 32);
            this.lblPrompt.TabIndex = 4;
            this.lblPrompt.Text = "Prompt";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrompt.Click += new System.EventHandler(this.lblPrompt_Click);
            // 
            // ucProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblboxItems);
            this.Controls.Add(this.grpItemDetails);
            this.Name = "ucProductListing";
            this.Size = new System.Drawing.Size(795, 469);
            this.grpItemDetails.ResumeLayout(false);
            this.grpItemDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItemDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lblboxItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmboxAmount;
        private System.Windows.Forms.TextBox txtboxAmount;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.Label lblPrompt;
    }
}
