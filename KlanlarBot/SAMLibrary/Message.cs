using System.Windows.Forms;

namespace SAMLibrary
{
    public static class Message
    {
        public static DialogResult Error(string str)
        {
            return MessageBox.Show(str, "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
        public static DialogResult Info(string str)
        {
            return MessageBox.Show(str, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult Warning(string str)
        {
            return MessageBox.Show(str, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
