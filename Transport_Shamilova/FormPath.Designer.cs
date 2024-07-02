namespace Transport_Shamilova
{
    partial class FormPath
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
            this.transportDataSet1 = new Transport_Shamilova.TransportDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddPath = new System.Windows.Forms.Button();
            this.buttonEditPath = new System.Windows.Forms.Button();
            this.dataGridViewPath = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPath)).BeginInit();
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
            // transportDataSet1
            // 
            this.transportDataSet1.DataSetName = "TransportDataSet";
            this.transportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пути всех маршрутов";
            // 
            // buttonAddPath
            // 
            this.buttonAddPath.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAddPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddPath.Location = new System.Drawing.Point(12, 12);
            this.buttonAddPath.Name = "buttonAddPath";
            this.buttonAddPath.Size = new System.Drawing.Size(161, 31);
            this.buttonAddPath.TabIndex = 2;
            this.buttonAddPath.Text = "Добавить";
            this.buttonAddPath.UseVisualStyleBackColor = false;
            this.buttonAddPath.Click += new System.EventHandler(this.buttonAddPath_Click);
            // 
            // buttonEditPath
            // 
            this.buttonEditPath.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonEditPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditPath.Location = new System.Drawing.Point(445, 12);
            this.buttonEditPath.Name = "buttonEditPath";
            this.buttonEditPath.Size = new System.Drawing.Size(161, 31);
            this.buttonEditPath.TabIndex = 2;
            this.buttonEditPath.Text = "Редактировать";
            this.buttonEditPath.UseVisualStyleBackColor = false;
            this.buttonEditPath.Click += new System.EventHandler(this.buttonEditPath_Click);
            // 
            // dataGridViewPath
            // 
            this.dataGridViewPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPath.Location = new System.Drawing.Point(0, 122);
            this.dataGridViewPath.Name = "dataGridViewPath";
            this.dataGridViewPath.RowHeadersWidth = 51;
            this.dataGridViewPath.RowTemplate.Height = 24;
            this.dataGridViewPath.Size = new System.Drawing.Size(606, 226);
            this.dataGridViewPath.TabIndex = 0;
            // 
            // FormPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(606, 348);
            this.Controls.Add(this.buttonEditPath);
            this.Controls.Add(this.buttonAddPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPath);
            this.Name = "FormPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пути";
            this.Load += new System.EventHandler(this.FormPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TransportDataSet transportDataSet;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private TransportDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private TransportDataSet transportDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddPath;
        private System.Windows.Forms.Button buttonEditPath;
        private System.Windows.Forms.DataGridView dataGridViewPath;
    }
}