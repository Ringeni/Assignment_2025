namespace calculator2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numText1 = new System.Windows.Forms.TextBox();
            this.numText2 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.option = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.numText1);
            this.flowLayoutPanel1.Controls.Add(this.numText2);
            this.flowLayoutPanel1.Controls.Add(this.option);
            this.flowLayoutPanel1.Controls.Add(this.calculate);
            this.flowLayoutPanel1.Controls.Add(this.result);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(124, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(516, 377);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // numText1
            // 
            this.numText1.Location = new System.Drawing.Point(3, 3);
            this.numText1.Name = "numText1";
            this.numText1.Size = new System.Drawing.Size(100, 21);
            this.numText1.TabIndex = 1;
            // 
            // numText2
            // 
            this.numText2.Location = new System.Drawing.Point(109, 3);
            this.numText2.Name = "numText2";
            this.numText2.Size = new System.Drawing.Size(100, 21);
            this.numText2.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(341, 3);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(422, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(41, 12);
            this.result.TabIndex = 5;
            this.result.Text = "result";
            // 
            // option
            // 
            this.option.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.option.FormattingEnabled = true;
            this.option.ItemHeight = 12;
            this.option.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.option.Location = new System.Drawing.Point(215, 3);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(120, 88);
            this.option.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox numText1;
        private System.Windows.Forms.TextBox numText2;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ListBox option;
    }
}

