using System.Windows.Forms;

namespace Fan_s_directory
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ShowRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.SortTypesComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SearchPanel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CreateChange);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ShowRecord);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SortComboBox);
            this.panel1.Controls.Add(this.SortTypesComboBox);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 471);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(335, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "enter the details\r\n";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(825, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 32);
            this.CloseButton.TabIndex = 23;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(611, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Editing and making changes\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Location = new System.Drawing.Point(43, 87);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(133, 20);
            this.SearchPanel.TabIndex = 21;
            this.SearchPanel.TextChanged += new System.EventHandler(this.SearchPanel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(595, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Do you want to add someone?\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CreateChange
            // 
            this.CreateChange.Location = new System.Drawing.Point(663, 87);
            this.CreateChange.Name = "CreateChange";
            this.CreateChange.Size = new System.Drawing.Size(98, 41);
            this.CreateChange.TabIndex = 17;
            this.CreateChange.Text = "change";
            this.CreateChange.UseVisualStyleBackColor = true;
            this.CreateChange.Click += new System.EventHandler(this.CreateChange_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.peopleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 196);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataSource = typeof(Fan_s_directory.People);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(285, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Do you want to find record holders?\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ShowRecord
            // 
            this.ShowRecord.BackColor = System.Drawing.Color.Snow;
            this.ShowRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowRecord.Location = new System.Drawing.Point(338, 157);
            this.ShowRecord.Name = "ShowRecord";
            this.ShowRecord.Size = new System.Drawing.Size(107, 40);
            this.ShowRecord.TabIndex = 14;
            this.ShowRecord.Text = "Show Recordsmen";
            this.ShowRecord.UseVisualStyleBackColor = false;
            this.ShowRecord.Click += new System.EventHandler(this.ShowRecord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(266, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 13;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(267, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cannot find specifically sportsmen? \r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SortComboBox
            // 
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Location = new System.Drawing.Point(400, 87);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(145, 21);
            this.SortComboBox.TabIndex = 10;
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
            // 
            // SortTypesComboBox
            // 
            this.SortTypesComboBox.FormattingEnabled = true;
            this.SortTypesComboBox.Location = new System.Drawing.Point(239, 87);
            this.SortTypesComboBox.Name = "SortTypesComboBox";
            this.SortTypesComboBox.Size = new System.Drawing.Size(134, 21);
            this.SortTypesComboBox.TabIndex = 9;
            this.SortTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.SortTypesComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ShowRecord;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateChange;
        private System.Windows.Forms.ComboBox SortTypesComboBox;
        private System.Windows.Forms.TextBox SearchPanel;
        private Label label6;
        private Label CloseButton;
        private Label label7;
    }
}

