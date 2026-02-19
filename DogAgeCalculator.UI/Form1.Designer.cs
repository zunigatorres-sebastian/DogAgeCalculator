namespace DogAgeCalculator.UI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label6 = new Label();
            txt_result = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            bCalculate = new Button();
            bClear = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txt_ownerName = new TextBox();
            label2 = new Label();
            txt_dogName = new TextBox();
            label3 = new Label();
            txt_dogBreed = new TextBox();
            label4 = new Label();
            txt_dogAge = new TextBox();
            label5 = new Label();
            txt_dogWeight = new TextBox();
            groupBox2 = new GroupBox();
            dgv = new DataGridView();
            groupBox1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 32, 30);
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.ForeColor = Color.FromArgb(238, 238, 238);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label6);
            flowLayoutPanel3.Controls.Add(txt_result);
            flowLayoutPanel3.Dock = DockStyle.Right;
            flowLayoutPanel3.Location = new Point(681, 19);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(116, 147);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "RESULT:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_result
            // 
            txt_result.AutoSize = true;
            txt_result.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_result.ForeColor = Color.FromArgb(255, 67, 1);
            txt_result.Location = new Point(61, 0);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(28, 32);
            txt_result.TabIndex = 1;
            txt_result.Text = "0";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(bCalculate);
            flowLayoutPanel2.Controls.Add(bClear);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(208, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(589, 147);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // bCalculate
            // 
            bCalculate.Cursor = Cursors.Hand;
            bCalculate.FlatStyle = FlatStyle.Flat;
            bCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bCalculate.ForeColor = Color.FromArgb(255, 67, 1);
            bCalculate.Location = new Point(3, 3);
            bCalculate.MinimumSize = new Size(84, 23);
            bCalculate.Name = "bCalculate";
            bCalculate.Size = new Size(84, 23);
            bCalculate.TabIndex = 0;
            bCalculate.Text = "CALCULATE";
            bCalculate.UseVisualStyleBackColor = true;
            bCalculate.Click += bCalculate_Click;
            // 
            // bClear
            // 
            bClear.Cursor = Cursors.Hand;
            bClear.FlatStyle = FlatStyle.Flat;
            bClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bClear.Location = new Point(93, 3);
            bClear.MinimumSize = new Size(84, 23);
            bClear.Name = "bClear";
            bClear.Size = new Size(84, 23);
            bClear.TabIndex = 1;
            bClear.Text = "CLEAR";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_ownerName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txt_dogName);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txt_dogBreed);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(txt_dogAge);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(txt_dogWeight);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(205, 147);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.MinimumSize = new Size(89, 15);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Owners name: ";
            // 
            // txt_ownerName
            // 
            txt_ownerName.BackColor = Color.FromArgb(60, 61, 55);
            txt_ownerName.BorderStyle = BorderStyle.None;
            txt_ownerName.ForeColor = Color.FromArgb(238, 238, 238);
            txt_ownerName.Location = new Point(98, 3);
            txt_ownerName.Name = "txt_ownerName";
            txt_ownerName.Size = new Size(100, 16);
            txt_ownerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.MinimumSize = new Size(89, 15);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Dog's name: ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_dogName
            // 
            txt_dogName.BackColor = Color.FromArgb(60, 61, 55);
            txt_dogName.BorderStyle = BorderStyle.None;
            txt_dogName.ForeColor = Color.FromArgb(238, 238, 238);
            txt_dogName.Location = new Point(98, 32);
            txt_dogName.Name = "txt_dogName";
            txt_dogName.Size = new Size(100, 16);
            txt_dogName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 58);
            label3.MinimumSize = new Size(89, 15);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Dog breed: ";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_dogBreed
            // 
            txt_dogBreed.BackColor = Color.FromArgb(60, 61, 55);
            txt_dogBreed.BorderStyle = BorderStyle.None;
            txt_dogBreed.ForeColor = Color.FromArgb(238, 238, 238);
            txt_dogBreed.Location = new Point(98, 61);
            txt_dogBreed.Name = "txt_dogBreed";
            txt_dogBreed.Size = new Size(100, 16);
            txt_dogBreed.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 87);
            label4.MinimumSize = new Size(89, 15);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 6;
            label4.Text = "Dog's Age: ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_dogAge
            // 
            txt_dogAge.BackColor = Color.FromArgb(60, 61, 55);
            txt_dogAge.BorderStyle = BorderStyle.None;
            txt_dogAge.ForeColor = Color.FromArgb(238, 238, 238);
            txt_dogAge.Location = new Point(98, 90);
            txt_dogAge.Name = "txt_dogAge";
            txt_dogAge.Size = new Size(100, 16);
            txt_dogAge.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 116);
            label5.MinimumSize = new Size(89, 15);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 8;
            label5.Text = "Dog's weight: ";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_dogWeight
            // 
            txt_dogWeight.BackColor = Color.FromArgb(60, 61, 55);
            txt_dogWeight.BorderStyle = BorderStyle.None;
            txt_dogWeight.ForeColor = Color.FromArgb(238, 238, 238);
            txt_dogWeight.Location = new Point(98, 119);
            txt_dogWeight.Name = "txt_dogWeight";
            txt_dogWeight.Size = new Size(100, 16);
            txt_dogWeight.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(30, 32, 30);
            groupBox2.Controls.Add(dgv);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.FromArgb(238, 238, 238);
            groupBox2.Location = new Point(0, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 281);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(105, 117, 101);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(105, 117, 101);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(238, 238, 238);
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.FromArgb(30, 32, 30);
            dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 32, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 67, 1);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 32, 30);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 67, 1);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 61, 55);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(60, 61, 55);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle3;
            dgv.Dock = DockStyle.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(30, 32, 30);
            dgv.Location = new Point(3, 19);
            dgv.Name = "dgv";
            dgv.Size = new Size(794, 259);
            dgv.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(525, 489);
            Name = "Form1";
            Text = "Dog Age Calculator v1.0.0";
            groupBox1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txt_ownerName;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dgv;
        private TextBox txt_dogName;
        private Label label3;
        private TextBox txt_dogBreed;
        private Label label4;
        private TextBox txt_dogAge;
        private Label label5;
        private TextBox txt_dogWeight;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button bCalculate;
        private Button bClear;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label6;
        private Label txt_result;
    }
}
