﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.AbstractFactory
{
    public interface IAbstractFactory
    {
        IClassA CreateObjectA();
        IClassB CreateObjectB();
    }
}
