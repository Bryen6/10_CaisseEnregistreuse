namespace POOII_Module10_CaisseEnregistreuse
{
    partial class fEcranClient
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
            tb_ecranClient = new TextBox();
            SuspendLayout();
            // 
            // tb_ecranClient
            // 
            tb_ecranClient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_ecranClient.Location = new Point(12, 12);
            tb_ecranClient.Name = "tb_ecranClient";
            tb_ecranClient.Size = new Size(958, 27);
            tb_ecranClient.TabIndex = 0;
            tb_ecranClient.Text = "Bienvenue";
            // 
            // fEcranClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 53);
            Controls.Add(tb_ecranClient);
            Location = new Point(460, 123);
            MaximumSize = new Size(1300, 100);
            MinimumSize = new Size(600, 100);
            Name = "fEcranClient";
            StartPosition = FormStartPosition.Manual;
            Text = "Ecran client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_ecranClient;
    }
}