﻿using System;

namespace Route256.MerchandiseService.Domain.AggregationModels.GiveOutMerchPackRequestAggregate
{
    public class GiveOutDate
    {
        public GiveOutDate(DateTime value)
        {
            Value = value;
        }

        public DateTime Value { get; }
    }
}