using System;

namespace RentalOfPremises.Api.ModelsRequest.Contract
{
    public class ContractRequest 
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        // <summary>
        /// Номер договора
        /// </summary>
        public decimal Number { get; set; }

        /// <summary>
        /// Платеж
        /// </summary>
        public decimal Payment { get; set; }

        /// <summary>
        /// Идентификатор арендатора
        /// </summary>
        public Guid Tenant { get; set; }

        /// <summary>
        /// Идентификатор помещения
        /// </summary>
        public Guid Room { get; set; }

        /// <summary>
        /// Дата начала действия договора
        /// </summary>
        public DateTimeOffset DateStart { get; set; }

        /// <summary>
        /// Дата окончания действия договора
        /// </summary>
        public DateTimeOffset DateEnd { get; set; }

        /// <summary>
        /// Архивный ли договор
        /// </summary>
        public bool Archive { get; set; } = false;
    }
}
