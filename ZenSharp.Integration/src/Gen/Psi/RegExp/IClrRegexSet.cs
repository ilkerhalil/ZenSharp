//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414, 0114
// ReSharper disable RedundantNameQualifier
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
namespace JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree
{
  public partial interface IClrRegexSet : JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifierOwner
  {
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBody Body { get; }
  
    JetBrains.ReSharper.Psi.Tree.ITokenNode LBracket { get; }
  
    JetBrains.ReSharper.Psi.Tree.ITokenNode NegativeMark { get; }
  
    JetBrains.ReSharper.Psi.Tree.ITokenNode RBracket { get; }
  
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBody SetBody(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBody param);
  
  }
}
