using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Forms.Abstractions.Interfaces
{
    public interface IFieldSubmission
    {
        string Name { get; }

        string Value { get; }
    }
}