
namespace QuanLyChiTieu
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btBaocao = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.btLich = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(12, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(134, 127);
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btBaocao);
            this.groupBox3.Controls.Add(this.btNhap);
            this.groupBox3.Controls.Add(this.btLich);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 419);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu";
            // 
            // btBaocao
            // 
            this.btBaocao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaocao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btBaocao.Location = new System.Drawing.Point(3, 111);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(138, 41);
            this.btBaocao.TabIndex = 0;
            this.btBaocao.Text = "Báo Cáo";
            this.btBaocao.UseVisualStyleBackColor = false;
            this.btBaocao.Click += new System.EventHandler(this.btBaocao_Click);
            // 
            // btNhap
            // 
            this.btNhap.BackColor = System.Drawing.Color.Orange;
            this.btNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btNhap.Location = new System.Drawing.Point(3, 36);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(138, 41);
            this.btNhap.TabIndex = 0;
            this.btNhap.Text = "Nhập";
            this.btNhap.UseVisualStyleBackColor = false;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btLich
            // 
            this.btLich.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLich.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btLich.Location = new System.Drawing.Point(3, 73);
            this.btLich.Name = "btLich";
            this.btLich.Size = new System.Drawing.Size(138, 41);
            this.btLich.TabIndex = 0;
            this.btLich.Text = "Lịch";
            this.btLich.UseVisualStyleBackColor = false;
            this.btLich.Click += new System.EventHandler(this.btLich_Click);
            // 
            // pnBody
            // 
            this.pnBody.Location = new System.Drawing.Point(152, 12);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(633, 595);
            this.pnBody.TabIndex = 25;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 625);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox10);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Chi Tieu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btLich;
        private System.Windows.Forms.Panel pnBody;
    }
}

