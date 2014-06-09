﻿using BallsLine.Entities;
using BallsLine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BallsLine.Interfaces
{
    public interface IElement
    {
        Position Position { get; set; }
        ElementType Type { get; set; }
    }
}
