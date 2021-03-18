// Decompiled with JetBrains decompiler
// Type: RealHCF_Builder.Program
// Assembly: RealHCF Builder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 848789C7-2401-4BD3-A543-CA0682BA649A
// Assembly location: C:\Users\Rasib\Desktop\RealHCF_Builder (admin access).exe

using System;
using System.Windows.Forms;

namespace RealHCF_Builder
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new frmMain());
    }
  }
}
