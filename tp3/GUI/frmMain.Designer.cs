
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSave = new System.Windows.Forms.Button();
            this.tbReports = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.btnStockReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbStock = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.pnlPieceProperties = new System.Windows.Forms.Panel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTipoPieza = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbManufacturer = new MetroSet_UI.Controls.MetroSetComboBox();
            this.cmbPieceType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.dtpDateStock = new System.Windows.Forms.DateTimePicker();
            this.cmbCustomType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lblManufacturer = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblDate = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblType = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbName = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnDeleteStock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvPieces = new System.Windows.Forms.DataGridView();
            this.btnAddStock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbMain = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tbAssembly = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.dgvElectronics = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTuners = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPickups = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWood = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblPickups = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblElectronics = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTuners = new MetroSet_UI.Controls.MetroSetLabel();
            this.dgvWood = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvGuitars = new System.Windows.Forms.DataGridView();
            this.dtpDateGuitars = new System.Windows.Forms.DateTimePicker();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblGuitarModel = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbGuitarModel = new MetroSet_UI.Controls.MetroSetComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tbReports.SuspendLayout();
            this.tbStock.SuspendLayout();
            this.pnlPieceProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieces)).BeginInit();
            this.tbMain.SuspendLayout();
            this.tbAssembly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectronics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuitars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::GUI.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(1081, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 35);
            this.btnSave.TabIndex = 28;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbReports
            // 
            this.tbReports.BaseColor = System.Drawing.Color.White;
            this.tbReports.Controls.Add(this.btnStockReport);
            this.tbReports.Font = null;
            this.tbReports.ImageIndex = 2;
            this.tbReports.ImageKey = null;
            this.tbReports.IsDerivedStyle = true;
            this.tbReports.Location = new System.Drawing.Point(4, 42);
            this.tbReports.Name = "tbReports";
            this.tbReports.Size = new System.Drawing.Size(1191, 647);
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
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // tbStock
            // 
            this.tbStock.BaseColor = System.Drawing.Color.White;
            this.tbStock.Controls.Add(this.pnlPieceProperties);
            this.tbStock.Controls.Add(this.btnDeleteStock);
            this.tbStock.Controls.Add(this.dgvPieces);
            this.tbStock.Controls.Add(this.btnAddStock);
            this.tbStock.Font = null;
            this.tbStock.ImageIndex = 0;
            this.tbStock.ImageKey = null;
            this.tbStock.IsDerivedStyle = true;
            this.tbStock.Location = new System.Drawing.Point(4, 42);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(1191, 647);
            this.tbStock.Style = MetroSet_UI.Enums.Style.Light;
            this.tbStock.StyleManager = null;
            this.tbStock.TabIndex = 0;
            this.tbStock.Text = "STOCK";
            this.tbStock.ThemeAuthor = "Narwin";
            this.tbStock.ThemeName = "MetroLite";
            this.tbStock.ToolTipText = null;
            // 
            // pnlPieceProperties
            // 
            this.pnlPieceProperties.BackColor = System.Drawing.Color.White;
            this.pnlPieceProperties.Controls.Add(this.txtName);
            this.pnlPieceProperties.Controls.Add(this.lblTipoPieza);
            this.pnlPieceProperties.Controls.Add(this.cmbManufacturer);
            this.pnlPieceProperties.Controls.Add(this.cmbPieceType);
            this.pnlPieceProperties.Controls.Add(this.dtpDateStock);
            this.pnlPieceProperties.Controls.Add(this.cmbCustomType);
            this.pnlPieceProperties.Controls.Add(this.lblManufacturer);
            this.pnlPieceProperties.Controls.Add(this.lblDate);
            this.pnlPieceProperties.Controls.Add(this.lblType);
            this.pnlPieceProperties.Controls.Add(this.lbName);
            this.pnlPieceProperties.Location = new System.Drawing.Point(5, 3);
            this.pnlPieceProperties.Name = "pnlPieceProperties";
            this.pnlPieceProperties.Size = new System.Drawing.Size(346, 234);
            this.pnlPieceProperties.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(83, 54);
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
            // lblTipoPieza
            // 
            this.lblTipoPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipoPieza.IsDerivedStyle = true;
            this.lblTipoPieza.Location = new System.Drawing.Point(4, 15);
            this.lblTipoPieza.Name = "lblTipoPieza";
            this.lblTipoPieza.Size = new System.Drawing.Size(59, 23);
            this.lblTipoPieza.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTipoPieza.StyleManager = null;
            this.lblTipoPieza.TabIndex = 12;
            this.lblTipoPieza.Text = "PIEZA:";
            this.lblTipoPieza.ThemeAuthor = "Narwin";
            this.lblTipoPieza.ThemeName = "MetroLite";
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
            this.cmbManufacturer.Location = new System.Drawing.Point(110, 182);
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
            this.cmbPieceType.Location = new System.Drawing.Point(90, 12);
            this.cmbPieceType.Name = "cmbPieceType";
            this.cmbPieceType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbPieceType.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbPieceType.Size = new System.Drawing.Size(246, 26);
            this.cmbPieceType.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbPieceType.StyleManager = null;
            this.cmbPieceType.TabIndex = 11;
            this.cmbPieceType.ThemeAuthor = "Narwin";
            this.cmbPieceType.ThemeName = "MetroLite";
            this.cmbPieceType.SelectedIndexChanged += new System.EventHandler(this.cmbPieceType_SelectedIndexChanged);
            // 
            // dtpDateStock
            // 
            this.dtpDateStock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStock.Location = new System.Drawing.Point(90, 141);
            this.dtpDateStock.Name = "dtpDateStock";
            this.dtpDateStock.Size = new System.Drawing.Size(256, 23);
            this.dtpDateStock.TabIndex = 22;
            this.dtpDateStock.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
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
            this.cmbCustomType.Location = new System.Drawing.Point(73, 92);
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
            // lblManufacturer
            // 
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblManufacturer.IsDerivedStyle = true;
            this.lblManufacturer.Location = new System.Drawing.Point(3, 185);
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
            this.lblDate.Location = new System.Drawing.Point(-1, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 23);
            this.lblDate.Style = MetroSet_UI.Enums.Style.Light;
            this.lblDate.StyleManager = null;
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "INGRESO:";
            this.lblDate.ThemeAuthor = "Narwin";
            this.lblDate.ThemeName = "MetroLite";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.IsDerivedStyle = true;
            this.lblType.Location = new System.Drawing.Point(3, 95);
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
            this.lbName.Location = new System.Drawing.Point(3, 54);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 23);
            this.lbName.Style = MetroSet_UI.Enums.Style.Light;
            this.lbName.StyleManager = null;
            this.lbName.TabIndex = 13;
            this.lbName.Text = "NOMBRE:";
            this.lbName.ThemeAuthor = "Narwin";
            this.lbName.ThemeName = "MetroLite";
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Depth = 0;
            this.btnDeleteStock.Location = new System.Drawing.Point(459, 518);
            this.btnDeleteStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Primary = true;
            this.btnDeleteStock.Size = new System.Drawing.Size(651, 27);
            this.btnDeleteStock.TabIndex = 4;
            this.btnDeleteStock.Text = "ELIMINAR";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // dgvPieces
            // 
            this.dgvPieces.AllowUserToAddRows = false;
            this.dgvPieces.AllowUserToResizeColumns = false;
            this.dgvPieces.AllowUserToResizeRows = false;
            this.dgvPieces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPieces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieces.Location = new System.Drawing.Point(463, 0);
            this.dgvPieces.Name = "dgvPieces";
            this.dgvPieces.ReadOnly = true;
            this.dgvPieces.RowHeadersWidth = 10;
            this.dgvPieces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPieces.Size = new System.Drawing.Size(647, 512);
            this.dgvPieces.TabIndex = 0;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Depth = 0;
            this.btnAddStock.Location = new System.Drawing.Point(2, 243);
            this.btnAddStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Primary = true;
            this.btnAddStock.Size = new System.Drawing.Size(348, 27);
            this.btnAddStock.TabIndex = 5;
            this.btnAddStock.Text = "AGREGAR";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
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
            this.tbMain.ImageList = this.imageList2;
            this.tbMain.IsDerivedStyle = true;
            this.tbMain.ItemSize = new System.Drawing.Size(100, 38);
            this.tbMain.Location = new System.Drawing.Point(12, 68);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 2;
            this.tbMain.SelectedTextColor = System.Drawing.Color.White;
            this.tbMain.Size = new System.Drawing.Size(1199, 693);
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
            // tbAssembly
            // 
            this.tbAssembly.BaseColor = System.Drawing.Color.White;
            this.tbAssembly.Controls.Add(this.dgvElectronics);
            this.tbAssembly.Controls.Add(this.dgvTuners);
            this.tbAssembly.Controls.Add(this.dgvPickups);
            this.tbAssembly.Controls.Add(this.lblWood);
            this.tbAssembly.Controls.Add(this.lblPickups);
            this.tbAssembly.Controls.Add(this.lblElectronics);
            this.tbAssembly.Controls.Add(this.lblTuners);
            this.tbAssembly.Controls.Add(this.dgvWood);
            this.tbAssembly.Controls.Add(this.btnCreate);
            this.tbAssembly.Controls.Add(this.dgvGuitars);
            this.tbAssembly.Controls.Add(this.dtpDateGuitars);
            this.tbAssembly.Controls.Add(this.metroSetLabel3);
            this.tbAssembly.Controls.Add(this.lblGuitarModel);
            this.tbAssembly.Controls.Add(this.cmbGuitarModel);
            this.tbAssembly.Font = null;
            this.tbAssembly.ImageIndex = 1;
            this.tbAssembly.ImageKey = "save.png";
            this.tbAssembly.IsDerivedStyle = false;
            this.tbAssembly.Location = new System.Drawing.Point(4, 42);
            this.tbAssembly.Name = "tbAssembly";
            this.tbAssembly.Size = new System.Drawing.Size(1191, 647);
            this.tbAssembly.Style = MetroSet_UI.Enums.Style.Light;
            this.tbAssembly.StyleManager = null;
            this.tbAssembly.TabIndex = 1;
            this.tbAssembly.Text = "ENSAMBLAJE";
            this.tbAssembly.ThemeAuthor = "Narwin";
            this.tbAssembly.ThemeName = "MetroLite";
            this.tbAssembly.ToolTipText = null;
            // 
            // dgvElectronics
            // 
            this.dgvElectronics.AutoGenerateColumns = false;
            this.dgvElectronics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElectronics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvElectronics.DataSource = this.partBindingSource;
            this.dgvElectronics.Location = new System.Drawing.Point(409, 240);
            this.dgvElectronics.Name = "dgvElectronics";
            this.dgvElectronics.ReadOnly = true;
            this.dgvElectronics.RowHeadersVisible = false;
            this.dgvElectronics.RowHeadersWidth = 10;
            this.dgvElectronics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElectronics.ShowEditingIcon = false;
            this.dgvElectronics.Size = new System.Drawing.Size(403, 124);
            this.dgvElectronics.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn10.HeaderText = "Type";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn11.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EntryDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "EntryDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(Entidades.Part);
            // 
            // dgvTuners
            // 
            this.dgvTuners.AutoGenerateColumns = false;
            this.dgvTuners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTuners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvTuners.DataSource = this.partBindingSource;
            this.dgvTuners.Location = new System.Drawing.Point(409, 97);
            this.dgvTuners.Name = "dgvTuners";
            this.dgvTuners.ReadOnly = true;
            this.dgvTuners.RowHeadersVisible = false;
            this.dgvTuners.RowHeadersWidth = 10;
            this.dgvTuners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuners.ShowEditingIcon = false;
            this.dgvTuners.Size = new System.Drawing.Size(403, 124);
            this.dgvTuners.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 65;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn7.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 117;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EntryDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "EntryDate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 96;
            // 
            // dgvPickups
            // 
            this.dgvPickups.AutoGenerateColumns = false;
            this.dgvPickups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPickups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvPickups.DataSource = this.partBindingSource;
            this.dgvPickups.Location = new System.Drawing.Point(0, 240);
            this.dgvPickups.Name = "dgvPickups";
            this.dgvPickups.ReadOnly = true;
            this.dgvPickups.RowHeadersVisible = false;
            this.dgvPickups.RowHeadersWidth = 10;
            this.dgvPickups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPickups.ShowEditingIcon = false;
            this.dgvPickups.Size = new System.Drawing.Size(403, 124);
            this.dgvPickups.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EntryDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "EntryDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblWood
            // 
            this.lblWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWood.IsDerivedStyle = true;
            this.lblWood.Location = new System.Drawing.Point(3, 79);
            this.lblWood.Name = "lblWood";
            this.lblWood.Size = new System.Drawing.Size(86, 15);
            this.lblWood.Style = MetroSet_UI.Enums.Style.Light;
            this.lblWood.StyleManager = null;
            this.lblWood.TabIndex = 51;
            this.lblWood.Text = "MADERA";
            this.lblWood.ThemeAuthor = "Narwin";
            this.lblWood.ThemeName = "MetroLite";
            // 
            // lblPickups
            // 
            this.lblPickups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPickups.IsDerivedStyle = true;
            this.lblPickups.Location = new System.Drawing.Point(3, 224);
            this.lblPickups.Name = "lblPickups";
            this.lblPickups.Size = new System.Drawing.Size(86, 23);
            this.lblPickups.Style = MetroSet_UI.Enums.Style.Light;
            this.lblPickups.StyleManager = null;
            this.lblPickups.TabIndex = 50;
            this.lblPickups.Text = "PICKUPS";
            this.lblPickups.ThemeAuthor = "Narwin";
            this.lblPickups.ThemeName = "MetroLite";
            // 
            // lblElectronics
            // 
            this.lblElectronics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblElectronics.IsDerivedStyle = true;
            this.lblElectronics.Location = new System.Drawing.Point(409, 224);
            this.lblElectronics.Name = "lblElectronics";
            this.lblElectronics.Size = new System.Drawing.Size(106, 23);
            this.lblElectronics.Style = MetroSet_UI.Enums.Style.Light;
            this.lblElectronics.StyleManager = null;
            this.lblElectronics.TabIndex = 49;
            this.lblElectronics.Text = "ELECTRONICA";
            this.lblElectronics.ThemeAuthor = "Narwin";
            this.lblElectronics.ThemeName = "MetroLite";
            // 
            // lblTuners
            // 
            this.lblTuners.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTuners.IsDerivedStyle = true;
            this.lblTuners.Location = new System.Drawing.Point(409, 79);
            this.lblTuners.Name = "lblTuners";
            this.lblTuners.Size = new System.Drawing.Size(86, 15);
            this.lblTuners.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTuners.StyleManager = null;
            this.lblTuners.TabIndex = 48;
            this.lblTuners.Text = "CLAVIJAS";
            this.lblTuners.ThemeAuthor = "Narwin";
            this.lblTuners.ThemeName = "MetroLite";
            // 
            // dgvWood
            // 
            this.dgvWood.AutoGenerateColumns = false;
            this.dgvWood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvWood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn});
            this.dgvWood.DataSource = this.partBindingSource;
            this.dgvWood.Location = new System.Drawing.Point(0, 97);
            this.dgvWood.MultiSelect = false;
            this.dgvWood.Name = "dgvWood";
            this.dgvWood.ReadOnly = true;
            this.dgvWood.RowHeadersVisible = false;
            this.dgvWood.RowHeadersWidth = 10;
            this.dgvWood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWood.ShowEditingIcon = false;
            this.dgvWood.Size = new System.Drawing.Size(403, 124);
            this.dgvWood.TabIndex = 44;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 70;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 65;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Width = 117;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryDateDataGridViewTextBoxColumn.Width = 96;
            // 
            // btnCreate
            // 
            this.btnCreate.Depth = 0;
            this.btnCreate.Location = new System.Drawing.Point(409, 15);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Primary = true;
            this.btnCreate.Size = new System.Drawing.Size(646, 58);
            this.btnCreate.TabIndex = 43;
            this.btnCreate.Text = "FABRICAR";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvGuitars
            // 
            this.dgvGuitars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuitars.Location = new System.Drawing.Point(0, 370);
            this.dgvGuitars.Name = "dgvGuitars";
            this.dgvGuitars.Size = new System.Drawing.Size(1116, 216);
            this.dgvGuitars.TabIndex = 39;
            // 
            // dtpDateGuitars
            // 
            this.dtpDateGuitars.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateGuitars.Location = new System.Drawing.Point(105, 50);
            this.dtpDateGuitars.Name = "dtpDateGuitars";
            this.dtpDateGuitars.Size = new System.Drawing.Size(244, 23);
            this.dtpDateGuitars.TabIndex = 36;
            this.dtpDateGuitars.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(-4, 50);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(108, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 30;
            this.metroSetLabel3.Text = "FABRICACION:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
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
            "TELECASTER"});
            this.cmbGuitarModel.Location = new System.Drawing.Point(105, 18);
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
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "open.png");
            this.imageList2.Images.SetKeyName(1, "save.png");
            this.imageList2.Images.SetKeyName(2, "search.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1138, 707);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUITAR CUSTOM SHOP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbReports.ResumeLayout(false);
            this.tbStock.ResumeLayout(false);
            this.pnlPieceProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieces)).EndInit();
            this.tbMain.ResumeLayout(false);
            this.tbAssembly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectronics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuitars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private MetroSet_UI.Child.MetroSetSetTabPage tbReports;
        private MaterialSkin.Controls.MaterialRaisedButton btnStockReport;
        private MetroSet_UI.Child.MetroSetSetTabPage tbStock;
        private System.Windows.Forms.Panel pnlPieceProperties;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MetroSet_UI.Controls.MetroSetComboBox cmbManufacturer;
        private System.Windows.Forms.DateTimePicker dtpDateStock;
        private MetroSet_UI.Controls.MetroSetComboBox cmbCustomType;
        private MetroSet_UI.Controls.MetroSetLabel lblManufacturer;
        private MetroSet_UI.Controls.MetroSetLabel lblDate;
        private MetroSet_UI.Controls.MetroSetLabel lblType;
        private MetroSet_UI.Controls.MetroSetLabel lbName;
        private MetroSet_UI.Controls.MetroSetLabel lblTipoPieza;
        private MetroSet_UI.Controls.MetroSetComboBox cmbPieceType;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteStock;
        private System.Windows.Forms.DataGridView dgvPieces;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddStock;
        private MetroSet_UI.Controls.MetroSetTabControl tbMain;
        private System.Windows.Forms.BindingSource partBindingSource;
        private MetroSet_UI.Child.MetroSetSetTabPage tbAssembly;
        private System.Windows.Forms.DataGridView dgvElectronics;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView dgvTuners;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dgvPickups;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MetroSet_UI.Controls.MetroSetLabel lblWood;
        private MetroSet_UI.Controls.MetroSetLabel lblPickups;
        private MetroSet_UI.Controls.MetroSetLabel lblElectronics;
        private MetroSet_UI.Controls.MetroSetLabel lblTuners;
        private System.Windows.Forms.DataGridView dgvWood;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreate;
        private System.Windows.Forms.DataGridView dgvGuitars;
        private System.Windows.Forms.DateTimePicker dtpDateGuitars;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel lblGuitarModel;
        private MetroSet_UI.Controls.MetroSetComboBox cmbGuitarModel;
        private System.Windows.Forms.ImageList imageList2;
    }
}

