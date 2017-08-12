namespace UnitConverter
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.dgvConverters = new System.Windows.Forms.DataGridView();
            this.dgvConvertersConvertColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConverters)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.txtInput, 0, 2);
            this.tlpMain.Controls.Add(this.txtResult, 2, 2);
            this.tlpMain.Controls.Add(this.lblMainTitle, 0, 0);
            this.tlpMain.Controls.Add(this.lblInputTitle, 0, 1);
            this.tlpMain.Controls.Add(this.lblResultTitle, 2, 1);
            this.tlpMain.Controls.Add(this.dgvConverters, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(12, 0, 12, 12);
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(778, 544);
            this.tlpMain.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(15, 109);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(239, 420);
            this.txtInput.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(524, 109);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(239, 420);
            this.txtResult.TabIndex = 20;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMainTitle.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lblMainTitle, 3);
            this.lblMainTitle.Location = new System.Drawing.Point(353, 24);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(3, 24, 3, 24);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(72, 20);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "MainTitle";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Location = new System.Drawing.Point(97, 80);
            this.lblInputTitle.Margin = new System.Windows.Forms.Padding(3, 12, 3, 6);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(75, 20);
            this.lblInputTitle.TabIndex = 2;
            this.lblInputTitle.Text = "InputTitle";
            this.lblInputTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Location = new System.Drawing.Point(601, 80);
            this.lblResultTitle.Margin = new System.Windows.Forms.Padding(3, 12, 3, 6);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(84, 20);
            this.lblResultTitle.TabIndex = 2;
            this.lblResultTitle.Text = "ResultTitle";
            this.lblResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvConverters
            // 
            this.dgvConverters.AllowUserToAddRows = false;
            this.dgvConverters.AllowUserToDeleteRows = false;
            this.dgvConverters.AllowUserToResizeColumns = false;
            this.dgvConverters.AllowUserToResizeRows = false;
            this.dgvConverters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvConverters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConverters.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConverters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConverters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConverters.ColumnHeadersVisible = false;
            this.dgvConverters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvConvertersConvertColumn});
            this.dgvConverters.Location = new System.Drawing.Point(269, 109);
            this.dgvConverters.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.dgvConverters.MinimumSize = new System.Drawing.Size(200, 0);
            this.dgvConverters.Name = "dgvConverters";
            this.dgvConverters.ReadOnly = true;
            this.dgvConverters.RowHeadersVisible = false;
            this.dgvConverters.RowTemplate.Height = 28;
            this.dgvConverters.Size = new System.Drawing.Size(240, 150);
            this.dgvConverters.TabIndex = 10;
            // 
            // dgvConvertersConvertColumn
            // 
            this.dgvConvertersConvertColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvConvertersConvertColumn.DataPropertyName = "Title";
            this.dgvConvertersConvertColumn.HeaderText = "Column1";
            this.dgvConvertersConvertColumn.MinimumWidth = 40;
            this.dgvConvertersConvertColumn.Name = "dgvConvertersConvertColumn";
            this.dgvConvertersConvertColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "WindowTitle";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConverters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.DataGridView dgvConverters;
        private System.Windows.Forms.DataGridViewButtonColumn dgvConvertersConvertColumn;
    }
}