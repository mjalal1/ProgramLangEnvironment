
namespace ProgramLangEnvironment
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
            this.commandLine = new System.Windows.Forms.RichTextBox();
            this.programWindow = new System.Windows.Forms.RichTextBox();
            this.outputWindow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.outputWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // commandLine
            // 
            this.commandLine.BackColor = System.Drawing.Color.Moccasin;
            this.commandLine.Location = new System.Drawing.Point(26, 290);
            this.commandLine.Name = "commandLine";
            this.commandLine.Size = new System.Drawing.Size(339, 22);
            this.commandLine.TabIndex = 0;
            this.commandLine.Text = "";
            this.commandLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandLine_KeyPress);
            // 
            // programWindow
            // 
            this.programWindow.BackColor = System.Drawing.Color.Moccasin;
            this.programWindow.Location = new System.Drawing.Point(26, 26);
            this.programWindow.Name = "programWindow";
            this.programWindow.Size = new System.Drawing.Size(339, 231);
            this.programWindow.TabIndex = 1;
            this.programWindow.Text = "";
            // 
            // outputWindow
            // 
            this.outputWindow.BackColor = System.Drawing.Color.PeachPuff;
            this.outputWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputWindow.Location = new System.Drawing.Point(479, 27);
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.Size = new System.Drawing.Size(302, 229);
            this.outputWindow.TabIndex = 2;
            this.outputWindow.TabStop = false;
            this.outputWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.outputWindow_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.programWindow);
            this.Controls.Add(this.commandLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.outputWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox commandLine;
        private System.Windows.Forms.RichTextBox programWindow;
        private System.Windows.Forms.PictureBox outputWindow;
    }
}

