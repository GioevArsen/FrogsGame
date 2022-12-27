namespace FrogsGame
{
    partial class FormShowResult
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
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxResult
            // 
            this.listBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 24;
            this.listBoxResult.Location = new System.Drawing.Point(0, 0);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(470, 592);
            this.listBoxResult.TabIndex = 0;
            // 
            // FormShowResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 592);
            this.Controls.Add(this.listBoxResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormShowResult";
            this.Text = "Список результатов игры";
            this.Load += new System.EventHandler(this.FormShowResult_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResult;
    }
}