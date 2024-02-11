namespace Client
{
    partial class Main
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
            Navigation_Stores = new Button();
            Navigation_Bar = new GroupBox();
            Navigation_Recipes = new Button();
            Navigation_Profile = new Button();
            groupBox1 = new GroupBox();
            SearchBar = new GroupBox();
            Navigation_Bar.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Navigation_Stores
            // 
            Navigation_Stores.Anchor = AnchorStyles.Bottom;
            Navigation_Stores.BackColor = SystemColors.Highlight;
            Navigation_Stores.FlatAppearance.BorderColor = Color.RebeccaPurple;
            Navigation_Stores.FlatAppearance.BorderSize = 0;
            Navigation_Stores.FlatStyle = FlatStyle.Flat;
            Navigation_Stores.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Navigation_Stores.ForeColor = Color.White;
            Navigation_Stores.Location = new Point(0, 0);
            Navigation_Stores.Margin = new Padding(0);
            Navigation_Stores.Name = "Navigation_Stores";
            Navigation_Stores.Size = new Size(133, 75);
            Navigation_Stores.TabIndex = 1;
            Navigation_Stores.Tag = "Navigation_Buttons";
            Navigation_Stores.Text = "Stores";
            Navigation_Stores.UseVisualStyleBackColor = false;
            // 
            // Navigation_Bar
            // 
            Navigation_Bar.Anchor = AnchorStyles.Bottom;
            Navigation_Bar.BackColor = SystemColors.Highlight;
            Navigation_Bar.Controls.Add(Navigation_Profile);
            Navigation_Bar.Controls.Add(Navigation_Recipes);
            Navigation_Bar.Controls.Add(Navigation_Stores);
            Navigation_Bar.Location = new Point(0, 625);
            Navigation_Bar.Margin = new Padding(0);
            Navigation_Bar.Name = "Navigation_Bar";
            Navigation_Bar.Padding = new Padding(0);
            Navigation_Bar.RightToLeft = RightToLeft.No;
            Navigation_Bar.Size = new Size(400, 75);
            Navigation_Bar.TabIndex = 2;
            Navigation_Bar.TabStop = false;
            // 
            // Navigation_Recipes
            // 
            Navigation_Recipes.Anchor = AnchorStyles.Bottom;
            Navigation_Recipes.BackColor = SystemColors.Highlight;
            Navigation_Recipes.FlatAppearance.BorderColor = Color.RebeccaPurple;
            Navigation_Recipes.FlatAppearance.BorderSize = 0;
            Navigation_Recipes.FlatStyle = FlatStyle.Flat;
            Navigation_Recipes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Navigation_Recipes.ForeColor = Color.White;
            Navigation_Recipes.Location = new Point(133, 0);
            Navigation_Recipes.Margin = new Padding(0);
            Navigation_Recipes.Name = "Navigation_Recipes";
            Navigation_Recipes.Size = new Size(134, 75);
            Navigation_Recipes.TabIndex = 2;
            Navigation_Recipes.Tag = "Navigation_Buttons";
            Navigation_Recipes.Text = "Recipes";
            Navigation_Recipes.UseVisualStyleBackColor = false;
            // 
            // Navigation_Profile
            // 
            Navigation_Profile.Anchor = AnchorStyles.Bottom;
            Navigation_Profile.BackColor = SystemColors.Highlight;
            Navigation_Profile.FlatAppearance.BorderColor = Color.RebeccaPurple;
            Navigation_Profile.FlatAppearance.BorderSize = 0;
            Navigation_Profile.FlatStyle = FlatStyle.Flat;
            Navigation_Profile.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Navigation_Profile.ForeColor = Color.White;
            Navigation_Profile.Location = new Point(267, 0);
            Navigation_Profile.Margin = new Padding(0);
            Navigation_Profile.Name = "Navigation_Profile";
            Navigation_Profile.Size = new Size(133, 75);
            Navigation_Profile.TabIndex = 4;
            Navigation_Profile.Tag = "Navigation_Buttons";
            Navigation_Profile.Text = "Profile";
            Navigation_Profile.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SearchBar);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(400, 625);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(25, 0);
            SearchBar.Margin = new Padding(0);
            SearchBar.Name = "SearchBar";
            SearchBar.Padding = new Padding(0);
            SearchBar.Size = new Size(350, 25);
            SearchBar.TabIndex = 0;
            SearchBar.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 700);
            Controls.Add(groupBox1);
            Controls.Add(Navigation_Bar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Load += Main_Load;
            Navigation_Bar.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button Navigation_Stores;
        private GroupBox Navigation_Bar;
        private Button Navigation_Profile;
        private Button Navigation_Recipes;
        private GroupBox groupBox1;
        private GroupBox SearchBar;
    }
}