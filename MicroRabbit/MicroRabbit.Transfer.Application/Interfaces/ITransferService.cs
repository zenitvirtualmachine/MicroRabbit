using System;
using System.Collections.Generic;
using System.Text;

using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
    
}
