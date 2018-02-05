namespace GameWar
{
    partial class Fase_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fase_1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AtaquePerson1 = new System.Windows.Forms.Button();
            this.DefesaPerson1 = new System.Windows.Forms.Button();
            this.DefesaPerson2 = new System.Windows.Forms.Button();
            this.AtaquePerson2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(291, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 238);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 238);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // AtaquePerson1
            // 
            this.AtaquePerson1.Location = new System.Drawing.Point(13, 267);
            this.AtaquePerson1.Name = "AtaquePerson1";
            this.AtaquePerson1.Size = new System.Drawing.Size(75, 23);
            this.AtaquePerson1.TabIndex = 2;
            this.AtaquePerson1.Text = "ATACAR";
            this.AtaquePerson1.UseVisualStyleBackColor = true;
            // 
            // DefesaPerson1
            // 
            this.DefesaPerson1.Location = new System.Drawing.Point(168, 266);
            this.DefesaPerson1.Name = "DefesaPerson1";
            this.DefesaPerson1.Size = new System.Drawing.Size(75, 23);
            this.DefesaPerson1.TabIndex = 3;
            this.DefesaPerson1.Text = "DEFENDER";
            this.DefesaPerson1.UseVisualStyleBackColor = true;
            // 
            // DefesaPerson2
            // 
            this.DefesaPerson2.Location = new System.Drawing.Point(446, 266);
            this.DefesaPerson2.Name = "DefesaPerson2";
            this.DefesaPerson2.Size = new System.Drawing.Size(75, 23);
            this.DefesaPerson2.TabIndex = 5;
            this.DefesaPerson2.Text = "DEFENDER";
            this.DefesaPerson2.UseVisualStyleBackColor = true;
            // 
            // AtaquePerson2
            // 
            this.AtaquePerson2.Location = new System.Drawing.Point(291, 267);
            this.AtaquePerson2.Name = "AtaquePerson2";
            this.AtaquePerson2.Size = new System.Drawing.Size(75, 23);
            this.AtaquePerson2.TabIndex = 4;
            this.AtaquePerson2.Text = "ATACAR";
            this.AtaquePerson2.UseVisualStyleBackColor = true;
            // 
            // Fase_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 326);
            this.Controls.Add(this.DefesaPerson2);
            this.Controls.Add(this.AtaquePerson2);
            this.Controls.Add(this.DefesaPerson1);
            this.Controls.Add(this.AtaquePerson1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fase_1";
            this.Text = "GAME WAR - PRIMEIRA FASE";
            this.Load += new System.EventHandler(this.Fase_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AtaquePerson1;
        private System.Windows.Forms.Button DefesaPerson1;
        private System.Windows.Forms.Button DefesaPerson2;
        private System.Windows.Forms.Button AtaquePerson2;
    }
}