namespace assit
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DTt_work_date = new System.Windows.Forms.DateTimePicker();
            this.TBc_status = new System.Windows.Forms.TextBox();
            this.TBupd_status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTcheck_status_Click = new System.Windows.Forms.Button();
            this.BTupd_status_Click = new System.Windows.Forms.Button();
            this.BTdel_status_Click = new System.Windows.Forms.Button();
            this.BTins_status_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTt_work_date
            // 
            this.DTt_work_date.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DTt_work_date.Location = new System.Drawing.Point(147, 15);
            this.DTt_work_date.Name = "DTt_work_date";
            this.DTt_work_date.Size = new System.Drawing.Size(222, 26);
            this.DTt_work_date.TabIndex = 0;
            this.DTt_work_date.Value = new System.DateTime(2016, 1, 28, 0, 0, 0, 0);
            // 
            // TBc_status
            // 
            this.TBc_status.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBc_status.Location = new System.Drawing.Point(147, 50);
            this.TBc_status.Name = "TBc_status";
            this.TBc_status.Size = new System.Drawing.Size(131, 26);
            this.TBc_status.TabIndex = 1;
            // 
            // TBupd_status
            // 
            this.TBupd_status.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBupd_status.Location = new System.Drawing.Point(147, 80);
            this.TBupd_status.Name = "TBupd_status";
            this.TBupd_status.Size = new System.Drawing.Size(131, 26);
            this.TBupd_status.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "数据处理日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "数据处理状态：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "状态修改值：";
            // 
            // BTcheck_status_Click
            // 
            this.BTcheck_status_Click.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTcheck_status_Click.Location = new System.Drawing.Point(31, 133);
            this.BTcheck_status_Click.Name = "BTcheck_status_Click";
            this.BTcheck_status_Click.Size = new System.Drawing.Size(120, 35);
            this.BTcheck_status_Click.TabIndex = 6;
            this.BTcheck_status_Click.Text = "查询";
            this.BTcheck_status_Click.UseVisualStyleBackColor = true;
            this.BTcheck_status_Click.Click += new System.EventHandler(this.BTcheck_status_Click_Click);
            // 
            // BTupd_status_Click
            // 
            this.BTupd_status_Click.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTupd_status_Click.Location = new System.Drawing.Point(181, 133);
            this.BTupd_status_Click.Name = "BTupd_status_Click";
            this.BTupd_status_Click.Size = new System.Drawing.Size(120, 35);
            this.BTupd_status_Click.TabIndex = 7;
            this.BTupd_status_Click.Text = "更新";
            this.BTupd_status_Click.UseVisualStyleBackColor = true;
            this.BTupd_status_Click.Click += new System.EventHandler(this.BTupd_status_Click_Click);
            // 
            // BTdel_status_Click
            // 
            this.BTdel_status_Click.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTdel_status_Click.Location = new System.Drawing.Point(31, 174);
            this.BTdel_status_Click.Name = "BTdel_status_Click";
            this.BTdel_status_Click.Size = new System.Drawing.Size(120, 35);
            this.BTdel_status_Click.TabIndex = 8;
            this.BTdel_status_Click.Text = "删除";
            this.BTdel_status_Click.UseVisualStyleBackColor = true;
            this.BTdel_status_Click.Click += new System.EventHandler(this.BTdel_status_Click_Click);
            // 
            // BTins_status_Click
            // 
            this.BTins_status_Click.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTins_status_Click.Location = new System.Drawing.Point(181, 174);
            this.BTins_status_Click.Name = "BTins_status_Click";
            this.BTins_status_Click.Size = new System.Drawing.Size(120, 35);
            this.BTins_status_Click.TabIndex = 9;
            this.BTins_status_Click.Text = "插入";
            this.BTins_status_Click.UseVisualStyleBackColor = true;
            this.BTins_status_Click.Click += new System.EventHandler(this.BTins_status_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 232);
            this.Controls.Add(this.BTins_status_Click);
            this.Controls.Add(this.BTdel_status_Click);
            this.Controls.Add(this.BTupd_status_Click);
            this.Controls.Add(this.BTcheck_status_Click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBupd_status);
            this.Controls.Add(this.TBc_status);
            this.Controls.Add(this.DTt_work_date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "状态控制";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTt_work_date;
        private System.Windows.Forms.TextBox TBc_status;
        private System.Windows.Forms.TextBox TBupd_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTcheck_status_Click;
        private System.Windows.Forms.Button BTupd_status_Click;
        private System.Windows.Forms.Button BTdel_status_Click;
        private System.Windows.Forms.Button BTins_status_Click;
    }
}

