using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SelectionStatements
{
    public class Animals
    {
        class Animal // This is the base type for all animals.
        {
            public string? Name;
            public DateTime Born;
            public byte Legs;
        }
        class Cat : Animal // This is a subtype of animal.
        {
            public bool IsDomestic;
        }
        class Spider : Animal // This is another subtype of animal.
        {
            public bool IsPoisonous;
        }
    }
}
