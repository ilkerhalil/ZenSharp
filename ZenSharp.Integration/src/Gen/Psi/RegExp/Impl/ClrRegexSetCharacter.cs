//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414, 0114
// ReSharper disable RedundantNameQualifier
using System;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree;
using JetBrains.ReSharper.Psi.RegExp.ClrRegex.Gen;
namespace JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree
{
  internal partial class ClrRegexSetCharacter : JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree.ClrRegexCompositeElement, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetCharacter
  {
    internal ClrRegexSetCharacter() : base() { }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType
    {
      get { return JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree.ElementType.CLR_REGEX_SET_CHARACTER; }
    }
    public  void Accept(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.TreeNodeVisitor visitor)
    {
      visitor.VisitClrRegexSetCharacter(this);
    }
    public  void Accept<TContext>(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.TreeNodeVisitor<TContext> visitor, TContext context)
    {
      visitor.VisitClrRegexSetCharacter(this, context);
    }
    public  TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context)
    {
      return visitor.VisitClrRegexSetCharacter(this, context);
    }
    public override string ToString()
    {
      return "IClrRegexSetCharacter";
    }
  }
}
