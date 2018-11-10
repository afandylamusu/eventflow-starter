using EventFlow.ReadStores;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanLiris.Spinning.Domain.ReadModels
{
    public abstract class EFReadModel : IReadModel
    {
        
        public int Id { get; set; }
    }
}
