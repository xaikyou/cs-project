using System.Data;
using System.Runtime.InteropServices;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        DataTable notes = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title", typeof(String));
            notes.Columns.Add("Note", typeof(String));
            previousNotes.DataSource = notes;
            previousNotes.Columns["Note"].Visible = false;
            previousNotes.Font = new System.Drawing.Font("Please write me a song", 20F, System.Drawing.FontStyle.Bold);
        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleBox.Clear();
            noteBox.Clear();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            int index = -1;
            if (previousNotes.CurrentRow != null)
            {
                index = previousNotes.CurrentCell.RowIndex;
            }
            if (index > -1)
            {
                titleBox.Text = notes.Rows[index].ItemArray[0].ToString();
                noteBox.Text = notes.Rows[index].ItemArray[1].ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            notes.Rows.Add(titleBox.Text, noteBox.Text);
            titleBox.Clear();
            noteBox.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = previousNotes.CurrentCell.RowIndex;
            notes.Rows[index].Delete();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = -1;
            if (previousNotes.CurrentRow != null)
            {
                index = previousNotes.CurrentCell.RowIndex;
            }
            if (index > -1)
            {
                titleBox.Text = notes.Rows[index].ItemArray[0].ToString();
                noteBox.Text = notes.Rows[index].ItemArray[1].ToString();
            }
        }

        // Make the form moveable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}