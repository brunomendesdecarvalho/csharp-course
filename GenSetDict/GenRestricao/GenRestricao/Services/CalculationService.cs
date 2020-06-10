using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenRestricao.Services
{
    class CalculationService
    {
        public CalculationService()
        {
        }

        public T Max<T>(List<T> list) where T : IComparable
        {
            return list.Max();
        }
    }
}
