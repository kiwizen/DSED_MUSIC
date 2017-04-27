﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicDBService.View
{
    public class ViewModelClass
    {
        public void Clear()
        {
            if (ClearMethod != null) ClearMethod();
        }

        public void Add(object p)
        {
            if (AddMethod != null) AddMethod(p);
        }

        public delegate void ClearDelegate();
        public ClearDelegate ClearMethod = null;

        public delegate void AddDelegate(object p);
        public AddDelegate AddMethod = null;

        public ViewModelClass()
        {

        }
    }
}