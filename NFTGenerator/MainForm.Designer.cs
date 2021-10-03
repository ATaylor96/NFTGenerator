
namespace NFTGenerator
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Accessories");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Backgrounds");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Body");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Effects");
            this.loadButton = new System.Windows.Forms.Button();
            this.rarityListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addRarityButton = new System.Windows.Forms.Button();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.removeRarityButton = new System.Windows.Forms.Button();
            this.rarityNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.rarityLabel = new System.Windows.Forms.Label();
            this.filesTreeView = new System.Windows.Forms.TreeView();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputBrowse = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.howManyLabel = new System.Windows.Forms.Label();
            this.numberToGenerateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rarityNumbericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberToGenerateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(200, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Files";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // rarityListView
            // 
            this.rarityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.rarityListView.HideSelection = false;
            this.rarityListView.Location = new System.Drawing.Point(218, 83);
            this.rarityListView.Name = "rarityListView";
            this.rarityListView.Size = new System.Drawing.Size(180, 222);
            this.rarityListView.TabIndex = 3;
            this.rarityListView.UseCompatibleStateImageBehavior = false;
            this.rarityListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rarity";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chance";
            // 
            // addRarityButton
            // 
            this.addRarityButton.Location = new System.Drawing.Point(218, 54);
            this.addRarityButton.Name = "addRarityButton";
            this.addRarityButton.Size = new System.Drawing.Size(180, 23);
            this.addRarityButton.TabIndex = 5;
            this.addRarityButton.Text = "Add";
            this.addRarityButton.UseVisualStyleBackColor = true;
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Location = new System.Drawing.Point(218, 28);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(132, 20);
            this.suffixTextBox.TabIndex = 4;
            // 
            // removeRarityButton
            // 
            this.removeRarityButton.Location = new System.Drawing.Point(218, 311);
            this.removeRarityButton.Name = "removeRarityButton";
            this.removeRarityButton.Size = new System.Drawing.Size(180, 23);
            this.removeRarityButton.TabIndex = 6;
            this.removeRarityButton.Text = "Remove Selected";
            this.removeRarityButton.UseVisualStyleBackColor = true;
            // 
            // rarityNumbericUpDown
            // 
            this.rarityNumbericUpDown.Location = new System.Drawing.Point(356, 28);
            this.rarityNumbericUpDown.Name = "rarityNumbericUpDown";
            this.rarityNumbericUpDown.Size = new System.Drawing.Size(42, 20);
            this.rarityNumbericUpDown.TabIndex = 7;
            this.rarityNumbericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // suffixLabel
            // 
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Location = new System.Drawing.Point(215, 12);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(33, 13);
            this.suffixLabel.TabIndex = 8;
            this.suffixLabel.Text = "Suffix";
            // 
            // rarityLabel
            // 
            this.rarityLabel.AutoSize = true;
            this.rarityLabel.Location = new System.Drawing.Point(353, 12);
            this.rarityLabel.Name = "rarityLabel";
            this.rarityLabel.Size = new System.Drawing.Size(34, 13);
            this.rarityLabel.TabIndex = 9;
            this.rarityLabel.Text = "Rarity";
            // 
            // filesTreeView
            // 
            this.filesTreeView.Location = new System.Drawing.Point(12, 41);
            this.filesTreeView.Name = "filesTreeView";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Accessories";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Backgrounds";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Body";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Effects";
            this.filesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.filesTreeView.Size = new System.Drawing.Size(200, 293);
            this.filesTreeView.TabIndex = 10;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(401, 15);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(64, 13);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Output Path";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(471, 12);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(238, 20);
            this.outputTextBox.TabIndex = 1;
            // 
            // outputBrowse
            // 
            this.outputBrowse.Location = new System.Drawing.Point(404, 38);
            this.outputBrowse.Name = "outputBrowse";
            this.outputBrowse.Size = new System.Drawing.Size(305, 23);
            this.outputBrowse.TabIndex = 2;
            this.outputBrowse.Text = "Browse";
            this.outputBrowse.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(404, 106);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(305, 228);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // howManyLabel
            // 
            this.howManyLabel.AutoSize = true;
            this.howManyLabel.Location = new System.Drawing.Point(401, 64);
            this.howManyLabel.Name = "howManyLabel";
            this.howManyLabel.Size = new System.Drawing.Size(190, 13);
            this.howManyLabel.TabIndex = 12;
            this.howManyLabel.Text = "How many would you like to generate?";
            // 
            // numberToGenerateNumericUpDown
            // 
            this.numberToGenerateNumericUpDown.Location = new System.Drawing.Point(404, 80);
            this.numberToGenerateNumericUpDown.Name = "numberToGenerateNumericUpDown";
            this.numberToGenerateNumericUpDown.Size = new System.Drawing.Size(305, 20);
            this.numberToGenerateNumericUpDown.TabIndex = 11;
            this.numberToGenerateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 344);
            this.Controls.Add(this.howManyLabel);
            this.Controls.Add(this.numberToGenerateNumericUpDown);
            this.Controls.Add(this.filesTreeView);
            this.Controls.Add(this.rarityLabel);
            this.Controls.Add(this.suffixLabel);
            this.Controls.Add(this.rarityNumbericUpDown);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.removeRarityButton);
            this.Controls.Add(this.addRarityButton);
            this.Controls.Add(this.suffixTextBox);
            this.Controls.Add(this.rarityListView);
            this.Controls.Add(this.outputBrowse);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFT Generator";
            ((System.ComponentModel.ISupportInitialize)(this.rarityNumbericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberToGenerateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListView rarityListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button addRarityButton;
        private System.Windows.Forms.TextBox suffixTextBox;
        private System.Windows.Forms.Button removeRarityButton;
        private System.Windows.Forms.NumericUpDown rarityNumbericUpDown;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.Label rarityLabel;
        private System.Windows.Forms.TreeView filesTreeView;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button outputBrowse;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label howManyLabel;
        private System.Windows.Forms.NumericUpDown numberToGenerateNumericUpDown;
    }
}

