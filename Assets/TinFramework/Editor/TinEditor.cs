/****************************************************
文件：TinEditor.cs
作者：ZED
日期：2019/11/11 21:23:09
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class TinEditor : Editor
{
    /* 测试外部图片替换
    private static string resPath = "D:/I-GAMES/Art/UI资源/切图/优化版/_通用UI资源/Badgebg.png";

    private static string savePath = Application.dataPath + "/Res/";

    [MenuItem("游戏开发工具/检查空文件夹。")]
    public static void Generate()
    {
        FileStream fileStream = new FileStream(resPath, FileMode.Open, FileAccess.Read);
        fileStream.Seek(0, SeekOrigin.Begin);
        byte[] bytes = new byte[fileStream.Length];
        fileStream.Read(bytes, 0, (int)fileStream.Length);
        fileStream.Close();
        fileStream.Dispose();
        fileStream = null;

        string innerPath = "Assets/Res/" + "Badgebg.png";
        string tempSavePath = savePath + "Badgebg.png";

        //删除已有的图片
        Sprite sp = AssetDatabase.LoadAssetAtPath<Sprite>(innerPath);
        Vector4 border = sp.border;
        if (null != sp)
            AssetDatabase.DeleteAsset(innerPath);
        //替换图片
        File.WriteAllBytes(tempSavePath, bytes);
        //改变Sprite的属性
        TextureImporter importer = TextureImporter.GetAtPath(innerPath) as TextureImporter;
        importer.textureType = TextureImporterType.Sprite;
        importer.maxTextureSize = 2048;
        importer.textureCompression = TextureImporterCompression.CompressedLQ;
        importer.isReadable = false;
        importer.filterMode = FilterMode.Bilinear;
        importer.npotScale = TextureImporterNPOTScale.None;
        importer.wrapMode = TextureWrapMode.Clamp;
        importer.mipmapEnabled = false;
        importer.spriteImportMode = SpriteImportMode.Single;
        importer.spriteBorder = border;

        UnityEngine.Object asset = AssetDatabase.LoadAssetAtPath(importer.assetPath, typeof(Texture));
        if (asset)
        {
            EditorUtility.SetDirty(asset);
            AssetDatabase.ImportAsset(innerPath);
        }
        else
            importer.textureType = TextureImporterType.Default;
        importer.SaveAndReimport();
    }
    */
}

