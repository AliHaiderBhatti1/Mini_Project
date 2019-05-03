namespace WindowsFormsApp1
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.evmanage = new System.Windows.Forms.Button();
            this.promanage = new System.Windows.Forms.Button();
            this.admanage = new System.Windows.Forms.Button();
            this.Stmanage = new System.Windows.Forms.Button();
            this.ManageGroupButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.evmanage, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.promanage, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.admanage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Stmanage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ManageGroupButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(823, 319);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // evmanage
            // 
            this.evmanage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.evmanage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.evmanage.Location = new System.Drawing.Point(319, 201);
            this.evmanage.Name = "evmanage";
            this.evmanage.Size = new System.Drawing.Size(184, 76);
            this.evmanage.TabIndex = 3;
            this.evmanage.Text = "Manage Evaluation";
            this.evmanage.UseVisualStyleBackColor = true;
            this.evmanage.Click += new System.EventHandler(this.evmanage_Click_1);
            // 
            // promanage
            // 
            this.promanage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.promanage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.promanage.Location = new System.Drawing.Point(47, 203);
            this.promanage.Name = "promanage";
            this.promanage.Size = new System.Drawing.Size(180, 71);
            this.promanage.TabIndex = 2;
            this.promanage.Text = "Manage Project";
            this.promanage.UseVisualStyleBackColor = true;
            this.promanage.Click += new System.EventHandler(this.promanage_Click_1);
            // 
            // admanage
            // 
            this.admanage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admanage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.admanage.Location = new System.Drawing.Point(319, 39);
            this.admanage.Name = "admanage";
            this.admanage.Size = new System.Drawing.Size(184, 80);
            this.admanage.TabIndex = 1;
            this.admanage.Text = "Manage Advisor ";
            this.admanage.UseVisualStyleBackColor = true;
            this.admanage.Click += new System.EventHandler(this.admanage_Click_1);
            // 
            // Stmanage
            // 
            this.Stmanage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stmanage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Stmanage.Location = new System.Drawing.Point(47, 41);
            this.Stmanage.Name = "Stmanage";
            this.Stmanage.Size = new System.Drawing.Size(179, 77);
            this.Stmanage.TabIndex = 0;
            this.Stmanage.Text = "Manage Student ";
            this.Stmanage.UseVisualStyleBackColor = true;
            this.Stmanage.Click += new System.EventHandler(this.Stmanage_Click_1);
            // 
            // ManageGroupButton
            // 
            this.ManageGroupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManageGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ManageGroupButton.Location = new System.Drawing.Point(592, 41);
            this.ManageGroupButton.Name = "ManageGroupButton";
            this.ManageGroupButton.Size = new System.Drawing.Size(186, 76);
            this.ManageGroupButton.TabIndex = 4;
            this.ManageGroupButton.Text = "Manage Groups";
            this.ManageGroupButton.UseVisualStyleBackColor = true;
            this.ManageGroupButton.Click += new System.EventHandler(this.ManageGroupButton_Click_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(823, 150);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FINAL YEAR PROJECT";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "MANAGEMENT SYSTEM";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(594, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 79);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button evmanage;
        private System.Windows.Forms.Button promanage;
        private System.Windows.Forms.Button admanage;
        private System.Windows.Forms.Button Stmanage;
        private System.Windows.Forms.Button ManageGroupButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}