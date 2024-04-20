namespace PluginsForRenga
{
    partial class AddingProperties
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ViewFiles = new System.Windows.Forms.Button();
            this.CancelAdding = new System.Windows.Forms.Button();
            this.AddProperties = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загрузите файл";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 142);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 52);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ViewFiles
            // 
            this.ViewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewFiles.Location = new System.Drawing.Point(675, 142);
            this.ViewFiles.Name = "ViewFiles";
            this.ViewFiles.Size = new System.Drawing.Size(167, 52);
            this.ViewFiles.TabIndex = 2;
            this.ViewFiles.Text = "Обзор";
            this.ViewFiles.UseVisualStyleBackColor = true;
            this.ViewFiles.Click += new System.EventHandler(this.ViewFilesClick);
            // 
            // CancelAdding
            // 
            this.CancelAdding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAdding.Location = new System.Drawing.Point(704, 628);
            this.CancelAdding.Name = "CancelAdding";
            this.CancelAdding.Size = new System.Drawing.Size(138, 50);
            this.CancelAdding.TabIndex = 3;
            this.CancelAdding.Text = "Отмена";
            this.CancelAdding.UseVisualStyleBackColor = true;
            this.CancelAdding.Click += new System.EventHandler(this.CancelAddingClick);
            // 
            // AddProperties
            // 
            this.AddProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProperties.Location = new System.Drawing.Point(509, 628);
            this.AddProperties.Name = "AddProperties";
            this.AddProperties.Size = new System.Drawing.Size(164, 50);
            this.AddProperties.TabIndex = 4;
            this.AddProperties.Text = "Добавить";
            this.AddProperties.UseVisualStyleBackColor = true;
            this.AddProperties.Click += new System.EventHandler(this.AddPropertiesClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "Примечание:\r\nДобавятся свойства, отсутствующие в текущем проекте";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(312, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteClick);
            // 
            // AddingProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProperties);
            this.Controls.Add(this.CancelAdding);
            this.Controls.Add(this.ViewFiles);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddingProperties";
            this.Text = "AddingProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ViewFiles;
        private System.Windows.Forms.Button CancelAdding;
        private System.Windows.Forms.Button AddProperties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}