using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;

namespace WpfApp1.Model;

public partial class Manyworker
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public int? Salary { get; set; }

    public override string ToString()
    {
        return $"{Name} -- {Salary}";
    }
}
