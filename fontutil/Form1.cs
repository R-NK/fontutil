using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fontutil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using(StreamReader sr = new StreamReader("fonttable.txt"))
            {
                List<string> tablelist = new List<string>();
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    tablelist.Add(line);
                }
                tablelist.Sort();
                listBox_font.Items.AddRange(tablelist.ToArray());
            }
        }

        private void button_folder_Click(object sender, EventArgs e)
        {
            var Dialog = new CommonOpenFileDialog();
            // フォルダーを開く設定に
            Dialog.IsFolderPicker = true;
            // 読み取り専用フォルダ/コントロールパネルは開かない
            Dialog.EnsureReadOnly = false;
            Dialog.AllowNonFileSystemItems = false;
            // パス指定
            Dialog.DefaultDirectory = Application.StartupPath;
            // 開く
            var Result = Dialog.ShowDialog();
            // もし開かれているなら
            if (Result == CommonFileDialogResult.Ok)
            {
                // ここでいろいろする（開いたフォルダはDialog.FileNameで取得）
                textBox_path.Text = Dialog.FileName;
            }
        }

        private void button_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TGAファイル (*.tga)|*.tga";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_tga.Text = ofd.FileName;
            }
        }

        private void listBox_font_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_tga.Text != "")
            {
                Assembly m = Assembly.LoadFrom("tga2tex.dll");
                dynamic instance1 = Activator.CreateInstance(m.GetType("tga2tex.Class1"));
                byte[] tex = instance1.tgaconv(textBox_tga.Text);
                string baseName = Path.GetFileNameWithoutExtension(textBox_tga.Text);
                //カンマで分割
                string[] fontarry = listBox_font.SelectedItem.ToString().Split(',');
                FileStream fs = new FileStream(fontarry[0], FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(tex);
                bw.Close();
                fs.Close();
                textBox_pro.AppendText(baseName + ".tga" + " → " + fontarry[0] + "\r\n");
            }else
            {
                textBox_pro.AppendText("TGAファイルを選択してください\r\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox_font.SelectedItems.Count != 0 & textBox_tga.Text != "")
            {
                //カンマで分割
                string[] fontarry = listBox_font.SelectedItem.ToString().Split(',');
                string ori_path = textBox_path.Text + "\\" + fontarry[1];
                Assembly m = Assembly.LoadFrom("codepoint.dll");
                dynamic instance1 = Activator.CreateInstance(m.GetType("codepoint.Class1"));
                //拡張子をfntに
                string file = PathUtils.GetPathWithoutExtension(textBox_tga.Text);
                file = file.Substring(0, file.Length - 2);
                string filename = file + ".fnt";
                byte[] codepoint = instance1.codelink(filename, ori_path);
                FileStream fs = new FileStream(fontarry[1], FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(codepoint);
                bw.Close();
                fs.Close();
                textBox_pro.AppendText(Path.GetFileName(filename) + " → " + fontarry[1] + "\r\n");
            }else
            {
                textBox_pro.AppendText("座標ファイルを選択してください\r\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public static class PathUtils
    {
        /// <summary>
        /// 指定されたパス文字列から拡張子を削除して返します
        /// </summary>
        public static string GetPathWithoutExtension(string path)
        {
            var extension = Path.GetExtension(path);
            if (string.IsNullOrEmpty(extension))
            {
                return path;
            }
            return path.Replace(extension, string.Empty);
        }
    }
}
