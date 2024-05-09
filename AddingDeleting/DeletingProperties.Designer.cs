namespace RengaExtensions.AddingDeleting
{
    partial class DeletingProperties
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProperties = new System.Windows.Forms.Button();
            this.CancelAdding = new System.Windows.Forms.Button();
            this.ViewFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(49, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(594, 50);
            this.label3.TabIndex = 12;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(695, 60);
            this.label2.TabIndex = 11;
            this.label2.Text = "Примечание:\r\nУдалятся свойства, присутствующие в текущем проекте";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddProperties
            // 
            this.AddProperties.BackColor = System.Drawing.Color.Transparent;
            this.AddProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProperties.Location = new System.Drawing.Point(512, 624);
            this.AddProperties.Name = "AddProperties";
            this.AddProperties.Size = new System.Drawing.Size(165, 49);
            this.AddProperties.TabIndex = 10;
            this.AddProperties.Text = "Удалить";
            this.AddProperties.UseVisualStyleBackColor = false;
            this.AddProperties.Click += new System.EventHandler(this.DeletePropertiesClick);
            // 
            // CancelAdding
            // 
            this.CancelAdding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAdding.Location = new System.Drawing.Point(709, 624);
            this.CancelAdding.Name = "CancelAdding";
            this.CancelAdding.Size = new System.Drawing.Size(138, 49);
            this.CancelAdding.TabIndex = 9;
            this.CancelAdding.Text = "Отмена";
            this.CancelAdding.UseVisualStyleBackColor = true;
            this.CancelAdding.Click += new System.EventHandler(this.CancelAddingClick);
            // 
            // ViewFiles
            // 
            this.ViewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewFiles.Location = new System.Drawing.Point(679, 139);
            this.ViewFiles.Name = "ViewFiles";
            this.ViewFiles.Size = new System.Drawing.Size(166, 52);
            this.ViewFiles.TabIndex = 8;
            this.ViewFiles.Text = "Обзор";
            this.ViewFiles.UseVisualStyleBackColor = true;
            this.ViewFiles.Click += new System.EventHandler(this.ViewFilesClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Загрузите файл";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeletingProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 703);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProperties);
            this.Controls.Add(this.CancelAdding);
            this.Controls.Add(this.ViewFiles);
            this.Controls.Add(this.label1);
            this.Name = "DeletingProperties";
            this.Text = "Удаление свойств";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProperties;
        private System.Windows.Forms.Button CancelAdding;
        private System.Windows.Forms.Button ViewFiles;
        private System.Windows.Forms.Label label1;
    }
}