namespace UnitConverter
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dgvConverters.CellClick += DgvConverters_CellClick;
            dgvConverters.SelectionChanged += DgvConverters_SelectionChanged;
            dgvConverters.AutoGenerateColumns = false;
            dgvConverters.CurrentCell = null;
            dgvConverters.BorderStyle = BorderStyle.None;

            var actionTitles = new[]
            {
                new { Title = "Yards to Meters" },
                new { Title = "Inches To Centimeters" }
            };

            dgvConverters.DataSource = actionTitles.ToList();
        }

        private void DgvConverters_SelectionChanged(object sender, EventArgs e)
        {
            var datagridview = (DataGridView)sender;
            datagridview.ClearSelection();
        }

        private void DgvConverters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var datagridview = (DataGridView)sender;
            var cell = datagridview.Rows[e.RowIndex].Cells[e.ColumnIndex];
            txtResult.Text = string.Empty;
            txtResult.Text = Convert(cell.Value.ToString(), txtInput.Text);
        }

        private string Convert(string conversionType, string values)
        {
            switch (conversionType)
            {
                case "Yards to Meters":
                    return ConvertYardsToMeters(values);

                case "Inches To Centimeters":
                    return ConvertInchesToCentimeters(values);
            }

            return "";
        }

        private string ConvertInchesToCentimeters(string values)
        {
            var converter = new UnitConverter();
            return converter.InchesToCentimeters(values).Aggregate(new StringBuilder(),
                                                                   (builder, result) => builder.AppendLine(result),
                                                                   builder => builder.ToString());
        }

        private string ConvertYardsToMeters(string values)
        {
            var converter = new UnitConverter();
            return converter.YardsToMeters(values).Aggregate(new StringBuilder(),
                                                             (builder, result) => builder.AppendLine(result),
                                                             builder => builder.ToString());
        }
    }
}
