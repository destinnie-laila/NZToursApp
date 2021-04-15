namespace NZTours
{
    partial class frmTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNZ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnEditCost = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lstCost = new System.Windows.Forms.ListBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nupMarkup = new System.Windows.Forms.NumericUpDown();
            this.nupPassanger = new System.Windows.Forms.NumericUpDown();
            this.nupDistance = new System.Windows.Forms.NumericUpDown();
            this.cboCostType = new System.Windows.Forms.ComboBox();
            this.btnAddCost = new System.Windows.Forms.Button();
            this.lblPricepp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupMarkup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPassanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tour Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(25, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Cost";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.Location = new System.Drawing.Point(163, 71);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(163, 122);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(71, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Distance KMs";
            // 
            // lblNZ
            // 
            this.lblNZ.AutoSize = true;
            this.lblNZ.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNZ.Location = new System.Drawing.Point(308, 9);
            this.lblNZ.Name = "lblNZ";
            this.lblNZ.Size = new System.Drawing.Size(174, 39);
            this.lblNZ.TabIndex = 13;
            this.lblNZ.Text = "NZ Tours!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mark-up %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "# Passangers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "End Date ";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(416, 69);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 19;
            this.dtpStart.Value = new System.DateTime(2020, 5, 16, 0, 0, 0, 0);
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(416, 111);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 20;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // btnEditCost
            // 
            this.btnEditCost.Location = new System.Drawing.Point(103, 221);
            this.btnEditCost.Name = "btnEditCost";
            this.btnEditCost.Size = new System.Drawing.Size(75, 23);
            this.btnEditCost.TabIndex = 22;
            this.btnEditCost.Text = "Edit";
            this.btnEditCost.UseVisualStyleBackColor = true;
            this.btnEditCost.Click += new System.EventHandler(this.btnEditCost_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(353, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Price Per Person";
            // 
            // lstCost
            // 
            this.lstCost.AllowDrop = true;
            this.lstCost.FormattingEnabled = true;
            this.lstCost.ItemHeight = 16;
            this.lstCost.Location = new System.Drawing.Point(11, 42);
            this.lstCost.Name = "lstCost";
            this.lstCost.Size = new System.Drawing.Size(277, 132);
            this.lstCost.TabIndex = 28;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(176, 279);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(69, 20);
            this.lblTotalCost.TabIndex = 29;
            this.lblTotalCost.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(129, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(269, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "$";
            // 
            // nupMarkup
            // 
            this.nupMarkup.Location = new System.Drawing.Point(416, 150);
            this.nupMarkup.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nupMarkup.Name = "nupMarkup";
            this.nupMarkup.Size = new System.Drawing.Size(120, 22);
            this.nupMarkup.TabIndex = 32;
            this.nupMarkup.ValueChanged += new System.EventHandler(this.nupMarkup_ValueChanged);
            // 
            // nupPassanger
            // 
            this.nupPassanger.Location = new System.Drawing.Point(163, 225);
            this.nupPassanger.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nupPassanger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPassanger.Name = "nupPassanger";
            this.nupPassanger.Size = new System.Drawing.Size(120, 22);
            this.nupPassanger.TabIndex = 33;
            this.nupPassanger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPassanger.ValueChanged += new System.EventHandler(this.nupPassanger_ValueChanged);
            // 
            // nupDistance
            // 
            this.nupDistance.Location = new System.Drawing.Point(163, 174);
            this.nupDistance.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nupDistance.Name = "nupDistance";
            this.nupDistance.Size = new System.Drawing.Size(120, 22);
            this.nupDistance.TabIndex = 34;
            this.nupDistance.ValueChanged += new System.EventHandler(this.nupDistance_ValueChanged);
            // 
            // cboCostType
            // 
            this.cboCostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCostType.FormattingEnabled = true;
            this.cboCostType.Location = new System.Drawing.Point(14, 180);
            this.cboCostType.Name = "cboCostType";
            this.cboCostType.Size = new System.Drawing.Size(274, 24);
            this.cboCostType.TabIndex = 35;
            // 
            // btnAddCost
            // 
            this.btnAddCost.Location = new System.Drawing.Point(14, 219);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(75, 23);
            this.btnAddCost.TabIndex = 36;
            this.btnAddCost.Text = "Add";
            this.btnAddCost.UseVisualStyleBackColor = true;
            this.btnAddCost.Click += new System.EventHandler(this.btnAddCost_Click);
            // 
            // lblPricepp
            // 
            this.lblPricepp.AutoSize = true;
            this.lblPricepp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricepp.Location = new System.Drawing.Point(389, 231);
            this.lblPricepp.Name = "lblPricepp";
            this.lblPricepp.Size = new System.Drawing.Size(69, 20);
            this.lblPricepp.TabIndex = 37;
            this.lblPricepp.Text = "label10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnAddCost);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cboCostType);
            this.groupBox1.Controls.Add(this.lblTotalCost);
            this.groupBox1.Controls.Add(this.lstCost);
            this.groupBox1.Controls.Add(this.btnEditCost);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(622, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 342);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // frmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 368);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPricepp);
            this.Controls.Add(this.nupDistance);
            this.Controls.Add(this.nupPassanger);
            this.Controls.Add(this.nupMarkup);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTour";
            this.Text = "Tour";
            ((System.ComponentModel.ISupportInitialize)(this.nupMarkup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPassanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnEditCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nupMarkup;
        private System.Windows.Forms.NumericUpDown nupPassanger;
        private System.Windows.Forms.NumericUpDown nupDistance;
        private System.Windows.Forms.ComboBox cboCostType;
        private System.Windows.Forms.Button btnAddCost;
        private System.Windows.Forms.Label lblPricepp;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}