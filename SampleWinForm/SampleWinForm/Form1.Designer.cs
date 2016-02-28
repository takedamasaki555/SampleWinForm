namespace SampleWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumber1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNumber1.Location = new System.Drawing.Point(14, 13);
            this.txtNumber1.MaxLength = 4;
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(80, 19);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtNumber2
            // 
            this.txtNumber2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNumber2.Location = new System.Drawing.Point(146, 13);
            this.txtNumber2.MaxLength = 4;
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(80, 19);
            this.txtNumber2.TabIndex = 1;
            this.txtNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(258, 12);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(120, 19);
            this.txtAnswer.TabIndex = 2;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "＋",
            "－",
            "×",
            "÷"});
            this.cmbOperator.Location = new System.Drawing.Point(100, 12);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(40, 20);
            this.cmbOperator.TabIndex = 3;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(232, 10);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(20, 23);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.Text = "＝";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 44);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.ComboBox cmbOperator;
    }
}

