namespace ODP1_Connected_Start
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.patientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.appointmentGrid = new System.Windows.Forms.DataGridView();
            this.search_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.save_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientID
            // 
            this.patientID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.patientID.Location = new System.Drawing.Point(176, 76);
            this.patientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(187, 22);
            this.patientID.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Patient ID";
            // 
            // appointmentGrid
            // 
            this.appointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGrid.Location = new System.Drawing.Point(57, 118);
            this.appointmentGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentGrid.Name = "appointmentGrid";
            this.appointmentGrid.RowHeadersWidth = 51;
            this.appointmentGrid.Size = new System.Drawing.Size(456, 303);
            this.appointmentGrid.TabIndex = 27;
            // 
            // search_bt
            // 
            this.search_bt.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.search_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_bt.Location = new System.Drawing.Point(404, 73);
            this.search_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(100, 28);
            this.search_bt.TabIndex = 26;
            this.search_bt.Text = "Search";
            this.search_bt.UseVisualStyleBackColor = true;
            this.search_bt.Click += new System.EventHandler(this.search_bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 154);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(23, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_bt
            // 
            this.save_bt.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.save_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_bt.Location = new System.Drawing.Point(452, 441);
            this.save_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(100, 28);
            this.save_bt.TabIndex = 33;
            this.save_bt.Text = "Save";
            this.save_bt.UseVisualStyleBackColor = true;
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(568, 491);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appointmentGrid);
            this.Controls.Add(this.search_bt);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox patientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView appointmentGrid;
        private System.Windows.Forms.Button search_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save_bt;
    }
}