namespace _2048
{
    partial class Form1
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
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.gbBest = new System.Windows.Forms.GroupBox();
            this.lblBest = new System.Windows.Forms.Label();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.tileElement1 = new _2048.Controls.TileElement();
            this.tileElement2 = new _2048.Controls.TileElement();
            this.tileElement3 = new _2048.Controls.TileElement();
            this.tileElement4 = new _2048.Controls.TileElement();
            this.tileElement5 = new _2048.Controls.TileElement();
            this.tileElement6 = new _2048.Controls.TileElement();
            this.tileElement7 = new _2048.Controls.TileElement();
            this.tileElement8 = new _2048.Controls.TileElement();
            this.tileElement9 = new _2048.Controls.TileElement();
            this.tileElement10 = new _2048.Controls.TileElement();
            this.tileElement11 = new _2048.Controls.TileElement();
            this.tileElement12 = new _2048.Controls.TileElement();
            this.tileElement13 = new _2048.Controls.TileElement();
            this.tileElement14 = new _2048.Controls.TileElement();
            this.tileElement15 = new _2048.Controls.TileElement();
            this.tileElement16 = new _2048.Controls.TileElement();
            this.flpContainer.SuspendLayout();
            this.gbBest.SuspendLayout();
            this.gbScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpContainer
            // 
            this.flpContainer.Controls.Add(this.tileElement1);
            this.flpContainer.Controls.Add(this.tileElement2);
            this.flpContainer.Controls.Add(this.tileElement3);
            this.flpContainer.Controls.Add(this.tileElement4);
            this.flpContainer.Controls.Add(this.tileElement5);
            this.flpContainer.Controls.Add(this.tileElement6);
            this.flpContainer.Controls.Add(this.tileElement7);
            this.flpContainer.Controls.Add(this.tileElement8);
            this.flpContainer.Controls.Add(this.tileElement9);
            this.flpContainer.Controls.Add(this.tileElement10);
            this.flpContainer.Controls.Add(this.tileElement11);
            this.flpContainer.Controls.Add(this.tileElement12);
            this.flpContainer.Controls.Add(this.tileElement13);
            this.flpContainer.Controls.Add(this.tileElement14);
            this.flpContainer.Controls.Add(this.tileElement15);
            this.flpContainer.Controls.Add(this.tileElement16);
            this.flpContainer.Location = new System.Drawing.Point(12, 78);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(438, 425);
            this.flpContainer.TabIndex = 0;
            // 
            // gbBest
            // 
            this.gbBest.Controls.Add(this.lblBest);
            this.gbBest.Location = new System.Drawing.Point(316, 13);
            this.gbBest.Name = "gbBest";
            this.gbBest.Size = new System.Drawing.Size(134, 59);
            this.gbBest.TabIndex = 1;
            this.gbBest.TabStop = false;
            this.gbBest.Text = "Best";
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBest.Location = new System.Drawing.Point(33, 23);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(0, 29);
            this.lblBest.TabIndex = 0;
            // 
            // gbScore
            // 
            this.gbScore.Controls.Add(this.lblScore);
            this.gbScore.Location = new System.Drawing.Point(176, 16);
            this.gbScore.Name = "gbScore";
            this.gbScore.Size = new System.Drawing.Size(134, 59);
            this.gbScore.TabIndex = 1;
            this.gbScore.TabStop = false;
            this.gbScore.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore.Location = new System.Drawing.Point(29, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 29);
            this.lblScore.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Enabled = false;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewGame.Location = new System.Drawing.Point(23, 20);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(141, 45);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New game!";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // tileElement1
            // 
            this.tileElement1.Enabled = false;
            this.tileElement1.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement1.Location = new System.Drawing.Point(3, 3);
            this.tileElement1.Name = "tileElement1";
            this.tileElement1.Size = new System.Drawing.Size(100, 100);
            this.tileElement1.TabIndex = 0;
            this.tileElement1.Text = "0";
            this.tileElement1.UseVisualStyleBackColor = true;
            // 
            // tileElement2
            // 
            this.tileElement2.Enabled = false;
            this.tileElement2.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement2.Location = new System.Drawing.Point(109, 3);
            this.tileElement2.Name = "tileElement2";
            this.tileElement2.Size = new System.Drawing.Size(100, 100);
            this.tileElement2.TabIndex = 1;
            this.tileElement2.Text = "0";
            this.tileElement2.UseVisualStyleBackColor = true;
            // 
            // tileElement3
            // 
            this.tileElement3.Enabled = false;
            this.tileElement3.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement3.Location = new System.Drawing.Point(215, 3);
            this.tileElement3.Name = "tileElement3";
            this.tileElement3.Size = new System.Drawing.Size(100, 100);
            this.tileElement3.TabIndex = 2;
            this.tileElement3.Text = "0";
            this.tileElement3.UseVisualStyleBackColor = true;
            // 
            // tileElement4
            // 
            this.tileElement4.Enabled = false;
            this.tileElement4.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement4.Location = new System.Drawing.Point(321, 3);
            this.tileElement4.Name = "tileElement4";
            this.tileElement4.Size = new System.Drawing.Size(100, 100);
            this.tileElement4.TabIndex = 3;
            this.tileElement4.Text = "0";
            this.tileElement4.UseVisualStyleBackColor = true;
            // 
            // tileElement5
            // 
            this.tileElement5.Enabled = false;
            this.tileElement5.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement5.Location = new System.Drawing.Point(3, 109);
            this.tileElement5.Name = "tileElement5";
            this.tileElement5.Size = new System.Drawing.Size(100, 100);
            this.tileElement5.TabIndex = 4;
            this.tileElement5.Text = "0";
            this.tileElement5.UseVisualStyleBackColor = true;
            // 
            // tileElement6
            // 
            this.tileElement6.Enabled = false;
            this.tileElement6.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement6.Location = new System.Drawing.Point(109, 109);
            this.tileElement6.Name = "tileElement6";
            this.tileElement6.Size = new System.Drawing.Size(100, 100);
            this.tileElement6.TabIndex = 5;
            this.tileElement6.Text = "0";
            this.tileElement6.UseVisualStyleBackColor = true;
            // 
            // tileElement7
            // 
            this.tileElement7.Enabled = false;
            this.tileElement7.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement7.Location = new System.Drawing.Point(215, 109);
            this.tileElement7.Name = "tileElement7";
            this.tileElement7.Size = new System.Drawing.Size(100, 100);
            this.tileElement7.TabIndex = 6;
            this.tileElement7.Text = "0";
            this.tileElement7.UseVisualStyleBackColor = true;
            // 
            // tileElement8
            // 
            this.tileElement8.Enabled = false;
            this.tileElement8.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement8.Location = new System.Drawing.Point(321, 109);
            this.tileElement8.Name = "tileElement8";
            this.tileElement8.Size = new System.Drawing.Size(100, 100);
            this.tileElement8.TabIndex = 7;
            this.tileElement8.Text = "0";
            this.tileElement8.UseVisualStyleBackColor = true;
            // 
            // tileElement9
            // 
            this.tileElement9.Enabled = false;
            this.tileElement9.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement9.Location = new System.Drawing.Point(3, 215);
            this.tileElement9.Name = "tileElement9";
            this.tileElement9.Size = new System.Drawing.Size(100, 100);
            this.tileElement9.TabIndex = 8;
            this.tileElement9.Text = "0";
            this.tileElement9.UseVisualStyleBackColor = true;
            // 
            // tileElement10
            // 
            this.tileElement10.Enabled = false;
            this.tileElement10.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement10.Location = new System.Drawing.Point(109, 215);
            this.tileElement10.Name = "tileElement10";
            this.tileElement10.Size = new System.Drawing.Size(100, 100);
            this.tileElement10.TabIndex = 9;
            this.tileElement10.Text = "0";
            this.tileElement10.UseVisualStyleBackColor = true;
            // 
            // tileElement11
            // 
            this.tileElement11.Enabled = false;
            this.tileElement11.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement11.Location = new System.Drawing.Point(215, 215);
            this.tileElement11.Name = "tileElement11";
            this.tileElement11.Size = new System.Drawing.Size(100, 100);
            this.tileElement11.TabIndex = 10;
            this.tileElement11.Text = "0";
            this.tileElement11.UseVisualStyleBackColor = true;
            // 
            // tileElement12
            // 
            this.tileElement12.Enabled = false;
            this.tileElement12.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement12.Location = new System.Drawing.Point(321, 215);
            this.tileElement12.Name = "tileElement12";
            this.tileElement12.Size = new System.Drawing.Size(100, 100);
            this.tileElement12.TabIndex = 11;
            this.tileElement12.Text = "0";
            this.tileElement12.UseVisualStyleBackColor = true;
            // 
            // tileElement13
            // 
            this.tileElement13.Enabled = false;
            this.tileElement13.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement13.Location = new System.Drawing.Point(3, 321);
            this.tileElement13.Name = "tileElement13";
            this.tileElement13.Size = new System.Drawing.Size(100, 100);
            this.tileElement13.TabIndex = 12;
            this.tileElement13.Text = "0";
            this.tileElement13.UseVisualStyleBackColor = true;
            // 
            // tileElement14
            // 
            this.tileElement14.Enabled = false;
            this.tileElement14.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement14.Location = new System.Drawing.Point(109, 321);
            this.tileElement14.Name = "tileElement14";
            this.tileElement14.Size = new System.Drawing.Size(100, 100);
            this.tileElement14.TabIndex = 13;
            this.tileElement14.Text = "0";
            this.tileElement14.UseVisualStyleBackColor = true;
            // 
            // tileElement15
            // 
            this.tileElement15.Enabled = false;
            this.tileElement15.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement15.Location = new System.Drawing.Point(215, 321);
            this.tileElement15.Name = "tileElement15";
            this.tileElement15.Size = new System.Drawing.Size(100, 100);
            this.tileElement15.TabIndex = 14;
            this.tileElement15.Text = "0";
            this.tileElement15.UseVisualStyleBackColor = true;
            // 
            // tileElement16
            // 
            this.tileElement16.Enabled = false;
            this.tileElement16.Font = new System.Drawing.Font("Tahoma", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileElement16.Location = new System.Drawing.Point(321, 321);
            this.tileElement16.Name = "tileElement16";
            this.tileElement16.Size = new System.Drawing.Size(100, 100);
            this.tileElement16.TabIndex = 15;
            this.tileElement16.Text = "0";
            this.tileElement16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 515);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.gbScore);
            this.Controls.Add(this.gbBest);
            this.Controls.Add(this.flpContainer);
            this.Name = "Form1";
            this.Text = "2048 Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.flpContainer.ResumeLayout(false);
            this.gbBest.ResumeLayout(false);
            this.gbBest.PerformLayout();
            this.gbScore.ResumeLayout(false);
            this.gbScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private Controls.TileElement tileElement1;
        private Controls.TileElement tileElement2;
        private Controls.TileElement tileElement3;
        private Controls.TileElement tileElement4;
        private Controls.TileElement tileElement5;
        private Controls.TileElement tileElement6;
        private Controls.TileElement tileElement7;
        private Controls.TileElement tileElement8;
        private Controls.TileElement tileElement9;
        private Controls.TileElement tileElement10;
        private Controls.TileElement tileElement11;
        private Controls.TileElement tileElement12;
        private Controls.TileElement tileElement13;
        private Controls.TileElement tileElement14;
        private Controls.TileElement tileElement15;
        private Controls.TileElement tileElement16;
        private System.Windows.Forms.GroupBox gbBest;
        private System.Windows.Forms.GroupBox gbScore;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNewGame;
    }
}

