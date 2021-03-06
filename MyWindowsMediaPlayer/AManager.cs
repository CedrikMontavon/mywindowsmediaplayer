﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace MyWindowsMediaPlayer
{
    public abstract class AManager
    {
        public abstract void Add(string path);
        public abstract void Delete();
        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();
        public abstract void Next();
        public abstract void Prev();
        public abstract void VolumeUp();
        public abstract void VolumeDown();
        public abstract double Loading();
        public abstract double Position();
        public abstract void SetPosition(int newValue);
        public abstract ObservableCollection<Item> Datas(); 
    }
}
