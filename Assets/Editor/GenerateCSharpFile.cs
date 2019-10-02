using System;
using System.IO;
using System.Text;

/// <summary>
/// 创建类文件头注释的工具类
/// </summary>
public class GenerateCSharpFile : UnityEditor.AssetModificationProcessor
{
#if UNITY_EDITOR
    private static void OnWillCreateAsset(string path)
    {
        path = path.Replace(".meta", "");
        if (path.EndsWith(".cs"))
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("/****************************************************");
            string[] strs = path.Split('/');
            string scriptName = strs[strs.Length - 1];
            sb.AppendLine(string.Format("文件：{0}", scriptName));
            sb.AppendLine(string.Format("作者：{0}", Environment.UserName));
            sb.AppendLine(string.Format("日期：{0}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")));
            sb.AppendLine("功能：Noting");
            sb.AppendLine("*****************************************************/");
            string str = File.ReadAllText(path);
            sb.AppendLine(str);

            File.WriteAllText(path, sb.ToString());
        }
    }
#endif
}
