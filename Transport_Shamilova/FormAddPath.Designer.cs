namespace Transport_Shamilova
{
    partial class FormAddPath
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
            System.Windows.Forms.Label distanceLabel1;
            System.Windows.Forms.Label finalPointLabel1;
            System.Windows.Forms.Label startingPointLabel1;
            System.Windows.Forms.Label distanceLabel;
            System.Windows.Forms.Label finalPointLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label startingPointLabel;
            this.pathBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportDataSet = new Transport_Shamilova.TransportDataSet();
            this.pathTableAdapter = new Transport_Shamilova.TransportDataSetTableAdapters.PathTableAdapter();
            this.tableAdapterManager = new Transport_Shamilova.TransportDataSetTableAdapters.TableAdapterManager();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageAddPath = new System.Windows.Forms.TabPage();
            this.textBoxFinalPoint = new System.Windows.Forms.TextBox();
            this.textBoxStartingPoint = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.tabPageEditPath = new System.Windows.Forms.TabPage();
            this.distanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFinalPoint = new System.Windows.Forms.ComboBox();
            this.comboBoxStartingPoint = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            distanceLabel1 = new System.Windows.Forms.Label();
            finalPointLabel1 = new System.Windows.Forms.Label();
            startingPointLabel1 = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            finalPointLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            startingPointLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pathBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPageAddPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            this.tabPageEditPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // distanceLabel1
            // 
            distanceLabel1.AutoSize = true;
            distanceLabel1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            distanceLabel1.Location = new System.Drawing.Point(72, 251);
            distanceLabel1.Name = "distanceLabel1";
            distanceLabel1.Size = new System.Drawing.Size(114, 23);
            distanceLabel1.TabIndex = 4;
            distanceLabel1.Text = "Расстояние:";
            // 
            // finalPointLabel1
            // 
            finalPointLabel1.AutoSize = true;
            finalPointLabel1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            finalPointLabel1.Location = new System.Drawing.Point(72, 173);
            finalPointLabel1.Name = "finalPointLabel1";
            finalPointLabel1.Size = new System.Drawing.Size(155, 23);
            finalPointLabel1.TabIndex = 2;
            finalPointLabel1.Text = "Конечный пункт:";
            // 
            // startingPointLabel1
            // 
            startingPointLabel1.AutoSize = true;
            startingPointLabel1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startingPointLabel1.Location = new System.Drawing.Point(72, 99);
            startingPointLabel1.Name = "startingPointLabel1";
            startingPointLabel1.Size = new System.Drawing.Size(167, 23);
            startingPointLabel1.TabIndex = 0;
            startingPointLabel1.Text = "Начальный пункт:";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Font = new System.Drawing.Font("STKaiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            distanceLabel.Location = new System.Drawing.Point(96, 249);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(118, 26);
            distanceLabel.TabIndex = 9;
            distanceLabel.Text = "Расстояние";
            // 
            // finalPointLabel
            // 
            finalPointLabel.AutoSize = true;
            finalPointLabel.Font = new System.Drawing.Font("STKaiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            finalPointLabel.Location = new System.Drawing.Point(96, 190);
            finalPointLabel.Name = "finalPointLabel";
            finalPointLabel.Size = new System.Drawing.Size(161, 26);
            finalPointLabel.TabIndex = 8;
            finalPointLabel.Text = "Конечная точка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("STKaiti", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(164, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(252, 27);
            label1.TabIndex = 7;
            label1.Text = "Редактирование Пути:";
            // 
            // startingPointLabel
            // 
            startingPointLabel.AutoSize = true;
            startingPointLabel.Font = new System.Drawing.Font("STKaiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startingPointLabel.Location = new System.Drawing.Point(96, 137);
            startingPointLabel.Name = "startingPointLabel";
            startingPointLabel.Size = new System.Drawing.Size(168, 26);
            startingPointLabel.TabIndex = 7;
            startingPointLabel.Text = "Начальная точка";
            // 
            // pathBindingSource
            // 
            this.pathBindingSource.DataMember = "Path";
            this.pathBindingSource.DataSource = this.transportDataSet;
            // 
            // transportDataSet
            // 
            this.transportDataSet.DataSetName = "TransportDataSet";
            this.transportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pathTableAdapter
            // 
            this.pathTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PathTableAdapter = this.pathTableAdapter;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.TypeOfTransportTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transport_Shamilova.TransportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPageAddPath);
            this.tabControl2.Controls.Add(this.tabPageEditPath);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(582, 453);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPageAddPath
            // 
            this.tabPageAddPath.BackColor = System.Drawing.Color.Lavender;
            this.tabPageAddPath.Controls.Add(this.label2);
            this.tabPageAddPath.Controls.Add(this.textBoxFinalPoint);
            this.tabPageAddPath.Controls.Add(this.textBoxStartingPoint);
            this.tabPageAddPath.Controls.Add(this.buttonAdd);
            this.tabPageAddPath.Controls.Add(this.numericUpDownDistance);
            this.tabPageAddPath.Controls.Add(distanceLabel1);
            this.tabPageAddPath.Controls.Add(finalPointLabel1);
            this.tabPageAddPath.Controls.Add(startingPointLabel1);
            this.tabPageAddPath.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddPath.Name = "tabPageAddPath";
            this.tabPageAddPath.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddPath.Size = new System.Drawing.Size(574, 424);
            this.tabPageAddPath.TabIndex = 0;
            this.tabPageAddPath.Text = "Добавление";
            // 
            // textBoxFinalPoint
            // 
            this.textBoxFinalPoint.Location = new System.Drawing.Point(298, 177);
            this.textBoxFinalPoint.Name = "textBoxFinalPoint";
            this.textBoxFinalPoint.Size = new System.Drawing.Size(182, 22);
            this.textBoxFinalPoint.TabIndex = 8;
            // 
            // textBoxStartingPoint
            // 
            this.textBoxStartingPoint.Location = new System.Drawing.Point(298, 103);
            this.textBoxStartingPoint.Name = "textBoxStartingPoint";
            this.textBoxStartingPoint.Size = new System.Drawing.Size(182, 22);
            this.textBoxStartingPoint.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(188, 341);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(165, 45);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.Location = new System.Drawing.Point(298, 256);
            this.numericUpDownDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(182, 22);
            this.numericUpDownDistance.TabIndex = 6;
            // 
            // tabPageEditPath
            // 
            this.tabPageEditPath.BackColor = System.Drawing.Color.Lavender;
            this.tabPageEditPath.Controls.Add(distanceLabel);
            this.tabPageEditPath.Controls.Add(this.distanceNumericUpDown);
            this.tabPageEditPath.Controls.Add(this.comboBoxFinalPoint);
            this.tabPageEditPath.Controls.Add(this.comboBoxStartingPoint);
            this.tabPageEditPath.Controls.Add(finalPointLabel);
            this.tabPageEditPath.Controls.Add(label1);
            this.tabPageEditPath.Controls.Add(startingPointLabel);
            this.tabPageEditPath.Location = new System.Drawing.Point(4, 25);
            this.tabPageEditPath.Name = "tabPageEditPath";
            this.tabPageEditPath.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditPath.Size = new System.Drawing.Size(574, 424);
            this.tabPageEditPath.TabIndex = 1;
            this.tabPageEditPath.Text = "Редактирование";
            // 
            // distanceNumericUpDown
            // 
            this.distanceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pathBindingSource, "Distance", true));
            this.distanceNumericUpDown.Location = new System.Drawing.Point(307, 254);
            this.distanceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(153, 22);
            this.distanceNumericUpDown.TabIndex = 12;
            // 
            // comboBoxFinalPoint
            // 
            this.comboBoxFinalPoint.DataSource = this.pathBindingSource;
            this.comboBoxFinalPoint.DisplayMember = "FinalPoint";
            this.comboBoxFinalPoint.Enabled = false;
            this.comboBoxFinalPoint.FormattingEnabled = true;
            this.comboBoxFinalPoint.Location = new System.Drawing.Point(307, 194);
            this.comboBoxFinalPoint.Name = "comboBoxFinalPoint";
            this.comboBoxFinalPoint.Size = new System.Drawing.Size(154, 24);
            this.comboBoxFinalPoint.TabIndex = 10;
            this.comboBoxFinalPoint.ValueMember = "IdPath";
            // 
            // comboBoxStartingPoint
            // 
            this.comboBoxStartingPoint.DataSource = this.pathBindingSource;
            this.comboBoxStartingPoint.DisplayMember = "StartingPoint";
            this.comboBoxStartingPoint.FormattingEnabled = true;
            this.comboBoxStartingPoint.Location = new System.Drawing.Point(307, 141);
            this.comboBoxStartingPoint.Name = "comboBoxStartingPoint";
            this.comboBoxStartingPoint.Size = new System.Drawing.Size(154, 24);
            this.comboBoxStartingPoint.TabIndex = 11;
            this.comboBoxStartingPoint.ValueMember = "IdPath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Добавление нового Пути:";
            // 
            // FormAddPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.tabControl2);
            this.Name = "FormAddPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить Путь";
            this.Load += new System.EventHandler(this.FormAddPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pathBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPageAddPath.ResumeLayout(false);
            this.tabPageAddPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            this.tabPageEditPath.ResumeLayout(false);
            this.tabPageEditPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TransportDataSet transportDataSet;
        private System.Windows.Forms.BindingSource pathBindingSource;
        private TransportDataSetTableAdapters.PathTableAdapter pathTableAdapter;
        private TransportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPageAddPath;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownDistance;
        private System.Windows.Forms.TabPage tabPageEditPath;
        private System.Windows.Forms.NumericUpDown distanceNumericUpDown;
        private System.Windows.Forms.ComboBox comboBoxFinalPoint;
        private System.Windows.Forms.ComboBox comboBoxStartingPoint;
        private System.Windows.Forms.TextBox textBoxStartingPoint;
        private System.Windows.Forms.TextBox textBoxFinalPoint;
        private System.Windows.Forms.Label label2;
    }
}