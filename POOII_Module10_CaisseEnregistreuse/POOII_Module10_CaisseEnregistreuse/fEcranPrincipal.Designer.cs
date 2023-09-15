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
            dataGridView1 = new DataGridView();
            lbArticles = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(811, 249);
            dataGridView1.TabIndex = 0;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(605, 290);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(661, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(719, 320);
            button1.Name = "button1";
            button1.Size = new Size(104, 26);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 123);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(646, 84);
            button2.Name = "button2";
            button2.Size = new Size(159, 33);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(661, 28);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDown2.Location = new Point(717, 26);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(88, 27);
            numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDown1.Location = new Point(536, 26);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(88, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(480, 28);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(72, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 27);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(16, 28);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // fEcranPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 483);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lbArticles);
            Controls.Add(dataGridView1);
            MaximumSize = new Size(1300, 600);
            MinimumSize = new Size(850, 530);
            Name = "fEcranPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ecran principal";
            Load += fEcranPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbArticles;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
    }
}