namespace Lab3_Criptography
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
            this.layoutPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.label_p = new System.Windows.Forms.Label();
            this.numericUpDown_p = new System.Windows.Forms.NumericUpDown();
            this.label_q = new System.Windows.Forms.Label();
            this.numericUpDown_q = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_plaintext = new System.Windows.Forms.Label();
            this.textBox_plaintext = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_cipher = new System.Windows.Forms.Label();
            this.textBox_cipher = new System.Windows.Forms.TextBox();
            this.button_switch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_start = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.layoutPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_q)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPannel
            // 
            this.layoutPannel.Controls.Add(this.label_p);
            this.layoutPannel.Controls.Add(this.numericUpDown_p);
            this.layoutPannel.Controls.Add(this.label_q);
            this.layoutPannel.Controls.Add(this.numericUpDown_q);
            this.layoutPannel.Location = new System.Drawing.Point(9, 10);
            this.layoutPannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutPannel.Name = "layoutPannel";
            this.layoutPannel.Size = new System.Drawing.Size(187, 65);
            this.layoutPannel.TabIndex = 0;
            // 
            // label_p
            // 
            this.label_p.AutoSize = true;
            this.label_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_p.Location = new System.Drawing.Point(2, 0);
            this.label_p.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_p.Name = "label_p";
            this.label_p.Size = new System.Drawing.Size(120, 26);
            this.label_p.TabIndex = 0;
            this.label_p.Text = "Choose p:";
            // 
            // numericUpDown_p
            // 
            this.numericUpDown_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_p.Location = new System.Drawing.Point(126, 2);
            this.numericUpDown_p.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_p.Name = "numericUpDown_p";
            this.numericUpDown_p.Size = new System.Drawing.Size(53, 28);
            this.numericUpDown_p.TabIndex = 4;
            this.numericUpDown_p.Value = new decimal(new int[] {
            43,
            0,
            0,
            0});
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_q.Location = new System.Drawing.Point(2, 32);
            this.label_q.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(120, 26);
            this.label_q.TabIndex = 2;
            this.label_q.Text = "Choose q:";
            // 
            // numericUpDown_q
            // 
            this.numericUpDown_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_q.Location = new System.Drawing.Point(126, 34);
            this.numericUpDown_q.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_q.Name = "numericUpDown_q";
            this.numericUpDown_q.Size = new System.Drawing.Size(53, 28);
            this.numericUpDown_q.TabIndex = 5;
            this.numericUpDown_q.Value = new decimal(new int[] {
            47,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label_plaintext, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_plaintext, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 67);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_plaintext
            // 
            this.label_plaintext.AutoSize = true;
            this.label_plaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plaintext.Location = new System.Drawing.Point(2, 0);
            this.label_plaintext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_plaintext.Name = "label_plaintext";
            this.label_plaintext.Size = new System.Drawing.Size(112, 26);
            this.label_plaintext.TabIndex = 1;
            this.label_plaintext.Text = "Plaintext:";
            // 
            // textBox_plaintext
            // 
            this.textBox_plaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_plaintext.Location = new System.Drawing.Point(126, 3);
            this.textBox_plaintext.Multiline = true;
            this.textBox_plaintext.Name = "textBox_plaintext";
            this.textBox_plaintext.Size = new System.Drawing.Size(135, 61);
            this.textBox_plaintext.TabIndex = 2;
            this.textBox_plaintext.Text = "COLD";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label_cipher, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_cipher, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(314, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 67);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label_cipher
            // 
            this.label_cipher.AutoSize = true;
            this.label_cipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cipher.Location = new System.Drawing.Point(2, 0);
            this.label_cipher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cipher.Name = "label_cipher";
            this.label_cipher.Size = new System.Drawing.Size(128, 26);
            this.label_cipher.TabIndex = 1;
            this.label_cipher.Text = "Ciphertext:";
            // 
            // textBox_cipher
            // 
            this.textBox_cipher.Enabled = false;
            this.textBox_cipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cipher.Location = new System.Drawing.Point(136, 3);
            this.textBox_cipher.Multiline = true;
            this.textBox_cipher.Name = "textBox_cipher";
            this.textBox_cipher.Size = new System.Drawing.Size(135, 61);
            this.textBox_cipher.TabIndex = 2;
            this.textBox_cipher.Text = "0 16 23 2 12 3";
            // 
            // button_switch
            // 
            this.button_switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_switch.Location = new System.Drawing.Point(253, 153);
            this.button_switch.Name = "button_switch";
            this.button_switch.Size = new System.Drawing.Size(83, 32);
            this.button_switch.TabIndex = 3;
            this.button_switch.Text = "Switch";
            this.button_switch.UseVisualStyleBackColor = true;
            this.button_switch.Click += new System.EventHandler(this.button_switch_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label_result, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_start, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(190, 231);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // button_start
            // 
            this.button_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(58, 9);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(83, 32);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_result
            // 
            this.label_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(100, 62);
            this.label_result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 26);
            this.label_result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.button_switch);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.layoutPannel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.layoutPannel.ResumeLayout(false);
            this.layoutPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_q)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPannel;
        private System.Windows.Forms.Label label_p;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.NumericUpDown numericUpDown_p;
        private System.Windows.Forms.NumericUpDown numericUpDown_q;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_plaintext;
        private System.Windows.Forms.TextBox textBox_plaintext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_cipher;
        private System.Windows.Forms.TextBox textBox_cipher;
        private System.Windows.Forms.Button button_switch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_result;
    }
}

