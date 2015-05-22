namespace Flags
{
    partial class GamePanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePanel));
            this.flagImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optionOne = new System.Windows.Forms.RadioButton();
            this.optionTwo = new System.Windows.Forms.RadioButton();
            this.optionThree = new System.Windows.Forms.RadioButton();
            this.optionFour = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flagImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flagImage
            // 
            this.flagImage.Image = ((System.Drawing.Image)(resources.GetObject("flagImage.Image")));
            this.flagImage.Location = new System.Drawing.Point(3, 84);
            this.flagImage.Name = "flagImage";
            this.flagImage.Size = new System.Drawing.Size(132, 85);
            this.flagImage.TabIndex = 0;
            this.flagImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which country is this?";
            // 
            // optionOne
            // 
            this.optionOne.AutoSize = true;
            this.optionOne.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionOne.Location = new System.Drawing.Point(52, 60);
            this.optionOne.Name = "optionOne";
            this.optionOne.Size = new System.Drawing.Size(14, 13);
            this.optionOne.TabIndex = 0;
            this.optionOne.UseVisualStyleBackColor = true;
            this.optionOne.CheckedChanged += new System.EventHandler(this.optionOne_CheckedChanged);
            // 
            // optionTwo
            // 
            this.optionTwo.AutoSize = true;
            this.optionTwo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTwo.Location = new System.Drawing.Point(52, 94);
            this.optionTwo.Name = "optionTwo";
            this.optionTwo.Size = new System.Drawing.Size(14, 13);
            this.optionTwo.TabIndex = 0;
            this.optionTwo.UseVisualStyleBackColor = true;
            this.optionTwo.CheckedChanged += new System.EventHandler(this.optionTwo_CheckedChanged);
            // 
            // optionThree
            // 
            this.optionThree.AutoSize = true;
            this.optionThree.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionThree.Location = new System.Drawing.Point(52, 128);
            this.optionThree.Name = "optionThree";
            this.optionThree.Size = new System.Drawing.Size(14, 13);
            this.optionThree.TabIndex = 0;
            this.optionThree.UseVisualStyleBackColor = true;
            this.optionThree.CheckedChanged += new System.EventHandler(this.optionThree_CheckedChanged);
            // 
            // optionFour
            // 
            this.optionFour.AutoSize = true;
            this.optionFour.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionFour.Location = new System.Drawing.Point(52, 165);
            this.optionFour.Name = "optionFour";
            this.optionFour.Size = new System.Drawing.Size(14, 13);
            this.optionFour.TabIndex = 0;
            this.optionFour.UseVisualStyleBackColor = true;
            this.optionFour.CheckedChanged += new System.EventHandler(this.optionFour_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flagImage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 255);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Available time: 30 seconds";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.optionFour);
            this.panel2.Controls.Add(this.optionOne);
            this.panel2.Controls.Add(this.optionThree);
            this.panel2.Controls.Add(this.optionTwo);
            this.panel2.Location = new System.Drawing.Point(240, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 228);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(215, 284);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(71, 29);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "00:30";
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flags.Properties.Resources.world_map;
            this.ClientSize = new System.Drawing.Size(528, 336);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.panel1);
            this.Name = "GamePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePanel";
            this.Load += new System.EventHandler(this.GamePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flagImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flagImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optionOne;
        private System.Windows.Forms.RadioButton optionTwo;
        private System.Windows.Forms.RadioButton optionThree;
        private System.Windows.Forms.RadioButton optionFour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}