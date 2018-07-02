using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Application.Dto
{
    public interface IEntityDto : IEntityDto<int>
    {

    }

    /// <summary>
    /// Defines common properties for entity based DTOs.
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public interface IEntityDto<TPrimaryKey>
    {
        /// <summary>
        /// Id of the entity.
        /// </summary>
        TPrimaryKey Id { get; set; }
    }
}
