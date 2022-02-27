using System;
using System.Collections.Generic;

namespace DesafioOpcionalDataBaseFirst
{
    public partial class Cliente
    {
        public int VisitId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? VisitedAt { get; set; }
        public string? Phone { get; set; }
        public int StoreId { get; set; }
    }
}
