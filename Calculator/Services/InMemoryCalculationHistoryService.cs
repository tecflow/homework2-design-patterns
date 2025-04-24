using Calculator.Web.Models;
using System.Collections.Generic;

namespace Calculator.Services
{
    public class InMemoryCalculationHistoryService
    {
        private static List<CalculationRecord> _history = new();

        public void Add(CalculationRecord record) => _history.Add(record);

        public IEnumerable<CalculationRecord> GetAll() => _history;
    }
}
