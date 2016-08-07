namespace fontutil
{
    partial class Form1
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
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.button_folder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tga = new System.Windows.Forms.TextBox();
            this.button_file = new System.Windows.Forms.Button();
            this.listBox_font = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_pro = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(12, 30);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(534, 19);
            this.textBox_path.TabIndex = 0;
            // 
            // button_folder
            // 
            this.button_folder.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_folder.Location = new System.Drawing.Point(555, 28);
            this.button_folder.Name = "button_folder";
            this.button_folder.Size = new System.Drawing.Size(75, 23);
            this.button_folder.TabIndex = 1;
            this.button_folder.Text = "選択";
            this.button_folder.UseVisualStyleBackColor = true;
            this.button_folder.Click += new System.EventHandler(this.button_folder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "座標ファイルのあるフォルダ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "フォント画像(TGA):";
            // 
            // textBox_tga
            // 
            this.textBox_tga.Location = new System.Drawing.Point(12, 73);
            this.textBox_tga.Name = "textBox_tga";
            this.textBox_tga.ReadOnly = true;
            this.textBox_tga.Size = new System.Drawing.Size(534, 19);
            this.textBox_tga.TabIndex = 5;
            // 
            // button_file
            // 
            this.button_file.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_file.Location = new System.Drawing.Point(555, 71);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(75, 23);
            this.button_file.TabIndex = 6;
            this.button_file.Text = "選択";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // listBox_font
            // 
            this.listBox_font.FormattingEnabled = true;
            this.listBox_font.ItemHeight = 12;
            this.listBox_font.Location = new System.Drawing.Point(12, 98);
            this.listBox_font.Name = "listBox_font";
            this.listBox_font.Size = new System.Drawing.Size(534, 184);
            this.listBox_font.TabIndex = 3;
            this.listBox_font.SelectedIndexChanged += new System.EventHandler(this.listBox_font_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(555, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "変換";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_pro
            // 
            this.textBox_pro.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_pro.Location = new System.Drawing.Point(12, 295);
            this.textBox_pro.Multiline = true;
            this.textBox_pro.Name = "textBox_pro";
            this.textBox_pro.ReadOnly = true;
            this.textBox_pro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_pro.Size = new System.Drawing.Size(533, 75);
            this.textBox_pro.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(555, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "codepoint";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 382);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_pro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_file);
            this.Controls.Add(this.textBox_tga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_font);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_folder);
            this.Controls.Add(this.textBox_path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button button_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tga;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.ListBox listBox_font;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_pro;
        private System.Windows.Forms.Button button2;
    }
}

