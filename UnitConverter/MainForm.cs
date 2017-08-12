namespace UnitConverter
{
    using System;
    using System.Windows.Forms;
    using UnitConverter.Resources;

    public partial class MainForm : Form
    {
        private MainViewModel _viewmodel;

        public MainForm(MainViewModel viewmodel)
        {
            InitializeComponent();
            InitializeTexts();
            InitializeDataGridViewForConverters();
            InitializeDataBindings(viewmodel);
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

        private void InitializeDataBindings(MainViewModel viewmodel)
        {
            _viewmodel = viewmodel;
            txtResult.DataBindings.Add("Text", _viewmodel, nameof(_viewmodel.Result), true);
            dgvConverters.DataSource = _viewmodel.Converters;
        }

        private void InitializeTexts()
        {
            Text = ControlTexts.WindowTitle;
            lblMainTitle.Text = ControlTexts.MainTitle;
            lblInputTitle.Text = ControlTexts.InputTitle;
            lblResultTitle.Text = ControlTexts.ResultTitle;
        }

        private void InitializeDataGridViewForConverters()
        {
            dgvConvertersConvertColumn.DataPropertyName = "Name";
            dgvConverters.CellClick += DgvConverters_CellClick;
            dgvConverters.SelectionChanged += DgvConverters_SelectionChanged;
            dgvConverters.AutoGenerateColumns = false;
            dgvConverters.CurrentCell = null;
            dgvConverters.BorderStyle = BorderStyle.None;
        }
    }
}
