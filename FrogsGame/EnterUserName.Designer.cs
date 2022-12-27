namespace FrogsGame
{
    partial class EnterUserName
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonSaveUserName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-4, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите свое имя для сохранения результатов.";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserName.Location = new System.Drawing.Point(149, 152);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(236, 31);
            this.textBoxUserName.TabIndex = 1;
            // 
            // buttonSaveUserName
            // 
            this.buttonSaveUserName.Location = new System.Drawing.Point(149, 237);
            this.buttonSaveUserName.Name = "buttonSaveUserName";
            this.buttonSaveUserName.Size = new System.Drawing.Size(153, 42);
            this.buttonSaveUserName.TabIndex = 2;
            this.buttonSaveUserName.Text = "Сохранить результаты";
            this.buttonSaveUserName.UseVisualStyleBackColor = true;
            this.buttonSaveUserName.Click += new System.EventHandler(this.buttonSaveUserName_Click);
            // 
            // EnterUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 306);
            this.Controls.Add(this.buttonSaveUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label1);
            this.Name = "EnterUserName";
            this.Text = "Введите имя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonSaveUserName;
    }
}