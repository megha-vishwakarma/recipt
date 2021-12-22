
namespace feeRecipt
{
    partial class FeeRecipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeeRecipt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.Sname = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.Course = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.feeDetailsDataSet = new feeRecipt.feeDetailsDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new feeRecipt.feeDetailsDataSetTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.feeDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 26.18182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(142, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee Receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 45);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name of student";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(170, 455);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(152, 64);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(343, 455);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(152, 64);
            this.Print.TabIndex = 8;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.LightSalmon;
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(12, 447);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(152, 84);
            this.Generate.TabIndex = 9;
            this.Generate.Text = "Generate Receipt";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Sname
            // 
            this.Sname.BackColor = System.Drawing.Color.Silver;
            this.Sname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Name", true));
            this.Sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname.Location = new System.Drawing.Point(328, 115);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(244, 39);
            this.Sname.TabIndex = 10;
            this.Sname.TextChanged += new System.EventHandler(this.Sname_TextChanged);
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.Silver;
            this.Amount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Amount", true));
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(328, 224);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(244, 39);
            this.Amount.TabIndex = 11;
            // 
            // MobileNo
            // 
            this.MobileNo.BackColor = System.Drawing.Color.Silver;
            this.MobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNo.Location = new System.Drawing.Point(328, 283);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(244, 39);
            this.MobileNo.TabIndex = 12;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(611, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(422, 478);
            this.txtResult.TabIndex = 15;
            this.txtResult.Text = "";
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Course.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.studentBindingSource, "Course", true));
            this.Course.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "Course", true));
            this.Course.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Course", true));
            this.Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.FormattingEnabled = true;
            this.Course.Items.AddRange(new object[] {
            "Classical Music",
            "Paino",
            "Violin",
            "Guitar",
            "Tabla"});
            this.Course.Location = new System.Drawing.Point(328, 181);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(244, 30);
            this.Course.TabIndex = 16;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // feeDetailsDataSet
            // 
            this.feeDetailsDataSet.DataSetName = "feeDetailsDataSet";
            this.feeDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.feeDetailsDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // FeeRecipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1045, 574);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeeRecipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeeRecipt";
            this.Load += new System.EventHandler(this.FeeRecipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feeDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private feeDetailsDataSet feeDetailsDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private feeDetailsDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}

