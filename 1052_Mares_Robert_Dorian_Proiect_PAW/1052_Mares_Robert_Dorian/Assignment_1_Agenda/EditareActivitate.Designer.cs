﻿namespace Assignment_1_Agenda
{
    partial class EditareActivitate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditareActivitate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxProiect = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDeadLine = new System.Windows.Forms.DateTimePicker();
            this.labelDeadLine = new System.Windows.Forms.Label();
            this.textBoxCoord = new System.Windows.Forms.TextBox();
            this.labelCoord = new System.Windows.Forms.Label();
            this.textBoxProiect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProiect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResurse = new System.Windows.Forms.TextBox();
            this.labelResursa = new System.Windows.Forms.Label();
            this.checkBoxResurse = new System.Windows.Forms.CheckBox();
            this.textBoxDomeniu = new System.Windows.Forms.TextBox();
            this.labelDomeniu = new System.Windows.Forms.Label();
            this.dateTimeIncheiere = new System.Windows.Forms.DateTimePicker();
            this.labelDataIncheiere = new System.Windows.Forms.Label();
            this.dateTimePickerIncepere = new System.Windows.Forms.DateTimePicker();
            this.labelDataIncepere = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.cbTipActiv = new System.Windows.Forms.ComboBox();
            this.buttonAnuleaza = new System.Windows.Forms.Button();
            this.buttonConfirma = new System.Windows.Forms.Button();
            this.errorProviderDataIncheiere = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDeadLine = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDataIncheiere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeadLine)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxProiect);
            this.groupBox1.Controls.Add(this.dateTimePickerDeadLine);
            this.groupBox1.Controls.Add(this.labelDeadLine);
            this.groupBox1.Controls.Add(this.textBoxCoord);
            this.groupBox1.Controls.Add(this.labelCoord);
            this.groupBox1.Controls.Add(this.textBoxProiect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelProiect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxResurse);
            this.groupBox1.Controls.Add(this.labelResursa);
            this.groupBox1.Controls.Add(this.checkBoxResurse);
            this.groupBox1.Controls.Add(this.textBoxDomeniu);
            this.groupBox1.Controls.Add(this.labelDomeniu);
            this.groupBox1.Controls.Add(this.dateTimeIncheiere);
            this.groupBox1.Controls.Add(this.labelDataIncheiere);
            this.groupBox1.Controls.Add(this.dateTimePickerIncepere);
            this.groupBox1.Controls.Add(this.labelDataIncepere);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDenumire);
            this.groupBox1.Controls.Add(this.labelDenumire);
            this.groupBox1.Controls.Add(this.cbTipActiv);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 446);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii Activitate";
            // 
            // checkBoxProiect
            // 
            this.checkBoxProiect.AutoSize = true;
            this.checkBoxProiect.Location = new System.Drawing.Point(12, 311);
            this.checkBoxProiect.Name = "checkBoxProiect";
            this.checkBoxProiect.Size = new System.Drawing.Size(170, 17);
            this.checkBoxProiect.TabIndex = 8;
            this.checkBoxProiect.Text = "Activitatea contine un proiect?";
            this.checkBoxProiect.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDeadLine
            // 
            this.dateTimePickerDeadLine.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dateTimePickerDeadLine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDeadLine.Location = new System.Drawing.Point(79, 411);
            this.dateTimePickerDeadLine.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDeadLine.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDeadLine.Name = "dateTimePickerDeadLine";
            this.dateTimePickerDeadLine.Size = new System.Drawing.Size(128, 20);
            this.dateTimePickerDeadLine.TabIndex = 11;
            this.dateTimePickerDeadLine.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDeadLine_Validating);
            this.dateTimePickerDeadLine.Validated += new System.EventHandler(this.dateTimePickerDeadLine_Validated);
            // 
            // labelDeadLine
            // 
            this.labelDeadLine.AutoSize = true;
            this.labelDeadLine.Location = new System.Drawing.Point(18, 414);
            this.labelDeadLine.Name = "labelDeadLine";
            this.labelDeadLine.Size = new System.Drawing.Size(56, 13);
            this.labelDeadLine.TabIndex = 52;
            this.labelDeadLine.Text = "DeadLine:";
            // 
            // textBoxCoord
            // 
            this.textBoxCoord.Location = new System.Drawing.Point(12, 385);
            this.textBoxCoord.Name = "textBoxCoord";
            this.textBoxCoord.Size = new System.Drawing.Size(197, 20);
            this.textBoxCoord.TabIndex = 10;
            // 
            // labelCoord
            // 
            this.labelCoord.AutoSize = true;
            this.labelCoord.Location = new System.Drawing.Point(9, 369);
            this.labelCoord.Name = "labelCoord";
            this.labelCoord.Size = new System.Drawing.Size(68, 13);
            this.labelCoord.TabIndex = 50;
            this.labelCoord.Text = "Coodronator:";
            // 
            // textBoxProiect
            // 
            this.textBoxProiect.Location = new System.Drawing.Point(12, 346);
            this.textBoxProiect.Name = "textBoxProiect";
            this.textBoxProiect.Size = new System.Drawing.Size(197, 20);
            this.textBoxProiect.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(10, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 2);
            this.label3.TabIndex = 48;
            // 
            // labelProiect
            // 
            this.labelProiect.AutoSize = true;
            this.labelProiect.Location = new System.Drawing.Point(10, 330);
            this.labelProiect.Name = "labelProiect";
            this.labelProiect.Size = new System.Drawing.Size(40, 13);
            this.labelProiect.TabIndex = 47;
            this.labelProiect.Text = "Proiect";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(10, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 2);
            this.label2.TabIndex = 46;
            // 
            // textBoxResurse
            // 
            this.textBoxResurse.Location = new System.Drawing.Point(56, 265);
            this.textBoxResurse.Name = "textBoxResurse";
            this.textBoxResurse.Size = new System.Drawing.Size(151, 20);
            this.textBoxResurse.TabIndex = 7;
            // 
            // labelResursa
            // 
            this.labelResursa.AutoSize = true;
            this.labelResursa.Location = new System.Drawing.Point(7, 268);
            this.labelResursa.Name = "labelResursa";
            this.labelResursa.Size = new System.Drawing.Size(49, 13);
            this.labelResursa.TabIndex = 44;
            this.labelResursa.Text = "Resursa:";
            // 
            // checkBoxResurse
            // 
            this.checkBoxResurse.AutoSize = true;
            this.checkBoxResurse.Location = new System.Drawing.Point(11, 246);
            this.checkBoxResurse.Name = "checkBoxResurse";
            this.checkBoxResurse.Size = new System.Drawing.Size(111, 17);
            this.checkBoxResurse.TabIndex = 6;
            this.checkBoxResurse.Text = "Necesita resurse?";
            this.checkBoxResurse.UseVisualStyleBackColor = true;
            // 
            // textBoxDomeniu
            // 
            this.textBoxDomeniu.Location = new System.Drawing.Point(10, 220);
            this.textBoxDomeniu.Name = "textBoxDomeniu";
            this.textBoxDomeniu.Size = new System.Drawing.Size(197, 20);
            this.textBoxDomeniu.TabIndex = 5;
            // 
            // labelDomeniu
            // 
            this.labelDomeniu.AutoSize = true;
            this.labelDomeniu.Location = new System.Drawing.Point(10, 204);
            this.labelDomeniu.Name = "labelDomeniu";
            this.labelDomeniu.Size = new System.Drawing.Size(49, 13);
            this.labelDomeniu.TabIndex = 39;
            this.labelDomeniu.Text = "Domeniu";
            // 
            // dateTimeIncheiere
            // 
            this.dateTimeIncheiere.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dateTimeIncheiere.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeIncheiere.Location = new System.Drawing.Point(79, 151);
            this.dateTimeIncheiere.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimeIncheiere.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeIncheiere.Name = "dateTimeIncheiere";
            this.dateTimeIncheiere.Size = new System.Drawing.Size(127, 20);
            this.dateTimeIncheiere.TabIndex = 4;
            this.dateTimeIncheiere.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeIncheiere_Validating);
            this.dateTimeIncheiere.Validated += new System.EventHandler(this.dateTimeIncheiere_Validated);
            // 
            // labelDataIncheiere
            // 
            this.labelDataIncheiere.AutoSize = true;
            this.labelDataIncheiere.Location = new System.Drawing.Point(5, 155);
            this.labelDataIncheiere.Name = "labelDataIncheiere";
            this.labelDataIncheiere.Size = new System.Drawing.Size(71, 13);
            this.labelDataIncheiere.TabIndex = 35;
            this.labelDataIncheiere.Text = "Data Inchiere";
            // 
            // dateTimePickerIncepere
            // 
            this.dateTimePickerIncepere.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dateTimePickerIncepere.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIncepere.Location = new System.Drawing.Point(78, 118);
            this.dateTimePickerIncepere.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerIncepere.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerIncepere.Name = "dateTimePickerIncepere";
            this.dateTimePickerIncepere.Size = new System.Drawing.Size(128, 20);
            this.dateTimePickerIncepere.TabIndex = 3;
            // 
            // labelDataIncepere
            // 
            this.labelDataIncepere.AutoSize = true;
            this.labelDataIncepere.Location = new System.Drawing.Point(4, 119);
            this.labelDataIncepere.Name = "labelDataIncepere";
            this.labelDataIncepere.Size = new System.Drawing.Size(75, 13);
            this.labelDataIncepere.TabIndex = 33;
            this.labelDataIncepere.Text = "Data Incepere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tip Activitate";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(7, 44);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(200, 20);
            this.tbDenumire.TabIndex = 1;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(4, 26);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(99, 13);
            this.labelDenumire.TabIndex = 29;
            this.labelDenumire.Text = "Denumire Activitate";
            // 
            // cbTipActiv
            // 
            this.cbTipActiv.FormattingEnabled = true;
            this.cbTipActiv.Items.AddRange(new object[] {
            "RELAXARE",
            "MUNCA",
            "EDUCATIV"});
            this.cbTipActiv.Location = new System.Drawing.Point(7, 87);
            this.cbTipActiv.Name = "cbTipActiv";
            this.cbTipActiv.Size = new System.Drawing.Size(200, 21);
            this.cbTipActiv.TabIndex = 2;
            // 
            // buttonAnuleaza
            // 
            this.buttonAnuleaza.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAnuleaza.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnuleaza.Image")));
            this.buttonAnuleaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnuleaza.Location = new System.Drawing.Point(23, 464);
            this.buttonAnuleaza.Name = "buttonAnuleaza";
            this.buttonAnuleaza.Size = new System.Drawing.Size(103, 43);
            this.buttonAnuleaza.TabIndex = 13;
            this.buttonAnuleaza.Text = "Anuleaza\r\nOperatia";
            this.buttonAnuleaza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnuleaza.UseVisualStyleBackColor = false;
            this.buttonAnuleaza.Click += new System.EventHandler(this.buttonAnuleaza_Click);
            // 
            // buttonConfirma
            // 
            this.buttonConfirma.BackColor = System.Drawing.SystemColors.Info;
            this.buttonConfirma.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirma.Image")));
            this.buttonConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirma.Location = new System.Drawing.Point(150, 464);
            this.buttonConfirma.Name = "buttonConfirma";
            this.buttonConfirma.Size = new System.Drawing.Size(103, 43);
            this.buttonConfirma.TabIndex = 14;
            this.buttonConfirma.Text = "Confirma\r\nModificare";
            this.buttonConfirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirma.UseVisualStyleBackColor = false;
            this.buttonConfirma.Click += new System.EventHandler(this.buttonConfirma_Click);
            // 
            // errorProviderDataIncheiere
            // 
            this.errorProviderDataIncheiere.ContainerControl = this;
            // 
            // errorProviderDeadLine
            // 
            this.errorProviderDeadLine.ContainerControl = this;
            // 
            // EditareActivitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 521);
            this.Controls.Add(this.buttonConfirma);
            this.Controls.Add(this.buttonAnuleaza);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditareActivitate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editare Activitate";
            this.Load += new System.EventHandler(this.EditareActivitate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDataIncheiere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeadLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxProiect;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadLine;
        private System.Windows.Forms.Label labelDeadLine;
        private System.Windows.Forms.TextBox textBoxCoord;
        private System.Windows.Forms.Label labelCoord;
        private System.Windows.Forms.TextBox textBoxProiect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProiect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResurse;
        private System.Windows.Forms.Label labelResursa;
        private System.Windows.Forms.CheckBox checkBoxResurse;
        private System.Windows.Forms.TextBox textBoxDomeniu;
        private System.Windows.Forms.Label labelDomeniu;
        private System.Windows.Forms.DateTimePicker dateTimeIncheiere;
        private System.Windows.Forms.Label labelDataIncheiere;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncepere;
        private System.Windows.Forms.Label labelDataIncepere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.ComboBox cbTipActiv;
        private System.Windows.Forms.Button buttonAnuleaza;
        private System.Windows.Forms.Button buttonConfirma;
        private System.Windows.Forms.ErrorProvider errorProviderDataIncheiere;
        private System.Windows.Forms.ErrorProvider errorProviderDeadLine;
    }
}