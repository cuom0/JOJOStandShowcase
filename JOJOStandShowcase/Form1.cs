using System.Diagnostics;

namespace JOJOStandShowcase
{
    public partial class JoJoMenu : Form
    {
        public JoJoMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/cuom0") { UseShellExecute = true });
        }
    }
}