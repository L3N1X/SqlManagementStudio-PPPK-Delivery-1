namespace Task
{
    partial class ManagementStudioForm
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
            this.tbQueryEditor = new System.Windows.Forms.RichTextBox();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.lbTableColumns = new System.Windows.Forms.ListBox();
            this.lbViews = new System.Windows.Forms.ListBox();
            this.lbViewColumns = new System.Windows.Forms.ListBox();
            this.lbProcedures = new System.Windows.Forms.ListBox();
            this.lbProcedureParams = new System.Windows.Forms.ListBox();
            this.tbMessages = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQueryEditor
            // 
            this.tbQueryEditor.Location = new System.Drawing.Point(12, 38);
            this.tbQueryEditor.Name = "tbQueryEditor";
            this.tbQueryEditor.Size = new System.Drawing.Size(637, 101);
            this.tbQueryEditor.TabIndex = 1;
            this.tbQueryEditor.Text = "";
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(12, 11);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(173, 21);
            this.cbDatabases.TabIndex = 3;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Location = new System.Drawing.Point(191, 9);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(118, 23);
            this.btnExecuteQuery.TabIndex = 4;
            this.btnExecuteQuery.Text = "Exectute query";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.Location = new System.Drawing.Point(657, 38);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(210, 82);
            this.lbTables.TabIndex = 5;
            this.lbTables.SelectedIndexChanged += new System.EventHandler(this.lbTables_SelectedIndexChanged);
            // 
            // lbTableColumns
            // 
            this.lbTableColumns.FormattingEnabled = true;
            this.lbTableColumns.Location = new System.Drawing.Point(657, 126);
            this.lbTableColumns.Name = "lbTableColumns";
            this.lbTableColumns.Size = new System.Drawing.Size(210, 82);
            this.lbTableColumns.TabIndex = 6;
            // 
            // lbViews
            // 
            this.lbViews.FormattingEnabled = true;
            this.lbViews.Location = new System.Drawing.Point(657, 217);
            this.lbViews.Name = "lbViews";
            this.lbViews.Size = new System.Drawing.Size(210, 82);
            this.lbViews.TabIndex = 7;
            this.lbViews.SelectedIndexChanged += new System.EventHandler(this.lbViews_SelectedIndexChanged);
            // 
            // lbViewColumns
            // 
            this.lbViewColumns.FormattingEnabled = true;
            this.lbViewColumns.Location = new System.Drawing.Point(657, 305);
            this.lbViewColumns.Name = "lbViewColumns";
            this.lbViewColumns.Size = new System.Drawing.Size(210, 82);
            this.lbViewColumns.TabIndex = 8;
            // 
            // lbProcedures
            // 
            this.lbProcedures.FormattingEnabled = true;
            this.lbProcedures.Location = new System.Drawing.Point(657, 393);
            this.lbProcedures.Name = "lbProcedures";
            this.lbProcedures.Size = new System.Drawing.Size(210, 82);
            this.lbProcedures.TabIndex = 9;
            this.lbProcedures.SelectedIndexChanged += new System.EventHandler(this.lbProcedures_SelectedIndexChanged);
            // 
            // lbProcedureParams
            // 
            this.lbProcedureParams.FormattingEnabled = true;
            this.lbProcedureParams.Location = new System.Drawing.Point(657, 482);
            this.lbProcedureParams.Name = "lbProcedureParams";
            this.lbProcedureParams.Size = new System.Drawing.Size(210, 82);
            this.lbProcedureParams.TabIndex = 10;
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(11, 164);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.Size = new System.Drawing.Size(637, 35);
            this.tbMessages.TabIndex = 11;
            this.tbMessages.Text = "";
            this.tbMessages.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(873, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Table columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Views";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(873, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "View columns";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(873, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Procedures";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(873, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Procedure params";
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(12, 229);
            this.dgResults.Name = "dgResults";
            this.dgResults.Size = new System.Drawing.Size(636, 329);
            this.dgResults.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Messages";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Results";
            // 
            // ManagementStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 576);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgResults);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.lbProcedureParams);
            this.Controls.Add(this.lbProcedures);
            this.Controls.Add(this.lbViewColumns);
            this.Controls.Add(this.lbViews);
            this.Controls.Add(this.lbTableColumns);
            this.Controls.Add(this.lbTables);
            this.Controls.Add(this.btnExecuteQuery);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.tbQueryEditor);
            this.Name = "ManagementStudioForm";
            this.Text = "ManagementStudioForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagementStudioForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagementStudioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbQueryEditor;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.ListBox lbTableColumns;
        private System.Windows.Forms.ListBox lbViews;
        private System.Windows.Forms.ListBox lbViewColumns;
        private System.Windows.Forms.ListBox lbProcedures;
        private System.Windows.Forms.ListBox lbProcedureParams;
        private System.Windows.Forms.RichTextBox tbMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}