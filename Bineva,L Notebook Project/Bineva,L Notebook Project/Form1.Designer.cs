namespace Bineva_L_Notebook_Project
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
            label1 = new Label();
            new_note_btn = new Button();
            view_btn = new Button();
            delete_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(205, 48);
            label1.Name = "label1";
            label1.Size = new Size(373, 42);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Your Notes!";
            // 
            // new_note_btn
            // 
            new_note_btn.BackColor = Color.SeaShell;
            new_note_btn.BackgroundImageLayout = ImageLayout.None;
            new_note_btn.FlatAppearance.BorderColor = Color.SeaShell;
            new_note_btn.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            new_note_btn.Location = new Point(240, 147);
            new_note_btn.Name = "new_note_btn";
            new_note_btn.Size = new Size(297, 73);
            new_note_btn.TabIndex = 1;
            new_note_btn.Text = "Create a New Note +";
            new_note_btn.UseVisualStyleBackColor = false;
            new_note_btn.Click += new_note_btn_Click;
            // 
            // view_btn
            // 
            view_btn.BackColor = Color.SeaShell;
            view_btn.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            view_btn.ForeColor = SystemColors.ActiveCaptionText;
            view_btn.Location = new Point(240, 256);
            view_btn.Name = "view_btn";
            view_btn.Size = new Size(297, 73);
            view_btn.TabIndex = 2;
            view_btn.Text = "View Old Notes :)";
            view_btn.UseVisualStyleBackColor = false;
            view_btn.Click += view_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.SeaShell;
            delete_btn.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            delete_btn.Location = new Point(240, 352);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(297, 73);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "Delete a Note -";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e57197ade991c214aa623a72d0276c37;
            ClientSize = new Size(825, 454);
            Controls.Add(delete_btn);
            Controls.Add(view_btn);
            Controls.Add(new_note_btn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button new_note_btn;
        private Button view_btn;
        private Button delete_btn;
    }
}