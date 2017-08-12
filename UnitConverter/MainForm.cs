namespace UnitConverter
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private MainViewModel _viewmodel;

        public MainForm(MainViewModel viewmodel)
        {
            InitializeComponent();

            dgvConvertersConvertColumn.DataPropertyName = "Name";
            dgvConverters.CellClick += DgvConverters_CellClick;
            dgvConverters.SelectionChanged += DgvConverters_SelectionChanged;
            dgvConverters.AutoGenerateColumns = false;
            dgvConverters.CurrentCell = null;
            dgvConverters.BorderStyle = BorderStyle.None;

            _viewmodel = viewmodel;
            txtResult.DataBindings.Add("Text", _viewmodel, nameof(_viewmodel.Result), true);
            dgvConverters.DataSource = _viewmodel.Converters;
        }

        private void DgvConverters_SelectionChanged(object sender, EventArgs e)
        {
            var datagridview = (DataGridView)sender;
            datagridview.ClearSelection();
        }

        private void DgvConverters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var datagridview = (DataGridView)sender;
            var converter = (IUnitConverter)datagridview.Rows[e.RowIndex].DataBoundItem;

            _viewmodel.ConvertWith(converter, txtInput.Text);
        }
    }
}
