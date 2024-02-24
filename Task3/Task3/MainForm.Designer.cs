namespace Task3
{
    partial class MainForm
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
            label1 = new Label();
            OpenNewFormButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(48, 124);
            label1.Name = "label1";
            label1.Size = new Size(704, 159);
            label1.TabIndex = 0;
            label1.Text = "Main Form";
            // 
            // OpenNewFormButton
            // 
            OpenNewFormButton.Dock = DockStyle.Bottom;
            OpenNewFormButton.FlatStyle = FlatStyle.Flat;
            OpenNewFormButton.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OpenNewFormButton.ForeColor = SystemColors.ControlLightLight;
            OpenNewFormButton.Location = new Point(0, 390);
            OpenNewFormButton.Name = "OpenNewFormButton";
            OpenNewFormButton.Size = new Size(800, 60);
            OpenNewFormButton.TabIndex = 1;
            OpenNewFormButton.Text = "OPEN NEW FORM";
            OpenNewFormButton.UseVisualStyleBackColor = true;
            OpenNewFormButton.Click += OpenNewFormButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(OpenNewFormButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Home Work Task 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OpenNewFormButton;
    }
}
