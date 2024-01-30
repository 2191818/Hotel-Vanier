namespace HotelVanier
{
    partial class Billing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBillDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.addBillButton = new System.Windows.Forms.Button();
            this.addBillAmountTextBox = new System.Windows.Forms.TextBox();
            this.addBillCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hotelVanierDBDataSet = new HotelVanier.HotelVanierDBDataSet();
            this.viewCustomerAndBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewCustomerAndBillTableAdapter = new HotelVanier.HotelVanierDBDataSetTableAdapters.ViewCustomerAndBillTableAdapter();
            this.tableAdapterManager = new HotelVanier.HotelVanierDBDataSetTableAdapters.TableAdapterManager();
            this.viewCustomerAndBillBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewCustomerAndBillBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.viewCustomerAndBillDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalAmountSelectedTextBox = new System.Windows.Forms.TextBox();
            this.resetSeachBillsButton = new System.Windows.Forms.Button();
            this.deleteBillsButton = new System.Windows.Forms.Button();
            this.payBillsButton = new System.Windows.Forms.Button();
            this.searchBillsButton = new System.Windows.Forms.Button();
            this.searchBillsAmountTextBox = new System.Windows.Forms.TextBox();
            this.searchBillsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.searchBillsIDTextBox = new System.Windows.Forms.TextBox();
            this.searchBillsCustomerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchBillsCustomerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.searchBillsCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new HotelVanier.HotelVanierDBDataSetTableAdapters.BillTableAdapter();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new HotelVanier.HotelVanierDBDataSetTableAdapters.CustomerTableAdapter();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelVanierDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerAndBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerAndBillBindingNavigator)).BeginInit();
            this.viewCustomerAndBillBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerAndBillDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.addBillDescriptionComboBox);
            this.groupBox1.Controls.Add(this.addBillButton);
            this.groupBox1.Controls.Add(this.addBillAmountTextBox);
            this.groupBox1.Controls.Add(this.addBillCustomerIDTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
<<<<<<< Updated upstream
=======
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 425);
>>>>>>> Stashed changes
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // addBillDescriptionComboBox
            // 
            resources.ApplyResources(this.addBillDescriptionComboBox, "addBillDescriptionComboBox");
            this.addBillDescriptionComboBox.FormattingEnabled = true;
            this.addBillDescriptionComboBox.Items.AddRange(new object[] {
            resources.GetString("addBillDescriptionComboBox.Items"),
            resources.GetString("addBillDescriptionComboBox.Items1"),
            resources.GetString("addBillDescriptionComboBox.Items2"),
            resources.GetString("addBillDescriptionComboBox.Items3"),
            resources.GetString("addBillDescriptionComboBox.Items4"),
            resources.GetString("addBillDescriptionComboBox.Items5")});
            this.addBillDescriptionComboBox.Name = "addBillDescriptionComboBox";
            // 
            // addBillButton
            // 
            resources.ApplyResources(this.addBillButton, "addBillButton");
            this.addBillButton.BackColor = System.Drawing.Color.SpringGreen;
            this.addBillButton.Name = "addBillButton";
            this.addBillButton.UseVisualStyleBackColor = false;
            this.addBillButton.Click += new System.EventHandler(this.addBillButton_Click);
            // 
            // addBillAmountTextBox
            // 
            resources.ApplyResources(this.addBillAmountTextBox, "addBillAmountTextBox");
            this.addBillAmountTextBox.Name = "addBillAmountTextBox";
            // 
            // addBillCustomerIDTextBox
            // 
            resources.ApplyResources(this.addBillCustomerIDTextBox, "addBillCustomerIDTextBox");
            this.addBillCustomerIDTextBox.Name = "addBillCustomerIDTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // hotelVanierDBDataSet
            // 
            this.hotelVanierDBDataSet.DataSetName = "HotelVanierDBDataSet";
            this.hotelVanierDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewCustomerAndBillBindingSource
            // 
            this.viewCustomerAndBillBindingSource.DataMember = "ViewCustomerAndBill";
            this.viewCustomerAndBillBindingSource.DataSource = this.hotelVanierDBDataSet;
            // 
            // viewCustomerAndBillTableAdapter
            // 
            this.viewCustomerAndBillTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.HotelRoomTableAdapter = null;
            this.tableAdapterManager.RoomStatusInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelVanier.HotelVanierDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viewCustomerAndBillBindingNavigator
            // 
            resources.ApplyResources(this.viewCustomerAndBillBindingNavigator, "viewCustomerAndBillBindingNavigator");
            this.viewCustomerAndBillBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.viewCustomerAndBillBindingNavigator.BindingSource = this.viewCustomerAndBillBindingSource;
            this.viewCustomerAndBillBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.viewCustomerAndBillBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.viewCustomerAndBillBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.viewCustomerAndBillBindingNavigatorSaveItem});
            this.viewCustomerAndBillBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.viewCustomerAndBillBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.viewCustomerAndBillBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.viewCustomerAndBillBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.viewCustomerAndBillBindingNavigator.Name = "viewCustomerAndBillBindingNavigator";
            this.viewCustomerAndBillBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
<<<<<<< Updated upstream
=======
            this.viewCustomerAndBillBindingNavigator.Size = new System.Drawing.Size(771, 25);
            this.viewCustomerAndBillBindingNavigator.TabIndex = 5;
            this.viewCustomerAndBillBindingNavigator.Text = "bindingNavigator1";
>>>>>>> Stashed changes
            // 
            // bindingNavigatorAddNewItem
            // 
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorCountItem
            // 
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            // 
            // bindingNavigatorDeleteItem
            // 
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            // 
            // bindingNavigatorMoveNextItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            // 
            // viewCustomerAndBillBindingNavigatorSaveItem
            // 
            resources.ApplyResources(this.viewCustomerAndBillBindingNavigatorSaveItem, "viewCustomerAndBillBindingNavigatorSaveItem");
            this.viewCustomerAndBillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viewCustomerAndBillBindingNavigatorSaveItem.Name = "viewCustomerAndBillBindingNavigatorSaveItem";
            // 
            // viewCustomerAndBillDataGridView
            // 
            resources.ApplyResources(this.viewCustomerAndBillDataGridView, "viewCustomerAndBillDataGridView");
            this.viewCustomerAndBillDataGridView.AutoGenerateColumns = false;
            this.viewCustomerAndBillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCustomerAndBillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.viewCustomerAndBillDataGridView.DataSource = this.viewCustomerAndBillBindingSource;
<<<<<<< Updated upstream
=======
            this.viewCustomerAndBillDataGridView.Location = new System.Drawing.Point(8, 52);
>>>>>>> Stashed changes
            this.viewCustomerAndBillDataGridView.Name = "viewCustomerAndBillDataGridView";
            this.viewCustomerAndBillDataGridView.SelectionChanged += new System.EventHandler(this.viewCustomerAndBillDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BillId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CustomerFirstName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CustomerLastName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BillDescription";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Amount";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Paid";
            resources.ApplyResources(this.dataGridViewCheckBoxColumn1, "dataGridViewCheckBoxColumn1");
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.totalAmountSelectedTextBox);
            this.groupBox2.Controls.Add(this.resetSeachBillsButton);
            this.groupBox2.Controls.Add(this.deleteBillsButton);
            this.groupBox2.Controls.Add(this.payBillsButton);
            this.groupBox2.Controls.Add(this.searchBillsButton);
            this.groupBox2.Controls.Add(this.searchBillsAmountTextBox);
            this.groupBox2.Controls.Add(this.searchBillsDescriptionTextBox);
            this.groupBox2.Controls.Add(this.searchBillsIDTextBox);
            this.groupBox2.Controls.Add(this.searchBillsCustomerLastNameTextBox);
            this.groupBox2.Controls.Add(this.searchBillsCustomerFirstNameTextBox);
            this.groupBox2.Controls.Add(this.searchBillsCustomerIDTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
<<<<<<< Updated upstream
=======
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(341, 425);
>>>>>>> Stashed changes
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // totalAmountSelectedTextBox
            // 
            resources.ApplyResources(this.totalAmountSelectedTextBox, "totalAmountSelectedTextBox");
            this.totalAmountSelectedTextBox.Name = "totalAmountSelectedTextBox";
            this.totalAmountSelectedTextBox.ReadOnly = true;
            // 
            // resetSeachBillsButton
            // 
            resources.ApplyResources(this.resetSeachBillsButton, "resetSeachBillsButton");
            this.resetSeachBillsButton.Name = "resetSeachBillsButton";
            this.resetSeachBillsButton.UseVisualStyleBackColor = true;
            this.resetSeachBillsButton.Click += new System.EventHandler(this.resetSeachBillsButton_Click);
            // 
            // deleteBillsButton
            // 
            resources.ApplyResources(this.deleteBillsButton, "deleteBillsButton");
            this.deleteBillsButton.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBillsButton.Name = "deleteBillsButton";
            this.deleteBillsButton.UseVisualStyleBackColor = false;
            this.deleteBillsButton.Click += new System.EventHandler(this.deleteBillsButton_Click);
            // 
            // payBillsButton
            // 
            resources.ApplyResources(this.payBillsButton, "payBillsButton");
            this.payBillsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.payBillsButton.Name = "payBillsButton";
            this.payBillsButton.UseVisualStyleBackColor = false;
            this.payBillsButton.Click += new System.EventHandler(this.payBillsButton_Click);
            // 
            // searchBillsButton
            // 
            resources.ApplyResources(this.searchBillsButton, "searchBillsButton");
            this.searchBillsButton.Name = "searchBillsButton";
            this.searchBillsButton.UseVisualStyleBackColor = true;
            this.searchBillsButton.Click += new System.EventHandler(this.searchBillsButton_Click);
            // 
            // searchBillsAmountTextBox
            // 
            resources.ApplyResources(this.searchBillsAmountTextBox, "searchBillsAmountTextBox");
            this.searchBillsAmountTextBox.Name = "searchBillsAmountTextBox";
            this.searchBillsAmountTextBox.TextChanged += new System.EventHandler(this.searchBillsAmountTextBox_TextChanged);
            // 
            // searchBillsDescriptionTextBox
            // 
            resources.ApplyResources(this.searchBillsDescriptionTextBox, "searchBillsDescriptionTextBox");
            this.searchBillsDescriptionTextBox.Name = "searchBillsDescriptionTextBox";
            this.searchBillsDescriptionTextBox.TextChanged += new System.EventHandler(this.searchBillsDescriptionTextBox_TextChanged);
            // 
            // searchBillsIDTextBox
            // 
            resources.ApplyResources(this.searchBillsIDTextBox, "searchBillsIDTextBox");
            this.searchBillsIDTextBox.Name = "searchBillsIDTextBox";
            this.searchBillsIDTextBox.TextChanged += new System.EventHandler(this.searchBillsIDTextBox_TextChanged);
            // 
            // searchBillsCustomerLastNameTextBox
            // 
            resources.ApplyResources(this.searchBillsCustomerLastNameTextBox, "searchBillsCustomerLastNameTextBox");
            this.searchBillsCustomerLastNameTextBox.Name = "searchBillsCustomerLastNameTextBox";
            this.searchBillsCustomerLastNameTextBox.TextChanged += new System.EventHandler(this.searchBillsCustomerLastNameTextBox_TextChanged);
            // 
            // searchBillsCustomerFirstNameTextBox
            // 
            resources.ApplyResources(this.searchBillsCustomerFirstNameTextBox, "searchBillsCustomerFirstNameTextBox");
            this.searchBillsCustomerFirstNameTextBox.Name = "searchBillsCustomerFirstNameTextBox";
            this.searchBillsCustomerFirstNameTextBox.TextChanged += new System.EventHandler(this.searchBillsCustomerFirstNameTextBox_TextChanged);
            // 
            // searchBillsCustomerIDTextBox
            // 
            resources.ApplyResources(this.searchBillsCustomerIDTextBox, "searchBillsCustomerIDTextBox");
            this.searchBillsCustomerIDTextBox.Name = "searchBillsCustomerIDTextBox";
            this.searchBillsCustomerIDTextBox.TextChanged += new System.EventHandler(this.searchBillsCustomerIDTextBox_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.hotelVanierDBDataSet;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.hotelVanierDBDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
<<<<<<< Updated upstream
            this.pictureBox.Name = "pictureBox";
=======
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(8, 532);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(327, 106);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 25;
>>>>>>> Stashed changes
            this.pictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
<<<<<<< Updated upstream
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
=======
>>>>>>> Stashed changes
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.signoutToolStripMenuItem,
            this.exitToolStripMenuItem});
<<<<<<< Updated upstream
            this.menuStrip1.Name = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            resources.ApplyResources(this.homeToolStripMenuItem, "homeToolStripMenuItem");
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // signoutToolStripMenuItem
            // 
            resources.ApplyResources(this.signoutToolStripMenuItem, "signoutToolStripMenuItem");
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Click += new System.EventHandler(this.signoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
=======
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // signoutToolStripMenuItem
            // 
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.signoutToolStripMenuItem.Text = "Signout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
>>>>>>> Stashed changes
            // 
            // Billing
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
=======
            this.ClientSize = new System.Drawing.Size(771, 643);
>>>>>>> Stashed changes
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.viewCustomerAndBillDataGridView);
            this.Controls.Add(this.viewCustomerAndBillBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelVanierDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerAndBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerAndBillBindingNavigator)).EndInit();
            this.viewCustomerAndBillBindingNavigator.ResumeLayout(false);
            this.viewCustomerAndBillBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerAndBillDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private HotelVanierDBDataSet hotelVanierDBDataSet;
        private System.Windows.Forms.BindingSource viewCustomerAndBillBindingSource;
        private HotelVanierDBDataSetTableAdapters.ViewCustomerAndBillTableAdapter viewCustomerAndBillTableAdapter;
        private HotelVanierDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator viewCustomerAndBillBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton viewCustomerAndBillBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView viewCustomerAndBillDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBillButton;
        private System.Windows.Forms.TextBox addBillAmountTextBox;
        private System.Windows.Forms.TextBox addBillCustomerIDTextBox;
        private System.Windows.Forms.Button deleteBillsButton;
        private System.Windows.Forms.Button payBillsButton;
        private System.Windows.Forms.Button searchBillsButton;
        private System.Windows.Forms.TextBox searchBillsAmountTextBox;
        private System.Windows.Forms.TextBox searchBillsDescriptionTextBox;
        private System.Windows.Forms.TextBox searchBillsIDTextBox;
        private System.Windows.Forms.TextBox searchBillsCustomerLastNameTextBox;
        private System.Windows.Forms.TextBox searchBillsCustomerFirstNameTextBox;
        private System.Windows.Forms.TextBox searchBillsCustomerIDTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource billBindingSource;
        private HotelVanierDBDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private HotelVanierDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button resetSeachBillsButton;
        private System.Windows.Forms.TextBox totalAmountSelectedTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
<<<<<<< Updated upstream
        private System.Windows.Forms.ComboBox addBillDescriptionComboBox;
=======
>>>>>>> Stashed changes
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}