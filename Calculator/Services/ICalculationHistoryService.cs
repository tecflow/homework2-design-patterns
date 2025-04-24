using Calculator.Web.Models;
using System.Collections.Generic;

namespace Calculator.Services
{
    public interface ICalculationHistoryService
    {
        void Add(CalculationRecord record);
        IEnumerable<CalculationRecord> GetAll();
    }
}
