namespace ServisniProtokol
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cgr_BasicInfo = new GroupBox();
            bEditBasicInfo = new Button();
            lDatumMereniTEXT = new Label();
            lCisloProtokoluTEXT = new Label();
            lDatumMereni = new Label();
            LCisloProtokolu = new Label();
            cGrCustomer = new GroupBox();
            lEditCustomer = new Button();
            lICText = new Label();
            lPSCTEXT = new Label();
            lAdesaTEXT = new Label();
            lNazevTEXT = new Label();
            lIC = new Label();
            lPSC = new Label();
            lAdresa = new Label();
            lNazev = new Label();
            groupBox1 = new GroupBox();
            lSerioveTEXT = new Label();
            lModelTEXT = new Label();
            lVyrobceTEXT = new Label();
            lSerioveCislo = new Label();
            lModel = new Label();
            bEditDevice = new Button();
            lVyrobce = new Label();
            cGrMeasurrement = new GroupBox();
            bAdd = new Button();
            bEdit = new Button();
            bRemoveItem = new Button();
            DataGridMeassurementList = new DataGridView();
            col_Parameter = new DataGridViewTextBoxColumn();
            col_Value = new DataGridViewTextBoxColumn();
            col_Unit = new DataGridViewTextBoxColumn();
            col_IsValid = new DataGridViewTextBoxColumn();
            bSave = new Button();
            bLoad = new Button();
            bPreview = new Button();
            bExport = new Button();
            cgr_BasicInfo.SuspendLayout();
            cGrCustomer.SuspendLayout();
            groupBox1.SuspendLayout();
            cGrMeasurrement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridMeassurementList).BeginInit();
            SuspendLayout();
            // 
            // cgr_BasicInfo
            // 
            cgr_BasicInfo.Controls.Add(bEditBasicInfo);
            cgr_BasicInfo.Controls.Add(lDatumMereniTEXT);
            cgr_BasicInfo.Controls.Add(lCisloProtokoluTEXT);
            cgr_BasicInfo.Controls.Add(lDatumMereni);
            cgr_BasicInfo.Controls.Add(LCisloProtokolu);
            cgr_BasicInfo.Location = new Point(12, 32);
            cgr_BasicInfo.Name = "cgr_BasicInfo";
            cgr_BasicInfo.Size = new Size(604, 100);
            cgr_BasicInfo.TabIndex = 0;
            cgr_BasicInfo.TabStop = false;
            cgr_BasicInfo.Text = "Základní informace";
            // 
            // bEditBasicInfo
            // 
            bEditBasicInfo.Location = new Point(501, 18);
            bEditBasicInfo.Name = "bEditBasicInfo";
            bEditBasicInfo.Size = new Size(97, 72);
            bEditBasicInfo.TabIndex = 4;
            bEditBasicInfo.Text = "Upravit";
            bEditBasicInfo.UseVisualStyleBackColor = true;
            bEditBasicInfo.Click += bEditBasicInfo_Click;
            // 
            // lDatumMereniTEXT
            // 
            lDatumMereniTEXT.AutoSize = true;
            lDatumMereniTEXT.Location = new Point(143, 57);
            lDatumMereniTEXT.Name = "lDatumMereniTEXT";
            lDatumMereniTEXT.Size = new Size(12, 15);
            lDatumMereniTEXT.TabIndex = 3;
            lDatumMereniTEXT.Text = "?";
            // 
            // lCisloProtokoluTEXT
            // 
            lCisloProtokoluTEXT.AutoSize = true;
            lCisloProtokoluTEXT.Location = new Point(143, 33);
            lCisloProtokoluTEXT.Name = "lCisloProtokoluTEXT";
            lCisloProtokoluTEXT.Size = new Size(12, 15);
            lCisloProtokoluTEXT.TabIndex = 2;
            lCisloProtokoluTEXT.Text = "?";
            // 
            // lDatumMereni
            // 
            lDatumMereni.AutoSize = true;
            lDatumMereni.Location = new Point(25, 57);
            lDatumMereni.Name = "lDatumMereni";
            lDatumMereni.Size = new Size(86, 15);
            lDatumMereni.TabIndex = 1;
            lDatumMereni.Text = "Datum měření:";
            // 
            // LCisloProtokolu
            // 
            LCisloProtokolu.AutoSize = true;
            LCisloProtokolu.Location = new Point(25, 33);
            LCisloProtokolu.Name = "LCisloProtokolu";
            LCisloProtokolu.Size = new Size(91, 15);
            LCisloProtokolu.TabIndex = 0;
            LCisloProtokolu.Text = "Číslo protokolu:";
            // 
            // cGrCustomer
            // 
            cGrCustomer.Controls.Add(lEditCustomer);
            cGrCustomer.Controls.Add(lICText);
            cGrCustomer.Controls.Add(lPSCTEXT);
            cGrCustomer.Controls.Add(lAdesaTEXT);
            cGrCustomer.Controls.Add(lNazevTEXT);
            cGrCustomer.Controls.Add(lIC);
            cGrCustomer.Controls.Add(lPSC);
            cGrCustomer.Controls.Add(lAdresa);
            cGrCustomer.Controls.Add(lNazev);
            cGrCustomer.Location = new Point(12, 153);
            cGrCustomer.Name = "cGrCustomer";
            cGrCustomer.Size = new Size(288, 209);
            cGrCustomer.TabIndex = 1;
            cGrCustomer.TabStop = false;
            cGrCustomer.Text = "Zákazník";
            // 
            // lEditCustomer
            // 
            lEditCustomer.Location = new Point(207, 148);
            lEditCustomer.Name = "lEditCustomer";
            lEditCustomer.Size = new Size(75, 55);
            lEditCustomer.TabIndex = 8;
            lEditCustomer.Text = "Upravit";
            lEditCustomer.UseVisualStyleBackColor = true;
            lEditCustomer.Click += lEditCustomer_Click;
            // 
            // lICText
            // 
            lICText.AutoSize = true;
            lICText.Location = new Point(93, 121);
            lICText.Name = "lICText";
            lICText.Size = new Size(12, 15);
            lICText.TabIndex = 7;
            lICText.Text = "?";
            // 
            // lPSCTEXT
            // 
            lPSCTEXT.AutoSize = true;
            lPSCTEXT.Location = new Point(93, 94);
            lPSCTEXT.Name = "lPSCTEXT";
            lPSCTEXT.Size = new Size(12, 15);
            lPSCTEXT.TabIndex = 6;
            lPSCTEXT.Text = "?";
            // 
            // lAdesaTEXT
            // 
            lAdesaTEXT.AutoSize = true;
            lAdesaTEXT.Location = new Point(93, 66);
            lAdesaTEXT.Name = "lAdesaTEXT";
            lAdesaTEXT.Size = new Size(12, 15);
            lAdesaTEXT.TabIndex = 5;
            lAdesaTEXT.Text = "?";
            // 
            // lNazevTEXT
            // 
            lNazevTEXT.AutoSize = true;
            lNazevTEXT.Location = new Point(93, 42);
            lNazevTEXT.Name = "lNazevTEXT";
            lNazevTEXT.Size = new Size(12, 15);
            lNazevTEXT.TabIndex = 4;
            lNazevTEXT.Text = "?";
            // 
            // lIC
            // 
            lIC.AutoSize = true;
            lIC.Location = new Point(25, 121);
            lIC.Name = "lIC";
            lIC.Size = new Size(21, 15);
            lIC.TabIndex = 3;
            lIC.Text = "IČ:";
            // 
            // lPSC
            // 
            lPSC.AutoSize = true;
            lPSC.Location = new Point(25, 94);
            lPSC.Name = "lPSC";
            lPSC.Size = new Size(31, 15);
            lPSC.TabIndex = 2;
            lPSC.Text = "PSČ:";
            // 
            // lAdresa
            // 
            lAdresa.AutoSize = true;
            lAdresa.Location = new Point(25, 66);
            lAdresa.Name = "lAdresa";
            lAdresa.Size = new Size(46, 15);
            lAdresa.TabIndex = 1;
            lAdresa.Text = "Adresa:";
            // 
            // lNazev
            // 
            lNazev.AutoSize = true;
            lNazev.Location = new Point(25, 42);
            lNazev.Name = "lNazev";
            lNazev.Size = new Size(42, 15);
            lNazev.TabIndex = 0;
            lNazev.Text = "Název:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lSerioveTEXT);
            groupBox1.Controls.Add(lModelTEXT);
            groupBox1.Controls.Add(lVyrobceTEXT);
            groupBox1.Controls.Add(lSerioveCislo);
            groupBox1.Controls.Add(lModel);
            groupBox1.Controls.Add(bEditDevice);
            groupBox1.Controls.Add(lVyrobce);
            groupBox1.Location = new Point(320, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 209);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zařízení";
            // 
            // lSerioveTEXT
            // 
            lSerioveTEXT.AutoSize = true;
            lSerioveTEXT.Location = new Point(118, 94);
            lSerioveTEXT.Name = "lSerioveTEXT";
            lSerioveTEXT.Size = new Size(12, 15);
            lSerioveTEXT.TabIndex = 12;
            lSerioveTEXT.Text = "?";
            // 
            // lModelTEXT
            // 
            lModelTEXT.AutoSize = true;
            lModelTEXT.Location = new Point(118, 66);
            lModelTEXT.Name = "lModelTEXT";
            lModelTEXT.Size = new Size(12, 15);
            lModelTEXT.TabIndex = 11;
            lModelTEXT.Text = "?";
            // 
            // lVyrobceTEXT
            // 
            lVyrobceTEXT.AutoSize = true;
            lVyrobceTEXT.Location = new Point(118, 42);
            lVyrobceTEXT.Name = "lVyrobceTEXT";
            lVyrobceTEXT.Size = new Size(12, 15);
            lVyrobceTEXT.TabIndex = 10;
            lVyrobceTEXT.Text = "?";
            // 
            // lSerioveCislo
            // 
            lSerioveCislo.AutoSize = true;
            lSerioveCislo.Location = new Point(25, 94);
            lSerioveCislo.Name = "lSerioveCislo";
            lSerioveCislo.Size = new Size(75, 15);
            lSerioveCislo.TabIndex = 9;
            lSerioveCislo.Text = "Sériové číslo:";
            // 
            // lModel
            // 
            lModel.AutoSize = true;
            lModel.Location = new Point(25, 66);
            lModel.Name = "lModel";
            lModel.Size = new Size(44, 15);
            lModel.TabIndex = 8;
            lModel.Text = "Model:";
            // 
            // bEditDevice
            // 
            bEditDevice.Location = new Point(209, 148);
            bEditDevice.Name = "bEditDevice";
            bEditDevice.Size = new Size(75, 55);
            bEditDevice.TabIndex = 7;
            bEditDevice.Text = "Upravit";
            bEditDevice.UseVisualStyleBackColor = true;
            bEditDevice.Click += bEditDevice_Click;
            // 
            // lVyrobce
            // 
            lVyrobce.AutoSize = true;
            lVyrobce.Location = new Point(25, 42);
            lVyrobce.Name = "lVyrobce";
            lVyrobce.Size = new Size(53, 15);
            lVyrobce.TabIndex = 0;
            lVyrobce.Text = "Výrobce:";
            // 
            // cGrMeasurrement
            // 
            cGrMeasurrement.Controls.Add(bAdd);
            cGrMeasurrement.Controls.Add(bEdit);
            cGrMeasurrement.Controls.Add(bRemoveItem);
            cGrMeasurrement.Controls.Add(DataGridMeassurementList);
            cGrMeasurrement.Location = new Point(12, 368);
            cGrMeasurrement.Name = "cGrMeasurrement";
            cGrMeasurrement.Size = new Size(598, 289);
            cGrMeasurrement.TabIndex = 9;
            cGrMeasurrement.TabStop = false;
            cGrMeasurrement.Text = "Měření";
            // 
            // bAdd
            // 
            bAdd.Location = new Point(344, 251);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 3;
            bAdd.Text = "Přidat";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(425, 251);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 23);
            bEdit.TabIndex = 2;
            bEdit.Text = "Upravit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bRemoveItem
            // 
            bRemoveItem.Location = new Point(506, 251);
            bRemoveItem.Name = "bRemoveItem";
            bRemoveItem.Size = new Size(75, 23);
            bRemoveItem.TabIndex = 1;
            bRemoveItem.Text = "Smazat";
            bRemoveItem.UseVisualStyleBackColor = true;
            bRemoveItem.Click += bRemoveItem_Click;
            // 
            // DataGridMeassurementList
            // 
            DataGridMeassurementList.AllowUserToAddRows = false;
            DataGridMeassurementList.AllowUserToDeleteRows = false;
            DataGridMeassurementList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridMeassurementList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridMeassurementList.Columns.AddRange(new DataGridViewColumn[] { col_Parameter, col_Value, col_Unit, col_IsValid });
            DataGridMeassurementList.Location = new Point(15, 22);
            DataGridMeassurementList.MultiSelect = false;
            DataGridMeassurementList.Name = "DataGridMeassurementList";
            DataGridMeassurementList.ReadOnly = true;
            DataGridMeassurementList.RowTemplate.Height = 25;
            DataGridMeassurementList.Size = new Size(566, 223);
            DataGridMeassurementList.TabIndex = 0;
            // 
            // col_Parameter
            // 
            col_Parameter.DataPropertyName = "Parameter";
            col_Parameter.HeaderText = "Parametr";
            col_Parameter.Name = "col_Parameter";
            col_Parameter.ReadOnly = true;
            // 
            // col_Value
            // 
            col_Value.DataPropertyName = "Value";
            col_Value.HeaderText = "Naměřená hodnota";
            col_Value.Name = "col_Value";
            col_Value.ReadOnly = true;
            // 
            // col_Unit
            // 
            col_Unit.DataPropertyName = "Unit";
            col_Unit.HeaderText = "Jednotka";
            col_Unit.Name = "col_Unit";
            col_Unit.ReadOnly = true;
            // 
            // col_IsValid
            // 
            col_IsValid.DataPropertyName = "IsValid";
            col_IsValid.HeaderText = "Vyhovuje";
            col_IsValid.Name = "col_IsValid";
            col_IsValid.ReadOnly = true;
            // 
            // bSave
            // 
            bSave.Location = new Point(12, 663);
            bSave.Name = "bSave";
            bSave.Size = new Size(75, 23);
            bSave.TabIndex = 10;
            bSave.Text = "Uložit";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bLoad
            // 
            bLoad.Location = new Point(92, 663);
            bLoad.Name = "bLoad";
            bLoad.Size = new Size(75, 23);
            bLoad.TabIndex = 11;
            bLoad.Text = "Načíst";
            bLoad.UseVisualStyleBackColor = true;
            bLoad.Click += bLoad_Click;
            // 
            // bPreview
            // 
            bPreview.Location = new Point(454, 661);
            bPreview.Name = "bPreview";
            bPreview.Size = new Size(75, 23);
            bPreview.TabIndex = 12;
            bPreview.Text = "Náhled";
            bPreview.UseVisualStyleBackColor = true;
            bPreview.Click += bPreview_Click;
            // 
            // bExport
            // 
            bExport.Location = new Point(535, 661);
            bExport.Name = "bExport";
            bExport.Size = new Size(75, 23);
            bExport.TabIndex = 13;
            bExport.Text = "Export";
            bExport.UseVisualStyleBackColor = true;
            bExport.Click += bExport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 696);
            Controls.Add(bExport);
            Controls.Add(bPreview);
            Controls.Add(bLoad);
            Controls.Add(bSave);
            Controls.Add(cGrMeasurrement);
            Controls.Add(groupBox1);
            Controls.Add(cGrCustomer);
            Controls.Add(cgr_BasicInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Servisní protokol";
            cgr_BasicInfo.ResumeLayout(false);
            cgr_BasicInfo.PerformLayout();
            cGrCustomer.ResumeLayout(false);
            cGrCustomer.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            cGrMeasurrement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridMeassurementList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox cgr_BasicInfo;
        private Button bEditBasicInfo;
        private Label lDatumMereniTEXT;
        private Label lCisloProtokoluTEXT;
        private Label lDatumMereni;
        private Label LCisloProtokolu;
        private GroupBox cGrCustomer;
        private Label lIC;
        private Label lPSC;
        private Label lAdresa;
        private Label lNazev;
        private Label lICText;
        private Label lPSCTEXT;
        private Label lAdesaTEXT;
        private Label lNazevTEXT;
        private GroupBox groupBox1;
        private Label lVyrobce;
        private Button lEditCustomer;
        private Button bEditDevice;
        private GroupBox cGrMeasurrement;
        private Button bRemoveItem;
        private DataGridView DataGridMeassurementList;
        private Label lSerioveTEXT;
        private Label lModelTEXT;
        private Label lVyrobceTEXT;
        private Label lSerioveCislo;
        private Label lModel;
        private Button bAdd;
        private Button bEdit;
        private DataGridViewTextBoxColumn col_Parameter;
        private DataGridViewTextBoxColumn col_Value;
        private DataGridViewTextBoxColumn col_Unit;
        private DataGridViewTextBoxColumn col_IsValid;
        private Button bSave;
        private Button bLoad;
        private Button bPreview;
        private Button bExport;
    }
}
