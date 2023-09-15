namespace POOII_Module10_CaisseEnregistreuse
{
    partial class fEcranPrincipal
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
            dgvArticles = new DataGridView();
            lbArticles = new Label();
            lbTotal = new Label();
            tbTotal = new TextBox();
            btPayer = new Button();
            gbSimulateurScaner = new GroupBox();
            btSimuler = new Button();
            lbPrix = new Label();
            nudPrix = new NumericUpDown();
            nudQuantite = new NumericUpDown();
            lbQuantite = new Label();
            tbDescription = new TextBox();
            lbDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            gbSimulateurScaner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).BeginInit();
            SuspendLayout();
            // 
            // dgvArticles
            // 
            dgvArticles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Location = new Point(12, 32);
            dgvArticles.Name = "dgvArticles";
            dgvArticles.RowHeadersWidth = 51;
            dgvArticles.Size = new Size(811, 249);
            dgvArticles.TabIndex = 0;
            // 
            // lbArticles
            // 
            lbArticles.AutoSize = true;
            lbArticles.Location = new Point(12, 9);
            lbArticles.Name = "lbArticles";
            lbArticles.Size = new Size(65, 20);
            lbArticles.TabIndex = 1;
            lbArticles.Text = "Articles :";
            lbArticles.Click += label1_Click;
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(605, 290);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(42, 20);
            lbTotal.TabIndex = 2;
            lbTotal.Text = "Total";
            lbTotal.Click += label2_Click;
            // 
            // tbTotal
            // 
            tbTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTotal.Location = new Point(661, 287);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(162, 27);
            tbTotal.TabIndex = 3;
            // 
            // btPayer
            // 
            btPayer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btPayer.Location = new Point(719, 320);
            btPayer.Name = "btPayer";
            btPayer.Size = new Size(104, 26);
            btPayer.TabIndex = 4;
            btPayer.Text = "Payer";
            btPayer.UseVisualStyleBackColor = true;
            // 
            // gbSimulateurScaner
            // 
            gbSimulateurScaner.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbSimulateurScaner.Controls.Add(btSimuler);
            gbSimulateurScaner.Controls.Add(lbPrix);
            gbSimulateurScaner.Controls.Add(nudPrix);
            gbSimulateurScaner.Controls.Add(nudQuantite);
            gbSimulateurScaner.Controls.Add(lbQuantite);
            gbSimulateurScaner.Controls.Add(tbDescription);
            gbSimulateurScaner.Controls.Add(lbDescription);
            gbSimulateurScaner.Location = new Point(12, 348);
            gbSimulateurScaner.Name = "gbSimulateurScaner";
            gbSimulateurScaner.Size = new Size(811, 123);
            gbSimulateurScaner.TabIndex = 5;
            gbSimulateurScaner.TabStop = false;
            gbSimulateurScaner.Text = "Simulateur scaner";
            // 
            // btSimuler
            // 
            btSimuler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btSimuler.Location = new Point(646, 84);
            btSimuler.Name = "btSimuler";
            btSimuler.Size = new Size(159, 33);
            btSimuler.TabIndex = 6;
            btSimuler.Text = "Simuler";
            btSimuler.UseVisualStyleBackColor = true;
            btSimuler.Click += btSimuler_Click;
            // 
            // lbPrix
            // 
            lbPrix.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbPrix.AutoSize = true;
            lbPrix.Location = new Point(661, 28);
            lbPrix.Name = "lbPrix";
            lbPrix.Size = new Size(33, 20);
            lbPrix.TabIndex = 5;
            lbPrix.Text = "Prix";
            // 
            // nudPrix
            // 
            nudPrix.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nudPrix.Location = new Point(717, 26);
            nudPrix.Name = "nudPrix";
            nudPrix.Size = new Size(88, 27);
            nudPrix.TabIndex = 4;
            // 
            // nudQuantite
            // 
            nudQuantite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nudQuantite.Location = new Point(552, 26);
            nudQuantite.Name = "nudQuantite";
            nudQuantite.Size = new Size(88, 27);
            nudQuantite.TabIndex = 3;
            // 
            // lbQuantite
            // 
            lbQuantite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbQuantite.AutoSize = true;
            lbQuantite.Location = new Point(480, 28);
            lbQuantite.Name = "lbQuantite";
            lbQuantite.Size = new Size(66, 20);
            lbQuantite.TabIndex = 2;
            lbQuantite.Text = "Quantité";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(107, 26);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(367, 27);
            tbDescription.TabIndex = 1;
            // 
            // lbDescription
            // 
            lbDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(16, 28);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(85, 20);
            lbDescription.TabIndex = 0;
            lbDescription.Text = "Description";
            // 
            // fEcranPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 483);
            Controls.Add(gbSimulateurScaner);
            Controls.Add(btPayer);
            Controls.Add(tbTotal);
            Controls.Add(lbTotal);
            Controls.Add(lbArticles);
            Controls.Add(dgvArticles);
            MaximumSize = new Size(1300, 600);
            MinimumSize = new Size(850, 530);
            Name = "fEcranPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ecran principal";
            Load += fEcranPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticles).EndInit();
            gbSimulateurScaner.ResumeLayout(false);
            gbSimulateurScaner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArticles;
        private Label lbArticles;
        private Label lbTotal;
        private TextBox tbTotal;
        private Button btPayer;
        private GroupBox gbSimulateurScaner;
        private Label lbQuantite;
        private TextBox tbDescription;
        private Label lbDescription;
        private Button btSimuler;
        private Label lbPrix;
        private NumericUpDown nudPrix;
        private NumericUpDown nudQuantite;
    }
}