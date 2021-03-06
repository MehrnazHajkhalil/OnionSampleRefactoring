using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Core.Domain.BaseEntities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public int CreatorUserId { get; set; }
    public int ModifyUserId { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifyDtae { get; set; }
}