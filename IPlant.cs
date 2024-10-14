using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPlant
{
    decimal Get_Price();
    int Count { get; set; }
    string Name { get; }
    string About { get; }
}
