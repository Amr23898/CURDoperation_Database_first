namespace EF
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
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_age = new System.Windows.Forms.TextBox();
            this.text_lname = new System.Windows.Forms.TextBox();
            this.text_fname = new System.Windows.Forms.TextBox();
            this.combo_sup = new System.Windows.Forms.ComboBox();
            this.combo_deptid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ins = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_state = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstudent
            // 
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Location = new System.Drawing.Point(35, 255);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RowTemplate.Height = 25;
            this.dgvstudent.Size = new System.Drawing.Size(689, 183);
            this.dgvstudent.TabIndex = 0;
            this.dgvstudent.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstudent_RowHeaderMouseClick);
            this.dgvstudent.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstudent_RowHeaderMouseDoubleClick);
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(122, 17);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 23);
            this.text_id.TabIndex = 1;
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(395, 65);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(100, 23);
            this.text_address.TabIndex = 4;
            // 
            // text_age
            // 
            this.text_age.Location = new System.Drawing.Point(395, 17);
            this.text_age.Name = "text_age";
            this.text_age.Size = new System.Drawing.Size(100, 23);
            this.text_age.TabIndex = 5;
            // 
            // text_lname
            // 
            this.text_lname.Location = new System.Drawing.Point(122, 117);
            this.text_lname.Name = "text_lname";
            this.text_lname.Size = new System.Drawing.Size(100, 23);
            this.text_lname.TabIndex = 6;
            // 
            // text_fname
            // 
            this.text_fname.Location = new System.Drawing.Point(122, 65);
            this.text_fname.Name = "text_fname";
            this.text_fname.Size = new System.Drawing.Size(100, 23);
            this.text_fname.TabIndex = 7;
            // 
            // combo_sup
            // 
            this.combo_sup.FormattingEnabled = true;
            this.combo_sup.Location = new System.Drawing.Point(395, 105);
            this.combo_sup.Name = "combo_sup";
            this.combo_sup.Size = new System.Drawing.Size(121, 23);
            this.combo_sup.TabIndex = 8;
            // 
            // combo_deptid
            // 
            this.combo_deptid.FormattingEnabled = true;
            this.combo_deptid.Location = new System.Drawing.Point(395, 148);
            this.combo_deptid.Name = "combo_deptid";
            this.combo_deptid.Size = new System.Drawing.Size(121, 23);
            this.combo_deptid.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student_id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "dept_id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Supervioser";
            // 
            // btn_ins
            // 
            this.btn_ins.Location = new System.Drawing.Point(468, 214);
            this.btn_ins.Name = "btn_ins";
            this.btn_ins.Size = new System.Drawing.Size(75, 23);
            this.btn_ins.TabIndex = 17;
            this.btn_ins.Text = "insert";
            this.btn_ins.UseVisualStyleBackColor = true;
            this.btn_ins.Click += new System.EventHandler(this.btn_ins_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(337, 214);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(205, 214);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 19;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(65, 214);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_state
            // 
            this.lab_state.AutoSize = true;
            this.lab_state.Location = new System.Drawing.Point(604, 222);
            this.lab_state.Name = "lab_state";
            this.lab_state.Size = new System.Drawing.Size(0, 15);
            this.lab_state.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_state);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_ins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_deptid);
            this.Controls.Add(this.combo_sup);
            this.Controls.Add(this.text_fname);
            this.Controls.Add(this.text_lname);
            this.Controls.Add(this.text_age);
            this.Controls.Add(this.text_address);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.dgvstudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvstudent;
        private TextBox text_id;
        private TextBox text_address;
        private TextBox text_age;
        private TextBox text_lname;
        private TextBox text_fname;
        private ComboBox combo_sup;
        private ComboBox combo_deptid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btn_ins;
        private Button btn_update;
        private Button btn_del;
        private Button btn_search;
        private Label lab_state;
    }
}