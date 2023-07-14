namespace SalvadorForm
{
    partial class Form1
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.Label();
            this.comboBoxCriticity = new System.Windows.Forms.ComboBox();
            this.criticity = new System.Windows.Forms.Label();
            this.environment = new System.Windows.Forms.Label();
            this.checkBoxProd = new System.Windows.Forms.CheckBox();
            this.checkBoxPrepod = new System.Windows.Forms.CheckBox();
            this.checkBoxDemo = new System.Windows.Forms.CheckBox();
            this.description = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.startDate = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.comboBoxPercent = new System.Windows.Forms.ComboBox();
            this.percentComplete = new System.Windows.Forms.Label();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(16, 73);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(212, 22);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New Task";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(13, 54);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(33, 16);
            this.title.TabIndex = 2;
            this.title.Text = "Title";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(261, 54);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(58, 16);
            this.location.TabIndex = 4;
            this.location.Text = "Location";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "location1",
            "location2",
            "location3"});
            this.comboBoxLocation.Location = new System.Drawing.Point(264, 73);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(213, 24);
            this.comboBoxLocation.TabIndex = 6;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "type1",
            "type2",
            "type3"});
            this.comboBoxType.Location = new System.Drawing.Point(16, 127);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(119, 24);
            this.comboBoxType.TabIndex = 8;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(13, 108);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(39, 16);
            this.type.TabIndex = 7;
            this.type.Text = "Type";
            // 
            // comboBoxCriticity
            // 
            this.comboBoxCriticity.FormattingEnabled = true;
            this.comboBoxCriticity.Items.AddRange(new object[] {
            "criticity1",
            "criticity2",
            "criticity3"});
            this.comboBoxCriticity.Location = new System.Drawing.Point(162, 127);
            this.comboBoxCriticity.Name = "comboBoxCriticity";
            this.comboBoxCriticity.Size = new System.Drawing.Size(119, 24);
            this.comboBoxCriticity.TabIndex = 10;
            // 
            // criticity
            // 
            this.criticity.AutoSize = true;
            this.criticity.Location = new System.Drawing.Point(159, 108);
            this.criticity.Name = "criticity";
            this.criticity.Size = new System.Drawing.Size(49, 16);
            this.criticity.TabIndex = 9;
            this.criticity.Text = "Criticity";
            // 
            // environment
            // 
            this.environment.AutoSize = true;
            this.environment.Location = new System.Drawing.Point(308, 108);
            this.environment.Name = "environment";
            this.environment.Size = new System.Drawing.Size(81, 16);
            this.environment.TabIndex = 11;
            this.environment.Text = "Environment";
            // 
            // checkBoxProd
            // 
            this.checkBoxProd.AutoSize = true;
            this.checkBoxProd.Location = new System.Drawing.Point(311, 131);
            this.checkBoxProd.Name = "checkBoxProd";
            this.checkBoxProd.Size = new System.Drawing.Size(58, 20);
            this.checkBoxProd.TabIndex = 12;
            this.checkBoxProd.Text = "Prod";
            this.checkBoxProd.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrepod
            // 
            this.checkBoxPrepod.AutoSize = true;
            this.checkBoxPrepod.Location = new System.Drawing.Point(311, 157);
            this.checkBoxPrepod.Name = "checkBoxPrepod";
            this.checkBoxPrepod.Size = new System.Drawing.Size(74, 20);
            this.checkBoxPrepod.TabIndex = 13;
            this.checkBoxPrepod.Text = "Prepod";
            this.checkBoxPrepod.UseVisualStyleBackColor = true;
            // 
            // checkBoxDemo
            // 
            this.checkBoxDemo.AutoSize = true;
            this.checkBoxDemo.Location = new System.Drawing.Point(311, 183);
            this.checkBoxDemo.Name = "checkBoxDemo";
            this.checkBoxDemo.Size = new System.Drawing.Size(66, 20);
            this.checkBoxDemo.TabIndex = 14;
            this.checkBoxDemo.Text = "Demo";
            this.checkBoxDemo.UseVisualStyleBackColor = true;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(13, 205);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(75, 16);
            this.description.TabIndex = 15;
            this.description.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(16, 224);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(461, 94);
            this.richTextBoxDescription.TabIndex = 16;
            this.richTextBoxDescription.Text = "";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(13, 335);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(66, 16);
            this.startDate.TabIndex = 17;
            this.startDate.Text = "Start Date";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(263, 337);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(114, 16);
            this.duration.TabIndex = 18;
            this.duration.Text = "Duration (in hours)";
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.Location = new System.Drawing.Point(16, 354);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(213, 22);
            this.dateTimeStartDate.TabIndex = 19;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(266, 357);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(28, 23);
            this.buttonMinus.TabIndex = 20;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(300, 357);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(145, 22);
            this.textBoxDuration.TabIndex = 22;
            this.textBoxDuration.Text = "1,00";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(451, 357);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(28, 23);
            this.buttonPlus.TabIndex = 23;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Planned",
            "Not Planned"});
            this.comboBoxStatus.Location = new System.Drawing.Point(16, 410);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(213, 24);
            this.comboBoxStatus.TabIndex = 25;
            this.comboBoxStatus.Text = "Planned";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(13, 391);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(44, 16);
            this.status.TabIndex = 24;
            this.status.Text = "Status";
            // 
            // comboBoxPercent
            // 
            this.comboBoxPercent.FormattingEnabled = true;
            this.comboBoxPercent.Items.AddRange(new object[] {
            "0%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.comboBoxPercent.Location = new System.Drawing.Point(266, 410);
            this.comboBoxPercent.Name = "comboBoxPercent";
            this.comboBoxPercent.Size = new System.Drawing.Size(213, 24);
            this.comboBoxPercent.TabIndex = 27;
            this.comboBoxPercent.Text = "0%";
            // 
            // percentComplete
            // 
            this.percentComplete.AutoSize = true;
            this.percentComplete.Location = new System.Drawing.Point(263, 391);
            this.percentComplete.Name = "percentComplete";
            this.percentComplete.Size = new System.Drawing.Size(114, 16);
            this.percentComplete.TabIndex = 26;
            this.percentComplete.Text = "Percent Complete";
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(16, 453);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(262, 20);
            this.checkBoxEmail.TabIndex = 28;
            this.checkBoxEmail.Text = "Check here if you want to send an email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(404, 493);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 29;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(323, 493);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 30;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 544);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.checkBoxEmail);
            this.Controls.Add(this.comboBoxPercent);
            this.Controls.Add(this.percentComplete);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.status);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.dateTimeStartDate);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.description);
            this.Controls.Add(this.checkBoxDemo);
            this.Controls.Add(this.checkBoxPrepod);
            this.Controls.Add(this.checkBoxProd);
            this.Controls.Add(this.environment);
            this.Controls.Add(this.comboBoxCriticity);
            this.Controls.Add(this.criticity);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.type);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.location);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.ComboBox comboBoxCriticity;
        private System.Windows.Forms.Label criticity;
        private System.Windows.Forms.Label environment;
        private System.Windows.Forms.CheckBox checkBoxProd;
        private System.Windows.Forms.CheckBox checkBoxPrepod;
        private System.Windows.Forms.CheckBox checkBoxDemo;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox comboBoxPercent;
        private System.Windows.Forms.Label percentComplete;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

