namespace LogManipulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdjustment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFileType = new System.Windows.Forms.TextBox();
            this.listHeadings = new System.Windows.Forms.ListBox();
            this.textItemNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMaxItems = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select File...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(184, 82);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(533, 22);
            this.textBoxFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Headings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adjustment";
            // 
            // textBoxAdjustment
            // 
            this.textBoxAdjustment.Location = new System.Drawing.Point(280, 247);
            this.textBoxAdjustment.Name = "textBoxAdjustment";
            this.textBoxAdjustment.Size = new System.Drawing.Size(71, 22);
            this.textBoxAdjustment.TabIndex = 11;
            this.textBoxAdjustment.Text = "0";
            this.textBoxAdjustment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "File Type";
            // 
            // textBoxFileType
            // 
            this.textBoxFileType.Location = new System.Drawing.Point(184, 110);
            this.textBoxFileType.Name = "textBoxFileType";
            this.textBoxFileType.Size = new System.Drawing.Size(51, 22);
            this.textBoxFileType.TabIndex = 14;
            this.textBoxFileType.Text = "0";
            this.textBoxFileType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listHeadings
            // 
            this.listHeadings.FormattingEnabled = true;
            this.listHeadings.ItemHeight = 16;
            this.listHeadings.Location = new System.Drawing.Point(184, 138);
            this.listHeadings.Name = "listHeadings";
            this.listHeadings.Size = new System.Drawing.Size(533, 100);
            this.listHeadings.TabIndex = 17;
            this.listHeadings.SelectedIndexChanged += new System.EventHandler(this.listHeadings_SelectedIndexChanged);
            // 
            // textItemNo
            // 
            this.textItemNo.Location = new System.Drawing.Point(613, 244);
            this.textItemNo.Name = "textItemNo";
            this.textItemNo.Size = new System.Drawing.Size(51, 22);
            this.textItemNo.TabIndex = 19;
            this.textItemNo.Text = "0";
            this.textItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textItemNo.TextChanged += new System.EventHandler(this.textItemNo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Selected Item #";
            // 
            // labelMaxItems
            // 
            this.labelMaxItems.AutoSize = true;
            this.labelMaxItems.Location = new System.Drawing.Point(670, 247);
            this.labelMaxItems.Name = "labelMaxItems";
            this.labelMaxItems.Size = new System.Drawing.Size(32, 17);
            this.labelMaxItems.TabIndex = 20;
            this.labelMaxItems.Text = "of 0";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(61, 294);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(155, 30);
            this.buttonProcess.TabIndex = 21;
            this.buttonProcess.Text = "Process File";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 348);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.labelMaxItems);
            this.Controls.Add(this.textItemNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listHeadings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFileType);
            this.Controls.Add(this.textBoxAdjustment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SkyEye File Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdjustment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFileType;
        private System.Windows.Forms.ListBox listHeadings;
        private System.Windows.Forms.TextBox textItemNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMaxItems;
        private System.Windows.Forms.Button buttonProcess;
    }
}

