
namespace wpf
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.btnSortArray = new System.Windows.Forms.Button();
            this.txtArraySize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArrayOutput = new System.Windows.Forms.ListBox();
            this.txtResult = new System.Windows.Forms.ListBox();
            this.txtKValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.Location = new System.Drawing.Point(206, 68);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(125, 49);
            this.btnFindProduct.TabIndex = 1;
            this.btnFindProduct.Text = "Find product";
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSortArray
            // 
            this.btnSortArray.Location = new System.Drawing.Point(360, 68);
            this.btnSortArray.Name = "btnSortArray";
            this.btnSortArray.Size = new System.Drawing.Size(118, 49);
            this.btnSortArray.TabIndex = 2;
            this.btnSortArray.Text = "Sort array";
            this.btnSortArray.UseVisualStyleBackColor = true;
            this.btnSortArray.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtArraySize
            // 
            this.txtArraySize.Location = new System.Drawing.Point(68, 31);
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(100, 22);
            this.txtArraySize.TabIndex = 3;
            this.txtArraySize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size";
            // 
            // txtArrayOutput
            // 
            this.txtArrayOutput.FormattingEnabled = true;
            this.txtArrayOutput.ItemHeight = 16;
            this.txtArrayOutput.Location = new System.Drawing.Point(30, 151);
            this.txtArrayOutput.Name = "txtArrayOutput";
            this.txtArrayOutput.Size = new System.Drawing.Size(187, 276);
            this.txtArrayOutput.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.FormattingEnabled = true;
            this.txtResult.ItemHeight = 16;
            this.txtResult.Location = new System.Drawing.Point(244, 151);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(187, 276);
            this.txtResult.TabIndex = 6;
            // 
            // txtKValue
            // 
            this.txtKValue.Location = new System.Drawing.Point(376, 25);
            this.txtKValue.Name = "txtKValue";
            this.txtKValue.Size = new System.Drawing.Size(100, 22);
            this.txtKValue.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKValue);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtArrayOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArraySize);
            this.Controls.Add(this.btnSortArray);
            this.Controls.Add(this.btnFindProduct);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.Button btnSortArray;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox txtArrayOutput;
        private System.Windows.Forms.ListBox txtResult;
        private System.Windows.Forms.TextBox txtKValue;
    }
}

