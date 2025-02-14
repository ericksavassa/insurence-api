﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Insurance.Application.Services.Interfaces
{
    public interface IProductInsuranceService
    {
        Task<float> CalculateProductInsurance(int productId);
        Task<float> CalculateInsuranceForProductList(IList<int> productIdsList);
    }
}