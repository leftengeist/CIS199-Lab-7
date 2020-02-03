namespace Lab7
{
    partial class Lab7
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.wordsPerMinuteLbl = new System.Windows.Forms.Label();
            this.outGradeLbl = new System.Windows.Forms.Label();
            this.inWordsPerMinuteTxt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(110, 188);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(118, 44);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // wordsPerMinuteLbl
            // 
            this.wordsPerMinuteLbl.AutoSize = true;
            this.wordsPerMinuteLbl.Location = new System.Drawing.Point(44, 138);
            this.wordsPerMinuteLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wordsPerMinuteLbl.Name = "wordsPerMinuteLbl";
            this.wordsPerMinuteLbl.Size = new System.Drawing.Size(324, 25);
            this.wordsPerMinuteLbl.TabIndex = 1;
            this.wordsPerMinuteLbl.Text = "Enter Words Typed (per minute):";
            // 
            // outGradeLbl
            // 
            this.outGradeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outGradeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outGradeLbl.Location = new System.Drawing.Point(160, 290);
            this.outGradeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.outGradeLbl.Name = "outGradeLbl";
            this.outGradeLbl.Size = new System.Drawing.Size(158, 152);
            this.outGradeLbl.TabIndex = 2;
            this.outGradeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inWordsPerMinuteTxt
            // 
            this.inWordsPerMinuteTxt.Location = new System.Drawing.Point(372, 137);
            this.inWordsPerMinuteTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inWordsPerMinuteTxt.Name = "inWordsPerMinuteTxt";
            this.inWordsPerMinuteTxt.Size = new System.Drawing.Size(100, 31);
            this.inWordsPerMinuteTxt.TabIndex = 3;
            // 
            // clearBtn
            // 
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearBtn.Location = new System.Drawing.Point(304, 188);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(118, 44);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Lab7
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearBtn;
            this.ClientSize = new System.Drawing.Size(528, 563);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.inWordsPerMinuteTxt);
            this.Controls.Add(this.outGradeLbl);
            this.Controls.Add(this.wordsPerMinuteLbl);
            this.Controls.Add(this.calculateBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lab7";
            this.Text = "Lab7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label wordsPerMinuteLbl;
        private System.Windows.Forms.Label outGradeLbl;
        private System.Windows.Forms.TextBox inWordsPerMinuteTxt;
        private System.Windows.Forms.Button clearBtn;
    }
}

