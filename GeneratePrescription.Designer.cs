namespace ISTNASProject
{
    partial class GeneratePrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePrescription));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.AppId = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.Label();
            this.TreatmentId = new System.Windows.Forms.Label();
            this.PatientID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.prescriptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dentistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable5BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hlangaLDB = new ISTNASProject.HlangaLDB();
            this.hlangaLDB1 = new ISTNASProject.HlangaLDB();
            this.dataTable5TableAdapter = new ISTNASProject.HlangaLDBTableAdapters.DataTable5TableAdapter();
            this.prescription1TableAdapter1 = new ISTNASProject.HlangaLDBTableAdapters.Prescription1TableAdapter();
            this.dataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable4TableAdapter = new ISTNASProject.HlangaLDBTableAdapters.DataTable4TableAdapter();
            this.appointmentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.PrescriptionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlangaLDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlangaLDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by patient email : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 679);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1.Double Click to Choose Patient ";
            // 
            // PrescriptionGroupBox
            // 
            this.PrescriptionGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PrescriptionGroupBox.Controls.Add(this.listBox1);
            this.PrescriptionGroupBox.Controls.Add(this.dataGridView1);
            this.PrescriptionGroupBox.Controls.Add(this.button3);
            this.PrescriptionGroupBox.Controls.Add(this.label10);
            this.PrescriptionGroupBox.Controls.Add(this.textBox3);
            this.PrescriptionGroupBox.Controls.Add(this.label9);
            this.PrescriptionGroupBox.Controls.Add(this.textBox2);
            this.PrescriptionGroupBox.Controls.Add(this.comboBox1);
            this.PrescriptionGroupBox.Controls.Add(this.button2);
            this.PrescriptionGroupBox.Controls.Add(this.button1);
            this.PrescriptionGroupBox.Controls.Add(this.label8);
            this.PrescriptionGroupBox.Controls.Add(this.label7);
            this.PrescriptionGroupBox.Controls.Add(this.label6);
            this.PrescriptionGroupBox.Controls.Add(this.textBox5);
            this.PrescriptionGroupBox.Controls.Add(this.label5);
            this.PrescriptionGroupBox.Controls.Add(this.textBox4);
            this.PrescriptionGroupBox.Controls.Add(this.label4);
            this.PrescriptionGroupBox.Controls.Add(this.label2);
            this.PrescriptionGroupBox.Controls.Add(this.Description);
            this.PrescriptionGroupBox.Controls.Add(this.AppId);
            this.PrescriptionGroupBox.Controls.Add(this.PatientName);
            this.PrescriptionGroupBox.Controls.Add(this.TreatmentId);
            this.PrescriptionGroupBox.Controls.Add(this.PatientID);
            this.PrescriptionGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionGroupBox.ForeColor = System.Drawing.Color.White;
            this.PrescriptionGroupBox.Location = new System.Drawing.Point(737, 85);
            this.PrescriptionGroupBox.Name = "PrescriptionGroupBox";
            this.PrescriptionGroupBox.Size = new System.Drawing.Size(1263, 679);
            this.PrescriptionGroupBox.TabIndex = 5;
            this.PrescriptionGroupBox.TabStop = false;
            this.PrescriptionGroupBox.Text = "2.Prescription Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescriptionIDDataGridViewTextBoxColumn,
            this.appointmentIDDataGridViewTextBoxColumn,
            this.dentistIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn2,
            this.treatmentIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.medicationNameDataGridViewTextBoxColumn,
            this.prescriptionDateDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.instructionsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable5BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1202, 219);
            this.dataGridView1.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(971, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 34);
            this.button3.TabIndex = 30;
            this.button3.Text = "Add med";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(967, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "Add new medication:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(971, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 27);
            this.textBox3.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(720, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Search medication by name :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(724, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 26;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Paracetamol (Acetaminophen)",
            "",
            "",
            "Ibuprofen",
            "",
            "Aspirin (rare, not usually after surgery)",
            "",
            "",
            "Codeine (often in combination, e.g., Co-codamol)",
            "",
            "",
            "Tramadol (short-term severe pain)",
            "Amoxicillin",
            "",
            "",
            "Metronidazole",
            "",
            "",
            "Clindamycin",
            "",
            "",
            "Erythromycin",
            "Lidocaine (Lignocaine) with epinephrine",
            "",
            "",
            "Prilocaine",
            "",
            "",
            "Articaine",
            "",
            "",
            "Mepivacaine"});
            this.comboBox1.Location = new System.Drawing.Point(470, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 27);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(232, 635);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 23;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(42, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(74, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Selected patient details :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(466, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Enter presciption details :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(466, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Prescibing Dentist:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(470, 210);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(220, 27);
            this.textBox5.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(466, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Instructions:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(470, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 27);
            this.textBox4.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(466, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dosage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(466, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Medication Name:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.ForeColor = System.Drawing.Color.Black;
            this.Description.Location = new System.Drawing.Point(74, 232);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(40, 19);
            this.Description.TabIndex = 9;
            this.Description.Text = "N/A";
            // 
            // AppId
            // 
            this.AppId.AutoSize = true;
            this.AppId.BackColor = System.Drawing.Color.White;
            this.AppId.ForeColor = System.Drawing.Color.Black;
            this.AppId.Location = new System.Drawing.Point(74, 188);
            this.AppId.Name = "AppId";
            this.AppId.Size = new System.Drawing.Size(40, 19);
            this.AppId.TabIndex = 8;
            this.AppId.Text = "N/A";
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.BackColor = System.Drawing.Color.White;
            this.PatientName.ForeColor = System.Drawing.Color.Black;
            this.PatientName.Location = new System.Drawing.Point(74, 149);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(40, 19);
            this.PatientName.TabIndex = 7;
            this.PatientName.Text = "N/A";
            // 
            // TreatmentId
            // 
            this.TreatmentId.AutoSize = true;
            this.TreatmentId.BackColor = System.Drawing.Color.White;
            this.TreatmentId.ForeColor = System.Drawing.Color.Black;
            this.TreatmentId.Location = new System.Drawing.Point(74, 104);
            this.TreatmentId.Name = "TreatmentId";
            this.TreatmentId.Size = new System.Drawing.Size(40, 19);
            this.TreatmentId.TabIndex = 6;
            this.TreatmentId.Text = "N/A";
            // 
            // PatientID
            // 
            this.PatientID.AutoSize = true;
            this.PatientID.BackColor = System.Drawing.Color.White;
            this.PatientID.ForeColor = System.Drawing.Color.Black;
            this.PatientID.Location = new System.Drawing.Point(74, 64);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(40, 19);
            this.PatientID.TabIndex = 5;
            this.PatientID.Text = "N/A";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIDDataGridViewTextBoxColumn1,
            this.patientIDDataGridViewTextBoxColumn,
            this.treatmentIDDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.dataTable4BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 149);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(707, 111);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // prescriptionIDDataGridViewTextBoxColumn
            // 
            this.prescriptionIDDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn.HeaderText = "PrescriptionID";
            this.prescriptionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prescriptionIDDataGridViewTextBoxColumn.Name = "prescriptionIDDataGridViewTextBoxColumn";
            // 
            // appointmentIDDataGridViewTextBoxColumn
            // 
            this.appointmentIDDataGridViewTextBoxColumn.DataPropertyName = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.HeaderText = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentIDDataGridViewTextBoxColumn.Name = "appointmentIDDataGridViewTextBoxColumn";
            this.appointmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dentistIDDataGridViewTextBoxColumn
            // 
            this.dentistIDDataGridViewTextBoxColumn.DataPropertyName = "dentistID";
            this.dentistIDDataGridViewTextBoxColumn.HeaderText = "dentistID";
            this.dentistIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dentistIDDataGridViewTextBoxColumn.Name = "dentistIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn2
            // 
            this.patientIDDataGridViewTextBoxColumn2.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn2.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn2.Name = "patientIDDataGridViewTextBoxColumn2";
            this.patientIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // treatmentIDDataGridViewTextBoxColumn
            // 
            this.treatmentIDDataGridViewTextBoxColumn.DataPropertyName = "TreatmentID";
            this.treatmentIDDataGridViewTextBoxColumn.HeaderText = "TreatmentID";
            this.treatmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.treatmentIDDataGridViewTextBoxColumn.Name = "treatmentIDDataGridViewTextBoxColumn";
            this.treatmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // medicationNameDataGridViewTextBoxColumn
            // 
            this.medicationNameDataGridViewTextBoxColumn.DataPropertyName = "Medication_Name";
            this.medicationNameDataGridViewTextBoxColumn.HeaderText = "Medication_Name";
            this.medicationNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicationNameDataGridViewTextBoxColumn.Name = "medicationNameDataGridViewTextBoxColumn";
            // 
            // prescriptionDateDataGridViewTextBoxColumn
            // 
            this.prescriptionDateDataGridViewTextBoxColumn.DataPropertyName = "Prescription_Date";
            this.prescriptionDateDataGridViewTextBoxColumn.HeaderText = "Prescription_Date";
            this.prescriptionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prescriptionDateDataGridViewTextBoxColumn.Name = "prescriptionDateDataGridViewTextBoxColumn";
            // 
            // dosageDataGridViewTextBoxColumn
            // 
            this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
            // 
            // instructionsDataGridViewTextBoxColumn
            // 
            this.instructionsDataGridViewTextBoxColumn.DataPropertyName = "Instructions";
            this.instructionsDataGridViewTextBoxColumn.HeaderText = "Instructions";
            this.instructionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructionsDataGridViewTextBoxColumn.Name = "instructionsDataGridViewTextBoxColumn";
            // 
            // dataTable5BindingSource2
            // 
            this.dataTable5BindingSource2.DataMember = "DataTable5";
            this.dataTable5BindingSource2.DataSource = this.hlangaLDB;
            // 
            // hlangaLDB
            // 
            this.hlangaLDB.DataSetName = "HlangaLDB";
            this.hlangaLDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hlangaLDB1
            // 
            this.hlangaLDB1.DataSetName = "HlangaLDB";
            this.hlangaLDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable5TableAdapter
            // 
            this.dataTable5TableAdapter.ClearBeforeFill = true;
            // 
            // prescription1TableAdapter1
            // 
            this.prescription1TableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable4BindingSource
            // 
            this.dataTable4BindingSource.DataMember = "DataTable4";
            this.dataTable4BindingSource.DataSource = this.hlangaLDB;
            // 
            // dataTable4TableAdapter
            // 
            this.dataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // appointmentIDDataGridViewTextBoxColumn1
            // 
            this.appointmentIDDataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn1.HeaderText = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.appointmentIDDataGridViewTextBoxColumn1.Name = "appointmentIDDataGridViewTextBoxColumn1";
            this.appointmentIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treatmentIDDataGridViewTextBoxColumn1
            // 
            this.treatmentIDDataGridViewTextBoxColumn1.DataPropertyName = "TreatmentID";
            this.treatmentIDDataGridViewTextBoxColumn1.HeaderText = "TreatmentID";
            this.treatmentIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.treatmentIDDataGridViewTextBoxColumn1.Name = "treatmentIDDataGridViewTextBoxColumn1";
            this.treatmentIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn1.HeaderText = "email";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.listBox1.Location = new System.Drawing.Point(470, 274);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 61);
            this.listBox1.TabIndex = 33;
            // 
            // GeneratePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 846);
            this.Controls.Add(this.PrescriptionGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "GeneratePrescription";
            this.Text = "GeneratePrescription";
            this.Load += new System.EventHandler(this.GeneratePrescription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PrescriptionGroupBox.ResumeLayout(false);
            this.PrescriptionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlangaLDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlangaLDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox PrescriptionGroupBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label AppId;
        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Label TreatmentId;
        private System.Windows.Forms.Label PatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private HlangaLDB hlangaLDB;
        private HlangaLDBTableAdapters.DataTable5TableAdapter dataTable5TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HlangaLDB hlangaLDB1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dentistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable5BindingSource2;
        private HlangaLDBTableAdapters.Prescription1TableAdapter prescription1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dataTable4BindingSource;
        private HlangaLDBTableAdapters.DataTable4TableAdapter dataTable4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ListBox listBox1;
    }
}