using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kisik.DataAccess.Core.Enums;

namespace Kisik.DataAccess.Core.Models
{
    [Table("VirtualExpense")]
    public class VirtualExpenseRto
    {
        [Key] public int Id { get; set; }
        public float Cost { get; set; }
        public CostCurrencyRto CostCurrency { get; set; }
        public VirtualExpenseStatusRto Status { get; set; }
        public DateTimeOffset CreateDateTime { get; set; }
        public List<DateTimeOffset> ChangeDateTimes{ get; set; }
    }
}
