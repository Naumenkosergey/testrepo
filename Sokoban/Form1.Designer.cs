namespace Sokoban
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
            this.player = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.звукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.Label();
            this.box2 = new System.Windows.Forms.Label();
            this.box3 = new System.Windows.Forms.Label();
            this.base1 = new System.Windows.Forms.Label();
            this.base2 = new System.Windows.Forms.Label();
            this.base3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.player.Location = new System.Drawing.Point(100, 80);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.звукToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // звукToolStripMenuItem
            // 
            this.звукToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитьToolStripMenuItem,
            this.выключитьToolStripMenuItem});
            this.звукToolStripMenuItem.Name = "звукToolStripMenuItem";
            this.звукToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.звукToolStripMenuItem.Text = "Звук";
            // 
            // включитьToolStripMenuItem
            // 
            this.включитьToolStripMenuItem.Name = "включитьToolStripMenuItem";
            this.включитьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.включитьToolStripMenuItem.Text = "Включить";
            this.включитьToolStripMenuItem.Click += new System.EventHandler(this.ВключитьToolStripMenuItem_Click);
            // 
            // выключитьToolStripMenuItem
            // 
            this.выключитьToolStripMenuItem.Name = "выключитьToolStripMenuItem";
            this.выключитьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.выключитьToolStripMenuItem.Text = "Выключить";
            this.выключитьToolStripMenuItem.Click += new System.EventHandler(this.ВыключитьToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Звук есть";
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.Green;
            this.box1.Location = new System.Drawing.Point(500, 180);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(50, 50);
            this.box1.TabIndex = 3;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.Yellow;
            this.box2.Location = new System.Drawing.Point(400, 80);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(50, 50);
            this.box2.TabIndex = 4;
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.Color.Red;
            this.box3.Location = new System.Drawing.Point(300, 280);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(50, 50);
            this.box3.TabIndex = 5;
            // 
            // base1
            // 
            this.base1.BackColor = System.Drawing.Color.Black;
            this.base1.Location = new System.Drawing.Point(465, 445);
            this.base1.Name = "base1";
            this.base1.Size = new System.Drawing.Size(20, 20);
            this.base1.TabIndex = 6;
            // 
            // base2
            // 
            this.base2.BackColor = System.Drawing.Color.Black;
            this.base2.Location = new System.Drawing.Point(515, 445);
            this.base2.Name = "base2";
            this.base2.Size = new System.Drawing.Size(20, 20);
            this.base2.TabIndex = 7;
            // 
            // base3
            // 
            this.base3.BackColor = System.Drawing.Color.Black;
            this.base3.Location = new System.Drawing.Point(565, 445);
            this.base3.Name = "base3";
            this.base3.Size = new System.Drawing.Size(20, 20);
            this.base3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.base3);
            this.Controls.Add(this.base2);
            this.Controls.Add(this.base1);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem звукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label box1;
        private System.Windows.Forms.Label box2;
        private System.Windows.Forms.Label box3;
        private System.Windows.Forms.Label base1;
        private System.Windows.Forms.Label base2;
        private System.Windows.Forms.Label base3;
    }
}

