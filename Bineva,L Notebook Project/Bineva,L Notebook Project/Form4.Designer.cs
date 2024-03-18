namespace Bineva_L_Notebook_Project
{
    partial class Form4
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
            delete_btn = new Button();
            label1 = new Label();
            timestamp = new Label();
            Title_box = new ComboBox();
            label2 = new Label();
            Note = new TextBox();
            SuspendLayout();
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.SeaShell;
            back_btn.BackgroundImageLayout = ImageLayout.None;
            back_btn.FlatAppearance.BorderColor = Color.SeaShell;
            back_btn.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            back_btn.Location = new Point(450, 447);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(289, 65);
            back_btn.TabIndex = 13;
            back_btn.Text = "Back To Menu";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.SeaShell;
            delete_btn.BackgroundImageLayout = ImageLayout.None;
            delete_btn.FlatAppearance.BorderColor = Color.SeaShell;
            delete_btn.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            delete_btn.Location = new Point(121, 447);
            delete_btn.Name = "delete_btn";
            delete_btn.RightToLeft = RightToLeft.No;
            delete_btn.Size = new Size(289, 65);
            delete_btn.TabIndex = 11;
            delete_btn.Text = "Delete Note";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(241, 44);
            label1.Name = "label1";
            label1.Size = new Size(297, 42);
            label1.TabIndex = 9;
            label1.Text = "Delete Your Note :(";
            // 
            // timestamp
            // 
            timestamp.AutoSize = true;
            timestamp.BackColor = Color.Transparent;
            timestamp.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            timestamp.ForeColor = Color.Black;
            timestamp.Location = new Point(177, 400);
            timestamp.Name = "timestamp";
            timestamp.Size = new Size(0, 26);
            timestamp.TabIndex = 18;
            // 
            // Title_box
            // 
            Title_box.BackColor = Color.PeachPuff;
            Title_box.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Title_box.FormattingEnabled = true;
            Title_box.Location = new Point(177, 124);
            Title_box.Name = "Title_box";
            Title_box.Size = new Size(469, 34);
            Title_box.TabIndex = 16;
            Title_box.Text = "Choose your title:";
            Title_box.SelectedIndexChanged += Title_box_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaShell;
            label2.Location = new Point(221, 25);
            label2.Name = "label2";
            label2.Size = new Size(0, 42);
            label2.TabIndex = 14;
            // 
            // Note
            // 
            Note.BackColor = Color.PeachPuff;
            Note.BorderStyle = BorderStyle.None;
            Note.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Note.ForeColor = Color.Black;
            Note.Location = new Point(177, 186);
            Note.Multiline = true;
            Note.Name = "Note";
            Note.PlaceholderText = "Your Text:";
            Note.Size = new Size(469, 199);
            Note.TabIndex = 19;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e57197ade991c214aa623a72d0276c37;
            ClientSize = new Size(823, 542);
            Controls.Add(Note);
            Controls.Add(timestamp);
            Controls.Add(Title_box);
            Controls.Add(label2);
            Controls.Add(back_btn);
            Controls.Add(delete_btn);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_btn;
        private Button delete_btn;
        private Label label1;
        private Label timestamp;
        private ComboBox Title_box;
        private Label label2;
        private TextBox Note;
    }
}