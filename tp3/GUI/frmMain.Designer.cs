
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
            this.components = new System.ComponentModel.Container();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbReports = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.btnStockReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProductReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbAssembly = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.cmbGuitarModel = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblGuitarModel = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbStock = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.btnAddStock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvPieces = new System.Windows.Forms.DataGridView();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteStock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbPieceType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblTipoPieza = new MetroSet_UI.Controls.MetroSetLabel();
            this.pnlPieceProperties = new System.Windows.Forms.Panel();
            this.lbName = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblType = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblDate = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblManufacturer = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbCustomType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbManufacturer = new MetroSet_UI.Controls.MetroSetComboBox();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbMain = new MetroSet_UI.Controls.MetroSetTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.tbReports.SuspendLayout();
            this.tbAssembly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieces)).BeginInit();
            this.pnlPieceProperties.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(Entidades.Part);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = global::GUI.Properties.Resources.open;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Location = new System.Drawing.Point(924, 27);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(45, 35);
            this.btnOpen.TabIndex = 27;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::GUI.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(975, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 35);
            this.btnSave.TabIndex = 28;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbReports
            // 
            this.tbReports.BaseColor = System.Drawing.Color.White;
            this.tbReports.Controls.Add(this.btnProductReport);
            this.tbReports.Controls.Add(this.btnStockReport);
            this.tbReports.Font = null;
            this.tbReports.ImageIndex = 3;
            this.tbReports.ImageKey = null;
            this.tbReports.IsDerivedStyle = true;
            this.tbReports.Location = new System.Drawing.Point(4, 42);
            this.tbReports.Name = "tbReports";
            this.tbReports.Size = new System.Drawing.Size(1004, 415);
            this.tbReports.Style = MetroSet_UI.Enums.Style.Light;
            this.tbReports.StyleManager = null;
            this.tbReports.TabIndex = 3;
            this.tbReports.Text = "INFORMES";
            this.tbReports.ThemeAuthor = "Narwin";
            this.tbReports.ThemeName = "MetroLite";
            this.tbReports.ToolTipText = null;
            // 
            // btnStockReport
            // 
            this.btnStockReport.Depth = 0;
            this.btnStockReport.Location = new System.Drawing.Point(231, 34);
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
            this.btnProductReport.Location = new System.Drawing.Point(231, 89);
            this.btnProductReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Primary = true;
            this.btnProductReport.Size = new System.Drawing.Size(684, 27);
            this.btnProductReport.TabIndex = 46;
            this.btnProductReport.Text = "INFORME DE STOCK DE PRODUCTOS";
            this.btnProductReport.UseVisualStyleBackColor = true;
            // 
            // tbAssembly
            // 
            this.tbAssembly.BaseColor = System.Drawing.Color.White;
            this.tbAssembly.Controls.Add(this.btnCreate);
            this.tbAssembly.Controls.Add(this.dataGridView2);
            this.tbAssembly.Controls.Add(this.dateTimePicker1);
            this.tbAssembly.Controls.Add(this.numericUpDown1);
            this.tbAssembly.Controls.Add(this.metroSetLabel3);
            this.tbAssembly.Controls.Add(this.metroSetLabel4);
            this.tbAssembly.Controls.Add(this.lblGuitarModel);
            this.tbAssembly.Controls.Add(this.cmbGuitarModel);
            this.tbAssembly.Font = null;
            this.tbAssembly.ImageIndex = 1;
            this.tbAssembly.ImageKey = null;
            this.tbAssembly.IsDerivedStyle = true;
            this.tbAssembly.Location = new System.Drawing.Point(4, 42);
            this.tbAssembly.Name = "tbAssembly";
            this.tbAssembly.Size = new System.Drawing.Size(1004, 415);
            this.tbAssembly.Style = MetroSet_UI.Enums.Style.Light;
            this.tbAssembly.StyleManager = null;
            this.tbAssembly.TabIndex = 1;
            this.tbAssembly.Text = "ENSAMBLAJE";
            this.tbAssembly.ThemeAuthor = "Narwin";
            this.tbAssembly.ThemeName = "MetroLite";
            this.tbAssembly.ToolTipText = null;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(235, 23);
            this.numericUpDown1.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 23);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 105);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(684, 304);
            this.dataGridView2.TabIndex = 39;
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
            // tbStock
            // 
            this.tbStock.BaseColor = System.Drawing.Color.White;
            this.tbStock.Controls.Add(this.pnlPieceProperties);
            this.tbStock.Controls.Add(this.lblTipoPieza);
            this.tbStock.Controls.Add(this.cmbPieceType);
            this.tbStock.Controls.Add(this.btnDeleteStock);
            this.tbStock.Controls.Add(this.dgvPieces);
            this.tbStock.Controls.Add(this.btnAddStock);
            this.tbStock.Font = null;
            this.tbStock.ImageIndex = 0;
            this.tbStock.ImageKey = null;
            this.tbStock.IsDerivedStyle = true;
            this.tbStock.Location = new System.Drawing.Point(4, 42);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(1004, 415);
            this.tbStock.Style = MetroSet_UI.Enums.Style.Light;
            this.tbStock.StyleManager = null;
            this.tbStock.TabIndex = 0;
            this.tbStock.Text = "STOCK";
            this.tbStock.ThemeAuthor = "Narwin";
            this.tbStock.ThemeName = "MetroLite";
            this.tbStock.ToolTipText = null;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Depth = 0;
            this.btnAddStock.Location = new System.Drawing.Point(3, 365);
            this.btnAddStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Primary = true;
            this.btnAddStock.Size = new System.Drawing.Size(348, 27);
            this.btnAddStock.TabIndex = 5;
            this.btnAddStock.Text = "AGREGAR";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // dgvPieces
            // 
            this.dgvPieces.AllowUserToAddRows = false;
            this.dgvPieces.AllowUserToDeleteRows = false;
            this.dgvPieces.AllowUserToResizeColumns = false;
            this.dgvPieces.AllowUserToResizeRows = false;
            this.dgvPieces.AutoGenerateColumns = false;
            this.dgvPieces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPieces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classTypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn});
            this.dgvPieces.DataSource = this.partBindingSource;
            this.dgvPieces.Location = new System.Drawing.Point(357, 3);
            this.dgvPieces.Name = "dgvPieces";
            this.dgvPieces.ReadOnly = true;
            this.dgvPieces.RowHeadersWidth = 10;
            this.dgvPieces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPieces.Size = new System.Drawing.Size(647, 356);
            this.dgvPieces.TabIndex = 0;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "FECHA DE INGRESO";
            this.entryDateDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryDateDataGridViewTextBoxColumn.Width = 153;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "FABRICANTE";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Width = 120;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // classTypeDataGridViewTextBoxColumn
            // 
            this.classTypeDataGridViewTextBoxColumn.DataPropertyName = "ClassType";
            this.classTypeDataGridViewTextBoxColumn.HeaderText = "ITEM";
            this.classTypeDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.classTypeDataGridViewTextBoxColumn.Name = "classTypeDataGridViewTextBoxColumn";
            this.classTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Depth = 0;
            this.btnDeleteStock.Location = new System.Drawing.Point(357, 365);
            this.btnDeleteStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Primary = true;
            this.btnDeleteStock.Size = new System.Drawing.Size(547, 27);
            this.btnDeleteStock.TabIndex = 4;
            this.btnDeleteStock.Text = "ELIMINAR";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
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
            "ELECTRONICA",
            "MADERA",
            "PICKUPS"});
            this.cmbPieceType.Location = new System.Drawing.Point(79, 93);
            this.cmbPieceType.Name = "cmbPieceType";
            this.cmbPieceType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbPieceType.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbPieceType.Size = new System.Drawing.Size(272, 26);
            this.cmbPieceType.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbPieceType.StyleManager = null;
            this.cmbPieceType.TabIndex = 11;
            this.cmbPieceType.ThemeAuthor = "Narwin";
            this.cmbPieceType.ThemeName = "MetroLite";
            this.cmbPieceType.SelectedIndexChanged += new System.EventHandler(this.cmbPieceType_SelectedIndexChanged);
            // 
            // lblTipoPieza
            // 
            this.lblTipoPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipoPieza.IsDerivedStyle = true;
            this.lblTipoPieza.Location = new System.Drawing.Point(0, 96);
            this.lblTipoPieza.Name = "lblTipoPieza";
            this.lblTipoPieza.Size = new System.Drawing.Size(51, 23);
            this.lblTipoPieza.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTipoPieza.StyleManager = null;
            this.lblTipoPieza.TabIndex = 12;
            this.lblTipoPieza.Text = "PIEZA:";
            this.lblTipoPieza.ThemeAuthor = "Narwin";
            this.lblTipoPieza.ThemeName = "MetroLite";
            // 
            // pnlPieceProperties
            // 
            this.pnlPieceProperties.BackColor = System.Drawing.Color.White;
            this.pnlPieceProperties.Controls.Add(this.txtName);
            this.pnlPieceProperties.Controls.Add(this.cmbManufacturer);
            this.pnlPieceProperties.Controls.Add(this.dtpDate);
            this.pnlPieceProperties.Controls.Add(this.cmbCustomType);
            this.pnlPieceProperties.Controls.Add(this.lblManufacturer);
            this.pnlPieceProperties.Controls.Add(this.lblDate);
            this.pnlPieceProperties.Controls.Add(this.lblType);
            this.pnlPieceProperties.Controls.Add(this.lbName);
            this.pnlPieceProperties.Location = new System.Drawing.Point(5, 147);
            this.pnlPieceProperties.Name = "pnlPieceProperties";
            this.pnlPieceProperties.Size = new System.Drawing.Size(346, 212);
            this.pnlPieceProperties.TabIndex = 26;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbName.IsDerivedStyle = true;
            this.lbName.Location = new System.Drawing.Point(0, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 23);
            this.lbName.Style = MetroSet_UI.Enums.Style.Light;
            this.lbName.StyleManager = null;
            this.lbName.TabIndex = 13;
            this.lbName.Text = "NOMBRE:";
            this.lbName.ThemeAuthor = "Narwin";
            this.lbName.ThemeName = "MetroLite";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.IsDerivedStyle = true;
            this.lblType.Location = new System.Drawing.Point(0, 51);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 23);
            this.lblType.Style = MetroSet_UI.Enums.Style.Light;
            this.lblType.StyleManager = null;
            this.lblType.TabIndex = 14;
            this.lblType.Text = "TIPO:";
            this.lblType.ThemeAuthor = "Narwin";
            this.lblType.ThemeName = "MetroLite";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.IsDerivedStyle = true;
            this.lblDate.Location = new System.Drawing.Point(-4, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 23);
            this.lblDate.Style = MetroSet_UI.Enums.Style.Light;
            this.lblDate.StyleManager = null;
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "INGRESO:";
            this.lblDate.ThemeAuthor = "Narwin";
            this.lblDate.ThemeName = "MetroLite";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblManufacturer.IsDerivedStyle = true;
            this.lblManufacturer.Location = new System.Drawing.Point(0, 141);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(109, 23);
            this.lblManufacturer.Style = MetroSet_UI.Enums.Style.Light;
            this.lblManufacturer.StyleManager = null;
            this.lblManufacturer.TabIndex = 17;
            this.lblManufacturer.Text = "FABRICANTE:";
            this.lblManufacturer.ThemeAuthor = "Narwin";
            this.lblManufacturer.ThemeName = "MetroLite";
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
            this.cmbCustomType.Location = new System.Drawing.Point(70, 48);
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
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(87, 97);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(256, 23);
            this.dtpDate.TabIndex = 22;
            this.dtpDate.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
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
            this.cmbManufacturer.Location = new System.Drawing.Point(107, 138);
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
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(80, 10);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(262, 23);
            this.txtName.TabIndex = 24;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // tbMain
            // 
            this.tbMain.AccessibleName = "";
            this.tbMain.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tbMain.AnimateTime = 200;
            this.tbMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbMain.BackgroundColor = System.Drawing.Color.White;
            this.tbMain.Controls.Add(this.tbStock);
            this.tbMain.Controls.Add(this.tbAssembly);
            this.tbMain.Controls.Add(this.tbReports);
            this.tbMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbMain.IsDerivedStyle = true;
            this.tbMain.ItemSize = new System.Drawing.Size(100, 38);
            this.tbMain.Location = new System.Drawing.Point(12, 68);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.SelectedTextColor = System.Drawing.Color.White;
            this.tbMain.Size = new System.Drawing.Size(1012, 461);
            this.tbMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbMain.Speed = 100;
            this.tbMain.Style = MetroSet_UI.Enums.Style.Light;
            this.tbMain.StyleManager = null;
            this.tbMain.TabIndex = 0;
            this.tbMain.TabStop = false;
            this.tbMain.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.tbMain.ThemeAuthor = "Narwin";
            this.tbMain.ThemeName = "MetroLite";
            this.tbMain.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tbMain.UseAnimation = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 531);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUITAR CUSTOM SHOP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.tbReports.ResumeLayout(false);
            this.tbAssembly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tbStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieces)).EndInit();
            this.pnlPieceProperties.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource partBindingSource;
        private MetroSet_UI.Child.MetroSetSetTabPage tbReports;
        private MaterialSkin.Controls.MaterialRaisedButton btnProductReport;
        private MaterialSkin.Controls.MaterialRaisedButton btnStockReport;
        private MetroSet_UI.Child.MetroSetSetTabPage tbAssembly;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel lblGuitarModel;
        private MetroSet_UI.Controls.MetroSetComboBox cmbGuitarModel;
        private MetroSet_UI.Child.MetroSetSetTabPage tbStock;
        private System.Windows.Forms.Panel pnlPieceProperties;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MetroSet_UI.Controls.MetroSetComboBox cmbManufacturer;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private MetroSet_UI.Controls.MetroSetComboBox cmbCustomType;
        private MetroSet_UI.Controls.MetroSetLabel lblManufacturer;
        private MetroSet_UI.Controls.MetroSetLabel lblDate;
        private MetroSet_UI.Controls.MetroSetLabel lblType;
        private MetroSet_UI.Controls.MetroSetLabel lbName;
        private MetroSet_UI.Controls.MetroSetLabel lblTipoPieza;
        private MetroSet_UI.Controls.MetroSetComboBox cmbPieceType;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteStock;
        private System.Windows.Forms.DataGridView dgvPieces;
        private System.Windows.Forms.DataGridViewTextBoxColumn classTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddStock;
        private MetroSet_UI.Controls.MetroSetTabControl tbMain;
    }
}

