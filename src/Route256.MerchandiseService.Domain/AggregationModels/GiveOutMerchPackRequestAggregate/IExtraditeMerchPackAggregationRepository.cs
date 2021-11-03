﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Route256.MerchandiseService.Domain.AggregationModels.EmployeeAggregationModel;
using Route256.MerchandiseService.Domain.AggregationModels.MerchPackAggregationModel;
using Route256.MerchandiseService.Domain.Contracts;

namespace Route256.MerchandiseService.Domain.AggregationModels.GiveOutMerchPackRequestAggregate
{
    /// <summary>
    /// Репозиторий для управления сущностью <see cref="ExtraditeMerchPackRequest"/>
    /// </summary>
    public interface IExtraditeMerchPackAggregationRepository : IRepository<ExtraditeMerchPackRequest>
    {
        /// <summary>
        /// Получить запрос на выдачу набора мерча по идентификатору
        /// </summary>
        /// <param name="number"></param>
        /// <param name="cancellationToken">Токен для отмены операции. <see cref="CancellationToken"/></param>
        /// <returns>Объект запроса</returns>
        Task<IReadOnlyList<ExtraditeMerchPackRequest>> FindByIdAsync(RequestNumber number, CancellationToken cancellationToken = default);

        /// <summary>
        /// Получить запрос на выдачу набора мерча по идентификатору сотрудника и названию набора мерча
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="merchPackName"></param>
        /// <param name="cancellationToken">Токен для отмены операции. <see cref="CancellationToken"/></param>
        /// <returns>Объект запроса</returns>
        Task<IReadOnlyList<ExtraditeMerchPackRequest>> FindByEmployeeIdAndMerchPackNameAsync(EmployeeId employeeId, MerchPackName merchPackName, CancellationToken cancellationToken = default);
    }
}