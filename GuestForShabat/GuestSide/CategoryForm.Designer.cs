namespace GuestForShabat.GuestSide
{
    partial class CategoryForm
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
            this.button_addFood = new System.Windows.Forms.Button();
            this.textBox_food = new System.Windows.Forms.TextBox();
            this.label_category = new System.Windows.Forms.Label();
            this.listView_othersFood = new System.Windows.Forms.ListView();
            this.listView_myFood = new System.Windows.Forms.ListView();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label_myFood = new System.Windows.Forms.Label();
            this.label_othersFood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_addFood
            // 
            this.button_addFood.Location = new System.Drawing.Point(367, 608);
            this.button_addFood.Name = "button_addFood";
            this.button_addFood.Size = new System.Drawing.Size(104, 23);
            this.button_addFood.TabIndex = 0;
            this.button_addFood.Text = "הוספה";
            this.button_addFood.UseVisualStyleBackColor = true;
            this.button_addFood.Click += new System.EventHandler(this.OnButtonAddFoodClick);
            // 
            // textBox_food
            // 
            this.textBox_food.Location = new System.Drawing.Point(371, 571);
            this.textBox_food.Name = "textBox_food";
            this.textBox_food.Size = new System.Drawing.Size(100, 20);
            this.textBox_food.TabIndex = 1;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(252, 20);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(80, 24);
            this.label_category.TabIndex = 2;
            this.label_category.Text = "קטגוריה";
            // 
            // listView_othersFood
            // 
            this.listView_othersFood.HideSelection = false;
            this.listView_othersFood.Location = new System.Drawing.Point(39, 146);
            this.listView_othersFood.Name = "listView_othersFood";
            this.listView_othersFood.Size = new System.Drawing.Size(466, 247);
            this.listView_othersFood.TabIndex = 5;
            this.listView_othersFood.UseCompatibleStateImageBehavior = false;
            // 
            // listView_myFood
            // 
            this.listView_myFood.HideSelection = false;
            this.listView_myFood.Location = new System.Drawing.Point(39, 494);
            this.listView_myFood.Name = "listView_myFood";
            this.listView_myFood.Size = new System.Drawing.Size(311, 208);
            this.listView_myFood.TabIndex = 6;
            this.listView_myFood.UseCompatibleStateImageBehavior = false;
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(439, 730);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 23);
            this.button_prev.TabIndex = 7;
            this.button_prev.Text = "הקודם";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(52, 730);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 8;
            this.button_next.Text = "הבא";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label_myFood
            // 
            this.label_myFood.AutoSize = true;
            this.label_myFood.Location = new System.Drawing.Point(263, 478);
            this.label_myFood.Name = "label_myFood";
            this.label_myFood.Size = new System.Drawing.Size(74, 13);
            this.label_myFood.TabIndex = 9;
            this.label_myFood.Text = "ההזמנות שלי";
            // 
            // label_othersFood
            // 
            this.label_othersFood.AutoSize = true;
            this.label_othersFood.Location = new System.Drawing.Point(362, 130);
            this.label_othersFood.Name = "label_othersFood";
            this.label_othersFood.Size = new System.Drawing.Size(143, 13);
            this.label_othersFood.TabIndex = 10;
            this.label_othersFood.Text = "ההזמנות של שאר האורחים";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 796);
            this.Controls.Add(this.label_othersFood);
            this.Controls.Add(this.label_myFood);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.listView_myFood);
            this.Controls.Add(this.listView_othersFood);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.textBox_food);
            this.Controls.Add(this.button_addFood);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addFood;
        private System.Windows.Forms.TextBox textBox_food;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ListView listView_othersFood;
        private System.Windows.Forms.ListView listView_myFood;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_myFood;
        private System.Windows.Forms.Label label_othersFood;
    }
}