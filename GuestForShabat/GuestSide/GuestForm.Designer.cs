namespace GuestForShabat.GuestSide
{
    partial class GuestForm
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
            this.label_wellcome = new System.Windows.Forms.Label();
            this.label_guestName = new System.Windows.Forms.Label();
            this.textBox_guestName = new System.Windows.Forms.TextBox();
            this.button_addGuest = new System.Windows.Forms.Button();
            this.listBox_guests = new System.Windows.Forms.ListBox();
            this.button_continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_wellcome
            // 
            this.label_wellcome.AutoSize = true;
            this.label_wellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wellcome.Location = new System.Drawing.Point(125, 39);
            this.label_wellcome.Name = "label_wellcome";
            this.label_wellcome.Size = new System.Drawing.Size(149, 25);
            this.label_wellcome.TabIndex = 0;
            this.label_wellcome.Text = "ברוכים הבאים";
            // 
            // label_guestName
            // 
            this.label_guestName.AutoSize = true;
            this.label_guestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_guestName.Location = new System.Drawing.Point(135, 113);
            this.label_guestName.Name = "label_guestName";
            this.label_guestName.Size = new System.Drawing.Size(121, 24);
            this.label_guestName.TabIndex = 1;
            this.label_guestName.Text = "בחר שם אורח";
            // 
            // textBox_guestName
            // 
            this.textBox_guestName.Location = new System.Drawing.Point(187, 205);
            this.textBox_guestName.Name = "textBox_guestName";
            this.textBox_guestName.Size = new System.Drawing.Size(100, 20);
            this.textBox_guestName.TabIndex = 2;
            // 
            // button_addGuest
            // 
            this.button_addGuest.Location = new System.Drawing.Point(85, 202);
            this.button_addGuest.Name = "button_addGuest";
            this.button_addGuest.Size = new System.Drawing.Size(75, 23);
            this.button_addGuest.TabIndex = 5;
            this.button_addGuest.Text = "הוספה";
            this.button_addGuest.UseVisualStyleBackColor = true;
            this.button_addGuest.Click += new System.EventHandler(this.OnButtonAddGuestClick);
            // 
            // listBox_guests
            // 
            this.listBox_guests.FormattingEnabled = true;
            this.listBox_guests.Location = new System.Drawing.Point(64, 241);
            this.listBox_guests.Name = "listBox_guests";
            this.listBox_guests.Size = new System.Drawing.Size(250, 251);
            this.listBox_guests.TabIndex = 6;
            this.listBox_guests.SelectedIndexChanged += new System.EventHandler(this.listBox_guests_SelectedIndexChanged);
            // 
            // button_continue
            // 
            this.button_continue.Location = new System.Drawing.Point(35, 498);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(75, 23);
            this.button_continue.TabIndex = 7;
            this.button_continue.Text = "המשך";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 557);
            this.Controls.Add(this.button_continue);
            this.Controls.Add(this.listBox_guests);
            this.Controls.Add(this.button_addGuest);
            this.Controls.Add(this.textBox_guestName);
            this.Controls.Add(this.label_guestName);
            this.Controls.Add(this.label_wellcome);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_wellcome;
        private System.Windows.Forms.Label label_guestName;
        private System.Windows.Forms.TextBox textBox_guestName;
        private System.Windows.Forms.Button button_addGuest;
        private System.Windows.Forms.ListBox listBox_guests;
        private System.Windows.Forms.Button button_continue;
    }
}