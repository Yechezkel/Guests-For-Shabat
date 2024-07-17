namespace GuestForShabat
{
    partial class HostForm
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
            this.textBox_addCategory = new System.Windows.Forms.TextBox();
            this.button_category = new System.Windows.Forms.Button();
            this.listView_categories = new System.Windows.Forms.ListView();
            this.label_category = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_addCategory
            // 
            this.textBox_addCategory.Location = new System.Drawing.Point(68, 198);
            this.textBox_addCategory.Name = "textBox_addCategory";
            this.textBox_addCategory.Size = new System.Drawing.Size(391, 20);
            this.textBox_addCategory.TabIndex = 0;
            // 
            // button_category
            // 
            this.button_category.Location = new System.Drawing.Point(68, 242);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(391, 23);
            this.button_category.TabIndex = 1;
            this.button_category.Text = "הוסף קטגוריה";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.OnButtonAddCategoryClick);
            // 
            // listView_categories
            // 
            this.listView_categories.HideSelection = false;
            this.listView_categories.Location = new System.Drawing.Point(68, 366);
            this.listView_categories.Name = "listView_categories";
            this.listView_categories.Size = new System.Drawing.Size(391, 381);
            this.listView_categories.TabIndex = 2;
            this.listView_categories.UseCompatibleStateImageBehavior = false;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(205, 116);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(113, 31);
            this.label_category.TabIndex = 3;
            this.label_category.Text = "קטגוריות";
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 795);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.listView_categories);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.textBox_addCategory);
            this.Name = "HostForm";
            this.Text = "HostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_addCategory;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.ListView listView_categories;
        private System.Windows.Forms.Label label_category;
    }
}