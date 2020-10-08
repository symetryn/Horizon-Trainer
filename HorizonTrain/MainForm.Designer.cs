namespace HorizonTrain
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GameStatusLbl = new System.Windows.Forms.Label();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ShardTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Status:";
            // 
            // GameStatusLbl
            // 
            this.GameStatusLbl.AutoSize = true;
            this.GameStatusLbl.Location = new System.Drawing.Point(108, 9);
            this.GameStatusLbl.Name = "GameStatusLbl";
            this.GameStatusLbl.Size = new System.Drawing.Size(31, 17);
            this.GameStatusLbl.TabIndex = 1;
            this.GameStatusLbl.Text = "N/A";
            this.GameStatusLbl.UseMnemonic = false;
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(215, 98);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 31);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ShardTxt
            // 
            this.ShardTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShardTxt.Location = new System.Drawing.Point(15, 63);
            this.ShardTxt.Name = "ShardTxt";
            this.ShardTxt.Size = new System.Drawing.Size(275, 24);
            this.ShardTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Shard Amount";
            this.label2.Click += new System.EventHandler(this.MainForm_Shown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShardTxt);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.GameStatusLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Horizon Shard Setter";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GameStatusLbl;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox ShardTxt;
        private System.Windows.Forms.Label label2;
    }
}

