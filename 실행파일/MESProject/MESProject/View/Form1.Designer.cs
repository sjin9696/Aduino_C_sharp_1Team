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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnWCSelect = new System.Windows.Forms.Button();
            this.btnWOSelect = new System.Windows.Forms.Button();
            this.btnWOinsert = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucMainHome1 = new MESProject.View.UCMainHome();
            this.ucSelectWorkOrder1 = new MESProject.View.UCSelectWorkOrder();
            this.ucSelectWorkComplete1 = new MESProject.View.UCSelectWorkComplete();
            this.ucInsertWorkOrder1 = new MESProject.View.UCInsertWorkOrder();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.btnShutDown);
            this.panel1.Controls.Add(this.btnWCSelect);
            this.panel1.Controls.Add(this.btnWOSelect);
            this.panel1.Controls.Add(this.btnWOinsert);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 661);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(114)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelProgramName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 80);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(645, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "담당자 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(645, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "현재시간 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(732, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "김땡땡";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(732, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "2000-2-22";
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramName.ForeColor = System.Drawing.Color.White;
            this.labelProgramName.Location = new System.Drawing.Point(281, 21);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(214, 32);
            this.labelProgramName.TabIndex = 0;
            this.labelProgramName.Text = "작업지시 프로그램";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ucMainHome1);
            this.panel3.Controls.Add(this.ucSelectWorkOrder1);
            this.panel3.Controls.Add(this.ucSelectWorkComplete1);
            this.panel3.Controls.Add(this.ucInsertWorkOrder1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(150, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 581);
            this.panel3.TabIndex = 2;
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
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWCSelect;
        private System.Windows.Forms.Button btnWOSelect;
        private System.Windows.Forms.Button btnWOinsert;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelProgramName;
        private View.UCInsertWorkOrder ucInsertWorkOrder1;
        private View.UCSelectWorkOrder ucSelectWorkOrder1;
        private View.UCSelectWorkComplete ucSelectWorkComplete1;
        private View.UCMainHome ucMainHome1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShutDown;
    }
}

