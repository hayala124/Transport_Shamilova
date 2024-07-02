namespace Transport_Shamilova
{
    partial class FormRoute
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
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportDataSet = new Transport_Shamilova.TransportDataSet();
            this.routeTableAdapter = new Transport_Shamilova.TransportDataSetTableAdapters.RouteTableAdapter();
            this.tableAdapterManager = new Transport_Shamilova.TransportDataSetTableAdapters.TableAdapterManager();
            this.transportDataSet1 = new Transport_Shamilova.TransportDataSet();
            this.typeOfTransportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfTransportTableAdapter = new Transport_Shamilova.TransportDataSetTableAdapters.TypeOfTransportTableAdapter();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.dataGridViewRoute = new System.Windows.Forms.DataGridView();
            this.buttonAddRoute = new System.Windows.Forms.Button();
            this.buttonEditRoute = new System.Windows.Forms.Button();
            this.buttonDeleteRoute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNumberRouteFiltr = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrStops = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfTransportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.transportDataSet;
            // 
            // transportDataSet
            // 
            this.transportDataSet.DataSetName = "TransportDataSet";
            this.transportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // transportDataSet1
            // 
            this.transportDataSet1.DataSetName = "TransportDataSet";
            this.transportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeOfTransportBindingSource
            // 
            this.typeOfTransportBindingSource.DataMember = "TypeOfTransport";
            this.typeOfTransportBindingSource.DataSource = this.transportDataSet1;
            // 
            // typeOfTransportTableAdapter
            // 
            this.typeOfTransportTableAdapter.ClearBeforeFill = true;
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExportExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExportExcel.Location = new System.Drawing.Point(4, 320);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(158, 36);
            this.buttonExportExcel.TabIndex = 2;
            this.buttonExportExcel.Text = "Экспорт";
            this.buttonExportExcel.UseVisualStyleBackColor = false;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // dataGridViewRoute
            // 
            this.dataGridViewRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewRoute.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRoute.Name = "dataGridViewRoute";
            this.dataGridViewRoute.RowHeadersWidth = 51;
            this.dataGridViewRoute.RowTemplate.Height = 24;
            this.dataGridViewRoute.Size = new System.Drawing.Size(764, 211);
            this.dataGridViewRoute.TabIndex = 3;
            // 
            // buttonAddRoute
            // 
            this.buttonAddRoute.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAddRoute.Enabled = false;
            this.buttonAddRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRoute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddRoute.Location = new System.Drawing.Point(195, 320);
            this.buttonAddRoute.Name = "buttonAddRoute";
            this.buttonAddRoute.Size = new System.Drawing.Size(158, 36);
            this.buttonAddRoute.TabIndex = 2;
            this.buttonAddRoute.Text = "Добавить";
            this.buttonAddRoute.UseVisualStyleBackColor = false;
            this.buttonAddRoute.Click += new System.EventHandler(this.buttonAddRoute_Click);
            // 
            // buttonEditRoute
            // 
            this.buttonEditRoute.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonEditRoute.Enabled = false;
            this.buttonEditRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditRoute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditRoute.Location = new System.Drawing.Point(402, 320);
            this.buttonEditRoute.Name = "buttonEditRoute";
            this.buttonEditRoute.Size = new System.Drawing.Size(158, 36);
            this.buttonEditRoute.TabIndex = 2;
            this.buttonEditRoute.Text = "Редактировать";
            this.buttonEditRoute.UseVisualStyleBackColor = false;
            this.buttonEditRoute.Click += new System.EventHandler(this.buttonEditRoute_Click);
            // 
            // buttonDeleteRoute
            // 
            this.buttonDeleteRoute.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDeleteRoute.Enabled = false;
            this.buttonDeleteRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteRoute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteRoute.Location = new System.Drawing.Point(598, 320);
            this.buttonDeleteRoute.Name = "buttonDeleteRoute";
            this.buttonDeleteRoute.Size = new System.Drawing.Size(158, 36);
            this.buttonDeleteRoute.TabIndex = 2;
            this.buttonDeleteRoute.Text = "Удалить";
            this.buttonDeleteRoute.UseVisualStyleBackColor = false;
            this.buttonDeleteRoute.Click += new System.EventHandler(this.buttonDeleteRoute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фильтрация данных по номеру маршрута";
            // 
            // comboBoxNumberRouteFiltr
            // 
            this.comboBoxNumberRouteFiltr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.routeBindingSource, "IdRoute", true));
            this.comboBoxNumberRouteFiltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberRouteFiltr.FormattingEnabled = true;
            this.comboBoxNumberRouteFiltr.Items.AddRange(new object[] {
            "100-110",
            "110-120",
            "120-∞",
            "Все"});
            this.comboBoxNumberRouteFiltr.Location = new System.Drawing.Point(510, 232);
            this.comboBoxNumberRouteFiltr.Name = "comboBoxNumberRouteFiltr";
            this.comboBoxNumberRouteFiltr.Size = new System.Drawing.Size(175, 24);
            this.comboBoxNumberRouteFiltr.TabIndex = 5;
            this.comboBoxNumberRouteFiltr.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberRouteFiltr_SelectedIndexChanged);
            // 
            // textBoxFiltrStops
            // 
            this.textBoxFiltrStops.Location = new System.Drawing.Point(510, 280);
            this.textBoxFiltrStops.Name = "textBoxFiltrStops";
            this.textBoxFiltrStops.Size = new System.Drawing.Size(175, 22);
            this.textBoxFiltrStops.TabIndex = 6;
            this.textBoxFiltrStops.TextChanged += new System.EventHandler(this.textBoxFiltrStops_TextChanged);
            this.textBoxFiltrStops.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltrStops_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фильтрация данных по количеству остановок в пути";
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(764, 378);
            this.Controls.Add(this.textBoxFiltrStops);
            this.Controls.Add(this.comboBoxNumberRouteFiltr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRoute);
            this.Controls.Add(this.buttonDeleteRoute);
            this.Controls.Add(this.buttonEditRoute);
            this.Controls.Add(this.buttonAddRoute);
            this.Controls.Add(this.buttonExportExcel);
            this.Name = "FormRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Маршрут";
            this.Load += new System.EventHandler(this.FormRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfTransportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransportDataSet transportDataSet;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private TransportDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private TransportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TransportDataSet transportDataSet1;
        private System.Windows.Forms.BindingSource typeOfTransportBindingSource;
        private TransportDataSetTableAdapters.TypeOfTransportTableAdapter typeOfTransportTableAdapter;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.DataGridView dataGridViewRoute;
        private System.Windows.Forms.Button buttonAddRoute;
        private System.Windows.Forms.Button buttonEditRoute;
        private System.Windows.Forms.Button buttonDeleteRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNumberRouteFiltr;
        private System.Windows.Forms.TextBox textBoxFiltrStops;
        private System.Windows.Forms.Label label2;
    }
}