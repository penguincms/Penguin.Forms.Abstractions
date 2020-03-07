using System;
using System.Collections.Generic;

namespace Penguin.Forms.Abstractions.Interfaces
{
    public interface IFormSubmission
    {
        IEnumerable<IFieldSubmission> Fields { get; }
        string Name { get; }

        Guid Owner { get; }
    }
}