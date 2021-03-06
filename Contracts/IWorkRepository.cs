﻿using Entities.Dto;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IWorkRepository
    {
        void CalculateAddedCost(WorkDto work);
        decimal CalculateChildWorksCost(WorkDto work);
        IEnumerable<WorkEntity> GenerateData();
        Task<IEnumerable<WorkDto>> GetByIdAsync(Guid? id, bool trackChanges);
        Task CreateCollectionAsync(IEnumerable<WorkEntity> works);
    }
}
