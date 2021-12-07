using Kisik.DataAccess.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Kisik.DataAccess.Core.Models
{
    [Table("RejectExpence")]
    public class RejectExpenceRto
    {
        [Key] public int Id { get; set; }
        public int AuthorId { get; set; }
        public string WhereSpend { get; set; }
        public float Cost { get; set; }
        public CostCurrencyRto CostCurrency { get; set; }
        public DateTimeOffset CreateDateTime { get; set; }
        public DateTimeOffset RejectDateTime { get; set; }
    }
}