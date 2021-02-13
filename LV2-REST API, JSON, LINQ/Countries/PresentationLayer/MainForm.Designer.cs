namespace PresentationLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelMinPopulation = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCapital = new System.Windows.Forms.Label();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPopulationMax = new System.Windows.Forms.NumericUpDown();
            this.labelRegion = new System.Windows.Forms.Label();
            this.comboBoxRegions = new System.Windows.Forms.ComboBox();
            this.numericUpDownPopulationMin = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePregled = new System.Windows.Forms.TabPage();
            this.tabPageUnos = new System.Windows.Forms.TabPage();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelKontinent = new System.Windows.Forms.Label();
            this.labelPovrsina = new System.Windows.Forms.Label();
            this.labelBrojStanovnika = new System.Windows.Forms.Label();
            this.labelGlavniGrad = new System.Windows.Forms.Label();
            this.labelKod = new System.Windows.Forms.Label();
            this.buttonSaveCountry = new System.Windows.Forms.Button();
            this.comboBoxInputRegion = new System.Windows.Forms.ComboBox();
            this.textBoxInputArea = new System.Windows.Forms.TextBox();
            this.textBoxInputPopulation = new System.Windows.Forms.TextBox();
            this.textBoxInputCapital = new System.Windows.Forms.TextBox();
            this.textBoxInputName = new System.Windows.Forms.TextBox();
            this.textBoxInputCode = new System.Windows.Forms.TextBox();
            this.tabPageKartaSvijeta = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.groupBoxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationMin)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePregled.SuspendLayout();
            this.tabPageUnos.SuspendLayout();
            this.tabPageKartaSvijeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.pip,
            this.Capital,
            this.Population,
            this.Area,
            this.Region});
            this.dataGridViewCountries.Location = new System.Drawing.Point(261, 29);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.Size = new System.Drawing.Size(700, 250);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // pip
            // 
            this.pip.DataPropertyName = "name";
            this.pip.HeaderText = "Name";
            this.pip.Name = "pip";
            // 
            // Capital
            // 
            this.Capital.DataPropertyName = "capital";
            this.Capital.HeaderText = "Capital";
            this.Capital.Name = "Capital";
            // 
            // Population
            // 
            this.Population.DataPropertyName = "population";
            this.Population.HeaderText = "Population";
            this.Population.Name = "Population";
            // 
            // Area
            // 
            this.Area.DataPropertyName = "area";
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            // 
            // Region
            // 
            this.Region.DataPropertyName = "region";
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.label5);
            this.groupBoxActions.Controls.Add(this.buttonFilter);
            this.groupBoxActions.Controls.Add(this.labelMinPopulation);
            this.groupBoxActions.Controls.Add(this.textBoxName);
            this.groupBoxActions.Controls.Add(this.labelCapital);
            this.groupBoxActions.Controls.Add(this.textBoxCapital);
            this.groupBoxActions.Controls.Add(this.label2);
            this.groupBoxActions.Controls.Add(this.numericUpDownPopulationMax);
            this.groupBoxActions.Controls.Add(this.labelRegion);
            this.groupBoxActions.Controls.Add(this.comboBoxRegions);
            this.groupBoxActions.Controls.Add(this.numericUpDownPopulationMin);
            this.groupBoxActions.Location = new System.Drawing.Point(10, 23);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(230, 257);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Max population";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(15, 200);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(200, 30);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "FILTRIRAJ";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelMinPopulation
            // 
            this.labelMinPopulation.AutoSize = true;
            this.labelMinPopulation.Location = new System.Drawing.Point(1, 127);
            this.labelMinPopulation.Name = "labelMinPopulation";
            this.labelMinPopulation.Size = new System.Drawing.Size(76, 13);
            this.labelMinPopulation.TabIndex = 6;
            this.labelMinPopulation.Text = "Min population";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(84, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(26, 93);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(39, 13);
            this.labelCapital.TabIndex = 5;
            this.labelCapital.Text = "Capital";
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(84, 90);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(140, 20);
            this.textBoxCapital.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country Name";
            // 
            // numericUpDownPopulationMax
            // 
            this.numericUpDownPopulationMax.Location = new System.Drawing.Point(84, 160);
            this.numericUpDownPopulationMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPopulationMax.Name = "numericUpDownPopulationMax";
            this.numericUpDownPopulationMax.Size = new System.Drawing.Size(140, 20);
            this.numericUpDownPopulationMax.TabIndex = 4;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(26, 22);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(41, 13);
            this.labelRegion.TabIndex = 3;
            this.labelRegion.Text = "Region";
            // 
            // comboBoxRegions
            // 
            this.comboBoxRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegions.FormattingEnabled = true;
            this.comboBoxRegions.Location = new System.Drawing.Point(84, 19);
            this.comboBoxRegions.Name = "comboBoxRegions";
            this.comboBoxRegions.Size = new System.Drawing.Size(140, 21);
            this.comboBoxRegions.TabIndex = 0;
            // 
            // numericUpDownPopulationMin
            // 
            this.numericUpDownPopulationMin.Location = new System.Drawing.Point(84, 125);
            this.numericUpDownPopulationMin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPopulationMin.Name = "numericUpDownPopulationMin";
            this.numericUpDownPopulationMin.Size = new System.Drawing.Size(140, 20);
            this.numericUpDownPopulationMin.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePregled);
            this.tabControl1.Controls.Add(this.tabPageUnos);
            this.tabControl1.Controls.Add(this.tabPageKartaSvijeta);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 314);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPagePregled
            // 
            this.tabPagePregled.Controls.Add(this.dataGridViewCountries);
            this.tabPagePregled.Controls.Add(this.groupBoxActions);
            this.tabPagePregled.Location = new System.Drawing.Point(4, 22);
            this.tabPagePregled.Name = "tabPagePregled";
            this.tabPagePregled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePregled.Size = new System.Drawing.Size(978, 288);
            this.tabPagePregled.TabIndex = 0;
            this.tabPagePregled.Text = "Pregled";
            this.tabPagePregled.UseVisualStyleBackColor = true;
            // 
            // tabPageUnos
            // 
            this.tabPageUnos.Controls.Add(this.labelNaziv);
            this.tabPageUnos.Controls.Add(this.labelKontinent);
            this.tabPageUnos.Controls.Add(this.labelPovrsina);
            this.tabPageUnos.Controls.Add(this.labelBrojStanovnika);
            this.tabPageUnos.Controls.Add(this.labelGlavniGrad);
            this.tabPageUnos.Controls.Add(this.labelKod);
            this.tabPageUnos.Controls.Add(this.buttonSaveCountry);
            this.tabPageUnos.Controls.Add(this.comboBoxInputRegion);
            this.tabPageUnos.Controls.Add(this.textBoxInputArea);
            this.tabPageUnos.Controls.Add(this.textBoxInputPopulation);
            this.tabPageUnos.Controls.Add(this.textBoxInputCapital);
            this.tabPageUnos.Controls.Add(this.textBoxInputName);
            this.tabPageUnos.Controls.Add(this.textBoxInputCode);
            this.tabPageUnos.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnos.Name = "tabPageUnos";
            this.tabPageUnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnos.Size = new System.Drawing.Size(978, 288);
            this.tabPageUnos.TabIndex = 1;
            this.tabPageUnos.Text = "Unos";
            this.tabPageUnos.UseVisualStyleBackColor = true;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(27, 49);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 12;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelKontinent
            // 
            this.labelKontinent.AutoSize = true;
            this.labelKontinent.Location = new System.Drawing.Point(27, 190);
            this.labelKontinent.Name = "labelKontinent";
            this.labelKontinent.Size = new System.Drawing.Size(52, 13);
            this.labelKontinent.TabIndex = 11;
            this.labelKontinent.Text = "Kontinent";
            // 
            // labelPovrsina
            // 
            this.labelPovrsina.AutoSize = true;
            this.labelPovrsina.Location = new System.Drawing.Point(27, 155);
            this.labelPovrsina.Name = "labelPovrsina";
            this.labelPovrsina.Size = new System.Drawing.Size(48, 13);
            this.labelPovrsina.TabIndex = 10;
            this.labelPovrsina.Text = "Povrsina";
            // 
            // labelBrojStanovnika
            // 
            this.labelBrojStanovnika.AutoSize = true;
            this.labelBrojStanovnika.Location = new System.Drawing.Point(27, 120);
            this.labelBrojStanovnika.Name = "labelBrojStanovnika";
            this.labelBrojStanovnika.Size = new System.Drawing.Size(82, 13);
            this.labelBrojStanovnika.TabIndex = 9;
            this.labelBrojStanovnika.Text = "Broj Stanovnika";
            // 
            // labelGlavniGrad
            // 
            this.labelGlavniGrad.AutoSize = true;
            this.labelGlavniGrad.Location = new System.Drawing.Point(27, 85);
            this.labelGlavniGrad.Name = "labelGlavniGrad";
            this.labelGlavniGrad.Size = new System.Drawing.Size(61, 13);
            this.labelGlavniGrad.TabIndex = 8;
            this.labelGlavniGrad.Text = "Glavni grad";
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Location = new System.Drawing.Point(27, 12);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(26, 13);
            this.labelKod.TabIndex = 7;
            this.labelKod.Text = "Kod";
            // 
            // buttonSaveCountry
            // 
            this.buttonSaveCountry.Location = new System.Drawing.Point(30, 225);
            this.buttonSaveCountry.Name = "buttonSaveCountry";
            this.buttonSaveCountry.Size = new System.Drawing.Size(215, 45);
            this.buttonSaveCountry.TabIndex = 6;
            this.buttonSaveCountry.Text = "SPREMI";
            this.buttonSaveCountry.UseVisualStyleBackColor = true;
            this.buttonSaveCountry.Click += new System.EventHandler(this.buttonSaveCountry_Click);
            // 
            // comboBoxInputRegion
            // 
            this.comboBoxInputRegion.FormattingEnabled = true;
            this.comboBoxInputRegion.Location = new System.Drawing.Point(116, 187);
            this.comboBoxInputRegion.Name = "comboBoxInputRegion";
            this.comboBoxInputRegion.Size = new System.Drawing.Size(129, 21);
            this.comboBoxInputRegion.TabIndex = 5;
            // 
            // textBoxInputArea
            // 
            this.textBoxInputArea.Location = new System.Drawing.Point(116, 152);
            this.textBoxInputArea.Name = "textBoxInputArea";
            this.textBoxInputArea.Size = new System.Drawing.Size(129, 20);
            this.textBoxInputArea.TabIndex = 4;
            // 
            // textBoxInputPopulation
            // 
            this.textBoxInputPopulation.Location = new System.Drawing.Point(116, 117);
            this.textBoxInputPopulation.Name = "textBoxInputPopulation";
            this.textBoxInputPopulation.Size = new System.Drawing.Size(129, 20);
            this.textBoxInputPopulation.TabIndex = 3;
            // 
            // textBoxInputCapital
            // 
            this.textBoxInputCapital.Location = new System.Drawing.Point(116, 82);
            this.textBoxInputCapital.Name = "textBoxInputCapital";
            this.textBoxInputCapital.Size = new System.Drawing.Size(129, 20);
            this.textBoxInputCapital.TabIndex = 2;
            // 
            // textBoxInputName
            // 
            this.textBoxInputName.Location = new System.Drawing.Point(116, 46);
            this.textBoxInputName.Name = "textBoxInputName";
            this.textBoxInputName.Size = new System.Drawing.Size(129, 20);
            this.textBoxInputName.TabIndex = 1;
            // 
            // textBoxInputCode
            // 
            this.textBoxInputCode.Location = new System.Drawing.Point(116, 9);
            this.textBoxInputCode.Name = "textBoxInputCode";
            this.textBoxInputCode.Size = new System.Drawing.Size(129, 20);
            this.textBoxInputCode.TabIndex = 0;
            // 
            // tabPageKartaSvijeta
            // 
            this.tabPageKartaSvijeta.Controls.Add(this.webBrowser1);
            this.tabPageKartaSvijeta.Location = new System.Drawing.Point(4, 22);
            this.tabPageKartaSvijeta.Name = "tabPageKartaSvijeta";
            this.tabPageKartaSvijeta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKartaSvijeta.Size = new System.Drawing.Size(978, 288);
            this.tabPageKartaSvijeta.TabIndex = 2;
            this.tabPageKartaSvijeta.Text = "Karta Svijeta";
            this.tabPageKartaSvijeta.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(978, 288);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.openstreetmap.org/#map=7/44.523/16.460", System.UriKind.Absolute);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 311);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "World Countries";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulationMin)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePregled.ResumeLayout(false);
            this.tabPageUnos.ResumeLayout(false);
            this.tabPageUnos.PerformLayout();
            this.tabPageKartaSvijeta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.ComboBox comboBoxRegions;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulationMin;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulationMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn pip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePregled;
        private System.Windows.Forms.TabPage tabPageUnos;
        private System.Windows.Forms.TabPage tabPageKartaSvijeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.Label labelMinPopulation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSaveCountry;
        private System.Windows.Forms.ComboBox comboBoxInputRegion;
        private System.Windows.Forms.TextBox textBoxInputArea;
        private System.Windows.Forms.TextBox textBoxInputPopulation;
        private System.Windows.Forms.TextBox textBoxInputCapital;
        private System.Windows.Forms.TextBox textBoxInputName;
        private System.Windows.Forms.TextBox textBoxInputCode;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelKontinent;
        private System.Windows.Forms.Label labelPovrsina;
        private System.Windows.Forms.Label labelBrojStanovnika;
        private System.Windows.Forms.Label labelGlavniGrad;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

