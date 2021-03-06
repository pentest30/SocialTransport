﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using tacchograaph_reader.Core.Entities;
using TachographReader.Application.Dtos;
using TachographReader.Application.Dtos.Driver;

namespace TachographReader.Application.Queries
{
    public interface IDriverQueries
    {
        Task<List<Driver>> GetDriversAsync(Guid customerId);
        Task<DatatablesQueryModel<LegalFilesQueryViewModel>> GetLegalFilesAsync(Guid customerId ,string term , int start, int length);
        Task<int> GetLegalFilesCountAsync(Guid customerId);

        public Task<DatatablesQueryModel<DriverQueryViewModel>> GetLisOfDriversAsync(Guid customerId, string term,
            int start, int length);

        public Task<IEnumerable<DriverDto>> GetListOfDriversForApiAsync(Guid customerId);
        public Task<Driver> GetDriverByIdAsync(Guid driverId);
        public Task<Tuple<byte[], string>> GetLegalFileContentAsync(Guid id);

    }
}