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
  public partial interface IClrQuantifiableRegularExpression : JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexTreeNode
  {
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifierOwner Owner { get; }
  
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier Quantifier { get; }
  
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifierOwner SetOwner(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifierOwner param);
  
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier SetQuantifier(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier param);
  
  }
}
