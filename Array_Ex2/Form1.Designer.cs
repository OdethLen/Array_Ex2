namespace Array_Ex2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculateAverage = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            txtQualification = new TextBox();
            txtAverage = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnTotal = new Button();
            btnSaveVotes = new Button();
            txtTotalVotes = new TextBox();
            label4 = new Label();
            txtNoVotes = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculateAverage
            // 
            btnCalculateAverage.Location = new Point(235, 33);
            btnCalculateAverage.Name = "btnCalculateAverage";
            btnCalculateAverage.Size = new Size(75, 23);
            btnCalculateAverage.TabIndex = 0;
            btnCalculateAverage.Text = "Average";
            btnCalculateAverage.UseVisualStyleBackColor = true;
            btnCalculateAverage.Click += btnAverage_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(55, 116);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtQualification);
            groupBox1.Controls.Add(btnCalculateAverage);
            groupBox1.Controls.Add(txtAverage);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 145);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Results";
            // 
            // txtQualification
            // 
            txtQualification.Location = new Point(111, 38);
            txtQualification.Name = "txtQualification";
            txtQualification.Size = new Size(100, 23);
            txtQualification.TabIndex = 5;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(111, 69);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(100, 23);
            txtAverage.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 77);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Average:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(136, 116);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "Qualification:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTotal);
            groupBox2.Controls.Add(btnSaveVotes);
            groupBox2.Controls.Add(txtTotalVotes);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNoVotes);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 140);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Count";
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(235, 30);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(75, 23);
            btnTotal.TabIndex = 6;
            btnTotal.Text = "Total";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnSaveVotes
            // 
            btnSaveVotes.Location = new Point(136, 102);
            btnSaveVotes.Name = "btnSaveVotes";
            btnSaveVotes.Size = new Size(75, 23);
            btnSaveVotes.TabIndex = 6;
            btnSaveVotes.Text = "Save votes";
            btnSaveVotes.UseVisualStyleBackColor = true;
            btnSaveVotes.Click += btnSaveVotes_Click;
            // 
            // txtTotalVotes
            // 
            txtTotalVotes.Location = new Point(111, 53);
            txtTotalVotes.Name = "txtTotalVotes";
            txtTotalVotes.Size = new Size(100, 23);
            txtTotalVotes.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 61);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Total votes:";
            // 
            // txtNoVotes
            // 
            txtNoVotes.Location = new Point(111, 22);
            txtNoVotes.Name = "txtNoVotes";
            txtNoVotes.Size = new Size(100, 23);
            txtNoVotes.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 30);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 6;
            label3.Text = "No. of votes:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 362);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculateAverage;
        private Button btnExit;
        private GroupBox groupBox1;
        private TextBox txtAverage;
        private Label label2;
        private Button btnSave;
        private Label label1;
        private TextBox txtQualification;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private TextBox txtNoVotes;
        private Button btnSaveVotes;
        private TextBox txtTotalVotes;
        private Button btnTotal;
    }
}
