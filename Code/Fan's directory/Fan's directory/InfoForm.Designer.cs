using System.Drawing;

namespace Fan_s_directory
{
    partial class InfoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Origin = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.ToForm1 = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TypeOfSport = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Club = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Records = new System.Windows.Forms.TextBox();
            this.TypesOfSport = new System.Windows.Forms.TextBox();
            this.Nation = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.Origin);
            this.panel1.Controls.Add(this.Remove);
            this.panel1.Controls.Add(this.ToForm1);
            this.panel1.Controls.Add(this.Create);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TypeOfSport);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Club);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.Records);
            this.panel1.Controls.Add(this.TypesOfSport);
            this.panel1.Controls.Add(this.Nation);
            this.panel1.Controls.Add(this.Birthday);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.SecondName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 488);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Origin
            // 
            this.Origin.Location = new System.Drawing.Point(84, 177);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(166, 20);
            this.Origin.TabIndex = 62;
            this.Origin.TextChanged += new System.EventHandler(this.Origin_TextChanged_1);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(359, 212);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(203, 34);
            this.Remove.TabIndex = 61;
            this.Remove.Text = "Delete";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // ToForm1
            // 
            this.ToForm1.Location = new System.Drawing.Point(649, 212);
            this.ToForm1.Name = "ToForm1";
            this.ToForm1.Size = new System.Drawing.Size(203, 34);
            this.ToForm1.TabIndex = 60;
            this.ToForm1.Text = "Return to mainform\r\n\r\n\r\n";
            this.ToForm1.UseVisualStyleBackColor = true;
            this.ToForm1.Click += new System.EventHandler(this.ToForm1_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(67, 212);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(203, 34);
            this.Create.TabIndex = 59;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(730, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 58;
            this.label11.Text = "Club";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(717, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Records";
            // 
            // TypeOfSport
            // 
            this.TypeOfSport.AutoSize = true;
            this.TypeOfSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfSport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TypeOfSport.Location = new System.Drawing.Point(702, 49);
            this.TypeOfSport.Name = "TypeOfSport";
            this.TypeOfSport.Size = new System.Drawing.Size(89, 17);
            this.TypeOfSport.TabIndex = 56;
            this.TypeOfSport.Text = "TypeOfSport";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(437, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Nation";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(426, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(441, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Age";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(142, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(123, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "SecondName";
            // 
            // Club
            // 
            this.Club.Location = new System.Drawing.Point(663, 177);
            this.Club.Name = "Club";
            this.Club.Size = new System.Drawing.Size(166, 20);
            this.Club.TabIndex = 50;
            this.Club.TextChanged += new System.EventHandler(this.Club_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(132, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "FirstName";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(855, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 32);
            this.CloseButton.TabIndex = 48;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // Records
            // 
            this.Records.Location = new System.Drawing.Point(663, 117);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(166, 20);
            this.Records.TabIndex = 47;
            this.Records.TextChanged += new System.EventHandler(this.Records_TextChanged);
            // 
            // TypesOfSport
            // 
            this.TypesOfSport.Location = new System.Drawing.Point(663, 69);
            this.TypesOfSport.Name = "TypesOfSport";
            this.TypesOfSport.Size = new System.Drawing.Size(166, 20);
            this.TypesOfSport.TabIndex = 46;
            this.TypesOfSport.TextChanged += new System.EventHandler(this.TypesOfSport_TextChanged);
            // 
            // Nation
            // 
            this.Nation.Location = new System.Drawing.Point(379, 177);
            this.Nation.Name = "Nation";
            this.Nation.Size = new System.Drawing.Size(166, 20);
            this.Nation.TabIndex = 45;
            this.Nation.TextChanged += new System.EventHandler(this.Nation_TextChanged);
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(379, 121);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(166, 20);
            this.Birthday.TabIndex = 44;
            this.Birthday.TextChanged += new System.EventHandler(this.Birthday_TextChanged);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(379, 67);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(166, 20);
            this.Age.TabIndex = 43;
            this.Age.TextChanged += new System.EventHandler(this.Age_TextChanged);
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(84, 117);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(166, 20);
            this.SecondName.TabIndex = 41;
            this.SecondName.TextChanged += new System.EventHandler(this.SecondName_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(84, 67);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(166, 20);
            this.FirstName.TabIndex = 40;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(408, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 60);
            this.label1.TabIndex = 38;
            this.label1.Text = "Create/Delete\r\n\r\n\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.peopleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 236);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataSource = typeof(Fan_s_directory.People);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 489);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.InfoForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Records;
        public System.Windows.Forms.TextBox TypesOfSport;
        public System.Windows.Forms.TextBox Nation;
        public System.Windows.Forms.TextBox Birthday;
        public System.Windows.Forms.TextBox Age;
        public System.Windows.Forms.TextBox SecondName;
        public System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Club;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TypeOfSport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button ToForm1;
        private System.Windows.Forms.Button Remove;
        public System.Windows.Forms.TextBox Origin;
    }
}