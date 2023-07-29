using System;
using System.Globalization;

namespace Exercicio.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Value { get; set; }

        public Installment(DateTime dueDate, double value)
        {
            DueDate = dueDate;
            Value = value;
        }
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
