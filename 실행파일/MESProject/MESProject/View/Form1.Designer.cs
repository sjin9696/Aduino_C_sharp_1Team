namespace MESProject
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
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnWCSelect = new System.Windows.Forms.Button();
            this.btnWOSelect = new System.Windows.Forms.Button();
            this.btnWOinsert = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LBOrderName = new System.Windows.Forms.Label();
            this.LBDate = new System.Windows.Forms.Label();
            this.LBName = new System.Windows.Forms.Label();
            this.LBNowDate = new System.Windows.Forms.Label();
            this.LBProgramName = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucMainHome1 = new MESProject.View.UCMainHome();
            this.ucSelectWorkOrder1 = new MESProject.View.UCSelectWorkOrder();
            this.ucSelectWorkComplete1 = new MESProject.View.UCSelectWorkComplete();
            this.ucInsertWorkOrder1 = new MESProject.View.UCInsertWorkOrder();
            this.PanelLeft.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.PanelLeft.Controls.Add(this.btnShutDown);
            this.PanelLeft.Controls.Add(this.btnWCSelect);
            this.PanelLeft.Controls.Add(this.btnWOSelect);
            this.PanelLeft.Controls.Add(this.btnWOinsert);
            this.PanelLeft.Controls.Add(this.btnHome);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(150, 661);
            this.PanelLeft.TabIndex = 0;
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
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(210)))));
            this.PanelTop.Controls.Add(this.LBOrderName);
            this.PanelTop.Controls.Add(this.LBDate);
            this.PanelTop.Controls.Add(this.LBName);
            this.PanelTop.Controls.Add(this.LBNowDate);
            this.PanelTop.Controls.Add(this.LBProgramName);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(150, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(834, 80);
            this.PanelTop.TabIndex = 1;
            // 
            // LBOrderName
            // 
            this.LBOrderName.AutoSize = true;
            this.LBOrderName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBOrderName.ForeColor = System.Drawing.Color.White;
            this.LBOrderName.Location = new System.Drawing.Point(567, 42);
            this.LBOrderName.Name = "LBOrderName";
            this.LBOrderName.Size = new System.Drawing.Size(65, 21);
            this.LBOrderName.TabIndex = 4;
            this.LBOrderName.Text = "담당자 :";
            // 
            // LBDate
            // 
            this.LBDate.AutoSize = true;
            this.LBDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDate.ForeColor = System.Drawing.Color.White;
            this.LBDate.Location = new System.Drawing.Point(567, 9);
            this.LBDate.Name = "LBDate";
            this.LBDate.Size = new System.Drawing.Size(81, 21);
            this.LBDate.TabIndex = 3;
            this.LBDate.Text = "현재시간 :";
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBName.ForeColor = System.Drawing.Color.White;
            this.LBName.Location = new System.Drawing.Point(654, 42);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(58, 21);
            this.LBName.TabIndex = 2;
            this.LBName.Text = "김땡땡";
            // 
            // LBNowDate
            // 
            this.LBNowDate.AutoSize = true;
            this.LBNowDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNowDate.ForeColor = System.Drawing.Color.White;
            this.LBNowDate.Location = new System.Drawing.Point(654, 9);
            this.LBNowDate.Name = "LBNowDate";
            this.LBNowDate.Size = new System.Drawing.Size(158, 21);
            this.LBNowDate.TabIndex = 1;
            this.LBNowDate.Text = "2020-10-12 12:12:12";
            // 
            // LBProgramName
            // 
            this.LBProgramName.AutoSize = true;
            this.LBProgramName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBProgramName.ForeColor = System.Drawing.Color.White;
            this.LBProgramName.Location = new System.Drawing.Point(281, 21);
            this.LBProgramName.Name = "LBProgramName";
            this.LBProgramName.Size = new System.Drawing.Size(214, 32);
            this.LBProgramName.TabIndex = 0;
            this.LBProgramName.Text = "작업지시 프로그램";
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.White;
            this.panelCenter.Controls.Add(this.ucMainHome1);
            this.panelCenter.Controls.Add(this.ucSelectWorkOrder1);
            this.panelCenter.Controls.Add(this.ucSelectWorkComplete1);
            this.panelCenter.Controls.Add(this.ucInsertWorkOrder1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(150, 80);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(834, 581);
            this.panelCenter.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelLeft);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelLeft.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Button btnWCSelect;
        private System.Windows.Forms.Button btnWOSelect;
        private System.Windows.Forms.Button btnWOinsert;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label LBProgramName;
        private View.UCInsertWorkOrder ucInsertWorkOrder1;
        private View.UCSelectWorkOrder ucSelectWorkOrder1;
        private View.UCSelectWorkComplete ucSelectWorkComplete1;
        private View.UCMainHome ucMainHome1;
        private System.Windows.Forms.Label LBOrderName;
        private System.Windows.Forms.Label LBDate;
        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.Label LBNowDate;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Timer timer1;
    }
}

