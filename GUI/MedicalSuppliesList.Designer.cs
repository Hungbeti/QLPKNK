namespace GUI
{
    partial class MedicalSuppliesList
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
            this.btnService = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btnService);
            this.pnTop.Controls.Add(this.btnTool);
            this.pnTop.Controls.Add(this.btnMedicine);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(800, 96);
            this.pnTop.TabIndex = 0;
            // 
            // btnService
            // 
            this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnService.BackColor = System.Drawing.Color.White;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.Location = new System.Drawing.Point(681, 24);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(90, 50);
            this.btnService.TabIndex = 3;
            this.btnService.Text = "Dịch vụ";
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnTool
            // 
            this.btnTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTool.BackColor = System.Drawing.Color.White;
            this.btnTool.FlatAppearance.BorderSize = 0;
            this.btnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTool.Location = new System.Drawing.Point(539, 24);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(114, 50);
            this.btnTool.TabIndex = 2;
            this.btnTool.Text = "Dụng cụ";
            this.btnTool.UseVisualStyleBackColor = false;
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(229)))));
            this.btnMedicine.FlatAppearance.BorderSize = 0;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.Location = new System.Drawing.Point(411, 24);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(90, 50);
            this.btnMedicine.TabIndex = 1;
            this.btnMedicine.Text = "Thuốc";
            this.btnMedicine.UseVisualStyleBackColor = false;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách vật tư";
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 96);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(800, 354);
            this.pnContent.TabIndex = 1;
            // 
            // MedicalSuppliesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicalSuppliesList";
            this.Text = "MedicalSuppliesList";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnContent;
    }
}