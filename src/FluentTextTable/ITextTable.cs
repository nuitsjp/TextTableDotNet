﻿using System.Collections.Generic;
using System.IO;

namespace FluentTextTable
{
    public interface ITextTable<in TItem>
    {
        IEnumerable<TItem> DataSource { set; }

        string ToPlanText();
        void WritePlanText(TextWriter writer);

        string ToMarkdown();
        void WriteMarkdown(TextWriter writer);
    }
}