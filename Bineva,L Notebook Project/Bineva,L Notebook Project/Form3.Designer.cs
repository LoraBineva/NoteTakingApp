namespace Bineva_L_Notebook_Project
{
    partial class Form3
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
            back_btn = new Button();
            label1 = new Label();
            Title_box = new ComboBox();
            Note = new TextBox();
            timestamp = new Label();
            SuspendLayout();
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.SeaShell;
            back_btn.BackgroundImageLayout = ImageLayout.None;
            back_btn.FlatAppearance.BorderColor = Color.SeaShell;
            back_btn.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            back_btn.Location = new Point(248, 440);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(289, 65);
            back_btn.TabIndex = 7;
            back_btn.Text = "Back To Menu";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(209, 46);
            label1.Name = "label1";
            label1.Size = new Size(348, 42);
            label1.TabIndex = 5;
            label1.Text = "View Your Notes Here!";
            // 
            // Title_box
            // 
            Title_box.BackColor = Color.PeachPuff;
            Title_box.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Title_box.FormattingEnabled = true;
            Title_box.Items.AddRange(new object[] { "My first note" });
            Title_box.Location = new Point(165, 137);
            Title_box.Name = "Title_box";
            Title_box.Size = new Size(469, 34);
            Title_box.TabIndex = 9;
            Title_box.Text = "Choose your title:";
            Title_box.SelectedIndexChanged += Title_box_SelectedIndexChanged;
            // 
            // Note
            // 
            Note.BackColor = Color.PeachPuff;
            Note.BorderStyle = BorderStyle.None;
            Note.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Note.ForeColor = Color.Black;
            Note.Location = new Point(165, 188);
            Note.Multiline = true;
            Note.Name = "Note";
            Note.PlaceholderText = "Your Text:";
            Note.Size = new Size(469, 199);
            Note.TabIndex = 10;
            // 
            // timestamp
            // 
            timestamp.AutoSize = true;
            timestamp.BackColor = Color.Transparent;
            timestamp.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            timestamp.ForeColor = Color.Black;
            timestamp.Location = new Point(165, 390);
            timestamp.Name = "timestamp";
            timestamp.Size = new Size(0, 26);
            timestamp.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e57197ade991c214aa623a72d0276c37;
            ClientSize = new Size(820, 517);
            Controls.Add(timestamp);
            Controls.Add(Note);
            Controls.Add(Title_box);
            Controls.Add(back_btn);
            Controls.Add(label1);
            Name = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button back_btn;
        private Label label1;
        private ComboBox Title_box;
        private TextBox Note;
        private Label timestamp;
    }
}