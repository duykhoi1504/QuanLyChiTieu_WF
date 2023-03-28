
namespace QuanLyChiTieu
{
    partial class UserControlMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btBaocao = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.btLich = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btBaocao);
            this.groupBox3.Controls.Add(this.btNhap);
            this.groupBox3.Controls.Add(this.btLich);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 419);
            this.groupBox3.TabIndex = 15;
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
          
            // 
            // UserControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "UserControlMenu";
            this.Size = new System.Drawing.Size(151, 456);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btLich;
    }
}
