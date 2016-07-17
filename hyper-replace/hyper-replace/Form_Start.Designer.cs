namespace hyper_replace
{
    partial class main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Select_folder = new System.Windows.Forms.Button();
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.textBox_replace = new System.Windows.Forms.TextBox();
            this.label_select_folder = new System.Windows.Forms.Label();
            this.button_Start_replace = new System.Windows.Forms.Button();
            this.label_Text_to_find = new System.Windows.Forms.Label();
            this.label_Text_to_replace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Select_folder
            // 
            this.btn_Select_folder.Location = new System.Drawing.Point(32, 106);
            this.btn_Select_folder.Name = "btn_Select_folder";
            this.btn_Select_folder.Size = new System.Drawing.Size(220, 23);
            this.btn_Select_folder.TabIndex = 0;
            this.btn_Select_folder.Text = "Select_folder";
            this.btn_Select_folder.UseVisualStyleBackColor = true;
            this.btn_Select_folder.Click += new System.EventHandler(this.btn_Select_folder_Click);
            // 
            // textBox_folder
            // 
            this.textBox_folder.Location = new System.Drawing.Point(32, 31);
            this.textBox_folder.Multiline = true;
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.Size = new System.Drawing.Size(220, 69);
            this.textBox_folder.TabIndex = 1;
            // 
            // textBox_find
            // 
            this.textBox_find.Location = new System.Drawing.Point(32, 170);
            this.textBox_find.Multiline = true;
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(220, 92);
            this.textBox_find.TabIndex = 2;
            // 
            // textBox_replace
            // 
            this.textBox_replace.Location = new System.Drawing.Point(32, 291);
            this.textBox_replace.Multiline = true;
            this.textBox_replace.Name = "textBox_replace";
            this.textBox_replace.Size = new System.Drawing.Size(220, 92);
            this.textBox_replace.TabIndex = 3;
            // 
            // label_select_folder
            // 
            this.label_select_folder.AutoSize = true;
            this.label_select_folder.Font = new System.Drawing.Font("Meiryo UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_select_folder.Location = new System.Drawing.Point(28, 4);
            this.label_select_folder.Name = "label_select_folder";
            this.label_select_folder.Size = new System.Drawing.Size(165, 24);
            this.label_select_folder.TabIndex = 4;
            this.label_select_folder.Text = "//Select_folder";
            // 
            // button_Start_replace
            // 
            this.button_Start_replace.Location = new System.Drawing.Point(32, 389);
            this.button_Start_replace.Name = "button_Start_replace";
            this.button_Start_replace.Size = new System.Drawing.Size(220, 40);
            this.button_Start_replace.TabIndex = 9;
            this.button_Start_replace.Text = "Start_replace";
            this.button_Start_replace.UseVisualStyleBackColor = true;
            this.button_Start_replace.Click += new System.EventHandler(this.button_Start_replace_Click);
            // 
            // label_Text_to_find
            // 
            this.label_Text_to_find.AutoSize = true;
            this.label_Text_to_find.Font = new System.Drawing.Font("Meiryo UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_Text_to_find.Location = new System.Drawing.Point(28, 143);
            this.label_Text_to_find.Name = "label_Text_to_find";
            this.label_Text_to_find.Size = new System.Drawing.Size(160, 24);
            this.label_Text_to_find.TabIndex = 10;
            this.label_Text_to_find.Text = "//Text_to_find";
            // 
            // label_Text_to_replace
            // 
            this.label_Text_to_replace.AutoSize = true;
            this.label_Text_to_replace.Font = new System.Drawing.Font("Meiryo UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_Text_to_replace.Location = new System.Drawing.Point(28, 265);
            this.label_Text_to_replace.Name = "label_Text_to_replace";
            this.label_Text_to_replace.Size = new System.Drawing.Size(195, 24);
            this.label_Text_to_replace.TabIndex = 11;
            this.label_Text_to_replace.Text = "//Text_to_replace";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 441);
            this.Controls.Add(this.label_Text_to_replace);
            this.Controls.Add(this.label_Text_to_find);
            this.Controls.Add(this.button_Start_replace);
            this.Controls.Add(this.label_select_folder);
            this.Controls.Add(this.textBox_replace);
            this.Controls.Add(this.textBox_find);
            this.Controls.Add(this.textBox_folder);
            this.Controls.Add(this.btn_Select_folder);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Select_folder;
        private System.Windows.Forms.TextBox textBox_folder;
        private System.Windows.Forms.TextBox textBox_find;
        private System.Windows.Forms.TextBox textBox_replace;
        private System.Windows.Forms.Label label_select_folder;
        private System.Windows.Forms.Button button_Start_replace;
        private System.Windows.Forms.Label label_Text_to_find;
        private System.Windows.Forms.Label label_Text_to_replace;
    }
}

