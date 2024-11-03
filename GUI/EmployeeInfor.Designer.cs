namespace GUI
{
    partial class EmployeeInfor
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReception = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.panel3);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1028, 110);
            this.pnTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnReception);
            this.panel3.Controls.Add(this.btnDoctor);
            this.panel3.Location = new System.Drawing.Point(673, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 87);
            this.panel3.TabIndex = 23;
            // 
            // btnReception
            // 
            this.btnReception.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(229)))));
            this.btnReception.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReception.FlatAppearance.BorderSize = 0;
            this.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReception.Location = new System.Drawing.Point(0, 0);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(167, 87);
            this.btnReception.TabIndex = 0;
            this.btnReception.Text = "Lễ tân";
            this.btnReception.UseVisualStyleBackColor = false;
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.Color.White;
            this.btnDoctor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDoctor.FlatAppearance.BorderSize = 0;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.Location = new System.Drawing.Point(160, 0);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(177, 87);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "Bác sĩ";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 110);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1028, 501);
            this.pnContent.TabIndex = 1;
            // 
            // EmployeeInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 611);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnTop);
            this.Name = "EmployeeInfor";
            this.Text = "EmployeeInfor";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Label label1;
    }
}