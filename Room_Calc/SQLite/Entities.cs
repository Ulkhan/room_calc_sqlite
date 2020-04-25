using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Room_Calc.SQLite
{
    [Table]
    public class Material
    {
        [PrimaryKey] public int Id { get; set; }
        [Column(Length = 100), NotNull] public string Option { get; set; }
    }

    [Table]
    public class Color
    {
        [PrimaryKey] public int Id { get; set; }
        [Column(Length = 100), NotNull] public string Option { get; set; }
    }
}