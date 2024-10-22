namespace onthi
{
    partial class frm_nhapsach
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
            this.lb_tl = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_sotrang = new System.Windows.Forms.Label();
            this.lb_tt = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_sotrang = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.cb_tl = new System.Windows.Forms.ComboBox();
            this.txt_tt = new System.Windows.Forms.TextBox();
            this.dt_sach = new System.Windows.Forms.DataGridView();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.btn_count = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sach)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tl
            // 
            this.lb_tl.AutoSize = true;
            this.lb_tl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tl.Location = new System.Drawing.Point(69, 24);
            this.lb_tl.Name = "lb_tl";
            this.lb_tl.Size = new System.Drawing.Size(50, 16);
            this.lb_tl.TabIndex = 0;
            this.lb_tl.Text = "thể loại";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(69, 61);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(58, 16);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "mã sách";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(69, 99);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(57, 16);
            this.lb_ten.TabIndex = 2;
            this.lb_ten.Text = "tên sách";
            // 
            // lb_sotrang
            // 
            this.lb_sotrang.AutoSize = true;
            this.lb_sotrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sotrang.Location = new System.Drawing.Point(69, 139);
            this.lb_sotrang.Name = "lb_sotrang";
            this.lb_sotrang.Size = new System.Drawing.Size(55, 16);
            this.lb_sotrang.TabIndex = 3;
            this.lb_sotrang.Text = "số trang";
            // 
            // lb_tt
            // 
            this.lb_tt.AutoSize = true;
            this.lb_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tt.Location = new System.Drawing.Point(69, 199);
            this.lb_tt.Name = "lb_tt";
            this.lb_tt.Size = new System.Drawing.Size(52, 16);
            this.lb_tt.TabIndex = 4;
            this.lb_tt.Text = "Tóm tăt";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(162, 60);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 5;
            // 
            // txt_sotrang
            // 
            this.txt_sotrang.Location = new System.Drawing.Point(162, 135);
            this.txt_sotrang.Name = "txt_sotrang";
            this.txt_sotrang.Size = new System.Drawing.Size(121, 20);
            this.txt_sotrang.TabIndex = 6;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(162, 99);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(121, 20);
            this.txt_ten.TabIndex = 7;
            // 
            // cb_tl
            // 
            this.cb_tl.FormattingEnabled = true;
            this.cb_tl.Location = new System.Drawing.Point(162, 24);
            this.cb_tl.Name = "cb_tl";
            this.cb_tl.Size = new System.Drawing.Size(121, 21);
            this.cb_tl.TabIndex = 8;
            // 
            // txt_tt
            // 
            this.txt_tt.Location = new System.Drawing.Point(72, 227);
            this.txt_tt.Multiline = true;
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_tt.Size = new System.Drawing.Size(157, 50);
            this.txt_tt.TabIndex = 9;
            // 
            // dt_sach
            // 
            this.dt_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_sach.Location = new System.Drawing.Point(414, 4);
            this.dt_sach.Name = "dt_sach";
            this.dt_sach.Size = new System.Drawing.Size(374, 211);
            this.dt_sach.TabIndex = 10;
            this.dt_sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_sach_CellClick);
            this.dt_sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_sach_CellContentClick);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(72, 304);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 11;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(162, 304);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(261, 304);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(353, 304);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 14;
            this.btn_dong.Text = "Đsong";
            this.btn_dong.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(162, 362);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 15;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(405, 361);
            this.txt_count.Name = "txt_count";
            this.txt_count.ReadOnly = true;
            this.txt_count.Size = new System.Drawing.Size(100, 20);
            this.txt_count.TabIndex = 17;
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(324, 359);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(75, 23);
            this.btn_count.TabIndex = 18;
            this.btn_count.Text = "Đếm";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // frm_nhapsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.dt_sach);
            this.Controls.Add(this.txt_tt);
            this.Controls.Add(this.cb_tl);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_sotrang);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lb_tt);
            this.Controls.Add(this.lb_sotrang);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_tl);
            this.Name = "frm_nhapsach";
            this.Text = "frm_nhapsach";
            this.Load += new System.EventHandler(this.frm_nhapsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_sach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tl;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_sotrang;
        private System.Windows.Forms.Label lb_tt;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_sotrang;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.ComboBox cb_tl;
        private System.Windows.Forms.TextBox txt_tt;
        private System.Windows.Forms.DataGridView dt_sach;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Button btn_count;
    }
}