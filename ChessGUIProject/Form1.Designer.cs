
namespace ChessGUIProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChessProject = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.repeatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChessProject
            // 
            this.ChessProject.AutoSize = true;
            this.ChessProject.Location = new System.Drawing.Point(383, 529);
            this.ChessProject.Name = "ChessProject";
            this.ChessProject.Size = new System.Drawing.Size(130, 15);
            this.ChessProject.TabIndex = 0;
            this.ChessProject.Text = "Created By Guzu Daniel";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 1;
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.upButton.Location = new System.Drawing.Point(537, 44);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(96, 50);
            this.upButton.TabIndex = 2;
            this.upButton.Text = "UP";
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.downButton.Location = new System.Drawing.Point(537, 212);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(96, 50);
            this.downButton.TabIndex = 3;
            this.downButton.Text = "DOWN";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.leftButton.Location = new System.Drawing.Point(537, 156);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(96, 50);
            this.leftButton.TabIndex = 4;
            this.leftButton.Text = "LEFT";
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rightButton.Location = new System.Drawing.Point(537, 100);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(96, 50);
            this.rightButton.TabIndex = 5;
            this.rightButton.Text = "RIGHT";
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.Location = new System.Drawing.Point(537, 324);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 50);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // repeatButton
            // 
            this.repeatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.repeatButton.Location = new System.Drawing.Point(537, 268);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(96, 50);
            this.repeatButton.TabIndex = 7;
            this.repeatButton.Text = "REPEAT";
            this.repeatButton.UseVisualStyleBackColor = false;
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 565);
            this.Controls.Add(this.repeatButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChessProject);
            this.Name = "Form1";
            this.Text = "ChessProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChessProject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button repeatButton;
    }
}

