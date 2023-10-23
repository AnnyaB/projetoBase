using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Entities
{
    public abstract class Entity //classe abstrata pai de category e product
    {
        public int Id { get; protected set; } //encapsulamento
    }
}
