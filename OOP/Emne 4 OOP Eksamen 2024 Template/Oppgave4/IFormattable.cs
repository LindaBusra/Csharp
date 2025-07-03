using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Definerer et interface for formaterbare objekter.
public interface IFormattable
{
    string ToCSV();
    string ToJSON();
    string GetInfo();
}

