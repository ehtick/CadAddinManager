﻿namespace CadAddinManager.Model;

public interface IAddinNode
{
    bool Save { get; set; }

    bool Hidden { get; set; }
}