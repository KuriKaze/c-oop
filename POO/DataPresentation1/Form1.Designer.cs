namespace DataPresentation1
{
    partial class Form1
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
            this.dgSensorValueList = new System.Windows.Forms.DataGridView();
            this.PatientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorValueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbPatientCodeStart = new System.Windows.Forms.ComboBox();
            this.bStartPumping = new System.Windows.Forms.Button();
            this.bStopPumping = new System.Windows.Forms.Button();
            this.tbTimePeriod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSensorValueList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorValueBindingSource1)).BeginInit();
            this.SuspendLayout();
            //
            // dgSensorValueList
            //
            this.dgSensorValueList.AccessibleDescription = "dgSensorValueList";
            this.dgSensorValueList.AccessibleName = "dgSensorValueList";
            this.dgSensorValueList.AutoGenerateColumns = false;
            this.dgSensorValueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSensorValueList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientCode,
            this.typeDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn});
            this.dgSensorValueList.DataSource = this.sensorValueBindingSource1;
            this.dgSensorValueList.Location = new System.Drawing.Point(12, 31);
            this.dgSensorValueList.Name = "dgSensorValueList";
            this.dgSensorValueList.Size = new System.Drawing.Size(444, 415);
            this.dgSensorValueList.TabIndex = 0;
            //
            // PatientCode
            //
            this.PatientCode.DataPropertyName = "PatientCode";
            this.PatientCode.HeaderText = "PatientCode";
            this.PatientCode.Name = "PatientCode";
            this.PatientCode.ReadOnly = true;
            //
            // typeDataGridViewTextBoxColumn
            //
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            //
            // valueDataGridViewTextBoxColumn
            //
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            //
            // timeStampDataGridViewTextBoxColumn
            //
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            //
            // sensorValueBindingSource1
            //
            this.sensorValueBindingSource1.DataSource = typeof(Sensor.SensorValue);
            //
            // cbPatientCodeStart
            //
            this.cbPatientCodeStart.AccessibleDescription = "";
            this.cbPatientCodeStart.AccessibleName = "";
            this.cbPatientCodeStart.Location = new System.Drawing.Point(560, 33);
            this.cbPatientCodeStart.Name = "cbPatientCodeStart";
            this.cbPatientCodeStart.Size = new System.Drawing.Size(144, 21);
            this.cbPatientCodeStart.TabIndex = 0;
            this.cbPatientCodeStart.Tag = "";
            //
            // bStartPumping
            //
            this.bStartPumping.Location = new System.Drawing.Point(744, 31);
            this.bStartPumping.Name = "bStartPumping";
            this.bStartPumping.Size = new System.Drawing.Size(157, 23);
            this.bStartPumping.TabIndex = 1;
            this.bStartPumping.Text = "Start Monitoring";
            this.bStartPumping.UseVisualStyleBackColor = true;
            this.bStartPumping.Click += new System.EventHandler(this.bStartPumping_Click);
            //
            // bStopPumping
            //
            this.bStopPumping.Location = new System.Drawing.Point(744, 89);
            this.bStopPumping.Name = "bStopPumping";
            this.bStopPumping.Size = new System.Drawing.Size(157, 23);
            this.bStopPumping.TabIndex = 2;
            this.bStopPumping.Text = "Stop Monitoring";
            this.bStopPumping.UseVisualStyleBackColor = true;
            this.bStopPumping.Click += new System.EventHandler(this.bStopPumping_Click);
            //
            // tbTimePeriod
            //
            this.tbTimePeriod.Location = new System.Drawing.Point(560, 92);
            this.tbTimePeriod.Name = "tbTimePeriod";
            this.tbTimePeriod.Size = new System.Drawing.Size(144, 20);
            this.tbTimePeriod.TabIndex = 3;
            this.tbTimePeriod.Text = "2";
            this.tbTimePeriod.TextChanged += new System.EventHandler(this.tbTimePeriod_TextChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient Code";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time period between samples";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTimePeriod);
            this.Controls.Add(this.bStopPumping);
            this.Controls.Add(this.bStartPumping);
            this.Controls.Add(this.cbPatientCodeStart);
            this.Controls.Add(this.dgSensorValueList);
            this.Name = "Form1";
            this.Text = "Health Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.dgSensorValueList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorValueBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgSensorValueList;
        private System.Windows.Forms.BindingSource sensorValueBindingSource1;
        private System.Windows.Forms.ComboBox cbPatientCodeStart;
        private System.Windows.Forms.Button bStartPumping;
        private System.Windows.Forms.Button bStopPumping;
        private System.Windows.Forms.TextBox tbTimePeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
    }
}