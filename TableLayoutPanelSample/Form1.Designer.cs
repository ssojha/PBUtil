namespace TableLayoutPanelSample
{
    partial class Form1
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
            this.tblPnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlDataEntry = new System.Windows.Forms.TableLayoutPanel();
            this.ToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rbtnsuccessreq = new System.Windows.Forms.RadioButton();
            this.rbtnfailedreq = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbtnallreq = new System.Windows.Forms.RadioButton();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReqTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ListReqGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tblPnlMain.SuspendLayout();
            this.tblPnlDataEntry.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListReqGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPnlMain
            // 
            this.tblPnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlMain.ColumnCount = 1;
            this.tblPnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlMain.Controls.Add(this.tblPnlDataEntry, 0, 0);
            this.tblPnlMain.Controls.Add(this.ListReqGridView, 0, 1);
            this.tblPnlMain.Controls.Add(this.button2, 0, 2);
            this.tblPnlMain.Location = new System.Drawing.Point(9, 13);
            this.tblPnlMain.Name = "tblPnlMain";
            this.tblPnlMain.RowCount = 3;
            this.tblPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlMain.Size = new System.Drawing.Size(838, 403);
            this.tblPnlMain.TabIndex = 0;
            // 
            // tblPnlDataEntry
            // 
            this.tblPnlDataEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tblPnlDataEntry.AutoSize = true;
            this.tblPnlDataEntry.ColumnCount = 5;
            this.tblPnlMain.SetColumnSpan(this.tblPnlDataEntry, 2);
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.20527F));
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.79473F));
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tblPnlDataEntry.Controls.Add(this.ToTimePicker, 4, 1);
            this.tblPnlDataEntry.Controls.Add(this.FromTimePicker, 4, 0);
            this.tblPnlDataEntry.Controls.Add(this.ToDatePicker, 3, 1);
            this.tblPnlDataEntry.Controls.Add(this.rbtnsuccessreq, 1, 2);
            this.tblPnlDataEntry.Controls.Add(this.rbtnfailedreq, 1, 1);
            this.tblPnlDataEntry.Controls.Add(this.label1, 0, 0);
            this.tblPnlDataEntry.Controls.Add(this.label2, 0, 1);
            this.tblPnlDataEntry.Controls.Add(this.label3, 0, 2);
            this.tblPnlDataEntry.Controls.Add(this.label4, 2, 0);
            this.tblPnlDataEntry.Controls.Add(this.label5, 2, 1);
            this.tblPnlDataEntry.Controls.Add(this.label6, 2, 2);
            this.tblPnlDataEntry.Controls.Add(this.tableLayoutPanel1, 3, 3);
            this.tblPnlDataEntry.Controls.Add(this.rbtnallreq, 1, 0);
            this.tblPnlDataEntry.Controls.Add(this.FromDatePicker, 3, 0);
            this.tblPnlDataEntry.Controls.Add(this.ReqTypeComboBox, 3, 2);
            this.tblPnlDataEntry.Location = new System.Drawing.Point(3, 3);
            this.tblPnlDataEntry.Name = "tblPnlDataEntry";
            this.tblPnlDataEntry.RowCount = 4;
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlDataEntry.Size = new System.Drawing.Size(811, 116);
            this.tblPnlDataEntry.TabIndex = 0;
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ToTimePicker.Location = new System.Drawing.Point(692, 29);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.ShowUpDown = true;
            this.ToTimePicker.Size = new System.Drawing.Size(105, 20);
            this.ToTimePicker.TabIndex = 21;
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FromTimePicker.Location = new System.Drawing.Point(692, 3);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.ShowUpDown = true;
            this.FromTimePicker.Size = new System.Drawing.Size(105, 20);
            this.FromTimePicker.TabIndex = 20;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Location = new System.Drawing.Point(486, 29);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ToDatePicker.TabIndex = 19;
            // 
            // rbtnsuccessreq
            // 
            this.rbtnsuccessreq.AutoSize = true;
            this.rbtnsuccessreq.Location = new System.Drawing.Point(79, 55);
            this.rbtnsuccessreq.Name = "rbtnsuccessreq";
            this.rbtnsuccessreq.Size = new System.Drawing.Size(14, 13);
            this.rbtnsuccessreq.TabIndex = 17;
            this.rbtnsuccessreq.TabStop = true;
            this.rbtnsuccessreq.UseVisualStyleBackColor = true;
            // 
            // rbtnfailedreq
            // 
            this.rbtnfailedreq.AutoSize = true;
            this.rbtnfailedreq.Location = new System.Drawing.Point(79, 29);
            this.rbtnfailedreq.Name = "rbtnfailedreq";
            this.rbtnfailedreq.Size = new System.Drawing.Size(14, 13);
            this.rbtnfailedreq.TabIndex = 15;
            this.rbtnfailedreq.TabStop = true;
            this.rbtnfailedreq.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Request";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Failed Request";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Success Request";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "From Date/Time";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "To Date/Time";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Request Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(486, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 30);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowDrop = true;
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Location = new System.Drawing.Point(41, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(122, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rbtnallreq
            // 
            this.rbtnallreq.AutoSize = true;
            this.rbtnallreq.Location = new System.Drawing.Point(79, 3);
            this.rbtnallreq.Name = "rbtnallreq";
            this.rbtnallreq.Size = new System.Drawing.Size(14, 13);
            this.rbtnallreq.TabIndex = 13;
            this.rbtnallreq.TabStop = true;
            this.rbtnallreq.UseVisualStyleBackColor = true;
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Location = new System.Drawing.Point(486, 3);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.FromDatePicker.TabIndex = 0;
            // 
            // ReqTypeComboBox
            // 
            this.ReqTypeComboBox.FormattingEnabled = true;
            this.ReqTypeComboBox.Items.AddRange(new object[] {
            "CreateCustomer"});
            this.ReqTypeComboBox.Location = new System.Drawing.Point(486, 55);
            this.ReqTypeComboBox.Name = "ReqTypeComboBox";
            this.ReqTypeComboBox.Size = new System.Drawing.Size(121, 22);
            this.ReqTypeComboBox.TabIndex = 22;
            // 
            // ListReqGridView
            // 
            this.ListReqGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListReqGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListReqGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListReqGridView.Location = new System.Drawing.Point(3, 125);
            this.ListReqGridView.Name = "ListReqGridView";
            this.ListReqGridView.Size = new System.Drawing.Size(832, 244);
            this.ListReqGridView.TabIndex = 1;
            this.ListReqGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListReqGridView_CellContentClick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(760, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 423);
            this.Controls.Add(this.tblPnlMain);
            this.Font = new System.Drawing.Font("Poor Richard", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(677, 366);
            this.Name = "Form1";
            this.Text = "Log_Analyzer";
            this.tblPnlMain.ResumeLayout(false);
            this.tblPnlMain.PerformLayout();
            this.tblPnlDataEntry.ResumeLayout(false);
            this.tblPnlDataEntry.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListReqGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPnlMain;
        private System.Windows.Forms.TableLayoutPanel tblPnlDataEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView ListReqGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnallreq;
        private System.Windows.Forms.RadioButton rbtnfailedreq;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.RadioButton rbtnsuccessreq;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.DateTimePicker ToTimePicker;
        private System.Windows.Forms.DateTimePicker FromTimePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox ReqTypeComboBox;
    }
}

