namespace LeytnerSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.questText = new System.Windows.Forms.Label();
            this.ansText = new System.Windows.Forms.Label();
            this.ansBox = new System.Windows.Forms.TextBox();
            this.ansBut = new System.Windows.Forms.Button();
            this.nextBut = new System.Windows.Forms.Button();
            this.comText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questText
            // 
            this.questText.AutoSize = true;
            this.questText.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questText.Location = new System.Drawing.Point(12, 24);
            this.questText.Name = "questText";
            this.questText.Size = new System.Drawing.Size(0, 29);
            this.questText.TabIndex = 0;
            // 
            // ansText
            // 
            this.ansText.AutoSize = true;
            this.ansText.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansText.Location = new System.Drawing.Point(11, 67);
            this.ansText.Name = "ansText";
            this.ansText.Size = new System.Drawing.Size(73, 29);
            this.ansText.TabIndex = 1;
            this.ansText.Text = "Ответ";
            // 
            // ansBox
            // 
            this.ansBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansBox.Location = new System.Drawing.Point(11, 127);
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(273, 26);
            this.ansBox.TabIndex = 2;
            // 
            // ansBut
            // 
            this.ansBut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansBut.Location = new System.Drawing.Point(290, 127);
            this.ansBut.Name = "ansBut";
            this.ansBut.Size = new System.Drawing.Size(80, 26);
            this.ansBut.TabIndex = 3;
            this.ansBut.Text = "Ответить";
            this.ansBut.UseVisualStyleBackColor = true;
            this.ansBut.Click += new System.EventHandler(this.ansBut_Click);
            // 
            // nextBut
            // 
            this.nextBut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBut.Location = new System.Drawing.Point(152, 173);
            this.nextBut.Name = "nextBut";
            this.nextBut.Size = new System.Drawing.Size(75, 33);
            this.nextBut.TabIndex = 4;
            this.nextBut.Text = "Дальше";
            this.nextBut.UseVisualStyleBackColor = true;
            this.nextBut.Click += new System.EventHandler(this.nextBut_Click);
            // 
            // comText
            // 
            this.comText.AutoSize = true;
            this.comText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comText.Location = new System.Drawing.Point(13, 108);
            this.comText.Name = "comText";
            this.comText.Size = new System.Drawing.Size(102, 16);
            this.comText.TabIndex = 5;
            this.comText.Text = "Отличная работа!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 218);
            this.Controls.Add(this.comText);
            this.Controls.Add(this.nextBut);
            this.Controls.Add(this.ansBut);
            this.Controls.Add(this.ansBox);
            this.Controls.Add(this.ansText);
            this.Controls.Add(this.questText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LeytnerSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saveState);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questText;
        private System.Windows.Forms.Label ansText;
        private System.Windows.Forms.TextBox ansBox;
        private System.Windows.Forms.Button ansBut;
        private System.Windows.Forms.Button nextBut;
        private System.Windows.Forms.Label comText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}

