using System;
using FubuMVC.Core.Util;
using HtmlTags;

namespace FubuMVC.UI.Configuration
{
    public delegate HtmlTag TagBuilder(ElementRequest request);

    public delegate void TagModifier(ElementRequest request, HtmlTag tag);

    public interface IElementBuilder
    {
        TagBuilder CreateInitial(AccessorDef accessorDef);
    }

    public interface IElementModifier
    {
        TagModifier CreateModifier(AccessorDef accessorDef);
    }

    public interface IElementNamingConvention
    {
        string GetName(Type modelType, Accessor accessor);
    }

    public class DefaultElementNamingConvention : IElementNamingConvention
    {
        public string GetName(Type modelType, Accessor accessor)
        {
            return accessor.Name;
        }
    }
}