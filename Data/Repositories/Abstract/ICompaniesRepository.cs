﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Entities;

namespace Data.Repositories.Abstract
{
    public interface ICompaniesRepository
    {
        Task<CompanyEntity> GetCompanyAsync(int companyId);
        Task<CompanyEntity> AddCompanyAsync(Company company);
        Task<CompanyEntity> UpdateCompanyAsync(Company company);
        Task<CompanyEntity> DeleteCompanyAsync(int companyId);
        Task<List<CompanyEntity>> GetAllCompaniesAsync();
        Task<CompanyEntity> RemoveCompanyAsync(int companyId);
    }
}