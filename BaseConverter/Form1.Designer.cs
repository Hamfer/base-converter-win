using System.Windows.Forms;

namespace BaseConverterApp
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
            this.flowLayoutPanelParent = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBinary = new System.Windows.Forms.Label();
            this.textBoxBinary = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelOctal = new System.Windows.Forms.Label();
            this.textBoxOctal = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDecimal = new System.Windows.Forms.Label();
            this.textBoxDecimal = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelHex = new System.Windows.Forms.Label();
            this.textBoxHex = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanelParent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelParent
            // 
            this.flowLayoutPanelParent.AutoSize = true;
            this.flowLayoutPanelParent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelParent.Controls.Add(this.groupBox1);
            this.flowLayoutPanelParent.Controls.Add(this.groupBox2);
            this.flowLayoutPanelParent.Controls.Add(this.groupBox3);
            this.flowLayoutPanelParent.Controls.Add(this.groupBox4);
            this.flowLayoutPanelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelParent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelParent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelParent.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelParent.Name = "flowLayoutPanelParent";
            this.flowLayoutPanelParent.Size = new System.Drawing.Size(217, 264);
            this.flowLayoutPanelParent.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.labelBinary);
            this.flowLayoutPanel1.Controls.Add(this.textBoxBinary);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 39);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelBinary
            // 
            this.labelBinary.AutoSize = true;
            this.labelBinary.Location = new System.Drawing.Point(3, 0);
            this.labelBinary.Name = "labelBinary";
            this.labelBinary.Size = new System.Drawing.Size(78, 13);
            this.labelBinary.TabIndex = 0;
            this.labelBinary.Text = "Binary (Base 2)";
            // 
            // textBoxBinary
            // 
            this.textBoxBinary.Location = new System.Drawing.Point(3, 16);
            this.textBoxBinary.Name = "textBoxBinary";
            this.textBoxBinary.Size = new System.Drawing.Size(200, 20);
            this.textBoxBinary.TabIndex = 1;
            this.textBoxBinary.TextChanged += (sender, e) => this.textBoxBase_TextChanged(sender, e, 2);
            this.textBoxBinary.KeyPress += (sender, e) => this.textBoxBase_KeyPress(sender, e, 2);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(3, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 58);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.labelOctal);
            this.flowLayoutPanel2.Controls.Add(this.textBoxOctal);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(206, 39);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // labelOctal
            // 
            this.labelOctal.AutoSize = true;
            this.labelOctal.Location = new System.Drawing.Point(3, 0);
            this.labelOctal.Name = "labelOctal";
            this.labelOctal.Size = new System.Drawing.Size(74, 13);
            this.labelOctal.TabIndex = 2;
            this.labelOctal.Text = "Octal (Base 8)";
            // 
            // textBoxOctal
            // 
            this.textBoxOctal.Location = new System.Drawing.Point(3, 16);
            this.textBoxOctal.Name = "textBoxOctal";
            this.textBoxOctal.Size = new System.Drawing.Size(200, 20);
            this.textBoxOctal.TabIndex = 3;
            this.textBoxOctal.TextChanged += (sender, e) => this.textBoxBase_TextChanged(sender, e, 8);
            this.textBoxOctal.KeyPress += (sender, e) => this.textBoxBase_KeyPress(sender, e, 8);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.flowLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(3, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 58);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.labelDecimal);
            this.flowLayoutPanel3.Controls.Add(this.textBoxDecimal);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(206, 39);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // labelDecimal
            // 
            this.labelDecimal.AutoSize = true;
            this.labelDecimal.Location = new System.Drawing.Point(3, 0);
            this.labelDecimal.Name = "labelDecimal";
            this.labelDecimal.Size = new System.Drawing.Size(93, 13);
            this.labelDecimal.TabIndex = 4;
            this.labelDecimal.Text = "Decimal (Base 10)";
            // 
            // textBoxDecimal
            // 
            this.textBoxDecimal.Location = new System.Drawing.Point(3, 16);
            this.textBoxDecimal.Name = "textBoxDecimal";
            this.textBoxDecimal.Size = new System.Drawing.Size(200, 20);
            this.textBoxDecimal.TabIndex = 5;
            this.textBoxDecimal.TextChanged += (sender, e) => this.textBoxBase_TextChanged(sender, e, 10);
            this.textBoxDecimal.KeyPress += (sender, e) => this.textBoxBase_KeyPress(sender, e, 10);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.flowLayoutPanel4);
            this.groupBox4.Location = new System.Drawing.Point(3, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 58);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.labelHex);
            this.flowLayoutPanel4.Controls.Add(this.textBoxHex);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(206, 39);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // labelHex
            // 
            this.labelHex.AutoSize = true;
            this.labelHex.Location = new System.Drawing.Point(3, 0);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(74, 13);
            this.labelHex.TabIndex = 6;
            this.labelHex.Text = "Hex (Base 16)";
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(3, 16);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(200, 20);
            this.textBoxHex.TabIndex = 7;
            this.textBoxHex.TextChanged += (sender, e) => this.textBoxBase_TextChanged(sender, e, 16);
            this.textBoxHex.KeyPress += (sender, e) => this.textBoxBase_KeyPress(sender, e, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 264);
            this.Controls.Add(this.flowLayoutPanelParent);
            this.MaximumSize = new System.Drawing.Size(233, 303);
            this.MinimumSize = new System.Drawing.Size(233, 303);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Converter";
            this.TopMost = true;
            this.flowLayoutPanelParent.ResumeLayout(false);
            this.flowLayoutPanelParent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelBinary;
        private System.Windows.Forms.Label labelOctal;
        private System.Windows.Forms.Label labelDecimal;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.MaskedTextBox textBoxBinary;
        private System.Windows.Forms.MaskedTextBox textBoxOctal;
        private System.Windows.Forms.MaskedTextBox textBoxDecimal;
        private System.Windows.Forms.MaskedTextBox textBoxHex;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelParent;

        #endregion
    }
}