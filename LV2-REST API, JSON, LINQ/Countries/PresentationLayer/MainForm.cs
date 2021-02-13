using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Countries;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            _tableBindingSource.DataSource = _countryRepository.GetCountries();
        }
        private static CountryRepository _countryRepository = new CountryRepository();
        private BindingSource _tableBindingSource = new BindingSource();
        public List<Country> countries = _countryRepository.GetCountries();
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewCountries.DataSource = _tableBindingSource;
            var regions = _countryRepository.GetRegions();
            foreach (string region in regions)
            {
                if (region != "/")
                {
                    comboBoxRegions.Items.Add(region);
                    comboBoxInputRegion.Items.Add(region);
                }
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            _tableBindingSource.DataSource = _countryRepository.Filter(countries, comboBoxRegions.Text, textBoxName.Text, textBoxCapital.Text, Convert.ToInt32(numericUpDownPopulationMin.Value), Convert.ToInt32(numericUpDownPopulationMax.Value));
            string filterMessage = "Odabrali ste filtriranje po: ";
            if (!String.IsNullOrWhiteSpace(comboBoxRegions.Text))
            {
                filterMessage = filterMessage + "regiji;";
            }
            if (!String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                filterMessage = filterMessage + "imenu drzave;";
            }
            if (!String.IsNullOrWhiteSpace(textBoxCapital.Text))
            {
                filterMessage = filterMessage + "imenu glavnog grada;";
            }
            if (numericUpDownPopulationMin.Value >= 0)
            {
                filterMessage = filterMessage + "minimalnoj populaciji;";
            }
            if (numericUpDownPopulationMax.Value != 0)
            {
                filterMessage = filterMessage + "maksimalnoj populaciji;";
            }
            MessageBox.Show(filterMessage, "Filtriranje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSaveCountry_Click(object sender, EventArgs e)
        {
            countries.Add(new Country
            {
                Code = textBoxInputCode.Text,
                Name = textBoxInputName.Text,
                Capital = textBoxInputCapital.Text,
                Population = Convert.ToInt32(textBoxInputPopulation.Text),
                Area = Convert.ToSingle(textBoxInputArea.Text),
                Region = comboBoxInputRegion.Text
            });
            _tableBindingSource.DataSource = countries;
        }
    }
}
