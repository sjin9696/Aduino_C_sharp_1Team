﻿namespace MESProject.View
{
    partial class UCSelectWorkOrder
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvWOSelect = new System.Windows.Forms.DataGridView();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.dtpSecondDate = new System.Windows.Forms.DateTimePicker();
            this.lbBlank = new System.Windows.Forms.Label();
            this.dtpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWOSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWOSelect
            // 
            this.dgvWOSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWOSelect.Location = new System.Drawing.Point(3, 101);
            this.dgvWOSelect.Name = "dgvWOSelect";
            this.dgvWOSelect.RowTemplate.Height = 23;
            this.dgvWOSelect.Size = new System.Drawing.Size(1018, 547);
            this.dgvWOSelect.TabIndex = 2;
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Image = global::MESProject.Properties.Resources.icons8_refresh_32px;
            this.uiImageButton1.Location = new System.Drawing.Point(996, 71);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(25, 25);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 26;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = null;
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateSearch.Location = new System.Drawing.Point(486, 71);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(69, 25);
            this.btnDateSearch.TabIndex = 25;
            this.btnDateSearch.Text = "찾기";
            this.btnDateSearch.UseVisualStyleBackColor = true;
            // 
            // dtpSecondDate
            // 
            this.dtpSecondDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSecondDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSecondDate.Location = new System.Drawing.Point(254, 71);
            this.dtpSecondDate.Name = "dtpSecondDate";
            this.dtpSecondDate.Size = new System.Drawing.Size(226, 25);
            this.dtpSecondDate.TabIndex = 24;
            // 
            // lbBlank
            // 
            this.lbBlank.AutoSize = true;
            this.lbBlank.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlank.Location = new System.Drawing.Point(235, 77);
            this.lbBlank.Name = "lbBlank";
            this.lbBlank.Size = new System.Drawing.Size(13, 17);
            this.lbBlank.TabIndex = 23;
            this.lbBlank.Text = "-";
            // 
            // dtpFirstDate
            // 
            this.dtpFirstDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstDate.Location = new System.Drawing.Point(3, 71);
            this.dtpFirstDate.Name = "dtpFirstDate";
            this.dtpFirstDate.Size = new System.Drawing.Size(226, 25);
            this.dtpFirstDate.TabIndex = 22;
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "종합",
            "납품처",
            "제품명"});
            this.cbSearch.Location = new System.Drawing.Point(687, 71);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(82, 25);
            this.cbSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(922, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 25);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "찾기";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(775, 71);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(141, 25);
            this.tbSearch.TabIndex = 19;
            // 
            // UCSelectWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiImageButton1);
            this.Controls.Add(this.btnDateSearch);
            this.Controls.Add(this.dtpSecondDate);
            this.Controls.Add(this.lbBlank);
            this.Controls.Add(this.dtpFirstDate);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvWOSelect);
            this.Name = "UCSelectWorkOrder";
            this.Size = new System.Drawing.Size(1024, 651);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWOSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvWOSelect;
        private Sunny.UI.UIImageButton uiImageButton1;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.DateTimePicker dtpSecondDate;
        private System.Windows.Forms.Label lbBlank;
        private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}
