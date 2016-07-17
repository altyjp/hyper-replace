using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hyper_replace
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        //フォルダ選択ボタンのクリック
        private void btn_Select_folder_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();

            dialog.IsFolderPicker = true;

            //読み取り専用フォルダは開かない
            dialog.EnsureReadOnly = false;
            dialog.AllowNonFileSystemItems = false;

            //初期値をマイドキュメントに設定
            dialog.DefaultDirectory = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Personal);

            var _res = dialog.ShowDialog();

            if(_res == CommonFileDialogResult.Ok)
            {
                textBox_folder.Text = dialog.FileName;
            }

        }

        //リプレースを実行
        private void button_Start_replace_Click(object sender, EventArgs e)
        {
            var folder = textBox_folder.Text;
            var logic = new Main_logic();
            if (System.IO.Directory.Exists(@folder))
            {
                List<string> files = logic.getReplaceFile(folder);
                logic.findAndreplaceTexts(files[0],textBox_find.Lines,textBox_replace.Lines);

            }else
            {
                MessageBox.Show("ERROR:invaild folder.");
            }

        }
    }
}
