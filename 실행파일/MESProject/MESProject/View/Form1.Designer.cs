﻿namespace MESProject
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnWCSelect = new System.Windows.Forms.Button();
            this.btnWOSelect = new System.Windows.Forms.Button();
            this.btnWOinsert = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbOrderName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbNowDate = new System.Windows.Forms.Label();
            this.lbProgramName = new System.Windows.Forms.Label();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.ucMainHome1 = new MESProject.View.UCMainHome();
            this.ucSelectWorkOrder1 = new MESProject.View.UCSelectWorkOrder();
            this.ucSelectWorkComplete1 = new MESProject.View.UCSelectWorkComplete();
            this.ucInsertWorkOrder1 = new MESProject.View.UCInsertWorkOrder();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnLeft.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.pnLeft.Controls.Add(this.btnShutDown);
            this.pnLeft.Controls.Add(this.btnWCSelect);
            this.pnLeft.Controls.Add(this.btnWOSelect);
            this.pnLeft.Controls.Add(this.btnWOinsert);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(150, 661);
            this.pnLeft.TabIndex = 0;
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.Brown;
            this.btnShutDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShutDown.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnShutDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnShutDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.Color.White;
            this.btnShutDown.Location = new System.Drawing.Point(0, 601);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(150, 60);
            this.btnShutDown.TabIndex = 6;
            this.btnShutDown.Text = "종료";
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnWCSelect
            // 
            this.btnWCSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.btnWCSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWCSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWCSelect.FlatAppearance.BorderSize = 0;
            this.btnWCSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWCSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnWCSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWCSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWCSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWCSelect.ForeColor = System.Drawing.Color.White;
            this.btnWCSelect.Location = new System.Drawing.Point(0, 240);
            this.btnWCSelect.Name = "btnWCSelect";
            this.btnWCSelect.Size = new System.Drawing.Size(150, 80);
            this.btnWCSelect.TabIndex = 5;
            this.btnWCSelect.Text = "작업결과조회";
            this.btnWCSelect.UseVisualStyleBackColor = false;
            this.btnWCSelect.Click += new System.EventHandler(this.btnWCSelect_Click);
            // 
            // btnWOSelect
            // 
            this.btnWOSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.btnWOSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWOSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWOSelect.FlatAppearance.BorderSize = 0;
            this.btnWOSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWOSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnWOSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWOSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWOSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWOSelect.ForeColor = System.Drawing.Color.White;
            this.btnWOSelect.Location = new System.Drawing.Point(0, 160);
            this.btnWOSelect.Name = "btnWOSelect";
            this.btnWOSelect.Size = new System.Drawing.Size(150, 80);
            this.btnWOSelect.TabIndex = 4;
            this.btnWOSelect.Text = "작업지시서조회";
            this.btnWOSelect.UseVisualStyleBackColor = false;
            this.btnWOSelect.Click += new System.EventHandler(this.btnWOSelect_Click);
            // 
            // btnWOinsert
            // 
            this.btnWOinsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.btnWOinsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWOinsert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWOinsert.FlatAppearance.BorderSize = 0;
            this.btnWOinsert.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWOinsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnWOinsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.btnWOinsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWOinsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWOinsert.ForeColor = System.Drawing.Color.White;
            this.btnWOinsert.Location = new System.Drawing.Point(0, 80);
            this.btnWOinsert.Name = "btnWOinsert";
            this.btnWOinsert.Size = new System.Drawing.Size(150, 80);
            this.btnWOinsert.TabIndex = 3;
            this.btnWOinsert.Text = "작업지시서입력";
            this.btnWOinsert.UseVisualStyleBackColor = false;
            this.btnWOinsert.Click += new System.EventHandler(this.btnWOinsert_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(210)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 80);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "홈";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(210)))));
            this.pnTop.Controls.Add(this.lbOrderName);
            this.pnTop.Controls.Add(this.lbDate);
            this.pnTop.Controls.Add(this.lbName);
            this.pnTop.Controls.Add(this.lbNowDate);
            this.pnTop.Controls.Add(this.lbProgramName);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(150, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(834, 80);
            this.pnTop.TabIndex = 1;
            // 
            // lbOrderName
            // 
            this.lbOrderName.AutoSize = true;
            this.lbOrderName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderName.ForeColor = System.Drawing.Color.White;
            this.lbOrderName.Location = new System.Drawing.Point(567, 42);
            this.lbOrderName.Name = "lbOrderName";
            this.lbOrderName.Size = new System.Drawing.Size(65, 21);
            this.lbOrderName.TabIndex = 4;
            this.lbOrderName.Text = "담당자 :";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(567, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(81, 21);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "현재시간 :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(654, 42);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 21);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "김밥";
            // 
            // lbNowDate
            // 
            this.lbNowDate.AutoSize = true;
            this.lbNowDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNowDate.ForeColor = System.Drawing.Color.White;
            this.lbNowDate.Location = new System.Drawing.Point(654, 9);
            this.lbNowDate.Name = "lbNowDate";
            this.lbNowDate.Size = new System.Drawing.Size(158, 21);
            this.lbNowDate.TabIndex = 1;
            this.lbNowDate.Text = "2020-10-12 12:12:12";
            // 
            // lbProgramName
            // 
            this.lbProgramName.AutoSize = true;
            this.lbProgramName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgramName.ForeColor = System.Drawing.Color.White;
            this.lbProgramName.Location = new System.Drawing.Point(281, 21);
            this.lbProgramName.Name = "lbProgramName";
            this.lbProgramName.Size = new System.Drawing.Size(214, 32);
            this.lbProgramName.TabIndex = 0;
            this.lbProgramName.Text = "작업지시 프로그램";
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.White;
            this.pnCenter.Controls.Add(this.ucMainHome1);
            this.pnCenter.Controls.Add(this.ucSelectWorkOrder1);
            this.pnCenter.Controls.Add(this.ucSelectWorkComplete1);
            this.pnCenter.Controls.Add(this.ucInsertWorkOrder1);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(150, 80);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(834, 581);
            this.pnCenter.TabIndex = 2;
            // 
            // ucMainHome1
            // 
            this.ucMainHome1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMainHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainHome1.Location = new System.Drawing.Point(0, 0);
            this.ucMainHome1.Name = "ucMainHome1";
            this.ucMainHome1.Size = new System.Drawing.Size(834, 581);
            this.ucMainHome1.TabIndex = 3;
            // 
            // ucSelectWorkOrder1
            // 
            this.ucSelectWorkOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectWorkOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucSelectWorkOrder1.Name = "ucSelectWorkOrder1";
            this.ucSelectWorkOrder1.Size = new System.Drawing.Size(834, 581);
            this.ucSelectWorkOrder1.TabIndex = 2;
            // 
            // ucSelectWorkComplete1
            // 
            this.ucSelectWorkComplete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSelectWorkComplete1.Location = new System.Drawing.Point(0, 0);
            this.ucSelectWorkComplete1.Name = "ucSelectWorkComplete1";
            this.ucSelectWorkComplete1.Size = new System.Drawing.Size(834, 581);
            this.ucSelectWorkComplete1.TabIndex = 1;
            // 
            // ucInsertWorkOrder1
            // 
            this.ucInsertWorkOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInsertWorkOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucInsertWorkOrder1.Name = "ucInsertWorkOrder1";
            this.ucInsertWorkOrder1.Size = new System.Drawing.Size(834, 581);
            this.ucInsertWorkOrder1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnLeft.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button btnWCSelect;
        private System.Windows.Forms.Button btnWOSelect;
        private System.Windows.Forms.Button btnWOinsert;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Label lbProgramName;
        private View.UCInsertWorkOrder ucInsertWorkOrder1;
        private View.UCSelectWorkOrder ucSelectWorkOrder1;
        private View.UCSelectWorkComplete ucSelectWorkComplete1;
        private View.UCMainHome ucMainHome1;
        private System.Windows.Forms.Label lbOrderName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNowDate;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Timer timer1;
    }
}

