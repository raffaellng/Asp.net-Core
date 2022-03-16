using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestNetCore.Enum
{
    public enum OperatorsType
    {
        addition,
        subtraction,
        multiplication,
        division,
        mean
    }
}
