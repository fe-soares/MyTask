using Dev.Business.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dev.Business.Models
{
    public class Task: Entity
    {
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StratDate { get; set; }
        public DateTime EndDate { get; set; }
        public TaskStatus Status { get; set; }

        [MaxLength(16777215)]
        public byte[] Content { get; set; }
        //Para o Map AddColumn("dbo.testDB", "Content", c => c.Binary(storeType: "tinyblob"));
    }
}
