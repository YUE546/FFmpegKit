namespace FFmpegKit
{
    partial class ConvertForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.lvFiles = new System.Windows.Forms.ListView();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.chkGPU = new System.Windows.Forms.CheckBox();
            this.grpAdvanced = new System.Windows.Forms.GroupBox();
            this.lblCodec = new System.Windows.Forms.Label();
            this.cmbCodec = new System.Windows.Forms.ComboBox();
            this.lblCodecTip = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.lblQualityTip = new System.Windows.Forms.Label();
            this.lblPreset = new System.Windows.Forms.Label();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.lblBitrate = new System.Windows.Forms.Label();
            this.txtBitrate = new System.Windows.Forms.TextBox();
            this.lblBitrateTip = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeightTip = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpAdvanced.SuspendLayout();
            this.SuspendLayout();
            //
            // lvFiles
            //
            this.lvFiles.CheckBoxes = true;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                new System.Windows.Forms.ColumnHeader() { Text = "选中", Width = 50 },
                new System.Windows.Forms.ColumnHeader() { Text = "文件名", Width = 280 },
                new System.Windows.Forms.ColumnHeader() { Text = "路径", Width = 400 }});
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.Location = new System.Drawing.Point(12, 12);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(760, 280);
            this.lvFiles.TabIndex = 0;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.AllowDrop = true;
            this.lvFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvFiles_ItemDrag);
            this.lvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.LvFiles_DragEnter);
            this.lvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvFiles_DragDrop);
            //
            // btnAddFiles
            //
            this.btnAddFiles.Location = new System.Drawing.Point(12, 300);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(120, 35);
            this.btnAddFiles.Text = "添加文件";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            //
            // btnRemove
            //
            this.btnRemove.Location = new System.Drawing.Point(140, 300);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 35);
            this.btnRemove.Text = "移除勾选";

            this.btnTop.Location = new System.Drawing.Point(248, 300);
            this.btnTop.Size = new System.Drawing.Size(80, 35);
            this.btnTop.Text = "置顶";

            this.btnUp.Location = new System.Drawing.Point(336, 300);
            this.btnUp.Size = new System.Drawing.Size(80, 35);
            this.btnUp.Text = "上移";

            this.btnDown.Location = new System.Drawing.Point(424, 300);
            this.btnDown.Size = new System.Drawing.Size(80, 35);
            this.btnDown.Text = "下移";

            this.btnBottom.Location = new System.Drawing.Point(512, 300);
            this.btnBottom.Size = new System.Drawing.Size(80, 35);
            this.btnBottom.Text = "置底";

            this.btnClear.Location = new System.Drawing.Point(600, 300);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Text = "全部清空";
            //
            // btnSelectOutput
            //
            this.btnSelectOutput.Location = new System.Drawing.Point(12, 350);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(120, 30);
            this.btnSelectOutput.Text = "选择输出文件夹";
            //
            // txtOutputFolder
            //
            this.txtOutputFolder.Location = new System.Drawing.Point(140, 350);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(630, 30);
            this.txtOutputFolder.ReadOnly = true;
            //
            // cmbFormat
            //
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.Items.AddRange(new object[] { ".mp4", ".mkv", ".avi", ".mov", ".wmv", ".flv", ".ts", ".mp3", ".m4a", ".wav", ".flac", ".aac" });
            this.cmbFormat.Location = new System.Drawing.Point(140, 390);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(120, 28);
            this.cmbFormat.SelectedIndex = 0;
            //
            // chkGPU
            //
            this.chkGPU.AutoSize = true;
            this.chkGPU.Location = new System.Drawing.Point(280, 393);
            this.chkGPU.Name = "chkGPU";
            this.chkGPU.Size = new System.Drawing.Size(120, 20);
            this.chkGPU.Text = "硬件解码加速";
            this.chkGPU.Checked = true;
            //
            // grpAdvanced
            //
            this.grpAdvanced.Controls.Add(this.lblCodec);
            this.grpAdvanced.Controls.Add(this.cmbCodec);
            this.grpAdvanced.Controls.Add(this.lblCodecTip);
            this.grpAdvanced.Controls.Add(this.lblQuality);
            this.grpAdvanced.Controls.Add(this.txtQuality);
            this.grpAdvanced.Controls.Add(this.lblQualityTip);
            this.grpAdvanced.Controls.Add(this.lblPreset);
            this.grpAdvanced.Controls.Add(this.cmbPreset);
            this.grpAdvanced.Controls.Add(this.lblBitrate);
            this.grpAdvanced.Controls.Add(this.txtBitrate);
            this.grpAdvanced.Controls.Add(this.lblBitrateTip);
            this.grpAdvanced.Controls.Add(this.lblHeight);
            this.grpAdvanced.Controls.Add(this.txtHeight);
            this.grpAdvanced.Controls.Add(this.lblHeightTip);
            this.grpAdvanced.Location = new System.Drawing.Point(12, 430);
            this.grpAdvanced.Name = "grpAdvanced";
            this.grpAdvanced.Size = new System.Drawing.Size(760, 180);
            this.grpAdvanced.Text = "高级设置（可选）";
            //
            // lblCodec
            //
            this.lblCodec.AutoSize = true;
            this.lblCodec.Location = new System.Drawing.Point(20, 25);
            this.lblCodec.Text = "视频编码：";
            //
            // cmbCodec
            //
            this.cmbCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodec.Location = new System.Drawing.Point(150, 22);
            this.cmbCodec.Name = "cmbCodec";
            this.cmbCodec.Size = new System.Drawing.Size(250, 28);
            //
            // lblCodecTip
            //
            this.lblCodecTip.AutoSize = true;
            this.lblCodecTip.ForeColor = System.Drawing.Color.Red;
            this.lblCodecTip.Location = new System.Drawing.Point(410, 25);
            this.lblCodecTip.Name = "lblCodecTip";
            this.lblCodecTip.Text = "请选择视频编码器";
            this.lblCodecTip.Visible = false;
            //
            // lblQuality
            //
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(20, 55);
            this.lblQuality.Text = "质量值：";
            //
            // txtQuality
            //
            this.txtQuality.Location = new System.Drawing.Point(150, 52);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(70, 28);
            this.txtQuality.Text = "23";
            //
            // lblQualityTip
            //
            this.lblQualityTip.AutoSize = true;
            this.lblQualityTip.ForeColor = System.Drawing.Color.Gray;
            this.lblQualityTip.Location = new System.Drawing.Point(230, 55);
            this.lblQualityTip.Text = "CRF, 0-51, 默认23, 越小质量越高";
            //
            // lblPreset
            //
            this.lblPreset.AutoSize = true;
            this.lblPreset.Location = new System.Drawing.Point(20, 85);
            this.lblPreset.Text = "编码预设：";
            //
            // cmbPreset
            //
            this.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreset.Items.AddRange(new object[] { "ultrafast", "superfast", "veryfast", "faster", "fast", "medium", "slow", "slower", "veryslow" });
            this.cmbPreset.Location = new System.Drawing.Point(150, 82);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(150, 28);
            this.cmbPreset.SelectedIndex = 5;
            //
            // lblBitrate
            //
            this.lblBitrate.AutoSize = true;
            this.lblBitrate.Location = new System.Drawing.Point(20, 115);
            this.lblBitrate.Text = "码率上限 (kbps)：";
            //
            // txtBitrate
            //
            this.txtBitrate.Location = new System.Drawing.Point(150, 112);
            this.txtBitrate.Name = "txtBitrate";
            this.txtBitrate.Size = new System.Drawing.Size(100, 28);
            //
            // lblBitrateTip
            //
            this.lblBitrateTip.AutoSize = true;
            this.lblBitrateTip.ForeColor = System.Drawing.Color.Gray;
            this.lblBitrateTip.Location = new System.Drawing.Point(260, 115);
            this.lblBitrateTip.Text = "可选最大码率上限";
            //
            // lblHeight
            //
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(20, 148);
            this.lblHeight.Text = "高度 (px)：";
            //
            // txtHeight
            //
            this.txtHeight.Location = new System.Drawing.Point(150, 145);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 28);
            //
            // lblHeightTip
            //
            this.lblHeightTip.AutoSize = true;
            this.lblHeightTip.ForeColor = System.Drawing.Color.Gray;
            this.lblHeightTip.Location = new System.Drawing.Point(260, 148);
            this.lblHeightTip.Text = "宽度自动计算为偶数（推荐 720 / 1080）";
            //
            // btnStart
            //
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(300, 630);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 50);
            this.btnStart.Text = "开始转换";
            this.btnStart.UseVisualStyleBackColor = true;
            //
            // ConvertForm
            //
            this.Icon = global::FFmpegKit.Properties.Resources.LOGO_64;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 700);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.chkGPU);
            this.Controls.Add(this.grpAdvanced);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConvertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FFmpegKit - 音视频格式转换";
            this.grpAdvanced.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelectOutput;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.CheckBox chkGPU;
        private System.Windows.Forms.GroupBox grpAdvanced;
        private System.Windows.Forms.Label lblCodec;
        private System.Windows.Forms.ComboBox cmbCodec;
        private System.Windows.Forms.Label lblCodecTip;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label lblQualityTip;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.Label lblBitrate;
        private System.Windows.Forms.TextBox txtBitrate;
        private System.Windows.Forms.Label lblBitrateTip;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeightTip;
        private System.Windows.Forms.Button btnStart;
    }
}