namespace KARPO
{
    partial class Backup_and_Restor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save_to = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.txt_save_path = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_restor = new System.Windows.Forms.Button();
            this.txt_open_path = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_save_to);
            this.panel1.Controls.Add(this.btn_backup);
            this.panel1.Controls.Add(this.txt_save_path);
            this.panel1.Location = new System.Drawing.Point(30, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 141);
            this.panel1.TabIndex = 0;
            // 
            // btn_save_to
            // 
            this.btn_save_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_to.Location = new System.Drawing.Point(431, 40);
            this.btn_save_to.Name = "btn_save_to";
            this.btn_save_to.Size = new System.Drawing.Size(100, 30);
            this.btn_save_to.TabIndex = 1;
            this.btn_save_to.Text = "Brows";
            this.btn_save_to.UseVisualStyleBackColor = true;
            this.btn_save_to.Click += new System.EventHandler(this.btn_save_to_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Location = new System.Drawing.Point(248, 87);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(163, 35);
            this.btn_backup.TabIndex = 1;
            this.btn_backup.Text = "Start backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // txt_save_path
            // 
            this.txt_save_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_save_path.Location = new System.Drawing.Point(12, 40);
            this.txt_save_path.Name = "txt_save_path";
            this.txt_save_path.Size = new System.Drawing.Size(398, 30);
            this.txt_save_path.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_restor);
            this.panel2.Controls.Add(this.txt_open_path);
            this.panel2.Location = new System.Drawing.Point(31, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 141);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(431, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Brows";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_restor
            // 
            this.btn_restor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restor.Location = new System.Drawing.Point(262, 87);
            this.btn_restor.Name = "btn_restor";
            this.btn_restor.Size = new System.Drawing.Size(147, 35);
            this.btn_restor.TabIndex = 1;
            this.btn_restor.Text = "Start restor";
            this.btn_restor.UseVisualStyleBackColor = true;
            this.btn_restor.Click += new System.EventHandler(this.btn_restor_Click);
            // 
            // txt_open_path
            // 
            this.txt_open_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_open_path.Location = new System.Drawing.Point(12, 40);
            this.txt_open_path.Name = "txt_open_path";
            this.txt_open_path.Size = new System.Drawing.Size(398, 30);
            this.txt_open_path.TabIndex = 0;
            // 
            // open
            // 
            this.open.FileName = "open";
            // 
            // Backup_and_Restor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Backup_and_Restor";
            this.Text = "Backup_and_Restor";
            this.Load += new System.EventHandler(this.Backup_and_Restor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save_to;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.TextBox txt_save_path;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_restor;
        private System.Windows.Forms.TextBox txt_open_path;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.OpenFileDialog open;
    }
}