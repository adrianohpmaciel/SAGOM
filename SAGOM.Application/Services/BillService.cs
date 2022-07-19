using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Application.Interfaces;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Services
{
    public class BillService : IBillService
    {
        private IBillRepository _billRepository;
        private readonly IMapper _mapper;

        public BillService(IBillRepository billRepository, IMapper mapper)
        {
            _billRepository = billRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BillDTO>?> GetBillsByDate(DateTime data)
        {
            var billsEntity = await _billRepository.GetBillsByDate(data);
            return _mapper.Map<IEnumerable<BillDTO>>(billsEntity);
        }

        public async Task<BillDTO?> GetBillById(int id)
        {
            var billEntity = await _billRepository.GetBillByIdAsync(id);
            return _mapper.Map<BillDTO>(billEntity);
        }

        public async Task Add(BillDTO bill)
        {
            var billEntity = _mapper.Map<Bill>(bill);
            await _billRepository.CreateAsync(billEntity);
        }

        public async Task Update(BillDTO bill)
        {
            var billEntity = _mapper.Map<Bill>(bill);
            await _billRepository.UpdateAsync(billEntity);
        }

        public async Task Remove(BillDTO bill)
        {
            var billEntity = _mapper.Map<Bill>(bill);
            await _billRepository.RemoveAsync(billEntity);
        }
    }
}
