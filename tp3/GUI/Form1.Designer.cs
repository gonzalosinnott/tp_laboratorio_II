﻿
namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMain = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbStock = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.txtOrigin = new MetroSet_UI.Controls.MetroSetTextBox();
            this.cmbManufacturer = new MetroSet_UI.Controls.MetroSetComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbCustomType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.txtName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblOrigin = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblManufacturer = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblDate = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblAmount = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblType = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbName = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTipoPieza = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbPieceType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.btnSearchPieces = new MetroSet_UI.Controls.MetroSetTile();
            this.txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddStock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeleteStock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbAssembly = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.btnCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSearchGuitars = new MetroSet_UI.Controls.MetroSetTile();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDispatch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblGuitarModel = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbGuitarModel = new MetroSet_UI.Controls.MetroSetComboBox();
            this.tbQuality = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tbReports = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetTile1 = new MetroSet_UI.Controls.MetroSetTile();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRecallStock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.metroSetTile2 = new MetroSet_UI.Controls.MetroSetTile();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRecallProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnStockReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProductReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSendedProducts = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRecalledStock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRecalledProducts = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbMain.SuspendLayout();
            this.tbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbAssembly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tbQuality.SuspendLayout();
            this.tbReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.AccessibleName = "";
            this.tbMain.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbMain.AnimateTime = 200;
            this.tbMain.BackgroundColor = System.Drawing.Color.White;
            this.tbMain.Controls.Add(this.tbStock);
            this.tbMain.Controls.Add(this.tbAssembly);
            this.tbMain.Controls.Add(this.tbQuality);
            this.tbMain.Controls.Add(this.tbReports);
            this.tbMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbMain.IsDerivedStyle = true;
            this.tbMain.ItemSize = new System.Drawing.Size(100, 38);
            this.tbMain.Location = new System.Drawing.Point(12, 68);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.SelectedTextColor = System.Drawing.Color.White;
            this.tbMain.Size = new System.Drawing.Size(695, 461);
            this.tbMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbMain.Speed = 100;
            this.tbMain.Style = MetroSet_UI.Enums.Style.Light;
            this.tbMain.StyleManager = null;
            this.tbMain.TabIndex = 0;
            this.tbMain.ThemeAuthor = "Narwin";
            this.tbMain.ThemeName = "MetroLite";
            this.tbMain.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbMain.UseAnimation = false;
            // 
            // tbStock
            // 
            this.tbStock.BaseColor = System.Drawing.Color.White;
            this.tbStock.Controls.Add(this.txtOrigin);
            this.tbStock.Controls.Add(this.cmbManufacturer);
            this.tbStock.Controls.Add(this.dtpDate);
            this.tbStock.Controls.Add(this.nudAmount);
            this.tbStock.Controls.Add(this.cmbCustomType);
            this.tbStock.Controls.Add(this.txtName);
            this.tbStock.Controls.Add(this.lblOrigin);
            this.tbStock.Controls.Add(this.lblManufacturer);
            this.tbStock.Controls.Add(this.lblDate);
            this.tbStock.Controls.Add(this.lblAmount);
            this.tbStock.Controls.Add(this.lblType);
            this.tbStock.Controls.Add(this.lbName);
            this.tbStock.Controls.Add(this.lblTipoPieza);
            this.tbStock.Controls.Add(this.cmbPieceType);
            this.tbStock.Controls.Add(this.btnSearchPieces);
            this.tbStock.Controls.Add(this.txt);
            this.tbStock.Controls.Add(this.btnAddStock);
            this.tbStock.Controls.Add(this.btnDeleteStock);
            this.tbStock.Controls.Add(this.dataGridView1);
            this.tbStock.Font = null;
            this.tbStock.ImageIndex = 0;
            this.tbStock.ImageKey = null;
            this.tbStock.IsDerivedStyle = true;
            this.tbStock.Location = new System.Drawing.Point(4, 42);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(687, 415);
            this.tbStock.Style = MetroSet_UI.Enums.Style.Light;
            this.tbStock.StyleManager = null;
            this.tbStock.TabIndex = 0;
            this.tbStock.Text = "STOCK";
            this.tbStock.ThemeAuthor = "Narwin";
            this.tbStock.ThemeName = "MetroLite";
            this.tbStock.ToolTipText = null;
            // 
            // txtOrigin
            // 
            this.txtOrigin.AutoCompleteCustomSource = null;
            this.txtOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOrigin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOrigin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtOrigin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtOrigin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtOrigin.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOrigin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtOrigin.Image = null;
            this.txtOrigin.IsDerivedStyle = true;
            this.txtOrigin.Lines = null;
            this.txtOrigin.Location = new System.Drawing.Point(103, 203);
            this.txtOrigin.MaxLength = 32767;
            this.txtOrigin.Multiline = false;
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.ReadOnly = false;
            this.txtOrigin.Size = new System.Drawing.Size(235, 30);
            this.txtOrigin.Style = MetroSet_UI.Enums.Style.Light;
            this.txtOrigin.StyleManager = null;
            this.txtOrigin.TabIndex = 24;
            this.txtOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOrigin.ThemeAuthor = "Narwin";
            this.txtOrigin.ThemeName = "MetroLite";
            this.txtOrigin.UseSystemPasswordChar = false;
            this.txtOrigin.WatermarkText = "";
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.AllowDrop = true;
            this.cmbManufacturer.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbManufacturer.BackColor = System.Drawing.Color.Transparent;
            this.cmbManufacturer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbManufacturer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbManufacturer.CausesValidation = false;
            this.cmbManufacturer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbManufacturer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbManufacturer.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbManufacturer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.IsDerivedStyle = true;
            this.cmbManufacturer.ItemHeight = 20;
            this.cmbManufacturer.Items.AddRange(new object[] {
            "CLAVIJAS",
            "CUERDAS",
            "ELECTRONICA",
            "MADERA",
            "MASTIL",
            "PICKUPS",
            "TREMOLO"});
            this.cmbManufacturer.Location = new System.Drawing.Point(103, 171);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbManufacturer.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbManufacturer.Size = new System.Drawing.Size(235, 26);
            this.cmbManufacturer.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbManufacturer.StyleManager = null;
            this.cmbManufacturer.TabIndex = 23;
            this.cmbManufacturer.ThemeAuthor = "Narwin";
            this.cmbManufacturer.ThemeName = "MetroLite";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(82, 142);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(256, 23);
            this.dtpDate.TabIndex = 22;
            this.dtpDate.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(103, 113);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(235, 23);
            this.nudAmount.TabIndex = 21;
            // 
            // cmbCustomType
            // 
            this.cmbCustomType.AllowDrop = true;
            this.cmbCustomType.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbCustomType.BackColor = System.Drawing.Color.Transparent;
            this.cmbCustomType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbCustomType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbCustomType.CausesValidation = false;
            this.cmbCustomType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbCustomType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbCustomType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbCustomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCustomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbCustomType.FormattingEnabled = true;
            this.cmbCustomType.IsDerivedStyle = true;
            this.cmbCustomType.ItemHeight = 20;
            this.cmbCustomType.Items.AddRange(new object[] {
            "CLAVIJAS",
            "CUERDAS",
            "ELECTRONICA",
            "MADERA",
            "MASTIL",
            "PICKUPS",
            "TREMOLO"});
            this.cmbCustomType.Location = new System.Drawing.Point(66, 81);
            this.cmbCustomType.Name = "cmbCustomType";
            this.cmbCustomType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbCustomType.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbCustomType.Size = new System.Drawing.Size(272, 26);
            this.cmbCustomType.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbCustomType.StyleManager = null;
            this.cmbCustomType.TabIndex = 20;
            this.cmbCustomType.ThemeAuthor = "Narwin";
            this.cmbCustomType.ThemeName = "MetroLite";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteCustomSource = null;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtName.Image = null;
            this.txtName.IsDerivedStyle = true;
            this.txtName.Lines = null;
            this.txtName.Location = new System.Drawing.Point(82, 45);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = false;
            this.txtName.Size = new System.Drawing.Size(256, 30);
            this.txtName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtName.StyleManager = null;
            this.txtName.TabIndex = 19;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.ThemeAuthor = "Narwin";
            this.txtName.ThemeName = "MetroLite";
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.WatermarkText = "";
            // 
            // lblOrigin
            // 
            this.lblOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrigin.IsDerivedStyle = true;
            this.lblOrigin.Location = new System.Drawing.Point(0, 210);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(74, 23);
            this.lblOrigin.Style = MetroSet_UI.Enums.Style.Light;
            this.lblOrigin.StyleManager = null;
            this.lblOrigin.TabIndex = 18;
            this.lblOrigin.Text = "ORIGEN:";
            this.lblOrigin.ThemeAuthor = "Narwin";
            this.lblOrigin.ThemeName = "MetroLite";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblManufacturer.IsDerivedStyle = true;
            this.lblManufacturer.Location = new System.Drawing.Point(-4, 174);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(109, 23);
            this.lblManufacturer.Style = MetroSet_UI.Enums.Style.Light;
            this.lblManufacturer.StyleManager = null;
            this.lblManufacturer.TabIndex = 17;
            this.lblManufacturer.Text = "FABRICANTE:";
            this.lblManufacturer.ThemeAuthor = "Narwin";
            this.lblManufacturer.ThemeName = "MetroLite";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.IsDerivedStyle = true;
            this.lblDate.Location = new System.Drawing.Point(-4, 148);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 23);
            this.lblDate.Style = MetroSet_UI.Enums.Style.Light;
            this.lblDate.StyleManager = null;
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "INGRESO:";
            this.lblDate.ThemeAuthor = "Narwin";
            this.lblDate.ThemeName = "MetroLite";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAmount.IsDerivedStyle = true;
            this.lblAmount.Location = new System.Drawing.Point(-4, 113);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(85, 23);
            this.lblAmount.Style = MetroSet_UI.Enums.Style.Light;
            this.lblAmount.StyleManager = null;
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "CANTIDAD:";
            this.lblAmount.ThemeAuthor = "Narwin";
            this.lblAmount.ThemeName = "MetroLite";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.IsDerivedStyle = true;
            this.lblType.Location = new System.Drawing.Point(-4, 84);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 23);
            this.lblType.Style = MetroSet_UI.Enums.Style.Light;
            this.lblType.StyleManager = null;
            this.lblType.TabIndex = 14;
            this.lblType.Text = "TIPO:";
            this.lblType.ThemeAuthor = "Narwin";
            this.lblType.ThemeName = "MetroLite";
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbName.IsDerivedStyle = true;
            this.lbName.Location = new System.Drawing.Point(-4, 52);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 23);
            this.lbName.Style = MetroSet_UI.Enums.Style.Light;
            this.lbName.StyleManager = null;
            this.lbName.TabIndex = 13;
            this.lbName.Text = "NOMBRE:";
            this.lbName.ThemeAuthor = "Narwin";
            this.lbName.ThemeName = "MetroLite";
            // 
            // lblTipoPieza
            // 
            this.lblTipoPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipoPieza.IsDerivedStyle = true;
            this.lblTipoPieza.Location = new System.Drawing.Point(-4, 16);
            this.lblTipoPieza.Name = "lblTipoPieza";
            this.lblTipoPieza.Size = new System.Drawing.Size(51, 23);
            this.lblTipoPieza.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTipoPieza.StyleManager = null;
            this.lblTipoPieza.TabIndex = 12;
            this.lblTipoPieza.Text = "PIEZA:";
            this.lblTipoPieza.ThemeAuthor = "Narwin";
            this.lblTipoPieza.ThemeName = "MetroLite";
            // 
            // cmbPieceType
            // 
            this.cmbPieceType.AllowDrop = true;
            this.cmbPieceType.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbPieceType.BackColor = System.Drawing.Color.Transparent;
            this.cmbPieceType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbPieceType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbPieceType.CausesValidation = false;
            this.cmbPieceType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbPieceType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbPieceType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbPieceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPieceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPieceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbPieceType.FormattingEnabled = true;
            this.cmbPieceType.IsDerivedStyle = true;
            this.cmbPieceType.ItemHeight = 20;
            this.cmbPieceType.Items.AddRange(new object[] {
            "CLAVIJAS",
            "CUERDAS",
            "ELECTRONICA",
            "MADERA",
            "MASTIL",
            "PICKUPS",
            "TREMOLO"});
            this.cmbPieceType.Location = new System.Drawing.Point(66, 13);
            this.cmbPieceType.Name = "cmbPieceType";
            this.cmbPieceType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbPieceType.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbPieceType.Size = new System.Drawing.Size(272, 26);
            this.cmbPieceType.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbPieceType.StyleManager = null;
            this.cmbPieceType.TabIndex = 11;
            this.cmbPieceType.ThemeAuthor = "Narwin";
            this.cmbPieceType.ThemeName = "MetroLite";
            // 
            // btnSearchPieces
            // 
            this.btnSearchPieces.BackgroundImage = global::GUI.Properties.Resources.search_512;
            this.btnSearchPieces.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearchPieces.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSearchPieces.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnSearchPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearchPieces.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearchPieces.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchPieces.HoverTextColor = System.Drawing.Color.White;
            this.btnSearchPieces.IsDerivedStyle = true;
            this.btnSearchPieces.Location = new System.Drawing.Point(652, 16);
            this.btnSearchPieces.Name = "btnSearchPieces";
            this.btnSearchPieces.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchPieces.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchPieces.NormalTextColor = System.Drawing.Color.White;
            this.btnSearchPieces.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchPieces.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchPieces.PressTextColor = System.Drawing.Color.White;
            this.btnSearchPieces.Size = new System.Drawing.Size(34, 23);
            this.btnSearchPieces.Style = MetroSet_UI.Enums.Style.Light;
            this.btnSearchPieces.StyleManager = null;
            this.btnSearchPieces.TabIndex = 10;
            this.btnSearchPieces.ThemeAuthor = "Narwin";
            this.btnSearchPieces.ThemeName = "MetroLite";
            this.btnSearchPieces.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            // 
            // txt
            // 
            this.txt.Depth = 0;
            this.txt.Hint = "";
            this.txt.Location = new System.Drawing.Point(357, 16);
            this.txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt.Name = "txt";
            this.txt.PasswordChar = '\0';
            this.txt.SelectedText = "";
            this.txt.SelectionLength = 0;
            this.txt.SelectionStart = 0;
            this.txt.Size = new System.Drawing.Size(289, 23);
            this.txt.TabIndex = 7;
            this.txt.Text = "Buscar...";
            this.txt.UseSystemPasswordChar = false;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Depth = 0;
            this.btnAddStock.Location = new System.Drawing.Point(5, 365);
            this.btnAddStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Primary = true;
            this.btnAddStock.Size = new System.Drawing.Size(329, 27);
            this.btnAddStock.TabIndex = 5;
            this.btnAddStock.Text = "AGREGAR";
            this.btnAddStock.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Depth = 0;
            this.btnDeleteStock.Location = new System.Drawing.Point(357, 365);
            this.btnDeleteStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Primary = true;
            this.btnDeleteStock.Size = new System.Drawing.Size(329, 27);
            this.btnDeleteStock.TabIndex = 4;
            this.btnDeleteStock.Text = "ELIMINAR";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbAssembly
            // 
            this.tbAssembly.BaseColor = System.Drawing.Color.White;
            this.tbAssembly.Controls.Add(this.btnCreate);
            this.tbAssembly.Controls.Add(this.btnSearchGuitars);
            this.tbAssembly.Controls.Add(this.txtSearch);
            this.tbAssembly.Controls.Add(this.btnDispatch);
            this.tbAssembly.Controls.Add(this.dataGridView2);
            this.tbAssembly.Controls.Add(this.dateTimePicker1);
            this.tbAssembly.Controls.Add(this.numericUpDown1);
            this.tbAssembly.Controls.Add(this.metroSetLabel3);
            this.tbAssembly.Controls.Add(this.metroSetLabel4);
            this.tbAssembly.Controls.Add(this.lblGuitarModel);
            this.tbAssembly.Controls.Add(this.cmbGuitarModel);
            this.tbAssembly.Font = null;
            this.tbAssembly.ImageIndex = 0;
            this.tbAssembly.ImageKey = null;
            this.tbAssembly.IsDerivedStyle = true;
            this.tbAssembly.Location = new System.Drawing.Point(4, 42);
            this.tbAssembly.Name = "tbAssembly";
            this.tbAssembly.Size = new System.Drawing.Size(687, 415);
            this.tbAssembly.Style = MetroSet_UI.Enums.Style.Light;
            this.tbAssembly.StyleManager = null;
            this.tbAssembly.TabIndex = 1;
            this.tbAssembly.Text = "ENSAMBLAJE";
            this.tbAssembly.ThemeAuthor = "Narwin";
            this.tbAssembly.ThemeName = "MetroLite";
            this.tbAssembly.ToolTipText = null;
            // 
            // btnCreate
            // 
            this.btnCreate.Depth = 0;
            this.btnCreate.Location = new System.Drawing.Point(358, 14);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Primary = true;
            this.btnCreate.Size = new System.Drawing.Size(326, 85);
            this.btnCreate.TabIndex = 43;
            this.btnCreate.Text = "FABRICAR";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnSearchGuitars
            // 
            this.btnSearchGuitars.BackgroundImage = global::GUI.Properties.Resources.search_512;
            this.btnSearchGuitars.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearchGuitars.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSearchGuitars.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnSearchGuitars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearchGuitars.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearchGuitars.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchGuitars.HoverTextColor = System.Drawing.Color.White;
            this.btnSearchGuitars.IsDerivedStyle = true;
            this.btnSearchGuitars.Location = new System.Drawing.Point(650, 127);
            this.btnSearchGuitars.Name = "btnSearchGuitars";
            this.btnSearchGuitars.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchGuitars.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchGuitars.NormalTextColor = System.Drawing.Color.White;
            this.btnSearchGuitars.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchGuitars.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSearchGuitars.PressTextColor = System.Drawing.Color.White;
            this.btnSearchGuitars.Size = new System.Drawing.Size(34, 23);
            this.btnSearchGuitars.Style = MetroSet_UI.Enums.Style.Light;
            this.btnSearchGuitars.StyleManager = null;
            this.btnSearchGuitars.TabIndex = 42;
            this.btnSearchGuitars.ThemeAuthor = "Narwin";
            this.btnSearchGuitars.ThemeName = "MetroLite";
            this.btnSearchGuitars.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(3, 127);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(641, 23);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.Text = "Buscar...";
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // btnDispatch
            // 
            this.btnDispatch.Depth = 0;
            this.btnDispatch.Location = new System.Drawing.Point(0, 368);
            this.btnDispatch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Primary = true;
            this.btnDispatch.Size = new System.Drawing.Size(684, 27);
            this.btnDispatch.TabIndex = 40;
            this.btnDispatch.Text = "DESPACHAR";
            this.btnDispatch.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(684, 206);
            this.dataGridView2.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 23);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(235, 23);
            this.numericUpDown1.TabIndex = 35;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(-4, 76);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(108, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 30;
            this.metroSetLabel3.Text = "FABRICACION:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(-4, 47);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(85, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 29;
            this.metroSetLabel4.Text = "CANTIDAD:";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // lblGuitarModel
            // 
            this.lblGuitarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuitarModel.IsDerivedStyle = true;
            this.lblGuitarModel.Location = new System.Drawing.Point(-4, 18);
            this.lblGuitarModel.Name = "lblGuitarModel";
            this.lblGuitarModel.Size = new System.Drawing.Size(86, 23);
            this.lblGuitarModel.Style = MetroSet_UI.Enums.Style.Light;
            this.lblGuitarModel.StyleManager = null;
            this.lblGuitarModel.TabIndex = 26;
            this.lblGuitarModel.Text = "GUITARRA:";
            this.lblGuitarModel.ThemeAuthor = "Narwin";
            this.lblGuitarModel.ThemeName = "MetroLite";
            // 
            // cmbGuitarModel
            // 
            this.cmbGuitarModel.AllowDrop = true;
            this.cmbGuitarModel.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbGuitarModel.BackColor = System.Drawing.Color.Transparent;
            this.cmbGuitarModel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbGuitarModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbGuitarModel.CausesValidation = false;
            this.cmbGuitarModel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbGuitarModel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbGuitarModel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbGuitarModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGuitarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuitarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbGuitarModel.FormattingEnabled = true;
            this.cmbGuitarModel.IsDerivedStyle = true;
            this.cmbGuitarModel.ItemHeight = 20;
            this.cmbGuitarModel.Items.AddRange(new object[] {
            "LES PAUL",
            "SG",
            "STRATOCASTER",
            "TELECASTER"});
            this.cmbGuitarModel.Location = new System.Drawing.Point(95, 15);
            this.cmbGuitarModel.Name = "cmbGuitarModel";
            this.cmbGuitarModel.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbGuitarModel.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbGuitarModel.Size = new System.Drawing.Size(244, 26);
            this.cmbGuitarModel.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbGuitarModel.StyleManager = null;
            this.cmbGuitarModel.TabIndex = 25;
            this.cmbGuitarModel.ThemeAuthor = "Narwin";
            this.cmbGuitarModel.ThemeName = "MetroLite";
            // 
            // tbQuality
            // 
            this.tbQuality.BaseColor = System.Drawing.Color.White;
            this.tbQuality.Controls.Add(this.metroSetTile2);
            this.tbQuality.Controls.Add(this.materialSingleLineTextField2);
            this.tbQuality.Controls.Add(this.btnRecallProduct);
            this.tbQuality.Controls.Add(this.dataGridView4);
            this.tbQuality.Controls.Add(this.metroSetTile1);
            this.tbQuality.Controls.Add(this.materialSingleLineTextField1);
            this.tbQuality.Controls.Add(this.btnRecallStock);
            this.tbQuality.Controls.Add(this.dataGridView3);
            this.tbQuality.Font = null;
            this.tbQuality.ImageIndex = 0;
            this.tbQuality.ImageKey = null;
            this.tbQuality.IsDerivedStyle = true;
            this.tbQuality.Location = new System.Drawing.Point(4, 42);
            this.tbQuality.Name = "tbQuality";
            this.tbQuality.Size = new System.Drawing.Size(687, 415);
            this.tbQuality.Style = MetroSet_UI.Enums.Style.Light;
            this.tbQuality.StyleManager = null;
            this.tbQuality.TabIndex = 2;
            this.tbQuality.Text = "CONTROL DE CALIDAD";
            this.tbQuality.ThemeAuthor = "Narwin";
            this.tbQuality.ThemeName = "MetroLite";
            this.tbQuality.ToolTipText = null;
            // 
            // tbReports
            // 
            this.tbReports.BaseColor = System.Drawing.Color.White;
            this.tbReports.Controls.Add(this.btnRecalledProducts);
            this.tbReports.Controls.Add(this.btnRecalledStock);
            this.tbReports.Controls.Add(this.btnSendedProducts);
            this.tbReports.Controls.Add(this.btnProductReport);
            this.tbReports.Controls.Add(this.btnStockReport);
            this.tbReports.Font = null;
            this.tbReports.ImageIndex = 0;
            this.tbReports.ImageKey = null;
            this.tbReports.IsDerivedStyle = true;
            this.tbReports.Location = new System.Drawing.Point(4, 42);
            this.tbReports.Name = "tbReports";
            this.tbReports.Size = new System.Drawing.Size(687, 415);
            this.tbReports.Style = MetroSet_UI.Enums.Style.Light;
            this.tbReports.StyleManager = null;
            this.tbReports.TabIndex = 3;
            this.tbReports.Text = "INFORMES";
            this.tbReports.ThemeAuthor = "Narwin";
            this.tbReports.ThemeName = "MetroLite";
            this.tbReports.ToolTipText = null;
            // 
            // metroSetTile1
            // 
            this.metroSetTile1.BackgroundImage = global::GUI.Properties.Resources.search_512;
            this.metroSetTile1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile1.IsDerivedStyle = true;
            this.metroSetTile1.Location = new System.Drawing.Point(650, 3);
            this.metroSetTile1.Name = "metroSetTile1";
            this.metroSetTile1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Size = new System.Drawing.Size(34, 23);
            this.metroSetTile1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTile1.StyleManager = null;
            this.metroSetTile1.TabIndex = 46;
            this.metroSetTile1.ThemeAuthor = "Narwin";
            this.metroSetTile1.ThemeName = "MetroLite";
            this.metroSetTile1.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(3, 3);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(641, 23);
            this.materialSingleLineTextField1.TabIndex = 45;
            this.materialSingleLineTextField1.Text = "Buscar...";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // btnRecallStock
            // 
            this.btnRecallStock.Depth = 0;
            this.btnRecallStock.Location = new System.Drawing.Point(0, 164);
            this.btnRecallStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecallStock.Name = "btnRecallStock";
            this.btnRecallStock.Primary = true;
            this.btnRecallStock.Size = new System.Drawing.Size(684, 27);
            this.btnRecallStock.TabIndex = 44;
            this.btnRecallStock.Text = "RETIRAR DEL INVENTARIO";
            this.btnRecallStock.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 32);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(684, 126);
            this.dataGridView3.TabIndex = 43;
            // 
            // metroSetTile2
            // 
            this.metroSetTile2.BackgroundImage = global::GUI.Properties.Resources.search_512;
            this.metroSetTile2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile2.IsDerivedStyle = true;
            this.metroSetTile2.Location = new System.Drawing.Point(650, 216);
            this.metroSetTile2.Name = "metroSetTile2";
            this.metroSetTile2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile2.Size = new System.Drawing.Size(34, 23);
            this.metroSetTile2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTile2.StyleManager = null;
            this.metroSetTile2.TabIndex = 50;
            this.metroSetTile2.ThemeAuthor = "Narwin";
            this.metroSetTile2.ThemeName = "MetroLite";
            this.metroSetTile2.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(3, 216);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(641, 23);
            this.materialSingleLineTextField2.TabIndex = 49;
            this.materialSingleLineTextField2.Text = "Buscar...";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // btnRecallProduct
            // 
            this.btnRecallProduct.Depth = 0;
            this.btnRecallProduct.Location = new System.Drawing.Point(3, 377);
            this.btnRecallProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecallProduct.Name = "btnRecallProduct";
            this.btnRecallProduct.Primary = true;
            this.btnRecallProduct.Size = new System.Drawing.Size(684, 27);
            this.btnRecallProduct.TabIndex = 48;
            this.btnRecallProduct.Text = "RETIRAR PRODUCTO";
            this.btnRecallProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 245);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(684, 126);
            this.dataGridView4.TabIndex = 47;
            // 
            // btnStockReport
            // 
            this.btnStockReport.Depth = 0;
            this.btnStockReport.Location = new System.Drawing.Point(0, 21);
            this.btnStockReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Primary = true;
            this.btnStockReport.Size = new System.Drawing.Size(684, 27);
            this.btnStockReport.TabIndex = 45;
            this.btnStockReport.Text = "INFORME DE STOCK DE MATERIALES";
            this.btnStockReport.UseVisualStyleBackColor = true;
            // 
            // btnProductReport
            // 
            this.btnProductReport.Depth = 0;
            this.btnProductReport.Location = new System.Drawing.Point(0, 54);
            this.btnProductReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Primary = true;
            this.btnProductReport.Size = new System.Drawing.Size(684, 27);
            this.btnProductReport.TabIndex = 46;
            this.btnProductReport.Text = "INFORME DE STOCK DE PRODUCTOS";
            this.btnProductReport.UseVisualStyleBackColor = true;
            // 
            // btnSendedProducts
            // 
            this.btnSendedProducts.Depth = 0;
            this.btnSendedProducts.Location = new System.Drawing.Point(0, 87);
            this.btnSendedProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSendedProducts.Name = "btnSendedProducts";
            this.btnSendedProducts.Primary = true;
            this.btnSendedProducts.Size = new System.Drawing.Size(684, 27);
            this.btnSendedProducts.TabIndex = 47;
            this.btnSendedProducts.Text = "INFORME DE PRODUCTOS DESPACHADOS";
            this.btnSendedProducts.UseVisualStyleBackColor = true;
            // 
            // btnRecalledStock
            // 
            this.btnRecalledStock.Depth = 0;
            this.btnRecalledStock.Location = new System.Drawing.Point(0, 120);
            this.btnRecalledStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecalledStock.Name = "btnRecalledStock";
            this.btnRecalledStock.Primary = true;
            this.btnRecalledStock.Size = new System.Drawing.Size(684, 27);
            this.btnRecalledStock.TabIndex = 48;
            this.btnRecalledStock.Text = "INFORME DE MATERIALES FALLADOS";
            this.btnRecalledStock.UseVisualStyleBackColor = true;
            // 
            // btnRecalledProducts
            // 
            this.btnRecalledProducts.Depth = 0;
            this.btnRecalledProducts.Location = new System.Drawing.Point(0, 153);
            this.btnRecalledProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecalledProducts.Name = "btnRecalledProducts";
            this.btnRecalledProducts.Primary = true;
            this.btnRecalledProducts.Size = new System.Drawing.Size(684, 27);
            this.btnRecalledProducts.TabIndex = 49;
            this.btnRecalledProducts.Text = "INFORME DE PRODUCTOS FALLADOS";
            this.btnRecalledProducts.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 531);
            this.Controls.Add(this.tbMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "GUITAR CUSTOM SHOP";
            this.tbMain.ResumeLayout(false);
            this.tbStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbAssembly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tbQuality.ResumeLayout(false);
            this.tbReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl tbMain;
        private MetroSet_UI.Child.MetroSetSetTabPage tbStock;
        private MetroSet_UI.Child.MetroSetSetTabPage tbAssembly;
        private MetroSet_UI.Child.MetroSetSetTabPage tbQuality;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddStock;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteStock;
        private MetroSet_UI.Controls.MetroSetTile btnSearchPieces;
        private MetroSet_UI.Controls.MetroSetComboBox cmbPieceType;
        private MetroSet_UI.Controls.MetroSetLabel lblTipoPieza;
        private MetroSet_UI.Controls.MetroSetComboBox cmbCustomType;
        private MetroSet_UI.Controls.MetroSetTextBox txtName;
        private MetroSet_UI.Controls.MetroSetLabel lblOrigin;
        private MetroSet_UI.Controls.MetroSetLabel lblManufacturer;
        private MetroSet_UI.Controls.MetroSetLabel lblDate;
        private MetroSet_UI.Controls.MetroSetLabel lblAmount;
        private MetroSet_UI.Controls.MetroSetLabel lblType;
        private MetroSet_UI.Controls.MetroSetLabel lbName;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private MetroSet_UI.Controls.MetroSetTextBox txtOrigin;
        private MetroSet_UI.Controls.MetroSetComboBox cmbManufacturer;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private MetroSet_UI.Controls.MetroSetTile btnSearchGuitars;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnDispatch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel lblGuitarModel;
        private MetroSet_UI.Controls.MetroSetComboBox cmbGuitarModel;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreate;
        private MetroSet_UI.Child.MetroSetSetTabPage tbReports;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialRaisedButton btnRecallProduct;
        private System.Windows.Forms.DataGridView dataGridView4;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRaisedButton btnRecallStock;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MaterialSkin.Controls.MaterialRaisedButton btnRecalledProducts;
        private MaterialSkin.Controls.MaterialRaisedButton btnRecalledStock;
        private MaterialSkin.Controls.MaterialRaisedButton btnSendedProducts;
        private MaterialSkin.Controls.MaterialRaisedButton btnProductReport;
        private MaterialSkin.Controls.MaterialRaisedButton btnStockReport;
    }
}

