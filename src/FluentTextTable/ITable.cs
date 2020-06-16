﻿using System.Collections.Generic;
using System.IO;

namespace FluentTextTable
{
    public interface ITable<in TItem>
    {
        string ToString(IEnumerable<TItem> items);
        void Write(TextWriter writer, IEnumerable<TItem> items);
    }
}