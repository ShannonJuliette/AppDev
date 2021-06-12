
namespace Overall_Project
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
            this.report2 = new System.Windows.Forms.RadioButton();
            this.report3 = new System.Windows.Forms.RadioButton();
            this.report4 = new System.Windows.Forms.RadioButton();
            this.report5 = new System.Windows.Forms.RadioButton();
            this.report6 = new System.Windows.Forms.RadioButton();
            this.report7 = new System.Windows.Forms.RadioButton();
            this.report9 = new System.Windows.Forms.RadioButton();
            this.report10 = new System.Windows.Forms.RadioButton();
            this.report12 = new System.Windows.Forms.RadioButton();
            this.report_btn = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.btn_age = new System.Windows.Forms.Button();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // report2
            // 
            this.report2.AutoSize = true;
            this.report2.Location = new System.Drawing.Point(49, 75);
            this.report2.Name = "report2";
            this.report2.Size = new System.Drawing.Size(326, 21);
            this.report2.TabIndex = 0;
            this.report2.TabStop = true;
            this.report2.Text = "Display the total profitability of the farm per day";
            this.report2.UseVisualStyleBackColor = true;
            // 
            // report3
            // 
            this.report3.AutoSize = true;
            this.report3.Location = new System.Drawing.Point(49, 127);
            this.report3.Name = "report3";
            this.report3.Size = new System.Drawing.Size(370, 21);
            this.report3.TabIndex = 1;
            this.report3.TabStop = true;
            this.report3.Text = "Display the total tax paid to the government per month";
            this.report3.UseVisualStyleBackColor = true;
            // 
            // report4
            // 
            this.report4.AutoSize = true;
            this.report4.Location = new System.Drawing.Point(49, 177);
            this.report4.Name = "report4";
            this.report4.Size = new System.Drawing.Size(400, 21);
            this.report4.TabIndex = 2;
            this.report4.TabStop = true;
            this.report4.Text = "Display the total amount of milk per day for goats and cows";
            this.report4.UseVisualStyleBackColor = true;
            // 
            // report5
            // 
            this.report5.AutoSize = true;
            this.report5.Location = new System.Drawing.Point(49, 227);
            this.report5.Name = "report5";
            this.report5.Size = new System.Drawing.Size(346, 21);
            this.report5.TabIndex = 3;
            this.report5.TabStop = true;
            this.report5.Text = "Display the average age of all animals (excl. dogs)";
            this.report5.UseVisualStyleBackColor = true;
            // 
            // report6
            // 
            this.report6.AutoSize = true;
            this.report6.Location = new System.Drawing.Point(49, 274);
            this.report6.Name = "report6";
            this.report6.Size = new System.Drawing.Size(417, 21);
            this.report6.TabIndex = 4;
            this.report6.TabStop = true;
            this.report6.Text = "Display the average profitability of Goats and Cows v/s Sheep";
            this.report6.UseVisualStyleBackColor = true;
            // 
            // report7
            // 
            this.report7.AutoSize = true;
            this.report7.Location = new System.Drawing.Point(49, 320);
            this.report7.Name = "report7";
            this.report7.Size = new System.Drawing.Size(361, 21);
            this.report7.TabIndex = 5;
            this.report7.TabStop = true;
            this.report7.Text = "Display the ratio of Dogs\' cost compared to total cost";
            this.report7.UseVisualStyleBackColor = true;
            // 
            // report9
            // 
            this.report9.AutoSize = true;
            this.report9.Location = new System.Drawing.Point(49, 364);
            this.report9.Name = "report9";
            this.report9.Size = new System.Drawing.Size(325, 21);
            this.report9.TabIndex = 6;
            this.report9.TabStop = true;
            this.report9.Text = "Display the ratio of livestock with the colour red";
            this.report9.UseVisualStyleBackColor = true;
            // 
            // report10
            // 
            this.report10.AutoSize = true;
            this.report10.Location = new System.Drawing.Point(49, 406);
            this.report10.Name = "report10";
            this.report10.Size = new System.Drawing.Size(287, 21);
            this.report10.TabIndex = 7;
            this.report10.TabStop = true;
            this.report10.Text = "Display the total tax paid for Jersey Cows";
            this.report10.UseVisualStyleBackColor = true;
            // 
            // report12
            // 
            this.report12.AutoSize = true;
            this.report12.Location = new System.Drawing.Point(49, 451);
            this.report12.Name = "report12";
            this.report12.Size = new System.Drawing.Size(319, 21);
            this.report12.TabIndex = 8;
            this.report12.TabStop = true;
            this.report12.Text = "Display the total profitability of all Jersey Cows";
            this.report12.UseVisualStyleBackColor = true;
            // 
            // report_btn
            // 
            this.report_btn.Location = new System.Drawing.Point(49, 515);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(132, 47);
            this.report_btn.TabIndex = 9;
            this.report_btn.Text = "Generate Report";
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(567, 75);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(155, 22);
            this.tb_id.TabIndex = 10;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(757, 67);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(111, 43);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "Search ID";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // btn_age
            // 
            this.btn_age.Location = new System.Drawing.Point(757, 145);
            this.btn_age.Name = "btn_age";
            this.btn_age.Size = new System.Drawing.Size(111, 40);
            this.btn_age.TabIndex = 13;
            this.btn_age.Text = "Search Age";
            this.btn_age.UseVisualStyleBackColor = true;
            this.btn_age.Click += new System.EventHandler(this.btn_age_Click);
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(547, 320);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output.Size = new System.Drawing.Size(416, 242);
            this.tb_output.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Searching";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reporting";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(263, 515);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(132, 47);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear Textbox";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(567, 154);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(155, 22);
            this.tb_age.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Generate file with IDs sorted by profitability";
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(661, 255);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(130, 40);
            this.btn_sort.TabIndex = 22;
            this.btn_sort.Text = "Generate File";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 620);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.btn_age);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.report12);
            this.Controls.Add(this.report10);
            this.Controls.Add(this.report9);
            this.Controls.Add(this.report7);
            this.Controls.Add(this.report6);
            this.Controls.Add(this.report5);
            this.Controls.Add(this.report4);
            this.Controls.Add(this.report3);
            this.Controls.Add(this.report2);
            this.Name = "Form1";
            this.Text = "Livestock Reporting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton report2;
        private System.Windows.Forms.RadioButton report3;
        private System.Windows.Forms.RadioButton report4;
        private System.Windows.Forms.RadioButton report5;
        private System.Windows.Forms.RadioButton report6;
        private System.Windows.Forms.RadioButton report7;
        private System.Windows.Forms.RadioButton report9;
        private System.Windows.Forms.RadioButton report10;
        private System.Windows.Forms.RadioButton report12;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button btn_age;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sort;
    }
}

