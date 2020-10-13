namespace MESProject.View
{
    partial class UCInsertWorkOrder
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.tlbWorkOrder = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbCount = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.tbNull = new System.Windows.Forms.TextBox();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lbOrnerName = new System.Windows.Forms.Label();
            this.lbNull = new System.Windows.Forms.Label();
            this.tbOrnerName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbOrderTime = new System.Windows.Forms.Label();
            this.lbTimeLimit = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnOrderInsert = new System.Windows.Forms.Panel();
            this.dgvWorkOrder = new System.Windows.Forms.DataGridView();
            this.btnPush = new System.Windows.Forms.Button();
            this.pnOrderList = new System.Windows.Forms.Panel();
            this.tlbWorkOrder.SuspendLayout();
            this.pnOrderInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).BeginInit();
            this.pnOrderList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(720, 297);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 35);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "확인";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // tlbWorkOrder
            // 
            this.tlbWorkOrder.ColumnCount = 4;
            this.tlbWorkOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21967F));
            this.tlbWorkOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.58876F));
            this.tlbWorkOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21967F));
            this.tlbWorkOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.9719F));
            this.tlbWorkOrder.Controls.Add(this.dateTimePicker2, 3, 0);
            this.tlbWorkOrder.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tlbWorkOrder.Controls.Add(this.lbCount, 2, 2);
            this.tlbWorkOrder.Controls.Add(this.tbCount, 3, 2);
            this.tlbWorkOrder.Controls.Add(this.tbCustomer, 3, 1);
            this.tlbWorkOrder.Controls.Add(this.tbNull, 1, 3);
            this.tlbWorkOrder.Controls.Add(this.lbCustomer, 2, 1);
            this.tlbWorkOrder.Controls.Add(this.tbProductName, 1, 2);
            this.tlbWorkOrder.Controls.Add(this.lbOrnerName, 0, 1);
            this.tlbWorkOrder.Controls.Add(this.lbNull, 0, 3);
            this.tlbWorkOrder.Controls.Add(this.tbOrnerName, 1, 1);
            this.tlbWorkOrder.Controls.Add(this.lbProductName, 0, 2);
            this.tlbWorkOrder.Controls.Add(this.lbOrderTime, 0, 0);
            this.tlbWorkOrder.Controls.Add(this.lbTimeLimit, 2, 0);
            this.tlbWorkOrder.Location = new System.Drawing.Point(86, 56);
            this.tlbWorkOrder.Name = "tlbWorkOrder";
            this.tlbWorkOrder.RowCount = 4;
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlbWorkOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlbWorkOrder.Size = new System.Drawing.Size(975, 235);
            this.tlbWorkOrder.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(646, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(226, 25);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 25);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // lbCount
            // 
            this.lbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(488, 130);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(120, 32);
            this.lbCount.TabIndex = 12;
            this.lbCount.Text = "수량 :";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCount.Location = new System.Drawing.Point(646, 133);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(226, 25);
            this.tbCount.TabIndex = 19;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(646, 68);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(226, 25);
            this.tbCustomer.TabIndex = 18;
            // 
            // tbNull
            // 
            this.tbNull.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNull.Location = new System.Drawing.Point(161, 198);
            this.tbNull.Name = "tbNull";
            this.tbNull.Size = new System.Drawing.Size(226, 25);
            this.tbNull.TabIndex = 16;
            // 
            // lbCustomer
            // 
            this.lbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(488, 65);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(120, 32);
            this.lbCustomer.TabIndex = 11;
            this.lbCustomer.Text = "납품처 :";
            this.lbCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductName.Location = new System.Drawing.Point(161, 133);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(226, 25);
            this.tbProductName.TabIndex = 15;
            // 
            // lbOrnerName
            // 
            this.lbOrnerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbOrnerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrnerName.Location = new System.Drawing.Point(3, 65);
            this.lbOrnerName.Name = "lbOrnerName";
            this.lbOrnerName.Size = new System.Drawing.Size(120, 32);
            this.lbOrnerName.TabIndex = 7;
            this.lbOrnerName.Text = "지시담당자 :";
            this.lbOrnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNull
            // 
            this.lbNull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbNull.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNull.Location = new System.Drawing.Point(3, 195);
            this.lbNull.Name = "lbNull";
            this.lbNull.Size = new System.Drawing.Size(120, 32);
            this.lbNull.TabIndex = 9;
            this.lbNull.Text = "비고란 :";
            this.lbNull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOrnerName
            // 
            this.tbOrnerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrnerName.Location = new System.Drawing.Point(161, 68);
            this.tbOrnerName.Name = "tbOrnerName";
            this.tbOrnerName.Size = new System.Drawing.Size(226, 25);
            this.tbOrnerName.TabIndex = 14;
            // 
            // lbProductName
            // 
            this.lbProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(3, 130);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(120, 32);
            this.lbProductName.TabIndex = 8;
            this.lbProductName.Text = "제품명 :";
            this.lbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrderTime
            // 
            this.lbOrderTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbOrderTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderTime.Location = new System.Drawing.Point(3, 0);
            this.lbOrderTime.Name = "lbOrderTime";
            this.lbOrderTime.Size = new System.Drawing.Size(120, 32);
            this.lbOrderTime.TabIndex = 0;
            this.lbOrderTime.Text = "지시일 :";
            this.lbOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimeLimit
            // 
            this.lbTimeLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.lbTimeLimit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLimit.Location = new System.Drawing.Point(488, 0);
            this.lbTimeLimit.Name = "lbTimeLimit";
            this.lbTimeLimit.Size = new System.Drawing.Size(120, 32);
            this.lbTimeLimit.TabIndex = 10;
            this.lbTimeLimit.Text = "기한일 :";
            this.lbTimeLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(863, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 35);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "클리어";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // pnOrderInsert
            // 
            this.pnOrderInsert.BackColor = System.Drawing.Color.White;
            this.pnOrderInsert.Controls.Add(this.btnClear);
            this.pnOrderInsert.Controls.Add(this.tlbWorkOrder);
            this.pnOrderInsert.Controls.Add(this.btnInsert);
            this.pnOrderInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnOrderInsert.Location = new System.Drawing.Point(0, 0);
            this.pnOrderInsert.Name = "pnOrderInsert";
            this.pnOrderInsert.Size = new System.Drawing.Size(1160, 342);
            this.pnOrderInsert.TabIndex = 0;
            // 
            // dgvWorkOrder
            // 
            this.dgvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrder.Location = new System.Drawing.Point(3, 14);
            this.dgvWorkOrder.Name = "dgvWorkOrder";
            this.dgvWorkOrder.RowTemplate.Height = 23;
            this.dgvWorkOrder.Size = new System.Drawing.Size(1154, 258);
            this.dgvWorkOrder.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btnPush.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPush.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.Location = new System.Drawing.Point(863, 275);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(80, 35);
            this.btnPush.TabIndex = 22;
            this.btnPush.Text = "푸시";
            this.btnPush.UseVisualStyleBackColor = false;
            // 
            // pnOrderList
            // 
            this.pnOrderList.BackColor = System.Drawing.Color.White;
            this.pnOrderList.Controls.Add(this.btnPush);
            this.pnOrderList.Controls.Add(this.dgvWorkOrder);
            this.pnOrderList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOrderList.Location = new System.Drawing.Point(0, 368);
            this.pnOrderList.Name = "pnOrderList";
            this.pnOrderList.Size = new System.Drawing.Size(1160, 313);
            this.pnOrderList.TabIndex = 1;
            // 
            // UCInsertWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnOrderList);
            this.Controls.Add(this.pnOrderInsert);
            this.Name = "UCInsertWorkOrder";
            this.Size = new System.Drawing.Size(1160, 681);
            this.tlbWorkOrder.ResumeLayout(false);
            this.tlbWorkOrder.PerformLayout();
            this.pnOrderInsert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).EndInit();
            this.pnOrderList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TableLayoutPanel tlbWorkOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.TextBox tbNull;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lbOrnerName;
        private System.Windows.Forms.Label lbNull;
        private System.Windows.Forms.TextBox tbOrnerName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbOrderTime;
        private System.Windows.Forms.Label lbTimeLimit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnOrderInsert;
        private System.Windows.Forms.DataGridView dgvWorkOrder;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Panel pnOrderList;
    }
}
