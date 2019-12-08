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
            this.label_q = new System.Windows.Forms.Label();
            this.numericUpDown_p = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_q = new System.Windows.Forms.NumericUpDown();
            this.layoutPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_q)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPannel
            // 
            this.layoutPannel.Controls.Add(this.label_p);
            this.layoutPannel.Controls.Add(this.numericUpDown_p);
            this.layoutPannel.Controls.Add(this.label_q);
            this.layoutPannel.Controls.Add(this.numericUpDown_q);
            this.layoutPannel.Location = new System.Drawing.Point(12, 12);
            this.layoutPannel.Name = "layoutPannel";
            this.layoutPannel.Size = new System.Drawing.Size(249, 80);
            this.layoutPannel.TabIndex = 0;
            // 
            // label_p
            // 
            this.label_p.AutoSize = true;
            this.label_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_p.Location = new System.Drawing.Point(3, 0);
            this.label_p.Name = "label_p";
            this.label_p.Size = new System.Drawing.Size(153, 32);
            this.label_p.TabIndex = 0;
            this.label_p.Text = "Choose p:";
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_q.Location = new System.Drawing.Point(3, 40);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(153, 32);
            this.label_q.TabIndex = 2;
            this.label_q.Text = "Choose q:";
            // 
            // numericUpDown_p
            // 
            this.numericUpDown_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_p.Location = new System.Drawing.Point(162, 3);
            this.numericUpDown_p.Name = "numericUpDown_p";
            this.numericUpDown_p.Size = new System.Drawing.Size(71, 34);
            this.numericUpDown_p.TabIndex = 4;
            this.numericUpDown_p.Value = new decimal(new int[] {
            43,
            0,
            0,
            0});
            // 
            // numericUpDown_q
            // 
            this.numericUpDown_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_q.Location = new System.Drawing.Point(162, 43);
            this.numericUpDown_q.Name = "numericUpDown_q";
            this.numericUpDown_q.Size = new System.Drawing.Size(71, 34);
            this.numericUpDown_q.TabIndex = 5;
            this.numericUpDown_q.Value = new decimal(new int[] {
            47,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutPannel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.layoutPannel.ResumeLayout(false);
            this.layoutPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_q)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPannel;
        private System.Windows.Forms.Label label_p;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.NumericUpDown numericUpDown_p;
        private System.Windows.Forms.NumericUpDown numericUpDown_q;
    }
}

