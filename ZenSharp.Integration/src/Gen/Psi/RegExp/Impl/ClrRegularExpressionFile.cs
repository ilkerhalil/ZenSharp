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
  internal partial class ClrRegularExpressionFile : ClrRegexFileBase, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpressionFile
  {
    public const short REGEXP_EXPRESSION = ChildRole.REGEXP_EXPRESSION;
    internal ClrRegularExpressionFile() : base() { }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType
    {
      get { return JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree.ElementType.CLR_REGULAR_EXPRESSION_FILE; }
    }
    public  void Accept(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.TreeNodeVisitor visitor)
    {
      visitor.VisitClrRegularExpressionFile(this);
    }
    public  void Accept<TContext>(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.TreeNodeVisitor<TContext> visitor, TContext context)
    {
      visitor.VisitClrRegularExpressionFile(this, context);
    }
    public  TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context)
    {
      return visitor.VisitClrRegularExpressionFile(this, context);
    }
    public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child)
    {
      switch (child.NodeType.Index)
      {
        case JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree.ElementType.CLR_REGULAR_EXPRESSION_NODE_TYPE_INDEX:
        return REGEXP_EXPRESSION;
      }
      return 0;
    }
    public virtual JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression RegularExpression
    {
      get { return (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression) FindChildByRole(REGEXP_EXPRESSION); }
    }
    public virtual JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression SetRegularExpression(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression param)
    {
      using (JetBrains.ReSharper.Resources.Shell.WriteLockCookie.Create(this.IsPhysical()))
      {
        JetBrains.ReSharper.Psi.Tree.ITreeNode current = null, next = GetNextFilteredChild(current);
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression result = null;
        next = GetNextFilteredChild(current);
        if (next != null && next.NodeType == JetBrains.ReSharper.Psi.RegExp.ClrRegex.Parsing.ClrRegexTokenTypes.BORDER)
        {
          current = next;
        }
        else
        {
          return result;
        }
        next = GetNextFilteredChild(current);
        if (next == null)
        {
          if (param == null) return null;
          current = result = JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter(this, current, param);
        }
        else if (next.NodeType == JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree.ElementType.CLR_REGULAR_EXPRESSION)
        {
          if (param != null)
          {
            current = result = JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, param);
          }
          else
          {
            current = GetNextFilteredChild(next);
            JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild(next);
          }
        }
        else
        {
          if (param == null) return null;
          result = JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, param);
          current = next;
        }
        return result;
      }
    }
    public override string ToString()
    {
      return "IClrRegularExpressionFile";
    }
  }
}
