namespace Optymalizacja_produkcji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RTB_Table = new System.Windows.Forms.RichTextBox();
            this.BUTTON_GenerateTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB_Table
            // 
            this.RTB_Table.Location = new System.Drawing.Point(476, 15);
            this.RTB_Table.Name = "RTB_Table";
            this.RTB_Table.Size = new System.Drawing.Size(449, 395);
            this.RTB_Table.TabIndex = 0;
            this.RTB_Table.Text = "";
            // 
            // BUTTON_GenerateTable
            // 
            this.BUTTON_GenerateTable.Location = new System.Drawing.Point(476, 416);
            this.BUTTON_GenerateTable.Name = "BUTTON_GenerateTable";
            this.BUTTON_GenerateTable.Size = new System.Drawing.Size(177, 38);
            this.BUTTON_GenerateTable.TabIndex = 1;
            this.BUTTON_GenerateTable.Text = "Generuj Tabele";
            this.BUTTON_GenerateTable.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 455);
            this.Controls.Add(this.BUTTON_GenerateTable);
            this.Controls.Add(this.RTB_Table);
            this.Name = "MainForm";
            this.Text = "Badania Operacyjne - Produkcja Piwa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Table;
        private System.Windows.Forms.Button BUTTON_GenerateTable;
    }
}

