// Decompiled with JetBrains decompiler
// Type: RealHCF_Builder.Properties.Resources
// Assembly: RealHCF Builder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 848789C7-2401-4BD3-A543-CA0682BA649A
// Assembly location: C:\Users\Rasib\Desktop\RealHCF_Builder (admin access).exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RealHCF_Builder.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (RealHCF_Builder.Properties.Resources.resourceMan == null)
          RealHCF_Builder.Properties.Resources.resourceMan = new ResourceManager("RealHCF_Builder.Properties.Resources", typeof (RealHCF_Builder.Properties.Resources).Assembly);
        return RealHCF_Builder.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => RealHCF_Builder.Properties.Resources.resourceCulture;
      set => RealHCF_Builder.Properties.Resources.resourceCulture = value;
    }

    internal static string AppLimit => RealHCF_Builder.Properties.Resources.ResourceManager.GetString(nameof (AppLimit), RealHCF_Builder.Properties.Resources.resourceCulture);

    internal static string DiscordTheme => RealHCF_Builder.Properties.Resources.ResourceManager.GetString(nameof (DiscordTheme), RealHCF_Builder.Properties.Resources.resourceCulture);

    internal static byte[] DiscordTitle => (byte[]) RealHCF_Builder.Properties.Resources.ResourceManager.GetObject(nameof (DiscordTitle), RealHCF_Builder.Properties.Resources.resourceCulture);

    internal static string Extractor => RealHCF_Builder.Properties.Resources.ResourceManager.GetString(nameof (Extractor), RealHCF_Builder.Properties.Resources.resourceCulture);

    internal static string frmMain => RealHCF_Builder.Properties.Resources.ResourceManager.GetString(nameof (frmMain), RealHCF_Builder.Properties.Resources.resourceCulture);

    internal static string frmMain_Designer => RealHCF_Builder.Properties.Resources.ResourceManager.GetString(nameof (frmMain_Designer), RealHCF_Builder.Properties.Resources.resourceCulture);

    internal static string Generator => RealHCF_Builder.Properties.Resources.ResourceManager.GetString(nameof (Generator), RealHCF_Builder.Properties.Resources.resourceCulture);

    internal static string Program => RealHCF_Builder.Properties.Resources.ResourceManager.GetString(nameof (Program), RealHCF_Builder.Properties.Resources.resourceCulture);
  }
}
