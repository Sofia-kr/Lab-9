namespace Lab_9
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.btnCreateDefault = new System.Windows.Forms.Button();
            this.btnCreateCustom = new System.Windows.Forms.Button();
            this.btnAppendData = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtContentToAdd = new System.Windows.Forms.TextBox();
            this.btnClearContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(191, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(155, 22);
            this.txtFileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Назва файлу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть інформацію для додавання в файл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата створення";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Location = new System.Drawing.Point(36, 304);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(44, 16);
            this.lblTotalFiles.TabIndex = 12;
            this.lblTotalFiles.Text = "label7";
            // 
            // btnCreateDefault
            // 
            this.btnCreateDefault.Location = new System.Drawing.Point(35, 267);
            this.btnCreateDefault.Name = "btnCreateDefault";
            this.btnCreateDefault.Size = new System.Drawing.Size(311, 34);
            this.btnCreateDefault.TabIndex = 13;
            this.btnCreateDefault.Text = "Створити файл по замовчуванню";
            this.btnCreateDefault.UseVisualStyleBackColor = true;
            this.btnCreateDefault.Click += new System.EventHandler(this.btnCreateDefault_Click);
            // 
            // btnCreateCustom
            // 
            this.btnCreateCustom.Location = new System.Drawing.Point(178, 86);
            this.btnCreateCustom.Name = "btnCreateCustom";
            this.btnCreateCustom.Size = new System.Drawing.Size(168, 23);
            this.btnCreateCustom.TabIndex = 14;
            this.btnCreateCustom.Text = "Створити файл ";
            this.btnCreateCustom.UseVisualStyleBackColor = true;
            this.btnCreateCustom.Click += new System.EventHandler(this.btnCreateCustom_Click);
            // 
            // btnAppendData
            // 
            this.btnAppendData.Location = new System.Drawing.Point(144, 229);
            this.btnAppendData.Name = "btnAppendData";
            this.btnAppendData.Size = new System.Drawing.Size(202, 23);
            this.btnAppendData.TabIndex = 15;
            this.btnAppendData.Text = "Додати інформацію";
            this.btnAppendData.UseVisualStyleBackColor = true;
            this.btnAppendData.Click += new System.EventHandler(this.btnAppendData_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(35, 385);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(221, 27);
            this.btnShowInfo.TabIndex = 16;
            this.btnShowInfo.Text = "Показати вміст файлу";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(39, 431);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(328, 65);
            this.txtContent.TabIndex = 17;
            // 
            // txtContentToAdd
            // 
            this.txtContentToAdd.Location = new System.Drawing.Point(39, 159);
            this.txtContentToAdd.Multiline = true;
            this.txtContentToAdd.Name = "txtContentToAdd";
            this.txtContentToAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContentToAdd.Size = new System.Drawing.Size(307, 55);
            this.txtContentToAdd.TabIndex = 18;
            // 
            // btnClearContent
            // 
            this.btnClearContent.Location = new System.Drawing.Point(39, 522);
            this.btnClearContent.Name = "btnClearContent";
            this.btnClearContent.Size = new System.Drawing.Size(167, 23);
            this.btnClearContent.TabIndex = 19;
            this.btnClearContent.Text = "Очистити файл";
            this.btnClearContent.UseVisualStyleBackColor = true;
            this.btnClearContent.Click += new System.EventHandler(this.btnClearContent_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 570);
            this.Controls.Add(this.btnClearContent);
            this.Controls.Add(this.txtContentToAdd);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btnAppendData);
            this.Controls.Add(this.btnCreateCustom);
            this.Controls.Add(this.btnCreateDefault);
            this.Controls.Add(this.lblTotalFiles);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Name = "Form1";
            this.Text = "File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.Button btnCreateDefault;
        private System.Windows.Forms.Button btnCreateCustom;
        private System.Windows.Forms.Button btnAppendData;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtContentToAdd;
        private System.Windows.Forms.Button btnClearContent;
    }
}

