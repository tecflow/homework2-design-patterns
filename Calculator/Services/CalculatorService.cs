using Calculator.Web.Models;
using System;
using System.Data;

namespace Calculator.Services
{
    public class CalculatorService
    {
        private readonly ICalculationHistoryService _history;

        public CalculatorService(ICalculationHistoryService history)
        {
            _history = history;
        }

        public double Calculate(string expression)
        {
            var result = Evaluate(expression);
            _history.Add(new CalculationRecord
            {
                Expression = expression,
                Result = result,
                Timestamp = DateTime.Now
            });
            return result;
        }

        private double Evaluate(string expression)
        {
            var table = new DataTable();
            return Convert.ToDouble(table.Compute(expression, string.Empty));
        }

        public IEnumerable<CalculationRecord> GetHistory() => _history.GetAll();
    }
}
