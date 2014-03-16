﻿using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgressBar.Bar
{
    public interface IBar
    {
        PositionOptions GetPositionOptions();

        List<Shape> Render(int currentPosition, PresentationInfo ppp);
    }
}
