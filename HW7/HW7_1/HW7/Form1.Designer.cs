
namespace HW7
{
    partial class HW7_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSales = new System.Windows.Forms.TextBox();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.tipTen = new System.Windows.Forms.Button();
            this.tipFifteen = new System.Windows.Forms.Button();
            this.tipTwenty = new System.Windows.Forms.Button();
            this.tipAny = new System.Windows.Forms.Button();
            this.textBoxPercent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // textBoxSales
            // 
            this.textBoxSales.Location = new System.Drawing.Point(86, 23);
            this.textBoxSales.Name = "textBoxSales";
            this.textBoxSales.Size = new System.Drawing.Size(100, 23);
            this.textBoxSales.TabIndex = 3;
            // 
            // textBoxTip
            // 
            this.textBoxTip.Location = new System.Drawing.Point(80, 63);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.ReadOnly = true;
            this.textBoxTip.Size = new System.Drawing.Size(100, 23);
            this.textBoxTip.TabIndex = 4;
            this.textBoxTip.TabStop = false;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(80, 103);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotal.TabIndex = 5;
            this.textBoxTotal.TabStop = false;
            // 
            // tipTen
            // 
            this.tipTen.Location = new System.Drawing.Point(230, 10);
            this.tipTen.Name = "tipTen";
            this.tipTen.Size = new System.Drawing.Size(95, 30);
            this.tipTen.TabIndex = 6;
            this.tipTen.Text = "10% Tip";
            this.tipTen.UseVisualStyleBackColor = true;
            this.tipTen.Click += new System.EventHandler(this.tipTen_Click);
            // 
            // tipFifteen
            // 
            this.tipFifteen.Location = new System.Drawing.Point(230, 45);
            this.tipFifteen.Name = "tipFifteen";
            this.tipFifteen.Size = new System.Drawing.Size(95, 30);
            this.tipFifteen.TabIndex = 7;
            this.tipFifteen.Text = "15% Tip";
            this.tipFifteen.UseVisualStyleBackColor = true;
            this.tipFifteen.Click += new System.EventHandler(this.tipFifteen_Click);
            // 
            // tipTwenty
            // 
            this.tipTwenty.Location = new System.Drawing.Point(230, 80);
            this.tipTwenty.Name = "tipTwenty";
            this.tipTwenty.Size = new System.Drawing.Size(95, 30);
            this.tipTwenty.TabIndex = 8;
            this.tipTwenty.Text = "20% Tip";
            this.tipTwenty.UseVisualStyleBackColor = true;
            this.tipTwenty.Click += new System.EventHandler(this.tipTwenty_Click);
            // 
            // tipAny
            // 
            this.tipAny.Location = new System.Drawing.Point(281, 115);
            this.tipAny.Name = "tipAny";
            this.tipAny.Size = new System.Drawing.Size(44, 25);
            this.tipAny.TabIndex = 9;
            this.tipAny.Text = "% Tip";
            this.tipAny.UseVisualStyleBackColor = true;
            this.tipAny.Click += new System.EventHandler(this.tipAny_Click);
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.Location = new System.Drawing.Point(233, 116);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.Size = new System.Drawing.Size(44, 23);
            this.textBoxPercent.TabIndex = 10;
            // 
            // HW7_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 151);
            this.Controls.Add(this.textBoxPercent);
            this.Controls.Add(this.tipAny);
            this.Controls.Add(this.tipTwenty);
            this.Controls.Add(this.tipFifteen);
            this.Controls.Add(this.tipTen);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.textBoxSales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HW7_1";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSales;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button tipTen;
        private System.Windows.Forms.Button tipFifteen;
        private System.Windows.Forms.Button tipTwenty;
        private System.Windows.Forms.Button tipAny;
        private System.Windows.Forms.TextBox textBoxPercent;
    }
}

