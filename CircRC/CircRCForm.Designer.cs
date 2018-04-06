namespace CircRC
{
    partial class CircRCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircRCForm));
            this.startResistanceCalculation = new System.Windows.Forms.Button();
            this.labelStartP = new System.Windows.Forms.Label();
            this.labelEndP = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.unitStartP = new System.Windows.Forms.Label();
            this.unitEndP = new System.Windows.Forms.Label();
            this.unitDuration = new System.Windows.Forms.Label();
            this.boxPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelRt = new System.Windows.Forms.Label();
            this.labelRl = new System.Windows.Forms.Label();
            this.plusDuration_Resistance = new System.Windows.Forms.Button();
            this.minusDuration_Resistance = new System.Windows.Forms.Button();
            this.plusEndPressure_Resistance = new System.Windows.Forms.Button();
            this.minusEndPressure_Resistance = new System.Windows.Forms.Button();
            this.plusStartPressure_Resistance = new System.Windows.Forms.Button();
            this.minusStartPressure_Resistance = new System.Windows.Forms.Button();
            this.textEnd_Resistance = new System.Windows.Forms.Label();
            this.textDuration_Resistance = new System.Windows.Forms.Label();
            this.textStart_Resistance = new System.Windows.Forms.Label();
            this.startComplianceCalculation = new System.Windows.Forms.Button();
            this.textResistanceRl = new System.Windows.Forms.Label();
            this.textResistanceRt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textComplianceRl = new System.Windows.Forms.Label();
            this.textComplianceRt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.minusStartPressure_Compliance = new System.Windows.Forms.Button();
            this.plusStartPressure_Compliance = new System.Windows.Forms.Button();
            this.minusEndPressure_Compliance = new System.Windows.Forms.Button();
            this.plusEndPressure_Compliance = new System.Windows.Forms.Button();
            this.minusDuration_Compliance = new System.Windows.Forms.Button();
            this.plusDuration_Compliance = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textEnd_Compliance = new System.Windows.Forms.Label();
            this.textDuration_Compliance = new System.Windows.Forms.Label();
            this.textStart_Compliance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startResistanceCalculation
            // 
            this.startResistanceCalculation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startResistanceCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startResistanceCalculation.Location = new System.Drawing.Point(247, 306);
            this.startResistanceCalculation.Name = "startResistanceCalculation";
            this.startResistanceCalculation.Size = new System.Drawing.Size(171, 31);
            this.startResistanceCalculation.TabIndex = 1;
            this.startResistanceCalculation.Text = "Learn Resistance";
            this.startResistanceCalculation.UseVisualStyleBackColor = true;
            this.startResistanceCalculation.Click += new System.EventHandler(this.startResistanceCal_Click);
            // 
            // labelStartP
            // 
            this.labelStartP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStartP.AutoSize = true;
            this.labelStartP.BackColor = System.Drawing.Color.Transparent;
            this.labelStartP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartP.Location = new System.Drawing.Point(211, 185);
            this.labelStartP.Name = "labelStartP";
            this.labelStartP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStartP.Size = new System.Drawing.Size(107, 18);
            this.labelStartP.TabIndex = 2;
            this.labelStartP.Text = "Start Pressure:";
            // 
            // labelEndP
            // 
            this.labelEndP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEndP.AutoSize = true;
            this.labelEndP.BackColor = System.Drawing.Color.Transparent;
            this.labelEndP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndP.Location = new System.Drawing.Point(216, 229);
            this.labelEndP.Name = "labelEndP";
            this.labelEndP.Size = new System.Drawing.Size(102, 18);
            this.labelEndP.TabIndex = 2;
            this.labelEndP.Text = "End Pressure:";
            // 
            // labelDuration
            // 
            this.labelDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDuration.AutoSize = true;
            this.labelDuration.BackColor = System.Drawing.Color.Transparent;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(250, 273);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(68, 18);
            this.labelDuration.TabIndex = 2;
            this.labelDuration.Text = "Duration:";
            // 
            // unitStartP
            // 
            this.unitStartP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unitStartP.AutoSize = true;
            this.unitStartP.BackColor = System.Drawing.Color.Transparent;
            this.unitStartP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitStartP.Location = new System.Drawing.Point(372, 185);
            this.unitStartP.Name = "unitStartP";
            this.unitStartP.Size = new System.Drawing.Size(60, 18);
            this.unitStartP.TabIndex = 6;
            this.unitStartP.Text = "cmH2O";
            this.unitStartP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitEndP
            // 
            this.unitEndP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unitEndP.AutoSize = true;
            this.unitEndP.BackColor = System.Drawing.Color.Transparent;
            this.unitEndP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitEndP.Location = new System.Drawing.Point(372, 229);
            this.unitEndP.Name = "unitEndP";
            this.unitEndP.Size = new System.Drawing.Size(60, 18);
            this.unitEndP.TabIndex = 6;
            this.unitEndP.Text = "cmH2O";
            this.unitEndP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitDuration
            // 
            this.unitDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unitDuration.BackColor = System.Drawing.Color.Transparent;
            this.unitDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitDuration.Location = new System.Drawing.Point(372, 273);
            this.unitDuration.Name = "unitDuration";
            this.unitDuration.Size = new System.Drawing.Size(53, 18);
            this.unitDuration.TabIndex = 6;
            this.unitDuration.Text = "sec";
            this.unitDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boxPort
            // 
            this.boxPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxPort.BackColor = System.Drawing.Color.White;
            this.boxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPort.FormattingEnabled = true;
            this.boxPort.Location = new System.Drawing.Point(250, 146);
            this.boxPort.Name = "boxPort";
            this.boxPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPort.Size = new System.Drawing.Size(64, 23);
            this.boxPort.TabIndex = 7;
            this.boxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // labelPort
            // 
            this.labelPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPort.AutoSize = true;
            this.labelPort.BackColor = System.Drawing.Color.Transparent;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(211, 148);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 18);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Port:";
            // 
            // labelRt
            // 
            this.labelRt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRt.BackColor = System.Drawing.Color.Transparent;
            this.labelRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRt.Location = new System.Drawing.Point(229, 379);
            this.labelRt.Name = "labelRt";
            this.labelRt.Size = new System.Drawing.Size(27, 23);
            this.labelRt.TabIndex = 8;
            this.labelRt.Text = "Rt:";
            this.labelRt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRl
            // 
            this.labelRl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRl.BackColor = System.Drawing.Color.Transparent;
            this.labelRl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRl.Location = new System.Drawing.Point(230, 347);
            this.labelRl.Name = "labelRl";
            this.labelRl.Size = new System.Drawing.Size(27, 23);
            this.labelRl.TabIndex = 8;
            this.labelRl.Text = "Rl:";
            this.labelRl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusDuration_Resistance
            // 
            this.plusDuration_Resistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusDuration_Resistance.BackColor = System.Drawing.Color.Transparent;
            this.plusDuration_Resistance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusDuration_Resistance.BackgroundImage")));
            this.plusDuration_Resistance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusDuration_Resistance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plusDuration_Resistance.Location = new System.Drawing.Point(431, 269);
            this.plusDuration_Resistance.Name = "plusDuration_Resistance";
            this.plusDuration_Resistance.Size = new System.Drawing.Size(27, 27);
            this.plusDuration_Resistance.TabIndex = 4;
            this.plusDuration_Resistance.UseVisualStyleBackColor = false;
            this.plusDuration_Resistance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plusDurationPressure_Resistance_Click);
            this.plusDuration_Resistance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plusDurationPressure_Resistance_Release);
            // 
            // minusDuration_Resistance
            // 
            this.minusDuration_Resistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusDuration_Resistance.BackColor = System.Drawing.Color.Transparent;
            this.minusDuration_Resistance.BackgroundImage = global::CircRC.Properties.Resources.minus;
            this.minusDuration_Resistance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusDuration_Resistance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minusDuration_Resistance.Location = new System.Drawing.Point(315, 269);
            this.minusDuration_Resistance.Name = "minusDuration_Resistance";
            this.minusDuration_Resistance.Size = new System.Drawing.Size(27, 27);
            this.minusDuration_Resistance.TabIndex = 4;
            this.minusDuration_Resistance.UseVisualStyleBackColor = false;
            this.minusDuration_Resistance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minusDurationPressure_Resistance_Click);
            this.minusDuration_Resistance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minusDurationPressure_Resistance_Release);
            // 
            // plusEndPressure_Resistance
            // 
            this.plusEndPressure_Resistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusEndPressure_Resistance.BackColor = System.Drawing.Color.Transparent;
            this.plusEndPressure_Resistance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusEndPressure_Resistance.BackgroundImage")));
            this.plusEndPressure_Resistance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusEndPressure_Resistance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plusEndPressure_Resistance.Location = new System.Drawing.Point(431, 225);
            this.plusEndPressure_Resistance.Name = "plusEndPressure_Resistance";
            this.plusEndPressure_Resistance.Size = new System.Drawing.Size(27, 27);
            this.plusEndPressure_Resistance.TabIndex = 4;
            this.plusEndPressure_Resistance.UseVisualStyleBackColor = false;
            this.plusEndPressure_Resistance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plusEndPressure_Resistance_Click);
            this.plusEndPressure_Resistance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plusEndPressure_Resistance_Release);
            // 
            // minusEndPressure_Resistance
            // 
            this.minusEndPressure_Resistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusEndPressure_Resistance.BackColor = System.Drawing.Color.Transparent;
            this.minusEndPressure_Resistance.BackgroundImage = global::CircRC.Properties.Resources.minus;
            this.minusEndPressure_Resistance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusEndPressure_Resistance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minusEndPressure_Resistance.Location = new System.Drawing.Point(315, 225);
            this.minusEndPressure_Resistance.Name = "minusEndPressure_Resistance";
            this.minusEndPressure_Resistance.Size = new System.Drawing.Size(27, 27);
            this.minusEndPressure_Resistance.TabIndex = 4;
            this.minusEndPressure_Resistance.UseVisualStyleBackColor = false;
            this.minusEndPressure_Resistance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minusEndPressure_Resistance_Click);
            this.minusEndPressure_Resistance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minusEndPressure_Resistance_Release);
            // 
            // plusStartPressure_Resistance
            // 
            this.plusStartPressure_Resistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusStartPressure_Resistance.BackColor = System.Drawing.Color.Transparent;
            this.plusStartPressure_Resistance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusStartPressure_Resistance.BackgroundImage")));
            this.plusStartPressure_Resistance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusStartPressure_Resistance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plusStartPressure_Resistance.Location = new System.Drawing.Point(431, 181);
            this.plusStartPressure_Resistance.Name = "plusStartPressure_Resistance";
            this.plusStartPressure_Resistance.Size = new System.Drawing.Size(27, 27);
            this.plusStartPressure_Resistance.TabIndex = 4;
            this.plusStartPressure_Resistance.UseVisualStyleBackColor = false;
            this.plusStartPressure_Resistance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plusStartPressure_Resistance_Click);
            this.plusStartPressure_Resistance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plusStartPressure_Resistance_Release);
            // 
            // minusStartPressure_Resistance
            // 
            this.minusStartPressure_Resistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusStartPressure_Resistance.BackColor = System.Drawing.Color.Transparent;
            this.minusStartPressure_Resistance.BackgroundImage = global::CircRC.Properties.Resources.minus;
            this.minusStartPressure_Resistance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusStartPressure_Resistance.ForeColor = System.Drawing.Color.Black;
            this.minusStartPressure_Resistance.Location = new System.Drawing.Point(315, 181);
            this.minusStartPressure_Resistance.Name = "minusStartPressure_Resistance";
            this.minusStartPressure_Resistance.Size = new System.Drawing.Size(27, 27);
            this.minusStartPressure_Resistance.TabIndex = 4;
            this.minusStartPressure_Resistance.UseVisualStyleBackColor = false;
            this.minusStartPressure_Resistance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minusStartPressure_Resistance_Click);
            this.minusStartPressure_Resistance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minusStartPressure_Resistance_Release);
            // 
            // textEnd_Resistance
            // 
            this.textEnd_Resistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEnd_Resistance.BackColor = System.Drawing.Color.White;
            this.textEnd_Resistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEnd_Resistance.Location = new System.Drawing.Point(346, 227);
            this.textEnd_Resistance.Name = "textEnd_Resistance";
            this.textEnd_Resistance.Size = new System.Drawing.Size(25, 23);
            this.textEnd_Resistance.TabIndex = 9;
            this.textEnd_Resistance.Text = "90";
            this.textEnd_Resistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textDuration_Resistance
            // 
            this.textDuration_Resistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDuration_Resistance.BackColor = System.Drawing.Color.White;
            this.textDuration_Resistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDuration_Resistance.Location = new System.Drawing.Point(346, 271);
            this.textDuration_Resistance.Name = "textDuration_Resistance";
            this.textDuration_Resistance.Size = new System.Drawing.Size(25, 23);
            this.textDuration_Resistance.TabIndex = 9;
            this.textDuration_Resistance.Text = "5";
            this.textDuration_Resistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textStart_Resistance
            // 
            this.textStart_Resistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textStart_Resistance.BackColor = System.Drawing.Color.White;
            this.textStart_Resistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStart_Resistance.Location = new System.Drawing.Point(346, 183);
            this.textStart_Resistance.Name = "textStart_Resistance";
            this.textStart_Resistance.Size = new System.Drawing.Size(25, 23);
            this.textStart_Resistance.TabIndex = 9;
            this.textStart_Resistance.Text = "5";
            this.textStart_Resistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startComplianceCalculation
            // 
            this.startComplianceCalculation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startComplianceCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startComplianceCalculation.Location = new System.Drawing.Point(499, 306);
            this.startComplianceCalculation.Name = "startComplianceCalculation";
            this.startComplianceCalculation.Size = new System.Drawing.Size(171, 31);
            this.startComplianceCalculation.TabIndex = 1;
            this.startComplianceCalculation.Text = "Learn Compliance";
            this.startComplianceCalculation.UseVisualStyleBackColor = true;
            this.startComplianceCalculation.Click += new System.EventHandler(this.startComplianceCal_Click);
            // 
            // textResistanceRl
            // 
            this.textResistanceRl.BackColor = System.Drawing.Color.White;
            this.textResistanceRl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResistanceRl.Location = new System.Drawing.Point(254, 351);
            this.textResistanceRl.Name = "textResistanceRl";
            this.textResistanceRl.Size = new System.Drawing.Size(88, 23);
            this.textResistanceRl.TabIndex = 9;
            this.textResistanceRl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textResistanceRt
            // 
            this.textResistanceRt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textResistanceRt.BackColor = System.Drawing.Color.White;
            this.textResistanceRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResistanceRt.Location = new System.Drawing.Point(254, 379);
            this.textResistanceRt.Name = "textResistanceRt";
            this.textResistanceRt.Size = new System.Drawing.Size(88, 23);
            this.textResistanceRt.TabIndex = 9;
            this.textResistanceRt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "cmH2O/L/sec";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "cmH2O/L/sec";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "m/N";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "m/N";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(511, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ct:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(511, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cl:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textComplianceRl
            // 
            this.textComplianceRl.BackColor = System.Drawing.Color.White;
            this.textComplianceRl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComplianceRl.Location = new System.Drawing.Point(538, 351);
            this.textComplianceRl.Name = "textComplianceRl";
            this.textComplianceRl.Size = new System.Drawing.Size(88, 23);
            this.textComplianceRl.TabIndex = 9;
            this.textComplianceRl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textComplianceRt
            // 
            this.textComplianceRt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textComplianceRt.BackColor = System.Drawing.Color.White;
            this.textComplianceRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComplianceRt.Location = new System.Drawing.Point(538, 379);
            this.textComplianceRt.Name = "textComplianceRt";
            this.textComplianceRt.Size = new System.Drawing.Size(88, 23);
            this.textComplianceRt.TabIndex = 9;
            this.textComplianceRt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 185);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Start Pressure:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(469, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "End Pressure:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(503, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Duration:";
            // 
            // minusStartPressure_Compliance
            // 
            this.minusStartPressure_Compliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusStartPressure_Compliance.BackColor = System.Drawing.Color.Transparent;
            this.minusStartPressure_Compliance.BackgroundImage = global::CircRC.Properties.Resources.minus;
            this.minusStartPressure_Compliance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusStartPressure_Compliance.ForeColor = System.Drawing.Color.Black;
            this.minusStartPressure_Compliance.Location = new System.Drawing.Point(568, 181);
            this.minusStartPressure_Compliance.Name = "minusStartPressure_Compliance";
            this.minusStartPressure_Compliance.Size = new System.Drawing.Size(27, 27);
            this.minusStartPressure_Compliance.TabIndex = 4;
            this.minusStartPressure_Compliance.UseVisualStyleBackColor = false;
            this.minusStartPressure_Compliance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minusStartPressure_Compliance_Click);
            this.minusStartPressure_Compliance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minusStartPressure_Compliance_Release);
            // 
            // plusStartPressure_Compliance
            // 
            this.plusStartPressure_Compliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusStartPressure_Compliance.BackColor = System.Drawing.Color.Transparent;
            this.plusStartPressure_Compliance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusStartPressure_Compliance.BackgroundImage")));
            this.plusStartPressure_Compliance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusStartPressure_Compliance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plusStartPressure_Compliance.Location = new System.Drawing.Point(684, 181);
            this.plusStartPressure_Compliance.Name = "plusStartPressure_Compliance";
            this.plusStartPressure_Compliance.Size = new System.Drawing.Size(27, 27);
            this.plusStartPressure_Compliance.TabIndex = 4;
            this.plusStartPressure_Compliance.UseVisualStyleBackColor = false;
            this.plusStartPressure_Compliance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plusStartPressure_Compliance_Click);
            this.plusStartPressure_Compliance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plusStartPressure_Compliance_Release);
            // 
            // minusEndPressure_Compliance
            // 
            this.minusEndPressure_Compliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusEndPressure_Compliance.BackColor = System.Drawing.Color.Transparent;
            this.minusEndPressure_Compliance.BackgroundImage = global::CircRC.Properties.Resources.minus;
            this.minusEndPressure_Compliance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusEndPressure_Compliance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minusEndPressure_Compliance.Location = new System.Drawing.Point(568, 225);
            this.minusEndPressure_Compliance.Name = "minusEndPressure_Compliance";
            this.minusEndPressure_Compliance.Size = new System.Drawing.Size(27, 27);
            this.minusEndPressure_Compliance.TabIndex = 4;
            this.minusEndPressure_Compliance.UseVisualStyleBackColor = false;
            this.minusEndPressure_Compliance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minusEndPressure_Compliance_Click);
            this.minusEndPressure_Compliance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minusEndPressure_Compliance_Release);
            // 
            // plusEndPressure_Compliance
            // 
            this.plusEndPressure_Compliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusEndPressure_Compliance.BackColor = System.Drawing.Color.Transparent;
            this.plusEndPressure_Compliance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusEndPressure_Compliance.BackgroundImage")));
            this.plusEndPressure_Compliance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusEndPressure_Compliance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plusEndPressure_Compliance.Location = new System.Drawing.Point(684, 225);
            this.plusEndPressure_Compliance.Name = "plusEndPressure_Compliance";
            this.plusEndPressure_Compliance.Size = new System.Drawing.Size(27, 27);
            this.plusEndPressure_Compliance.TabIndex = 4;
            this.plusEndPressure_Compliance.UseVisualStyleBackColor = false;
            this.plusEndPressure_Compliance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plusEndPressure_Compliance_Click);
            this.plusEndPressure_Compliance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plusEndPressure_Compliance_Release);
            // 
            // minusDuration_Compliance
            // 
            this.minusDuration_Compliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusDuration_Compliance.BackColor = System.Drawing.Color.Transparent;
            this.minusDuration_Compliance.BackgroundImage = global::CircRC.Properties.Resources.minus;
            this.minusDuration_Compliance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusDuration_Compliance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minusDuration_Compliance.Location = new System.Drawing.Point(568, 269);
            this.minusDuration_Compliance.Name = "minusDuration_Compliance";
            this.minusDuration_Compliance.Size = new System.Drawing.Size(27, 27);
            this.minusDuration_Compliance.TabIndex = 4;
            this.minusDuration_Compliance.UseVisualStyleBackColor = false;
            this.minusDuration_Compliance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minusDuration_Compliance_Click);
            this.minusDuration_Compliance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minusDuration_Compliance_Release);
            // 
            // plusDuration_Compliance
            // 
            this.plusDuration_Compliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusDuration_Compliance.BackColor = System.Drawing.Color.Transparent;
            this.plusDuration_Compliance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusDuration_Compliance.BackgroundImage")));
            this.plusDuration_Compliance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusDuration_Compliance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plusDuration_Compliance.Location = new System.Drawing.Point(684, 269);
            this.plusDuration_Compliance.Name = "plusDuration_Compliance";
            this.plusDuration_Compliance.Size = new System.Drawing.Size(27, 27);
            this.plusDuration_Compliance.TabIndex = 4;
            this.plusDuration_Compliance.UseVisualStyleBackColor = false;
            this.plusDuration_Compliance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plusDuration_Compliance_Click);
            this.plusDuration_Compliance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plusDuration_Compliance_Release);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(625, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "cmH2O";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(625, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "cmH2O";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(625, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "sec";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textEnd_Compliance
            // 
            this.textEnd_Compliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEnd_Compliance.BackColor = System.Drawing.Color.White;
            this.textEnd_Compliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEnd_Compliance.Location = new System.Drawing.Point(599, 227);
            this.textEnd_Compliance.Name = "textEnd_Compliance";
            this.textEnd_Compliance.Size = new System.Drawing.Size(25, 23);
            this.textEnd_Compliance.TabIndex = 9;
            this.textEnd_Compliance.Text = "57";
            this.textEnd_Compliance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textDuration_Compliance
            // 
            this.textDuration_Compliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDuration_Compliance.BackColor = System.Drawing.Color.White;
            this.textDuration_Compliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDuration_Compliance.Location = new System.Drawing.Point(599, 271);
            this.textDuration_Compliance.Name = "textDuration_Compliance";
            this.textDuration_Compliance.Size = new System.Drawing.Size(25, 23);
            this.textDuration_Compliance.TabIndex = 9;
            this.textDuration_Compliance.Text = "5";
            this.textDuration_Compliance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textStart_Compliance
            // 
            this.textStart_Compliance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textStart_Compliance.BackColor = System.Drawing.Color.White;
            this.textStart_Compliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStart_Compliance.Location = new System.Drawing.Point(599, 183);
            this.textStart_Compliance.Name = "textStart_Compliance";
            this.textStart_Compliance.Size = new System.Drawing.Size(25, 23);
            this.textStart_Compliance.TabIndex = 9;
            this.textStart_Compliance.Text = "7";
            this.textStart_Compliance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CircRCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::CircRC.Properties.Resources.unitmodified;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 733);
            this.Controls.Add(this.textStart_Compliance);
            this.Controls.Add(this.textStart_Resistance);
            this.Controls.Add(this.textComplianceRt);
            this.Controls.Add(this.textResistanceRt);
            this.Controls.Add(this.textComplianceRl);
            this.Controls.Add(this.textResistanceRl);
            this.Controls.Add(this.textDuration_Compliance);
            this.Controls.Add(this.textDuration_Resistance);
            this.Controls.Add(this.textEnd_Compliance);
            this.Controls.Add(this.textEnd_Resistance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelRl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelRt);
            this.Controls.Add(this.boxPort);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.unitDuration);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.unitEndP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.unitStartP);
            this.Controls.Add(this.plusDuration_Compliance);
            this.Controls.Add(this.plusDuration_Resistance);
            this.Controls.Add(this.minusDuration_Compliance);
            this.Controls.Add(this.minusDuration_Resistance);
            this.Controls.Add(this.plusEndPressure_Compliance);
            this.Controls.Add(this.plusEndPressure_Resistance);
            this.Controls.Add(this.minusEndPressure_Compliance);
            this.Controls.Add(this.minusEndPressure_Resistance);
            this.Controls.Add(this.plusStartPressure_Compliance);
            this.Controls.Add(this.plusStartPressure_Resistance);
            this.Controls.Add(this.minusStartPressure_Compliance);
            this.Controls.Add(this.minusStartPressure_Resistance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelEndP);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelStartP);
            this.Controls.Add(this.startComplianceCalculation);
            this.Controls.Add(this.startResistanceCalculation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(939, 807);
            this.Name = "CircRCForm";
            this.Text = "CircRCForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startResistanceCalculation;
        private System.Windows.Forms.Label labelStartP;
        private System.Windows.Forms.Label labelEndP;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Button minusStartPressure_Resistance;
        private System.Windows.Forms.Button plusStartPressure_Resistance;
        private System.Windows.Forms.Button minusEndPressure_Resistance;
        private System.Windows.Forms.Button plusEndPressure_Resistance;
        private System.Windows.Forms.Button minusDuration_Resistance;
        private System.Windows.Forms.Button plusDuration_Resistance;
        private System.Windows.Forms.Label unitStartP;
        private System.Windows.Forms.Label unitEndP;
        private System.Windows.Forms.Label unitDuration;
        private System.Windows.Forms.ComboBox boxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelRt;
        private System.Windows.Forms.Label labelRl;
        private System.Windows.Forms.Label textEnd_Resistance;
        private System.Windows.Forms.Label textDuration_Resistance;
        private System.Windows.Forms.Label textStart_Resistance;
        private System.Windows.Forms.Button startComplianceCalculation;
        private System.Windows.Forms.Label textResistanceRl;
        private System.Windows.Forms.Label textResistanceRt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label textComplianceRl;
        private System.Windows.Forms.Label textComplianceRt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button minusStartPressure_Compliance;
        private System.Windows.Forms.Button plusStartPressure_Compliance;
        private System.Windows.Forms.Button minusEndPressure_Compliance;
        private System.Windows.Forms.Button plusEndPressure_Compliance;
        private System.Windows.Forms.Button minusDuration_Compliance;
        private System.Windows.Forms.Button plusDuration_Compliance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label textEnd_Compliance;
        private System.Windows.Forms.Label textDuration_Compliance;
        private System.Windows.Forms.Label textStart_Compliance;
    }
}

