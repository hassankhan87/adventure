using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utilities
{
    public class UtilityManager : IUtilityManager
    {
        private readonly Lazy<IMapper> _lazyMapper;
        public UtilityManager(IMapper mapper)
        {
            _lazyMapper = new Lazy<IMapper>(mapper);
        }
        public IMapper Mapper => _lazyMapper.Value;
    }
}
