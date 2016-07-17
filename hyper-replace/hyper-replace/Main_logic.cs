using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyper_replace
{
    class Main_logic
    {

        /**
         * ファイルの一覧を取得するメソッド
         */
        public List<String> getReplaceFile(String folderpath)
        {
            IEnumerable<String> files =
                System.IO.Directory.EnumerateFiles(
                    folderpath, "*.txt", System.IO.SearchOption.AllDirectories);

            List<string> fileName = new List<string>();

            foreach (String f in files)
            {
                fileName.Add(f);
            }

            return fileName;
        }

        /**
         * 一件ファイルをリプレース！
         */
        public int findAndreplaceTexts(String filefullPathName,String[] find,String[] replace)
        {

            try
            {
                List<string> outputs = new List<string>();      //出力行

                //テキストファイルを開く
                System.IO.FileStream fs = new System.IO.FileStream(
                    filefullPathName, System.IO.FileMode.Open,
                    System.IO.FileAccess.Read);
                byte[] bs = new byte[fs.Length];
                //byte配列に読み込む
                fs.Read(bs, 0, bs.Length);
                fs.Close();

                //文字コードを取得する
                System.Text.Encoding enc = Encodedetector.GetCode(bs);

                if(enc == null)
                {
                    throw new IOException("Encode Fail!!");
                }
                //ファイル読み込み開始
                using (StreamReader sr =  new StreamReader(filefullPathName, enc))
                {
                    Boolean find_flag = false; //1stRow発見フラグ
                    string line;    //一行
                    
                    List<string> find_lines = new List<string>();   //発見された行

                    while ((line = sr.ReadLine()) != null)
                    {
                        //とりあえず1行入れる。
                        outputs.Add(line);

                        //パターン1,発見フラグが立っていない場合
                        if(line.IndexOf(find[0]) != -1 && !find_flag)
                        {
                            find_lines.Add(line);
                            find_flag = true;
                        }
                        //パターン2,１行目以降の行について
                        else if (find_flag)
                        {
                            find_lines.Add(line);
                        }

                        //検索行数と発見された行が一致したとき
                        if(find_lines.Count == find.Length && 
                            isLinesMatch(find_lines,find))
                        {

                            outputs = replaceLines(outputs, find, replace);

                            //初期化
                            find_flag = false;

                        }

                    }
                }

                for (int i = 0; i < outputs.Count; i++)
                {
                    Console.WriteLine(outputs[i]);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return 0;
        }



        /**
         * 検索行がすべてマッチしているか確認する
         */
        private Boolean isLinesMatch(List<string> find_lines, String[] find)
        {
            Boolean complate_match = false; //完全マッチフラグ

            complate_match = true;
            //全ての行に対して検索をかける
            for (int j = 0; j < find_lines.Count; j++)
            {
                //一致しない行があったとき
                if (find_lines[j].IndexOf(find[j]) == -1)
                {
                    //完全マッチ失敗
                    complate_match = false;
                    Console.Write("HUMAN IS DEAD,MISS MATCH");
                    break;
                }
            }
            return complate_match;
        }

        /**
         * 置き換える
         */
        private List<String> replaceLines(List<string> outputs,String[] find,String[] replace)
        {
           for (int j = outputs.Count - find.Length; j < outputs.Count; j++)
            {
                    int k = 0; //置換行
                    //置換行が存在しているか
                    if (k + 1 <= replace.Length)
                    {
                        outputs[j] = outputs[j].Replace(find[k], replace[k]);
                    }
                    k++;
             }

           //検索行よりも置換行が長い場合
           if(find.Length < replace.Length)
            {
                for(int j= replace.Length - find.Length; j< replace.Length; j++)
                {
                    outputs.Add(replace[j]);
                }
            }
            return outputs;
        }
    }
}
