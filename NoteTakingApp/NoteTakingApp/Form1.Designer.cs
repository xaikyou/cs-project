namespace NoteTakingApp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            titleBox = new TextBox();
            noteBox = new TextBox();
            title = new Label();
            note = new Label();
            previousNotes = new DataGridView();
            newNoteButton = new Button();
            loadButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            label1 = new Label();
            minimize = new Label();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.BackColor = Color.White;
            titleBox.BorderStyle = BorderStyle.FixedSingle;
            titleBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleBox.Location = new Point(413, 60);
            titleBox.MaxLength = 50;
            titleBox.Multiline = true;
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(825, 38);
            titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            noteBox.AcceptsTab = true;
            noteBox.BackColor = Color.White;
            noteBox.BorderStyle = BorderStyle.FixedSingle;
            noteBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            noteBox.Location = new Point(413, 143);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.ScrollBars = ScrollBars.Vertical;
            noteBox.Size = new Size(825, 595);
            noteBox.TabIndex = 1;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Please write me a song", 30F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(413, 15);
            title.Name = "title";
            title.Size = new Size(79, 42);
            title.TabIndex = 2;
            title.Text = "Title:";
            // 
            // note
            // 
            note.AutoSize = true;
            note.BackColor = Color.Transparent;
            note.Font = new Font("Please write me a song", 30F, FontStyle.Bold, GraphicsUnit.Point);
            note.ForeColor = Color.White;
            note.Location = new Point(413, 101);
            note.Name = "note";
            note.Size = new Size(87, 42);
            note.TabIndex = 3;
            note.Text = "Note:";
            // 
            // previousNotes
            // 
            previousNotes.AllowUserToAddRows = false;
            previousNotes.AllowUserToDeleteRows = false;
            previousNotes.AllowUserToResizeColumns = false;
            previousNotes.AllowUserToResizeRows = false;
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.White;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            previousNotes.DefaultCellStyle = dataGridViewCellStyle1;
            previousNotes.Location = new Point(12, 12);
            previousNotes.MultiSelect = false;
            previousNotes.Name = "previousNotes";
            previousNotes.ReadOnly = true;
            previousNotes.RowHeadersVisible = false;
            previousNotes.RowTemplate.Height = 35;
            previousNotes.Size = new Size(384, 572);
            previousNotes.TabIndex = 1;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // newNoteButton
            // 
            newNoteButton.Font = new Font("Please write me a song", 30F, FontStyle.Bold, GraphicsUnit.Point);
            newNoteButton.Location = new Point(12, 605);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(175, 55);
            newNoteButton.TabIndex = 5;
            newNoteButton.Text = "New Note";
            newNoteButton.UseVisualStyleBackColor = true;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // loadButton
            // 
            loadButton.Font = new Font("Please write me a song", 30F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Location = new Point(221, 605);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(175, 55);
            loadButton.TabIndex = 6;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Please write me a song", 30F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(12, 682);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(175, 55);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Please write me a song", 30F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(221, 682);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(175, 55);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 0, 0);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Please write me a song", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1203, 9);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(35, 35);
            label1.TabIndex = 9;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // minimize
            // 
            minimize.BackColor = Color.Silver;
            minimize.Cursor = Cursors.Hand;
            minimize.Font = new Font("Please write me a song", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            minimize.ForeColor = Color.Black;
            minimize.Location = new Point(1159, 9);
            minimize.Margin = new Padding(0);
            minimize.Name = "minimize";
            minimize.RightToLeft = RightToLeft.No;
            minimize.Size = new Size(35, 35);
            minimize.TabIndex = 9;
            minimize.TextAlign = ContentAlignment.MiddleRight;
            minimize.Click += minimize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1250, 750);
            Controls.Add(noteBox);
            Controls.Add(minimize);
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(loadButton);
            Controls.Add(newNoteButton);
            Controls.Add(previousNotes);
            Controls.Add(note);
            Controls.Add(title);
            Controls.Add(titleBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label title;
        private Label note;
        private DataGridView previousNotes;
        private Button newNoteButton;
        private Button loadButton;
        private Button saveButton;
        private Button deleteButton;
        private Label label1;
        private Label minimize;
    }
}