﻿using Files.Shared.Enums;
using System;
using System.Collections.Generic;

namespace Files.Uwp.Filesystem.FilesystemHistory
{
    public interface IStorageHistory : IDisposable
    {
        /// <summary>
        /// Type of operation that took place
        /// </summary>
        FileOperationType OperationType { get; }

        /// <summary>
        /// Source file/folder
        /// <br/>
        /// <br/>
        /// Attention!
        /// <br/>
        /// May contain more that one item
        /// </summary>
        IList<IStorageItemWithPath> Source { get; }

        /// <summary>
        /// Destination file/folder
        /// <br/>
        /// <br/>
        /// Attention!
        /// <br/>
        /// May contain more that one item
        /// </summary>
        IList<IStorageItemWithPath> Destination { get; }

        void Modify(IStorageHistory newHistory);
        void Modify(FileOperationType operationType, IStorageItemWithPath source, IStorageItemWithPath destination);
        void Modify(FileOperationType operationType, IList<IStorageItemWithPath> source, IList<IStorageItemWithPath> destination);
    }
}