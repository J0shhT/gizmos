﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Popcron
{
    [Serializable]
    public class DrawInfo
    {
        public List<Vector3> vectors = new List<Vector3>();
        public List<float> floats = new List<float>();

        public Quaternion? rotation = null;
        public Color? color = null;
    }
}