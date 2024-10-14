using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Plant : IPlant
{
    public abstract string Name { get; }
    public abstract string About { get; }

    public abstract decimal Get_Price();

    private int count;
    public int Count
    {
        get => count;
        set => count = value;
    }
}
