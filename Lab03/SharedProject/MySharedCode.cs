﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SharedProject
{
    class MySharedCode
    {
        public string GetFilePath(string fileName)
        {
#if __WINDOWS_UWP__
            var FilePath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
            filename);
#else
#if __ANDROID__
            string LibraryPath = Environment.GetFolderPath(
            Environment.SpecialFolder.Personal);
            var FilePath = Path.Combine(LibraryPath,fileName);
#endif
#endif
            return FilePath;
        }

    }
}
