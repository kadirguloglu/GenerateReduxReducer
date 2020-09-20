namespace GenerateReduxReducer
{
    partial class Master
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
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParam1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParam2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParam3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParam4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rchTypes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rchReducers = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rchActions = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbLogger = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rchImport = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rchImportAction = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rchInitialState = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(98, 6);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(244, 20);
            this.txtMethodName.TabIndex = 0;
            this.txtMethodName.Text = "GetCategoryLangWithCategoryId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Method Name :";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "GET",
            "POST",
            "DELETE",
            "PUT"});
            this.cmbType.Location = new System.Drawing.Point(98, 58);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(244, 21);
            this.cmbType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type :";
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(98, 85);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(244, 20);
            this.txtParam1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parameters";
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(98, 111);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(244, 20);
            this.txtParam2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parameters";
            // 
            // txtParam3
            // 
            this.txtParam3.Location = new System.Drawing.Point(98, 137);
            this.txtParam3.Name = "txtParam3";
            this.txtParam3.Size = new System.Drawing.Size(244, 20);
            this.txtParam3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Parameters";
            // 
            // txtParam4
            // 
            this.txtParam4.Location = new System.Drawing.Point(98, 163);
            this.txtParam4.Name = "txtParam4";
            this.txtParam4.Size = new System.Drawing.Size(244, 20);
            this.txtParam4.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Parameters";
            // 
            // rchTypes
            // 
            this.rchTypes.Location = new System.Drawing.Point(12, 209);
            this.rchTypes.Name = "rchTypes";
            this.rchTypes.Size = new System.Drawing.Size(627, 165);
            this.rchTypes.TabIndex = 3;
            this.rchTypes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "TYPES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(941, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "REDUCERS";
            // 
            // rchReducers
            // 
            this.rchReducers.Location = new System.Drawing.Point(685, 404);
            this.rchReducers.Name = "rchReducers";
            this.rchReducers.Size = new System.Drawing.Size(627, 165);
            this.rchReducers.TabIndex = 3;
            this.rchReducers.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(947, 593);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ACTIONS";
            // 
            // rchActions
            // 
            this.rchActions.Location = new System.Drawing.Point(685, 609);
            this.rchActions.Name = "rchActions";
            this.rchActions.Size = new System.Drawing.Size(627, 165);
            this.rchActions.TabIndex = 3;
            this.rchActions.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtEndpoint
            // 
            this.txtEndpoint.Location = new System.Drawing.Point(98, 32);
            this.txtEndpoint.Name = "txtEndpoint";
            this.txtEndpoint.Size = new System.Drawing.Size(244, 20);
            this.txtEndpoint.TabIndex = 1;
            this.txtEndpoint.Text = "CategoryService";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Endpoint :";
            // 
            // cbLogger
            // 
            this.cbLogger.AutoSize = true;
            this.cbLogger.Location = new System.Drawing.Point(348, 62);
            this.cbLogger.Name = "cbLogger";
            this.cbLogger.Size = new System.Drawing.Size(92, 17);
            this.cbLogger.TabIndex = 7;
            this.cbLogger.Text = "Sentry Logger";
            this.cbLogger.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(950, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "IMPORT";
            // 
            // rchImport
            // 
            this.rchImport.Location = new System.Drawing.Point(685, 209);
            this.rchImport.Name = "rchImport";
            this.rchImport.Size = new System.Drawing.Size(627, 165);
            this.rchImport.TabIndex = 3;
            this.rchImport.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(255, 593);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "IMPORT ACTION";
            // 
            // rchImportAction
            // 
            this.rchImportAction.Location = new System.Drawing.Point(12, 609);
            this.rchImportAction.Name = "rchImportAction";
            this.rchImportAction.Size = new System.Drawing.Size(627, 165);
            this.rchImportAction.TabIndex = 3;
            this.rchImportAction.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "INITIAL STATE";
            // 
            // rchInitialState
            // 
            this.rchInitialState.Location = new System.Drawing.Point(12, 404);
            this.rchInitialState.Name = "rchInitialState";
            this.rchInitialState.Size = new System.Drawing.Size(627, 165);
            this.rchInitialState.TabIndex = 3;
            this.rchInitialState.Text = "";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 825);
            this.Controls.Add(this.cbLogger);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rchInitialState);
            this.Controls.Add(this.rchImportAction);
            this.Controls.Add(this.rchImport);
            this.Controls.Add(this.rchActions);
            this.Controls.Add(this.rchReducers);
            this.Controls.Add(this.rchTypes);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParam4);
            this.Controls.Add(this.txtParam3);
            this.Controls.Add(this.txtParam2);
            this.Controls.Add(this.txtParam1);
            this.Controls.Add(this.txtEndpoint);
            this.Controls.Add(this.txtMethodName);
            this.Name = "Master";
            this.Text = "Master";
            this.Load += new System.EventHandler(this.Master_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParam1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParam3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParam4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rchTypes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rchReducers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rchActions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbLogger;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchImport;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rchImportAction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rchInitialState;
    }
}

