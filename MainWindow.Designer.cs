namespace xml_laba
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Developer = new System.Windows.Forms.CheckBox();
            this.ReleaseDate = new System.Windows.Forms.CheckBox();
            this.MainGenre = new System.Windows.Forms.CheckBox();
            this.GameMode = new System.Windows.Forms.CheckBox();
            this.Engine = new System.Windows.Forms.CheckBox();
            this.Metascore = new System.Windows.Forms.CheckBox();
            this.BSAX = new System.Windows.Forms.RadioButton();
            this.BLINQ = new System.Windows.Forms.RadioButton();
            this.BDOM = new System.Windows.Forms.RadioButton();
            this.BDeveloper = new System.Windows.Forms.ComboBox();
            this.BReleaseDate = new System.Windows.Forms.ComboBox();
            this.BMainGenre = new System.Windows.Forms.ComboBox();
            this.BEngine = new System.Windows.Forms.ComboBox();
            this.BGameMode = new System.Windows.Forms.ComboBox();
            this.BMetascore = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.transformButton = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.RichTextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Developer.Location = new System.Drawing.Point(15, 43);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(108, 25);
            this.Developer.TabIndex = 0;
            this.Developer.Text = "Developer";
            this.Developer.UseVisualStyleBackColor = true;
            this.Developer.CheckedChanged += new System.EventHandler(this.Developer_CheckedChanged);
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDate.Location = new System.Drawing.Point(15, 74);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(123, 25);
            this.ReleaseDate.TabIndex = 0;
            this.ReleaseDate.Text = "ReleaseDate";
            this.ReleaseDate.UseVisualStyleBackColor = true;
            this.ReleaseDate.CheckedChanged += new System.EventHandler(this.ReleaseDate_CheckedChanged);
            // 
            // MainGenre
            // 
            this.MainGenre.AutoSize = true;
            this.MainGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainGenre.Location = new System.Drawing.Point(15, 105);
            this.MainGenre.Name = "MainGenre";
            this.MainGenre.Size = new System.Drawing.Size(113, 25);
            this.MainGenre.TabIndex = 0;
            this.MainGenre.Text = "MainGenre";
            this.MainGenre.UseVisualStyleBackColor = true;
            this.MainGenre.CheckedChanged += new System.EventHandler(this.MainGenre_CheckedChanged);
            // 
            // GameMode
            // 
            this.GameMode.AutoSize = true;
            this.GameMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameMode.Location = new System.Drawing.Point(15, 136);
            this.GameMode.Name = "GameMode";
            this.GameMode.Size = new System.Drawing.Size(117, 25);
            this.GameMode.TabIndex = 0;
            this.GameMode.Text = "GameMode";
            this.GameMode.UseVisualStyleBackColor = true;
            this.GameMode.CheckedChanged += new System.EventHandler(this.GameMode_CheckedChanged);
            // 
            // Engine
            // 
            this.Engine.AutoSize = true;
            this.Engine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Engine.Location = new System.Drawing.Point(15, 167);
            this.Engine.Name = "Engine";
            this.Engine.Size = new System.Drawing.Size(82, 25);
            this.Engine.TabIndex = 0;
            this.Engine.Text = "Engine";
            this.Engine.UseVisualStyleBackColor = true;
            this.Engine.CheckedChanged += new System.EventHandler(this.Engine_CheckedChanged);
            // 
            // Metascore
            // 
            this.Metascore.AutoSize = true;
            this.Metascore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Metascore.Location = new System.Drawing.Point(15, 198);
            this.Metascore.Name = "Metascore";
            this.Metascore.Size = new System.Drawing.Size(108, 25);
            this.Metascore.TabIndex = 0;
            this.Metascore.Text = "Metascore\t\t";
            this.Metascore.UseVisualStyleBackColor = true;
            this.Metascore.CheckedChanged += new System.EventHandler(this.Metascore_CheckedChanged);
            // 
            // BSAX
            // 
            this.BSAX.AutoSize = true;
            this.BSAX.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BSAX.Location = new System.Drawing.Point(5, 246);
            this.BSAX.Name = "BSAX";
            this.BSAX.Size = new System.Drawing.Size(58, 25);
            this.BSAX.TabIndex = 1;
            this.BSAX.TabStop = true;
            this.BSAX.Text = "SAX";
            this.BSAX.UseVisualStyleBackColor = true;
            // 
            // BLINQ
            // 
            this.BLINQ.AutoSize = true;
            this.BLINQ.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BLINQ.Location = new System.Drawing.Point(69, 246);
            this.BLINQ.Name = "BLINQ";
            this.BLINQ.Size = new System.Drawing.Size(111, 25);
            this.BLINQ.TabIndex = 1;
            this.BLINQ.TabStop = true;
            this.BLINQ.Text = "Linq to Xml";
            this.BLINQ.UseVisualStyleBackColor = true;
            // 
            // BDOM
            // 
            this.BDOM.AutoSize = true;
            this.BDOM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BDOM.Location = new System.Drawing.Point(186, 246);
            this.BDOM.Name = "BDOM";
            this.BDOM.Size = new System.Drawing.Size(66, 25);
            this.BDOM.TabIndex = 1;
            this.BDOM.TabStop = true;
            this.BDOM.Text = "DOM";
            this.BDOM.UseVisualStyleBackColor = true;
            // 
            // BDeveloper
            // 
            this.BDeveloper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BDeveloper.Enabled = false;
            this.BDeveloper.FormattingEnabled = true;
            this.BDeveloper.Location = new System.Drawing.Point(186, 45);
            this.BDeveloper.Name = "BDeveloper";
            this.BDeveloper.Size = new System.Drawing.Size(263, 23);
            this.BDeveloper.TabIndex = 2;
            this.BDeveloper.Tag = "";
            // 
            // BReleaseDate
            // 
            this.BReleaseDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BReleaseDate.Enabled = false;
            this.BReleaseDate.FormattingEnabled = true;
            this.BReleaseDate.IntegralHeight = false;
            this.BReleaseDate.Location = new System.Drawing.Point(186, 76);
            this.BReleaseDate.Name = "BReleaseDate";
            this.BReleaseDate.Size = new System.Drawing.Size(263, 23);
            this.BReleaseDate.TabIndex = 2;
            // 
            // BMainGenre
            // 
            this.BMainGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BMainGenre.Enabled = false;
            this.BMainGenre.FormattingEnabled = true;
            this.BMainGenre.Location = new System.Drawing.Point(186, 107);
            this.BMainGenre.Name = "BMainGenre";
            this.BMainGenre.Size = new System.Drawing.Size(263, 23);
            this.BMainGenre.TabIndex = 2;
            // 
            // BEngine
            // 
            this.BEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BEngine.Enabled = false;
            this.BEngine.FormattingEnabled = true;
            this.BEngine.Location = new System.Drawing.Point(186, 169);
            this.BEngine.Name = "BEngine";
            this.BEngine.Size = new System.Drawing.Size(263, 23);
            this.BEngine.TabIndex = 2;
            // 
            // BGameMode
            // 
            this.BGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BGameMode.Enabled = false;
            this.BGameMode.FormattingEnabled = true;
            this.BGameMode.Location = new System.Drawing.Point(186, 138);
            this.BGameMode.Name = "BGameMode";
            this.BGameMode.Size = new System.Drawing.Size(263, 23);
            this.BGameMode.TabIndex = 2;
            // 
            // BMetascore
            // 
            this.BMetascore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BMetascore.Enabled = false;
            this.BMetascore.FormattingEnabled = true;
            this.BMetascore.Location = new System.Drawing.Point(186, 200);
            this.BMetascore.Name = "BMetascore";
            this.BMetascore.Size = new System.Drawing.Size(263, 23);
            this.BMetascore.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(19, 277);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(77, 25);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(19, 305);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(77, 25);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // transformButton
            // 
            this.transformButton.Location = new System.Drawing.Point(111, 277);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(69, 53);
            this.transformButton.TabIndex = 3;
            this.transformButton.Text = "Transform to html";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(473, 12);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(463, 334);
            this.w.TabIndex = 4;
            this.w.Text = "";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(197, 280);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(98, 49);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(948, 349);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.w);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.BMetascore);
            this.Controls.Add(this.BGameMode);
            this.Controls.Add(this.BEngine);
            this.Controls.Add(this.BMainGenre);
            this.Controls.Add(this.BReleaseDate);
            this.Controls.Add(this.BDeveloper);
            this.Controls.Add(this.BDOM);
            this.Controls.Add(this.BLINQ);
            this.Controls.Add(this.BSAX);
            this.Controls.Add(this.Metascore);
            this.Controls.Add(this.Engine);
            this.Controls.Add(this.GameMode);
            this.Controls.Add(this.MainGenre);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Developer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Game DB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Developer;
        private System.Windows.Forms.CheckBox ReleaseDate;
        private System.Windows.Forms.CheckBox MainGenre;
        private System.Windows.Forms.CheckBox GameMode;
        private System.Windows.Forms.CheckBox Engine;
        private System.Windows.Forms.CheckBox Metascore;
        private System.Windows.Forms.RadioButton BSAX;
        private System.Windows.Forms.RadioButton BLINQ;
        private System.Windows.Forms.RadioButton BDOM;
        private System.Windows.Forms.ComboBox BDeveloper;
        private System.Windows.Forms.ComboBox BReleaseDate;
        private System.Windows.Forms.ComboBox BMainGenre;
        private System.Windows.Forms.ComboBox BEngine;
        private System.Windows.Forms.ComboBox BGameMode;
        private System.Windows.Forms.ComboBox BMetascore;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.RichTextBox w;
        private System.Windows.Forms.Button helpButton;
    }
}

