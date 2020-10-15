﻿namespace MESProject.View
{
    partial class UCMainHome
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbProductStandard = new System.Windows.Forms.Label();
            this.pbProductData = new System.Windows.Forms.PictureBox();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPerformanceData = new System.Windows.Forms.Label();
            this.tlpChartData = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProductPercent3 = new System.Windows.Forms.Label();
            this.lbProductCount3 = new System.Windows.Forms.Label();
            this.lbProduct3 = new System.Windows.Forms.Label();
            this.lbProductPercent2 = new System.Windows.Forms.Label();
            this.lbProductCount2 = new System.Windows.Forms.Label();
            this.lbProduct2 = new System.Windows.Forms.Label();
            this.lbProductPercent1 = new System.Windows.Forms.Label();
            this.lbProductCount1 = new System.Windows.Forms.Label();
            this.lbProduct1 = new System.Windows.Forms.Label();
            this.lbProductPercent = new System.Windows.Forms.Label();
            this.lbProductCount = new System.Windows.Forms.Label();
            this.lbProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.tlpChartData.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartData
            // 
            chartArea2.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartData.Legends.Add(legend2);
            this.chartData.Location = new System.Drawing.Point(105, 33);
            this.chartData.Name = "chartData";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartData.Series.Add(series2);
            this.chartData.Size = new System.Drawing.Size(648, 307);
            this.chartData.TabIndex = 6;
            this.chartData.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbProductStandard);
            this.panel1.Controls.Add(this.pbProductData);
            this.panel1.Controls.Add(this.pbProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 303);
            this.panel1.TabIndex = 8;
            // 
            // lbProductStandard
            // 
            this.lbProductStandard.AutoSize = true;
            this.lbProductStandard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductStandard.Location = new System.Drawing.Point(10, 10);
            this.lbProductStandard.Name = "lbProductStandard";
            this.lbProductStandard.Size = new System.Drawing.Size(64, 17);
            this.lbProductStandard.TabIndex = 6;
            this.lbProductStandard.Text = "제품 규격";
            // 
            // pbProductData
            // 
            this.pbProductData.Image = global::MESProject.Properties.Resources.LED;
            this.pbProductData.Location = new System.Drawing.Point(519, 53);
            this.pbProductData.Name = "pbProductData";
            this.pbProductData.Size = new System.Drawing.Size(551, 216);
            this.pbProductData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductData.TabIndex = 5;
            this.pbProductData.TabStop = false;
            // 
            // pbProduct
            // 
            this.pbProduct.Image = global::MESProject.Properties.Resources.led_300x199;
            this.pbProduct.Location = new System.Drawing.Point(87, 53);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(364, 216);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProduct.TabIndex = 4;
            this.pbProduct.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.lbPerformanceData);
            this.panel2.Controls.Add(this.tlpChartData);
            this.panel2.Controls.Add(this.chartData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 366);
            this.panel2.TabIndex = 9;
            // 
            // lbPerformanceData
            // 
            this.lbPerformanceData.AutoSize = true;
            this.lbPerformanceData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerformanceData.Location = new System.Drawing.Point(10, 10);
            this.lbPerformanceData.Name = "lbPerformanceData";
            this.lbPerformanceData.Size = new System.Drawing.Size(77, 17);
            this.lbPerformanceData.TabIndex = 7;
            this.lbPerformanceData.Text = "성과 데이터";
            // 
            // tlpChartData
            // 
            this.tlpChartData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tlpChartData.ColumnCount = 4;
            this.tlpChartData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpChartData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpChartData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpChartData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpChartData.Controls.Add(this.lbProductPercent1, 3, 1);
            this.tlpChartData.Controls.Add(this.lbProductPercent, 3, 0);
            this.tlpChartData.Controls.Add(this.lbProductPercent2, 3, 2);
            this.tlpChartData.Controls.Add(this.lbProductPercent3, 3, 3);
            this.tlpChartData.Controls.Add(this.lbProductCount, 2, 0);
            this.tlpChartData.Controls.Add(this.lbProductCount1, 2, 1);
            this.tlpChartData.Controls.Add(this.lbProductCount2, 2, 2);
            this.tlpChartData.Controls.Add(this.lbProductCount3, 2, 3);
            this.tlpChartData.Controls.Add(this.lbProduct, 1, 0);
            this.tlpChartData.Controls.Add(this.lbProduct1, 1, 1);
            this.tlpChartData.Controls.Add(this.lbProduct2, 1, 2);
            this.tlpChartData.Controls.Add(this.lbProduct3, 1, 3);
            this.tlpChartData.Controls.Add(this.button3, 0, 3);
            this.tlpChartData.Controls.Add(this.button1, 0, 2);
            this.tlpChartData.Controls.Add(this.button2, 0, 1);
            this.tlpChartData.Controls.Add(this.label3, 3, 4);
            this.tlpChartData.Controls.Add(this.label2, 2, 4);
            this.tlpChartData.Controls.Add(this.label1, 1, 4);
            this.tlpChartData.Location = new System.Drawing.Point(652, 108);
            this.tlpChartData.Name = "tlpChartData";
            this.tlpChartData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpChartData.RowCount = 5;
            this.tlpChartData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpChartData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpChartData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpChartData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpChartData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpChartData.Size = new System.Drawing.Size(471, 191);
            this.tlpChartData.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(310, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "total_percent";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(189, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "total_count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductPercent3
            // 
            this.lbProductPercent3.AutoSize = true;
            this.lbProductPercent3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductPercent3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPercent3.Location = new System.Drawing.Point(310, 126);
            this.lbProductPercent3.Name = "lbProductPercent3";
            this.lbProductPercent3.Size = new System.Drawing.Size(158, 42);
            this.lbProductPercent3.TabIndex = 18;
            this.lbProductPercent3.Text = "40%";
            this.lbProductPercent3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbProductCount3
            // 
            this.lbProductCount3.AutoSize = true;
            this.lbProductCount3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductCount3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductCount3.Location = new System.Drawing.Point(189, 126);
            this.lbProductCount3.Name = "lbProductCount3";
            this.lbProductCount3.Size = new System.Drawing.Size(115, 42);
            this.lbProductCount3.TabIndex = 17;
            this.lbProductCount3.Text = "10";
            this.lbProductCount3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbProduct3
            // 
            this.lbProduct3.AutoSize = true;
            this.lbProduct3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProduct3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct3.Location = new System.Drawing.Point(63, 126);
            this.lbProduct3.Name = "lbProduct3";
            this.lbProduct3.Size = new System.Drawing.Size(120, 42);
            this.lbProduct3.TabIndex = 16;
            this.lbProduct3.Text = "light_003";
            this.lbProduct3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProductPercent2
            // 
            this.lbProductPercent2.AutoSize = true;
            this.lbProductPercent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductPercent2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPercent2.Location = new System.Drawing.Point(310, 84);
            this.lbProductPercent2.Name = "lbProductPercent2";
            this.lbProductPercent2.Size = new System.Drawing.Size(158, 42);
            this.lbProductPercent2.TabIndex = 15;
            this.lbProductPercent2.Text = "30%";
            this.lbProductPercent2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbProductCount2
            // 
            this.lbProductCount2.AutoSize = true;
            this.lbProductCount2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductCount2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductCount2.Location = new System.Drawing.Point(189, 84);
            this.lbProductCount2.Name = "lbProductCount2";
            this.lbProductCount2.Size = new System.Drawing.Size(115, 42);
            this.lbProductCount2.TabIndex = 14;
            this.lbProductCount2.Text = "10";
            this.lbProductCount2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbProduct2
            // 
            this.lbProduct2.AutoSize = true;
            this.lbProduct2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProduct2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct2.Location = new System.Drawing.Point(63, 84);
            this.lbProduct2.Name = "lbProduct2";
            this.lbProduct2.Size = new System.Drawing.Size(120, 42);
            this.lbProduct2.TabIndex = 13;
            this.lbProduct2.Text = "light_002";
            this.lbProduct2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProductPercent1
            // 
            this.lbProductPercent1.AutoSize = true;
            this.lbProductPercent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductPercent1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPercent1.Location = new System.Drawing.Point(310, 42);
            this.lbProductPercent1.Name = "lbProductPercent1";
            this.lbProductPercent1.Size = new System.Drawing.Size(158, 42);
            this.lbProductPercent1.TabIndex = 12;
            this.lbProductPercent1.Text = "30%";
            this.lbProductPercent1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbProductCount1
            // 
            this.lbProductCount1.AutoSize = true;
            this.lbProductCount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductCount1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductCount1.Location = new System.Drawing.Point(189, 42);
            this.lbProductCount1.Name = "lbProductCount1";
            this.lbProductCount1.Size = new System.Drawing.Size(115, 42);
            this.lbProductCount1.TabIndex = 11;
            this.lbProductCount1.Text = "10";
            this.lbProductCount1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbProduct1
            // 
            this.lbProduct1.AutoSize = true;
            this.lbProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProduct1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct1.Location = new System.Drawing.Point(63, 42);
            this.lbProduct1.Name = "lbProduct1";
            this.lbProduct1.Size = new System.Drawing.Size(120, 42);
            this.lbProduct1.TabIndex = 7;
            this.lbProduct1.Text = "light_001";
            this.lbProduct1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProductPercent
            // 
            this.lbProductPercent.AutoSize = true;
            this.lbProductPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPercent.Location = new System.Drawing.Point(310, 0);
            this.lbProductPercent.Name = "lbProductPercent";
            this.lbProductPercent.Size = new System.Drawing.Size(158, 42);
            this.lbProductPercent.TabIndex = 8;
            this.lbProductPercent.Text = "□Current Percent";
            this.lbProductPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductCount
            // 
            this.lbProductCount.AutoSize = true;
            this.lbProductCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductCount.Location = new System.Drawing.Point(189, 0);
            this.lbProductCount.Name = "lbProductCount";
            this.lbProductCount.Size = new System.Drawing.Size(115, 42);
            this.lbProductCount.TabIndex = 9;
            this.lbProductCount.Text = "□Current Value";
            this.lbProductCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct.Location = new System.Drawing.Point(63, 0);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(120, 42);
            this.lbProduct.TabIndex = 10;
            this.lbProduct.Text = "□Product Name";
            this.lbProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "TOTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(10, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 22);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(10, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 22);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(10, 136);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 22);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(652, 272);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 2);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(652, 147);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(470, 2);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // UCMainHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCMainHome";
            this.Size = new System.Drawing.Size(1160, 681);
            this.Load += new System.EventHandler(this.UCMainHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tlpChartData.ResumeLayout(false);
            this.tlpChartData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbProductData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tlpChartData;
        private System.Windows.Forms.Label lbProductPercent3;
        private System.Windows.Forms.Label lbProductCount3;
        private System.Windows.Forms.Label lbProduct3;
        private System.Windows.Forms.Label lbProductPercent2;
        private System.Windows.Forms.Label lbProductCount2;
        private System.Windows.Forms.Label lbProduct2;
        private System.Windows.Forms.Label lbProductPercent1;
        private System.Windows.Forms.Label lbProductCount1;
        private System.Windows.Forms.Label lbProduct1;
        private System.Windows.Forms.Label lbProductPercent;
        private System.Windows.Forms.Label lbProductCount;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbProductStandard;
        private System.Windows.Forms.Label lbPerformanceData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
