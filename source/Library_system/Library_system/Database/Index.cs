using System.ComponentModel.DataAnnotations;

namespace Library_system.Database
{
    interface IIndex
    {
        string Code { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int RangeFrom { get; set; }
        int RangeTo { get; set; }
        int CurrentIndex { get; set; }
    }

    class Index : IIndex
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RangeFrom { get; set; }
        public int RangeTo { get; set; }
        public int CurrentIndex { get; set; }
    }
}
