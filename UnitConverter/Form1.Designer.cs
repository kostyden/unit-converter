﻿namespace UnitConverter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DataGridViewConverterActions = new System.Windows.Forms.DataGridView();
            this.DataGridViewConverterActionsColumnAction = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewConverterActions)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(18, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 433);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input values:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Convert values from input box, seperated by a new line, from one unit to another";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yards to Meters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Location = new System.Drawing.Point(456, 111);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 433);
            this.textBox2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Result values:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 155);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Inches To Centimeters";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataGridViewConverterActions
            // 
            this.DataGridViewConverterActions.AllowUserToAddRows = false;
            this.DataGridViewConverterActions.AllowUserToDeleteRows = false;
            this.DataGridViewConverterActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewConverterActions.ColumnHeadersVisible = false;
            this.DataGridViewConverterActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewConverterActionsColumnAction});
            this.DataGridViewConverterActions.Location = new System.Drawing.Point(242, 214);
            this.DataGridViewConverterActions.Name = "DataGridViewConverterActions";
            this.DataGridViewConverterActions.ReadOnly = true;
            this.DataGridViewConverterActions.RowHeadersVisible = false;
            this.DataGridViewConverterActions.RowTemplate.Height = 28;
            this.DataGridViewConverterActions.Size = new System.Drawing.Size(206, 150);
            this.DataGridViewConverterActions.TabIndex = 4;
            // 
            // DataGridViewConverterActionsColumnAction
            // 
            this.DataGridViewConverterActionsColumnAction.DataPropertyName = "Title";
            this.DataGridViewConverterActionsColumnAction.HeaderText = "Column1";
            this.DataGridViewConverterActionsColumnAction.Name = "DataGridViewConverterActionsColumnAction";
            this.DataGridViewConverterActionsColumnAction.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 565);
            this.Controls.Add(this.DataGridViewConverterActions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewConverterActions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DataGridViewConverterActions;
        private System.Windows.Forms.DataGridViewButtonColumn DataGridViewConverterActionsColumnAction;
    }
}

