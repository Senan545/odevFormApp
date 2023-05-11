namespace odevvv
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
            goodButton = new Button();
            cheapButton = new Button();
            fastButton = new Button();
            SuspendLayout();
            // 
            // goodButton
            // 
            goodButton.BackColor = Color.Yellow;
            goodButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goodButton.Location = new Point(93, 66);
            goodButton.Name = "goodButton";
            goodButton.RightToLeft = RightToLeft.No;
            goodButton.Size = new Size(100, 40);
            goodButton.TabIndex = 0;
            goodButton.Text = "Good";
            goodButton.UseVisualStyleBackColor = false;
            goodButton.Click += goodButton_Click;
            // 
            // cheapButton
            // 
            cheapButton.BackColor = Color.Yellow;
            cheapButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cheapButton.Location = new Point(93, 125);
            cheapButton.Name = "cheapButton";
            cheapButton.Size = new Size(100, 40);
            cheapButton.TabIndex = 1;
            cheapButton.Text = "Cheap";
            cheapButton.UseVisualStyleBackColor = false;
            cheapButton.Click += cheapButton_Click;
            // 
            // fastButton
            // 
            fastButton.BackColor = Color.Yellow;
            fastButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fastButton.Location = new Point(93, 182);
            fastButton.Name = "fastButton";
            fastButton.Size = new Size(100, 40);
            fastButton.TabIndex = 2;
            fastButton.Text = "Fast";
            fastButton.UseVisualStyleBackColor = false;
            fastButton.Click += fastButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(fastButton);
            Controls.Add(cheapButton);
            Controls.Add(goodButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button goodButton;
        private Button cheapButton;
        private Button fastButton;
    }
}