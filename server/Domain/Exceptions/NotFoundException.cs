using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string message)
            : base(message)
        {
        }
    }

    public sealed class AdventureNotFoundException : NotFoundException
    {
        public AdventureNotFoundException(Guid adventureId)
            : base($"The adventure with the identifier {adventureId} was not found.")
        {
        }
    }

    public sealed class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(Guid userId)
            : base($"The user with the identifier {userId} was not found.")
        {
        }
    }
}
