﻿using System.Collections.Generic;

namespace TagCloud.file_readers
{
    public interface IFileReader
    {
        IEnumerable<string> GetWords();
    }
}