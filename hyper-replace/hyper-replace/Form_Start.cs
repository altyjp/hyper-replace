using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        //リプレースを実行処理を呼び出す
        private void button_Start_replace_Click(object sender, EventArgs e)
        {
            var folder = textBox_folder.Text;
            if (System.IO.Directory.Exists(@folder))
            {
                //バックグランド処理の設定
                bgw_replace.WorkerReportsProgress = true;
                bgw_replace.ProgressChanged += Bgw_replace_ProgressChanged;
                bgw_replace.RunWorkerAsync();
            }else
            {
                MessageBox.Show("ERROR:invaild folder.");
            }

        }

        //進捗率を表示する。
        private void Bgw_replace_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        //リプレース処理の本体
        private void bgw_replace_DoWork(object sender, DoWorkEventArgs e)
        {
            var folder = textBox_folder.Text;
            var logic = new Main_logic();
            //ファイルの一覧の取得
            List<string> files = logic.getReplaceFile(folder);
            int cnt = 0;
            foreach(String f in files)
            {
                //リプレース開始
                logic.findAndreplaceTexts(f, textBox_find.Lines, textBox_replace.Lines);
                cnt++;
                bgw_replace.ReportProgress((100 * cnt) / files.Count);
            }
        }

    }
}
