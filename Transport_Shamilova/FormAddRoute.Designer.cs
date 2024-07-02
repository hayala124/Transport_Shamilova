namespace Transport_Shamilova
{
    partial class FormAddRoute
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
            this.transportDataSet = new Transport_Shamilova.TransportDataSet();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new Transport_Shamilova.TransportDataSetTableAdapters.RouteTableAdapter();
            this.tableAdapterManager = new Transport_Shamilova.TransportDataSetTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAddRoute = new System.Windows.Forms.TabPage();
            this.comboBoxPath = new System.Windows.Forms.ComboBox();
            this.pathBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxTypeOfTransport = new System.Windows.Forms.ComboBox();
            this.typeOfTransportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownCars = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStops = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPassengers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumberRoute = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEditRoute = new System.Windows.Forms.TabPage();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPageDeleteRoute = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxNumberRoute = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.typeOfTransportTableAdapter = new Transport_Shamilova.TransportDataSetTableAdapters.TypeOfTransportTableAdapter();
            this.pathTableAdapter = new Transport_Shamilova.TransportDataSetTableAdapters.PathTableAdapter();
            this.dataGridViewRouteEdit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAddRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfTransportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassengers)).BeginInit();
            this.tabPageEditRoute.SuspendLayout();
            this.tabPageDeleteRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRouteEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // transportDataSet
            // 
            this.transportDataSet.DataSetName = "TransportDataSet";
            this.transportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.transportDataSet;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PathTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = this.routeTableAdapter;
            this.tableAdapterManager.TypeOfTransportTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transport_Shamilova.TransportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddRoute);
            this.tabControl1.Controls.Add(this.tabPageEditRoute);
            this.tabControl1.Controls.Add(this.tabPageDeleteRoute);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 453);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageAddRoute
            // 
            this.tabPageAddRoute.BackColor = System.Drawing.Color.Lavender;
            this.tabPageAddRoute.Controls.Add(this.comboBoxPath);
            this.tabPageAddRoute.Controls.Add(this.buttonAdd);
            this.tabPageAddRoute.Controls.Add(this.comboBoxTypeOfTransport);
            this.tabPageAddRoute.Controls.Add(this.numericUpDownCars);
            this.tabPageAddRoute.Controls.Add(this.numericUpDownStops);
            this.tabPageAddRoute.Controls.Add(this.numericUpDownPassengers);
            this.tabPageAddRoute.Controls.Add(this.label5);
            this.tabPageAddRoute.Controls.Add(this.label4);
            this.tabPageAddRoute.Controls.Add(this.label3);
            this.tabPageAddRoute.Controls.Add(this.labelNumberRoute);
            this.tabPageAddRoute.Controls.Add(this.label7);
            this.tabPageAddRoute.Controls.Add(this.label6);
            this.tabPageAddRoute.Controls.Add(this.label2);
            this.tabPageAddRoute.Controls.Add(this.label1);
            this.tabPageAddRoute.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddRoute.Name = "tabPageAddRoute";
            this.tabPageAddRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoute.Size = new System.Drawing.Size(574, 424);
            this.tabPageAddRoute.TabIndex = 0;
            this.tabPageAddRoute.Text = "Добавление";
            // 
            // comboBoxPath
            // 
            this.comboBoxPath.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.routeBindingSource, "PathID", true));
            this.comboBoxPath.DataSource = this.pathBindingSource;
            this.comboBoxPath.DisplayMember = "StartingPoint";
            this.comboBoxPath.FormattingEnabled = true;
            this.comboBoxPath.Location = new System.Drawing.Point(378, 289);
            this.comboBoxPath.Name = "comboBoxPath";
            this.comboBoxPath.Size = new System.Drawing.Size(159, 24);
            this.comboBoxPath.TabIndex = 39;
            this.comboBoxPath.ValueMember = "IdPath";
            // 
            // pathBindingSource
            // 
            this.pathBindingSource.DataMember = "Path";
            this.pathBindingSource.DataSource = this.transportDataSet;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(204, 343);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(171, 46);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // comboBoxTypeOfTransport
            // 
            this.comboBoxTypeOfTransport.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.routeBindingSource, "TypeOfTransportID", true));
            this.comboBoxTypeOfTransport.DataSource = this.typeOfTransportBindingSource;
            this.comboBoxTypeOfTransport.DisplayMember = "NameTransport";
            this.comboBoxTypeOfTransport.FormattingEnabled = true;
            this.comboBoxTypeOfTransport.Location = new System.Drawing.Point(378, 245);
            this.comboBoxTypeOfTransport.Name = "comboBoxTypeOfTransport";
            this.comboBoxTypeOfTransport.Size = new System.Drawing.Size(159, 24);
            this.comboBoxTypeOfTransport.TabIndex = 37;
            this.comboBoxTypeOfTransport.ValueMember = "IdTypeOfTransport";
            // 
            // typeOfTransportBindingSource
            // 
            this.typeOfTransportBindingSource.DataMember = "TypeOfTransport";
            this.typeOfTransportBindingSource.DataSource = this.transportDataSet;
            // 
            // numericUpDownCars
            // 
            this.numericUpDownCars.Location = new System.Drawing.Point(378, 198);
            this.numericUpDownCars.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCars.Name = "numericUpDownCars";
            this.numericUpDownCars.Size = new System.Drawing.Size(158, 22);
            this.numericUpDownCars.TabIndex = 34;
            // 
            // numericUpDownStops
            // 
            this.numericUpDownStops.Location = new System.Drawing.Point(379, 158);
            this.numericUpDownStops.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStops.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownStops.Name = "numericUpDownStops";
            this.numericUpDownStops.Size = new System.Drawing.Size(158, 22);
            this.numericUpDownStops.TabIndex = 35;
            this.numericUpDownStops.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownPassengers
            // 
            this.numericUpDownPassengers.Location = new System.Drawing.Point(379, 106);
            this.numericUpDownPassengers.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPassengers.Name = "numericUpDownPassengers";
            this.numericUpDownPassengers.Size = new System.Drawing.Size(158, 22);
            this.numericUpDownPassengers.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Количество машин на маршруте:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Количество остановок в пути:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Количество пассажиров в день:";
            // 
            // labelNumberRoute
            // 
            this.labelNumberRoute.AutoSize = true;
            this.labelNumberRoute.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberRoute.Location = new System.Drawing.Point(375, 68);
            this.labelNumberRoute.Name = "labelNumberRoute";
            this.labelNumberRoute.Size = new System.Drawing.Size(0, 22);
            this.labelNumberRoute.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(49, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Вид транспорта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(49, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Путь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(148, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Добавление нового Маршрута:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Номер маршрута:";
            // 
            // tabPageEditRoute
            // 
            this.tabPageEditRoute.BackColor = System.Drawing.Color.Lavender;
            this.tabPageEditRoute.Controls.Add(this.dataGridViewRouteEdit);
            this.tabPageEditRoute.Controls.Add(this.buttonEdit);
            this.tabPageEditRoute.Controls.Add(this.label14);
            this.tabPageEditRoute.Location = new System.Drawing.Point(4, 25);
            this.tabPageEditRoute.Name = "tabPageEditRoute";
            this.tabPageEditRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditRoute.Size = new System.Drawing.Size(574, 424);
            this.tabPageEditRoute.TabIndex = 1;
            this.tabPageEditRoute.Text = "Редактирование";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(198, 361);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(171, 46);
            this.buttonEdit.TabIndex = 52;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(142, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(259, 22);
            this.label14.TabIndex = 46;
            this.label14.Text = "Редактирование Маршрута:";
            // 
            // tabPageDeleteRoute
            // 
            this.tabPageDeleteRoute.BackColor = System.Drawing.Color.Lavender;
            this.tabPageDeleteRoute.Controls.Add(this.buttonDelete);
            this.tabPageDeleteRoute.Controls.Add(this.textBoxNumberRoute);
            this.tabPageDeleteRoute.Controls.Add(this.label16);
            this.tabPageDeleteRoute.Controls.Add(this.label17);
            this.tabPageDeleteRoute.Controls.Add(this.label18);
            this.tabPageDeleteRoute.Location = new System.Drawing.Point(4, 25);
            this.tabPageDeleteRoute.Name = "tabPageDeleteRoute";
            this.tabPageDeleteRoute.Size = new System.Drawing.Size(574, 424);
            this.tabPageDeleteRoute.TabIndex = 2;
            this.tabPageDeleteRoute.Text = "Удаление";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(188, 191);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(171, 46);
            this.buttonDelete.TabIndex = 52;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxNumberRoute
            // 
            this.textBoxNumberRoute.Location = new System.Drawing.Point(298, 85);
            this.textBoxNumberRoute.Name = "textBoxNumberRoute";
            this.textBoxNumberRoute.Size = new System.Drawing.Size(167, 22);
            this.textBoxNumberRoute.TabIndex = 51;
            this.textBoxNumberRoute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberRoute_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(378, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 22);
            this.label16.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(168, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 22);
            this.label17.TabIndex = 49;
            this.label17.Text = "Удаление Маршрута:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(73, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 22);
            this.label18.TabIndex = 50;
            this.label18.Text = "Номер маршрута:";
            // 
            // typeOfTransportTableAdapter
            // 
            this.typeOfTransportTableAdapter.ClearBeforeFill = true;
            // 
            // pathTableAdapter
            // 
            this.pathTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewRouteEdit
            // 
            this.dataGridViewRouteEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRouteEdit.Location = new System.Drawing.Point(0, 68);
            this.dataGridViewRouteEdit.Name = "dataGridViewRouteEdit";
            this.dataGridViewRouteEdit.RowHeadersWidth = 51;
            this.dataGridViewRouteEdit.RowTemplate.Height = 24;
            this.dataGridViewRouteEdit.Size = new System.Drawing.Size(571, 277);
            this.dataGridViewRouteEdit.TabIndex = 53;
            // 
            // FormAddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAddRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить Маршрут";
            this.Load += new System.EventHandler(this.FormAddRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddRoute.ResumeLayout(false);
            this.tabPageAddRoute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfTransportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassengers)).EndInit();
            this.tabPageEditRoute.ResumeLayout(false);
            this.tabPageEditRoute.PerformLayout();
            this.tabPageDeleteRoute.ResumeLayout(false);
            this.tabPageDeleteRoute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRouteEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransportDataSet transportDataSet;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private TransportDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private TransportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddRoute;
        private System.Windows.Forms.ComboBox comboBoxTypeOfTransport;
        private System.Windows.Forms.NumericUpDown numericUpDownCars;
        private System.Windows.Forms.NumericUpDown numericUpDownStops;
        private System.Windows.Forms.NumericUpDown numericUpDownPassengers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumberRoute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageEditRoute;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource typeOfTransportBindingSource;
        private TransportDataSetTableAdapters.TypeOfTransportTableAdapter typeOfTransportTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxPath;
        private System.Windows.Forms.BindingSource pathBindingSource;
        private TransportDataSetTableAdapters.PathTableAdapter pathTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageDeleteRoute;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxNumberRoute;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridViewRouteEdit;
    }
}