namespace MESProject.View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbProductData = new System.Windows.Forms.PictureBox();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbProduct1 = new System.Windows.Forms.Label();
            this.lbProductPercent = new System.Windows.Forms.Label();
            this.lbProductCount = new System.Windows.Forms.Label();
            this.lbProduct = new System.Windows.Forms.Label();
            this.tlpChartData = new System.Windows.Forms.TableLayoutPanel();
            this.lbProductCount1 = new System.Windows.Forms.Label();
            this.lbProductPercent1 = new System.Windows.Forms.Label();
            this.lbProduct2 = new System.Windows.Forms.Label();
            this.lbProductCount2 = new System.Windows.Forms.Label();
            this.lbProductPercent2 = new System.Windows.Forms.Label();
            this.lbProduct3 = new System.Windows.Forms.Label();
            this.lbProductCount3 = new System.Windows.Forms.Label();
            this.lbProductPercent3 = new System.Windows.Forms.Label();
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
            chartArea5.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartData.Legends.Add(legend5);
            this.chartData.Location = new System.Drawing.Point(60, 30);
            this.chartData.Name = "chartData";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartData.Series.Add(series5);
            this.chartData.Size = new System.Drawing.Size(648, 307);
            this.chartData.TabIndex = 6;
            this.chartData.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbProductData);
            this.panel1.Controls.Add(this.pbProduct);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 303);
            this.panel1.TabIndex = 8;
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
            this.panel2.Controls.Add(this.tlpChartData);
            this.panel2.Controls.Add(this.chartData);
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 366);
            this.panel2.TabIndex = 9;
            // 
            // lbProduct1
            // 
            this.lbProduct1.AutoSize = true;
            this.lbProduct1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct1.Location = new System.Drawing.Point(4, 68);
            this.lbProduct1.Name = "lbProduct1";
            this.lbProduct1.Size = new System.Drawing.Size(68, 21);
            this.lbProduct1.TabIndex = 7;
            this.lbProduct1.Text = "□Light 1";
            this.lbProduct1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductPercent
            // 
            this.lbProductPercent.AutoSize = true;
            this.lbProductPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPercent.Location = new System.Drawing.Point(200, 1);
            this.lbProductPercent.Name = "lbProductPercent";
            this.lbProductPercent.Size = new System.Drawing.Size(68, 21);
            this.lbProductPercent.TabIndex = 8;
            this.lbProductPercent.Text = "□퍼센트";
            this.lbProductPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductCount
            // 
            this.lbProductCount.AutoSize = true;
            this.lbProductCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductCount.Location = new System.Drawing.Point(102, 1);
            this.lbProductCount.Name = "lbProductCount";
            this.lbProductCount.Size = new System.Drawing.Size(52, 21);
            this.lbProductCount.TabIndex = 9;
            this.lbProductCount.Text = "□수량";
            this.lbProductCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct.Location = new System.Drawing.Point(4, 1);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(68, 21);
            this.lbProduct.TabIndex = 10;
            this.lbProduct.Text = "□제품명";
            this.lbProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpChartData
            // 
            this.tlpChartData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpChartData.ColumnCount = 3;
            this.tlpChartData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpChartData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpChartData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpChartData.Controls.Add(this.lbProductPercent3, 2, 3);
            this.tlpChartData.Controls.Add(this.lbProductCount3, 1, 3);
            this.tlpChartData.Controls.Add(this.lbProduct3, 0, 3);
            this.tlpChartData.Controls.Add(this.lbProductPercent2, 2, 2);
            this.tlpChartData.Controls.Add(this.lbProductCount2, 1, 2);
            this.tlpChartData.Controls.Add(this.lbProduct2, 0, 2);
            this.tlpChartData.Controls.Add(this.lbProductPercent1, 2, 1);
            this.tlpChartData.Controls.Add(this.lbProductCount1, 1, 1);
            this.tlpChartData.Controls.Add(this.lbProduct1, 0, 1);
            this.tlpChartData.Controls.Add(this.lbProductPercent, 2, 0);
            this.tlpChartData.Controls.Add(this.lbProductCount, 1, 0);
            this.tlpChartData.Controls.Add(this.lbProduct, 0, 0);
            this.tlpChartData.Location = new System.Drawing.Point(770, 47);
            this.tlpChartData.Name = "tlpChartData";
            this.tlpChartData.RowCount = 4;
            this.tlpChartData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpChartData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpChartData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpChartData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpChartData.Size = new System.Drawing.Size(300, 271);
            this.tlpChartData.TabIndex = 11;
            // 
            // lbProductCount1
            // 
            this.lbProductCount1.AutoSize = true;
            this.lbProductCount1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductCount1.Location = new System.Drawing.Point(102, 68);
            this.lbProductCount1.Name = "lbProductCount1";
            this.lbProductCount1.Size = new System.Drawing.Size(28, 21);
            this.lbProductCount1.TabIndex = 11;
            this.lbProductCount1.Text = "10";
            this.lbProductCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductPercent1
            // 
            this.lbProductPercent1.AutoSize = true;
            this.lbProductPercent1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPercent1.Location = new System.Drawing.Point(200, 68);
            this.lbProductPercent1.Name = "lbProductPercent1";
            this.lbProductPercent1.Size = new System.Drawing.Size(41, 21);
            this.lbProductPercent1.TabIndex = 12;
            this.lbProductPercent1.Text = "30%";
            this.lbProductPercent1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProduct2
            // 
            this.lbProduct2.AutoSize = true;
            this.lbProduct2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct2.Location = new System.Drawing.Point(4, 135);
            this.lbProduct2.Name = "lbProduct2";
            this.lbProduct2.Size = new System.Drawing.Size(68, 21);
            this.lbProduct2.TabIndex = 13;
            this.lbProduct2.Text = "□Light 2";
            this.lbProduct2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductCount2
            // 
            this.lbProductCount2.AutoSize = true;
            this.lbProductCount2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductCount2.Location = new System.Drawing.Point(102, 135);
            this.lbProductCount2.Name = "lbProductCount2";
            this.lbProductCount2.Size = new System.Drawing.Size(28, 21);
            this.lbProductCount2.TabIndex = 14;
            this.lbProductCount2.Text = "10";
            this.lbProductCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductPercent2
            // 
            this.lbProductPercent2.AutoSize = true;
            this.lbProductPercent2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPercent2.Location = new System.Drawing.Point(200, 135);
            this.lbProductPercent2.Name = "lbProductPercent2";
            this.lbProductPercent2.Size = new System.Drawing.Size(41, 21);
            this.lbProductPercent2.TabIndex = 15;
            this.lbProductPercent2.Text = "30%";
            this.lbProductPercent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProduct3
            // 
            this.lbProduct3.AutoSize = true;
            this.lbProduct3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct3.Location = new System.Drawing.Point(4, 202);
            this.lbProduct3.Name = "lbProduct3";
            this.lbProduct3.Size = new System.Drawing.Size(68, 21);
            this.lbProduct3.TabIndex = 16;
            this.lbProduct3.Text = "□Light 3";
            this.lbProduct3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductCount3
            // 
            this.lbProductCount3.AutoSize = true;
            this.lbProductCount3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductCount3.Location = new System.Drawing.Point(102, 202);
            this.lbProductCount3.Name = "lbProductCount3";
            this.lbProductCount3.Size = new System.Drawing.Size(28, 21);
            this.lbProductCount3.TabIndex = 17;
            this.lbProductCount3.Text = "10";
            this.lbProductCount3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductPercent3
            // 
            this.lbProductPercent3.AutoSize = true;
            this.lbProductPercent3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductPercent3.Location = new System.Drawing.Point(200, 202);
            this.lbProductPercent3.Name = "lbProductPercent3";
            this.lbProductPercent3.Size = new System.Drawing.Size(41, 21);
            this.lbProductPercent3.TabIndex = 18;
            this.lbProductPercent3.Text = "40%";
            this.lbProductPercent3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.panel2.ResumeLayout(false);
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
    }
}
