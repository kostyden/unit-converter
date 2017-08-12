using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnitConverter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

            DataGridViewConverterActions.AutoGenerateColumns = false;
            var actions = new[]
            {
                new ConverterAction { Title = "One", Convert = ConvertValues},
                new ConverterAction { Title = "Two", Convert = ConvertValues},
                new ConverterAction { Title = "Three", Convert = ConvertValues}
            };

            DataGridViewConverterActions.DataSource = actions.ToList();
            DataGridViewConverterActions.CellClick += DataGridViewConverterActions_CellClick;
		}

        private void DataGridViewConverterActions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var datagridview = (DataGridView)sender;
            var row = datagridview.Rows[e.RowIndex];
            var converter = (ConverterAction)row.DataBoundItem;
            textBox2.Text = converter.Convert(textBox1.Text);
        }

        private string ConvertValues(string values)
        {
            var converter = new UnitConverter();
            return converter.InchesToCentimeters(values).Aggregate(new StringBuilder(),
                                                                   (builder, result) => builder.AppendLine(result),
                                                                   builder => builder.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
		{
			var converter = new UnitConverter();

			textBox2.Text = "";

			for (int i = 0; i < converter.YardsToMeters(textBox1.Text).Count(); i++)
			{
				textBox2.Text += converter.YardsToMeters(textBox1.Text)[i] + Environment.NewLine;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var converter = new UnitConverter();

			textBox2.Text = "";

			for (int i = 0; i < converter.YardsToMeters(textBox1.Text).Count(); i++)
			{
				textBox2.Text += converter.InchesToCentimeters(textBox1.Text)[i] + Environment.NewLine;
			}

            using (var form = new MainForm())
            {
                form.ShowDialog();
            }
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
		}
	}

    public class ConverterAction
    {
        public string Title { get; set; }

        public Func<string, string> Convert { get; set; }
    }
}
