// FileDetector.cs
// 检测输入文件的类型
// ArcCreate or Arcade or Unknown
using System;
using System.Collections.Generic;
using System.Text;

namespace ARConverter.Utils;

public enum FileType
{
    ArcCreate,
    Arcade,
    Unknown
}
public class FileDetector
{
    static public FileType Detect(string? filename)
    {
        if (!File.Exists(filename))
            throw new Exception("没有找到" + filename + "喵");

        return Path.GetExtension(filename).ToUpper() switch
        {
            null => FileType.Unknown,
            _ when filename.EndsWith(".ZIP") => FileType.Arcade,
            _ when filename.EndsWith(".ARCPKG") => FileType.ArcCreate,
            _ => FileType.Unknown
        };
    }
}