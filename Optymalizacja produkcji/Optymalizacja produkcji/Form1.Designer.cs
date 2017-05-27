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
            this.BUTTON_StartSimplex = new System.Windows.Forms.Button();
            this.BUTTON_StartSimAnno = new System.Windows.Forms.Button();
            this.BUTTON_ShowSimplex = new System.Windows.Forms.Button();
            this.BUTTON_ShowSimAnno = new System.Windows.Forms.Button();
            this.BUTTON_ShowComparsion = new System.Windows.Forms.Button();
            this.BUTTON_ShowTable = new System.Windows.Forms.Button();
            this.RADIO_AllInstances = new System.Windows.Forms.RadioButton();
            this.RADIO_OneInstance = new System.Windows.Forms.RadioButton();
            this.COMBOBOX_WhichInstance = new System.Windows.Forms.ComboBox();
            this.LABEL_Title2 = new System.Windows.Forms.Label();
            this.LABEL_Title1 = new System.Windows.Forms.Label();
            this.BUTTON_Save = new System.Windows.Forms.Button();
            this.CHECHBOX_AddConditions = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RTB_Table
            // 
            this.RTB_Table.Location = new System.Drawing.Point(475, 57);
            this.RTB_Table.Name = "RTB_Table";
            this.RTB_Table.Size = new System.Drawing.Size(458, 338);
            this.RTB_Table.TabIndex = 0;
            this.RTB_Table.Text = "";
            this.RTB_Table.TextChanged += new System.EventHandler(this.RTB_Table_TextChanged);
            // 
            // BUTTON_GenerateTable
            // 
            this.BUTTON_GenerateTable.Location = new System.Drawing.Point(322, 57);
            this.BUTTON_GenerateTable.Name = "BUTTON_GenerateTable";
            this.BUTTON_GenerateTable.Size = new System.Drawing.Size(129, 63);
            this.BUTTON_GenerateTable.TabIndex = 1;
            this.BUTTON_GenerateTable.Text = "Generuj tabelę problemów";
            this.BUTTON_GenerateTable.UseVisualStyleBackColor = true;
            this.BUTTON_GenerateTable.Click += new System.EventHandler(this.BUTTON_GenerateTable_Click);
            // 
            // BUTTON_StartSimplex
            // 
            this.BUTTON_StartSimplex.Location = new System.Drawing.Point(322, 159);
            this.BUTTON_StartSimplex.Name = "BUTTON_StartSimplex";
            this.BUTTON_StartSimplex.Size = new System.Drawing.Size(129, 63);
            this.BUTTON_StartSimplex.TabIndex = 2;
            this.BUTTON_StartSimplex.Text = "Wylicz metodą Simplex";
            this.BUTTON_StartSimplex.UseVisualStyleBackColor = true;
            this.BUTTON_StartSimplex.Click += new System.EventHandler(this.BUTTON_StartSimplex_Click);
            // 
            // BUTTON_StartSimAnno
            // 
            this.BUTTON_StartSimAnno.Location = new System.Drawing.Point(322, 228);
            this.BUTTON_StartSimAnno.Name = "BUTTON_StartSimAnno";
            this.BUTTON_StartSimAnno.Size = new System.Drawing.Size(129, 63);
            this.BUTTON_StartSimAnno.TabIndex = 3;
            this.BUTTON_StartSimAnno.Text = "Wylicz Symulowanym Wyżarzaniem";
            this.BUTTON_StartSimAnno.UseVisualStyleBackColor = true;
            this.BUTTON_StartSimAnno.Click += new System.EventHandler(this.BUTTON_StartSimAnno_Click);
            // 
            // BUTTON_ShowSimplex
            // 
            this.BUTTON_ShowSimplex.Location = new System.Drawing.Point(476, 0);
            this.BUTTON_ShowSimplex.Name = "BUTTON_ShowSimplex";
            this.BUTTON_ShowSimplex.Size = new System.Drawing.Size(149, 51);
            this.BUTTON_ShowSimplex.TabIndex = 4;
            this.BUTTON_ShowSimplex.Text = "Wyświetl wyliczenia Simplex";
            this.BUTTON_ShowSimplex.UseVisualStyleBackColor = true;
            // 
            // BUTTON_ShowSimAnno
            // 
            this.BUTTON_ShowSimAnno.Location = new System.Drawing.Point(631, 0);
            this.BUTTON_ShowSimAnno.Name = "BUTTON_ShowSimAnno";
            this.BUTTON_ShowSimAnno.Size = new System.Drawing.Size(150, 51);
            this.BUTTON_ShowSimAnno.TabIndex = 5;
            this.BUTTON_ShowSimAnno.Text = "Wyświetl wyliczenia Sym. Wyżarz.";
            this.BUTTON_ShowSimAnno.UseVisualStyleBackColor = true;
            // 
            // BUTTON_ShowComparsion
            // 
            this.BUTTON_ShowComparsion.Location = new System.Drawing.Point(787, 0);
            this.BUTTON_ShowComparsion.Name = "BUTTON_ShowComparsion";
            this.BUTTON_ShowComparsion.Size = new System.Drawing.Size(150, 51);
            this.BUTTON_ShowComparsion.TabIndex = 6;
            this.BUTTON_ShowComparsion.Text = "Wyświetl porównanie wyników";
            this.BUTTON_ShowComparsion.UseVisualStyleBackColor = true;
            // 
            // BUTTON_ShowTable
            // 
            this.BUTTON_ShowTable.Location = new System.Drawing.Point(476, 401);
            this.BUTTON_ShowTable.Name = "BUTTON_ShowTable";
            this.BUTTON_ShowTable.Size = new System.Drawing.Size(130, 48);
            this.BUTTON_ShowTable.TabIndex = 7;
            this.BUTTON_ShowTable.Text = "Wyświetl tabelę";
            this.BUTTON_ShowTable.UseVisualStyleBackColor = true;
            this.BUTTON_ShowTable.Click += new System.EventHandler(this.BUTTON_ShowTable_Click);
            // 
            // RADIO_AllInstances
            // 
            this.RADIO_AllInstances.AutoSize = true;
            this.RADIO_AllInstances.Location = new System.Drawing.Point(612, 401);
            this.RADIO_AllInstances.Name = "RADIO_AllInstances";
            this.RADIO_AllInstances.Size = new System.Drawing.Size(92, 21);
            this.RADIO_AllInstances.TabIndex = 8;
            this.RADIO_AllInstances.TabStop = true;
            this.RADIO_AllInstances.Text = "Wszystkie";
            this.RADIO_AllInstances.UseVisualStyleBackColor = true;
            // 
            // RADIO_OneInstance
            // 
            this.RADIO_OneInstance.AutoSize = true;
            this.RADIO_OneInstance.Location = new System.Drawing.Point(612, 428);
            this.RADIO_OneInstance.Name = "RADIO_OneInstance";
            this.RADIO_OneInstance.Size = new System.Drawing.Size(68, 21);
            this.RADIO_OneInstance.TabIndex = 9;
            this.RADIO_OneInstance.TabStop = true;
            this.RADIO_OneInstance.Text = "Jedna";
            this.RADIO_OneInstance.UseVisualStyleBackColor = true;
            // 
            // COMBOBOX_WhichInstance
            // 
            this.COMBOBOX_WhichInstance.FormattingEnabled = true;
            this.COMBOBOX_WhichInstance.Location = new System.Drawing.Point(686, 425);
            this.COMBOBOX_WhichInstance.Name = "COMBOBOX_WhichInstance";
            this.COMBOBOX_WhichInstance.Size = new System.Drawing.Size(95, 24);
            this.COMBOBOX_WhichInstance.TabIndex = 10;
            // 
            // LABEL_Title2
            // 
            this.LABEL_Title2.AutoSize = true;
            this.LABEL_Title2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LABEL_Title2.Location = new System.Drawing.Point(12, 57);
            this.LABEL_Title2.Name = "LABEL_Title2";
            this.LABEL_Title2.Size = new System.Drawing.Size(212, 20);
            this.LABEL_Title2.TabIndex = 11;
            this.LABEL_Title2.Text = "MAKSYMALIZACJA ZYSKÓW";
            // 
            // LABEL_Title1
            // 
            this.LABEL_Title1.AutoSize = true;
            this.LABEL_Title1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LABEL_Title1.ForeColor = System.Drawing.Color.Chocolate;
            this.LABEL_Title1.Location = new System.Drawing.Point(12, 12);
            this.LABEL_Title1.Name = "LABEL_Title1";
            this.LABEL_Title1.Size = new System.Drawing.Size(277, 39);
            this.LABEL_Title1.TabIndex = 12;
            this.LABEL_Title1.Text = "PRODUKCJA PIWA";
            // 
            // BUTTON_Save
            // 
            this.BUTTON_Save.Location = new System.Drawing.Point(787, 399);
            this.BUTTON_Save.Name = "BUTTON_Save";
            this.BUTTON_Save.Size = new System.Drawing.Size(137, 50);
            this.BUTTON_Save.TabIndex = 13;
            this.BUTTON_Save.Text = "Zapisz Tabelę";
            this.BUTTON_Save.UseVisualStyleBackColor = true;
            // 
            // CHECHBOX_AddConditions
            // 
            this.CHECHBOX_AddConditions.AutoSize = true;
            this.CHECHBOX_AddConditions.Location = new System.Drawing.Point(322, 28);
            this.CHECHBOX_AddConditions.Name = "CHECHBOX_AddConditions";
            this.CHECHBOX_AddConditions.Size = new System.Drawing.Size(133, 21);
            this.CHECHBOX_AddConditions.TabIndex = 14;
            this.CHECHBOX_AddConditions.Text = "Własne war. los.";
            this.CHECHBOX_AddConditions.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(936, 455);
            this.Controls.Add(this.CHECHBOX_AddConditions);
            this.Controls.Add(this.BUTTON_Save);
            this.Controls.Add(this.LABEL_Title1);
            this.Controls.Add(this.LABEL_Title2);
            this.Controls.Add(this.COMBOBOX_WhichInstance);
            this.Controls.Add(this.RADIO_OneInstance);
            this.Controls.Add(this.RADIO_AllInstances);
            this.Controls.Add(this.BUTTON_ShowTable);
            this.Controls.Add(this.BUTTON_ShowComparsion);
            this.Controls.Add(this.BUTTON_ShowSimAnno);
            this.Controls.Add(this.BUTTON_ShowSimplex);
            this.Controls.Add(this.BUTTON_StartSimAnno);
            this.Controls.Add(this.BUTTON_StartSimplex);
            this.Controls.Add(this.BUTTON_GenerateTable);
            this.Controls.Add(this.RTB_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Badania Operacyjne - Produkcja Piwa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Table;
        private System.Windows.Forms.Button BUTTON_GenerateTable;
        private System.Windows.Forms.Button BUTTON_StartSimplex;
        private System.Windows.Forms.Button BUTTON_StartSimAnno;
        private System.Windows.Forms.Button BUTTON_ShowSimplex;
        private System.Windows.Forms.Button BUTTON_ShowSimAnno;
        private System.Windows.Forms.Button BUTTON_ShowComparsion;
        private System.Windows.Forms.Button BUTTON_ShowTable;
        private System.Windows.Forms.RadioButton RADIO_AllInstances;
        private System.Windows.Forms.RadioButton RADIO_OneInstance;
        private System.Windows.Forms.ComboBox COMBOBOX_WhichInstance;
        private System.Windows.Forms.Label LABEL_Title2;
        private System.Windows.Forms.Label LABEL_Title1;
        private System.Windows.Forms.Button BUTTON_Save;
        private System.Windows.Forms.CheckBox CHECHBOX_AddConditions;
    }
}

