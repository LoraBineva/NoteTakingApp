namespace Bineva_L_Notebook_Project
{
    partial class Form2
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
            label1 = new Label();
            Text = new TextBox();
            new_note_btn = new Button();
            Title = new TextBox();
            back_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(201, 48);
            label1.Name = "label1";
            label1.Size = new Size(363, 42);
            label1.TabIndex = 1;
            label1.Text = "Type in Your New Note!";
            // 
            // Text
            // 
            Text.BackColor = Color.PeachPuff;
            Text.BorderStyle = BorderStyle.None;
            Text.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Text.ForeColor = Color.Black;
            Text.Location = new Point(162, 212);
            Text.Multiline = true;
            Text.Name = "Text";
            Text.PlaceholderText = "Your Text:";
            Text.Size = new Size(469, 199);
            Text.TabIndex = 2;
            // 
            // new_note_btn
            // 
            new_note_btn.BackColor = Color.SeaShell;
            new_note_btn.BackgroundImageLayout = ImageLayout.None;
            new_note_btn.FlatAppearance.BorderColor = Color.SeaShell;
            new_note_btn.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            new_note_btn.Location = new Point(108, 430);
            new_note_btn.Name = "new_note_btn";
            new_note_btn.Size = new Size(289, 65);
            new_note_btn.TabIndex = 3;
            new_note_btn.Text = "Send Note";
            new_note_btn.UseVisualStyleBackColor = false;
            new_note_btn.Click += new_note_btn_Click;
            // 
            // Title
            // 
            Title.BackColor = Color.PeachPuff;
            Title.BorderStyle = BorderStyle.None;
            Title.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.Black;
            Title.Location = new Point(162, 152);
            Title.Multiline = true;
            Title.Name = "Title";
            Title.PlaceholderText = "Your Title:";
            Title.Size = new Size(469, 36);
            Title.TabIndex = 4;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.SeaShell;
            back_btn.BackgroundImageLayout = ImageLayout.None;
            back_btn.FlatAppearance.BorderColor = Color.SeaShell;
            back_btn.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            back_btn.Location = new Point(447, 430);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(289, 65);
            back_btn.TabIndex = 8;
            back_btn.Text = "Back To Menu";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e57197ade991c214aa623a72d0276c37;
            ClientSize = new Size(820, 516);
            Controls.Add(back_btn);
            Controls.Add(Title);
            Controls.Add(new_note_btn);
            Controls.Add(Text);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Text;
        private Button new_note_btn;
        private TextBox Title;
        private Button back_btn;
    }
}