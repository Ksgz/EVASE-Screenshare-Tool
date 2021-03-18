// Decompiled with JetBrains decompiler
// Type: RealHCF_Builder.SSToolInfo
// Assembly: RealHCF Builder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 848789C7-2401-4BD3-A543-CA0682BA649A
// Assembly location: C:\Users\Rasib\Desktop\RealHCF_Builder (admin access).exe

using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Text.RegularExpressions;

namespace RealHCF_Builder
{
  internal class SSToolInfo
  {
    public string Name { get; set; }

    public string Copyright { get; set; }

    public string LogoPath { get; set; }

    public string IconPath { get; set; }

    public string ApplicationsPath { get; set; }

    public int Expiry { get; set; }

    public string SavePath { get; set; }

    public void Compile(string path)
    {
      Image image = (Image) null;
      if (!string.IsNullOrEmpty(this.LogoPath))
        image = Image.FromFile(this.LogoPath);
      Icon icon = (Icon) null;
      if (!string.IsNullOrEmpty(this.IconPath))
        icon = Icon.ExtractAssociatedIcon(this.IconPath);
      byte[] numArray = File.ReadAllBytes(this.ApplicationsPath);
      byte[] discordTitle = RealHCF_Builder.Properties.Resources.DiscordTitle;
      string str = Regex.Replace(Regex.Replace(Regex.Replace(RealHCF_Builder.Properties.Resources.frmMain, "maxTime = 50", string.Format("maxTime = {0}", (object) (this.Expiry * 60))), "{name}", this.Name), "{copyright}", this.Copyright);
      ResourceWriter resourceWriter = new ResourceWriter("Resources.resources");
      if (image != null)
        resourceWriter.AddResource("logo.png", (object) image);
      resourceWriter.AddResource("Applications.zip", numArray);
      resourceWriter.AddResource("DiscordTitle.otf", discordTitle);
      resourceWriter.Generate();
      resourceWriter.Close();
      CompilerParameters options = new CompilerParameters()
      {
        OutputAssembly = path,
        GenerateExecutable = true,
        CompilerOptions = "/target:winexe" + (icon != null ? " /win32icon:\"" + this.IconPath + "\"" : "")
      };
      options.EmbeddedResources.Add("Resources.resources");
      options.ReferencedAssemblies.AddRange(new string[5]
      {
        "System.dll",
        "System.Drawing.dll",
        "System.IO.Compression.dll",
        "System.Windows.Forms.dll",
        "System.Linq.dll"
      });
      CompilerResults compilerResults = CodeDomProvider.CreateProvider("CSharp").CompileAssemblyFromSource(options, str, RealHCF_Builder.Properties.Resources.frmMain_Designer, RealHCF_Builder.Properties.Resources.Generator, RealHCF_Builder.Properties.Resources.Program, RealHCF_Builder.Properties.Resources.Extractor, RealHCF_Builder.Properties.Resources.DiscordTheme, RealHCF_Builder.Properties.Resources.AppLimit);
      if ((uint) compilerResults.Errors.Count > 0U)
        throw new Exception(string.Join("\n", new object[1]
        {
          (object) compilerResults.Errors
        }));
    }
  }
}
