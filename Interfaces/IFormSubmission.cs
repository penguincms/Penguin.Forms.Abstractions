using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Forms.Abstractions.Interfaces
{
    public interface IFormSubmission
    {
        IEnumerable<IFieldSubmission> Fields { get; }
        string Name { get; }

        Guid Owner { get; }
    }
}